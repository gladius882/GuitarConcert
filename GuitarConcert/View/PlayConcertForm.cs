/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-11-29
 * Time: 16:32
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Sanford.Multimedia.Midi;
using AlphaTab.Importer;
using AlphaTab.Model;

namespace GuitarConcert
{
	/// <summary>
	/// Description of PlayConcertForm.
	/// </summary>
	public partial class PlayConcertForm : Form
	{
		private Song currentSong;
		private Chord currentChord;
		private Score score;
		private int tick = 0;
		
		public PlayConcertForm(Song sng)
		{
			InitializeComponent();
			this.LoadSong(sng);
			
			this.lyricsBox.Font = new Font(SettingsSingleton.Instance.option["lyricsFontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.detailsList.Font = new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			
			this.splitContainer1.SplitterDistance = int.Parse(SettingsSingleton.Instance.option["leftPanelWidth"]);
			int tmp = int.Parse(SettingsSingleton.Instance.option["rightPanelWidth"]);
			this.splitContainer2.SplitterDistance = this.ClientSize.Width -this.splitContainer1.SplitterDistance-tmp;
			
			timer.Tick += this.Delay;
		}
		
		public void LoadSong(Song sng)
		{
			this.currentSong = sng;
			
			this.LoadCover();
			this.LoadDetails();
			
			this.lyricsBox.Clear();
			this.lyricsBox.Text = sng.Lyrics.Text;
			
			
			vScrollBar1.Minimum = 1;
			vScrollBar1.Maximum = this.lyricsBox.Lines.Length;
			
			
			this.chordsListBox.Items.Clear();
			foreach(string chrd in sng.SongBook.ChordsList)
			{
				this.chordsListBox.Items.Add(chrd);
			}
			
			try {
				this.score = ScoreLoader.LoadScoreFromBytes(File.ReadAllBytes(
					String.Format("{0}/{1}/{2} - {3}.gp3",
					            "cache",
					            "song",
					            sng.ArtistName,
					            sng.Name
					           )));
				
				this.alphaTabControl1.Tracks = new[] { score.Tracks[0] };
			}
			catch {
				;
			}
			
			string firstChord = this.chordsListBox.Items[0].ToString().Replace('/', ' ');
			Chord currChrd = new Chord(PathGenerator.ChordDiagramPath(firstChord));
			chordDiagramPicture.Image = currChrd.CreateBitmap();	
		}
		
		void LoadCover()
		{
			try {
				this.pictureBox1.ImageLocation = "assets/covers/"+
					currentSong.ArtistName+" - "+
					currentSong.AlbumTitle+".png";
			}
			catch {
				;
			}
		}
		
		void LoadDetails()
		{
			this.detailsList.Items.Add(currentSong.Name);
			this.detailsList.Items.Add(currentSong.ArtistName);
			this.detailsList.Items.Add(currentSong.AlbumTitle+" ("+currentSong.Release+")");
			this.detailsList.Items.Add(String.Empty);
			this.detailsList.Items.Add("Gatunek: " + currentSong.Tags[0].Name);
			this.detailsList.Items.Add("Metrum: " + currentSong.Metrum);
			this.detailsList.Items.Add("Kapo: " + currentSong.Capo);
		}
		
		void ToolStripPlayClick(object sender, EventArgs e)
		{
			this.timer.Interval = 60000 / this.currentSong.Bpm;
			timer.Start();
		}
		
		private void Delay(object sender, EventArgs e)
		{	
			if(tick >= currentSong.AutoscrollDelay)
			{
				if(this.tick%currentSong.AutoscrollSpeed == 0)
				{
//					int linesPerPage = lyricsBox.Height / (int.Parse(lyricsBox.Font.Size.ToString()) + lyricsBox.Margin.Vertical ) - 1;
//				
//					int lineToScroll = linesPerPage + (tick - currentSong.getInt("autoScrollDelay") ) / currentSong.getInt("autoScrollSpeed");
//					ScrollLyricsToLine(lineToScroll);
					if(vScrollBar1.Value < vScrollBar1.Maximum)
					{
						vScrollBar1.Value++;
					}
				}
			}
			
			if(tick < chordsListBox.Items.Count)
			{
				int visibleLines = this.chordsListBox.Height / this.chordsListBox.ItemHeight;
				this.SelectChordsLine(tick+visibleLines/2);
				this.SelectChordsLine(tick+1);
				
				string selectedValue = this.chordsListBox.SelectedItems[0].ToString().Trim();
				
				if(selectedValue != String.Empty)
				{
					Chord chrd = new Chord(PathGenerator.ChordDiagramPath(selectedValue.Replace('/', ' ')));
					this.currentChord = chrd;
					this.chordDiagramPicture.Image = chrd.CreateBitmap();
				}
			}
			else
				StopConcert();
			
			this.tick++;
		}
		
		void ToolStripStopClick(object sender, EventArgs e)
		{
			StopConcert();
		}
		
		void StopConcert()
		{
			timer.Stop();
			this.tick = 0;
			ScrollLyricsToLine(1);
			SelectChordsLine(1);
		}
		
		void ToolStripPauseClick(object sender, EventArgs e)
		{
			timer.Stop();
		}
		
		void SelectChordsLine(int line)
		{
			if(line < this.chordsListBox.Items.Count)
			{
				this.chordsListBox.SelectedIndex = line-1;
			}
		}
		
		void ScrollLyricsToLine(int line)
		{
			if(line >= lyricsBox.Lines.Length)
				return;
			
//			int offset = 0;
//			for(int i=0; i<line-1; i++)
//			{
//				offset += lyricsBox.Lines[i].Length;
//			}
//			
//			lyricsBox.SelectionStart = offset;
			int index = this.lyricsBox.GetFirstCharIndexFromLine(line-1);
			this.lyricsBox.SelectionStart = index;
			lyricsBox.ScrollToCaret();
		}
		
		void ToolStripBackClick(object sender, EventArgs e)
		{
			MainForm parent = (MainForm)this.MdiParent;
			parent.LoadView(new SongsForm());
		}
		
		void VScrollBar1Scroll(object sender, ScrollEventArgs e)
		{
			ScrollLyricsToLine(e.NewValue);
		}
		
		void VScrollBar1ValueChanged(object sender, EventArgs e)
		{
			ScrollLyricsToLine(vScrollBar1.Value);
		}
		
	}
}
