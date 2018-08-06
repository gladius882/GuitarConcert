/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-03
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Drawing;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using LastFmLib;

namespace GuitarConcert
{
	/// <summary>
	/// Description of NewSongForm.
	/// </summary>
	public partial class NewSongForm : Form
	{
		public NewSongForm()
		{
			InitializeComponent();
			
			foreach(string file in Directory.GetFiles(@"data\tags"))
			{
				string[] tag = file.Split(new[] {'/', '\\', '.'});
				TagsList.Items.Add(tag[tag.Length-2], false);
			}
			
			foreach(GroupBox box in Controls.OfType<GroupBox>())
			{
				if(box.MaximumSize.Height != 0)
					box.Size = box.MaximumSize;
			}
			
			Lyrics.Font = new System.Drawing.Font(SettingsSingleton.Instance.option["tabFontName"], 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			
			foreach(string file in Directory.GetFiles("chords"))
			{
				string[] chrd = file.Split(new[] {'/', '\\', '.'});
				ChordsList.Items.Add(chrd[chrd.Length-2].Replace(' ', '/'));
			}
			
			foreach(string file in Directory.GetFiles("data/artist"))
			{
				string[] artist = file.Split(new[] {'/', '\\', '.'});
				SongArtist.AutoCompleteCustomSource.Add(artist[artist.Length-2]);
			}
			
			Cover.ImageLocation = String.Empty;
			ArtistPicture.ImageLocation = String.Empty;
		}
		
		void ClearClick(object sender, EventArgs e)
		{
			foreach(GroupBox box in Controls.OfType<GroupBox>())
			{
				foreach(TableLayoutPanel panel in box.Controls.OfType<TableLayoutPanel>())
				{
					foreach(TextBox tb in panel.Controls.OfType<TextBox>())
					{
						tb.Text = "";
					}
				}
			}
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			(this.MdiParent as MainForm).LoadView(new SongsForm());
		}
		
		void GroupBoxDoubleClick(object sender, MouseEventArgs e)
		{
			
			GroupBox box = sender as GroupBox;
			Task.Run( () => InvokeSlide(box) );
		}
		
		private void InvokeSlide(GroupBox box)
		{
			if(InvokeRequired) {
				Invoke(new MethodInvoker( () => Slide(box) ));
			}
			else {
				Slide(box);
			}
		}
		
		private void Slide(GroupBox box)
		{
			if(box.Size.Height == box.MaximumSize.Height)
			{
				for(int i=box.Size.Height; i>=30; i-=4)
				{
					box.Size = new Size(box.Size.Width, i);
				}
				box.Size = new Size(box.Size.Width, 30);
			}
			else
			{
				for(int i=box.Size.Height; i<=box.MaximumSize.Height; i+=4)
				{
					box.Size = new Size(box.Size.Width, i);
				}
				box.Size = box.MaximumSize;
			}
		}
		
		void TagAddClick(object sender, EventArgs e)
		{
			string tagName = TagName.Text.Trim();
			
			if(tagName == String.Empty)
			{
				MessageBox.Show("Najpierw podaj nazwę tagu");
				return;
			}
			
			foreach(var item in TagsList.Items)
			{
				if(item.ToString().Trim().ToLower() == tagName.ToLower())
				{
					MessageBox.Show("Tagi nie mogą się powtarzać");
					return;
				}
			}
			
			Tag tag = new Tag();
			tag.Name = tagName.ToLower();
			tag.Summary = "Brak opisu";
			tag.Description = "Brak opisu";
			
			try {
				tag.Save("data/tags/"+tagName+".xml");
				TagsList.Items.Add(TagName.Text, true);
			}
			catch {
				MessageBox.Show("Wystąpił błąd podczas dodawania tagu");
				return;
			}
		}
		
		void TablatureDoubleClick(object sender, EventArgs e)
		{
			using(OpenFileDialog dialog = new OpenFileDialog())
			{
				string filter = "All supported GuitarPro files|*.gp5;*.gp4;*.gp3;*.gpx|";
				filter += "GuitarPro 6 files|*.gpx|";
				filter += "GuitarPro 5 files|*.gp5|";
				filter += "GuitarPro 4 files|*.gp4|";
				filter += "GuitarPro 3 files|*.gp3|";
				filter += "All files|*.*";
				dialog.Filter = filter;
				dialog.FilterIndex = 1;
				dialog.Multiselect = false;
				dialog.RestoreDirectory = true;
				dialog.ShowReadOnly = true;
				dialog.SupportMultiDottedExtensions = true;
				
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					string extension = dialog.FileName.Substring(dialog.FileName.LastIndexOf('.'));
					string newPath = Environment.CurrentDirectory + @"\cache\add\" + SongArtist.Text + " - " + SongTitle.Text + extension;
					
					if(File.Exists(newPath))
					   File.Delete(newPath);
					
					File.Copy(dialog.FileName, newPath);
					Tablature.Text = dialog.FileName;
				}
			}
		}
		
		void MidiDoubleClick(object sender, EventArgs e)
		{
			using(OpenFileDialog dialog = new OpenFileDialog())
			{
				string filter = "MIDI file|*.mid|";
				filter += "All files|*.*";
				dialog.Filter = filter;
				dialog.FilterIndex = 1;
				dialog.Multiselect = false;
				dialog.RestoreDirectory = true;
				dialog.ShowReadOnly = true;
				dialog.SupportMultiDottedExtensions = true;
				
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					string extension = dialog.FileName.Substring(dialog.FileName.LastIndexOf('.'));
					string newPath = Environment.CurrentDirectory + @"\cache\add\" + SongArtist.Text + " - " + SongTitle.Text + extension;
					
					if(File.Exists(newPath))
					   File.Delete(newPath);
					
					File.Copy(dialog.FileName, newPath);
					Midi.Text = dialog.FileName;
				}
			}
		}
		
		void NewSongFormFormClosed(object sender, FormClosedEventArgs e)
		{
			foreach(string file in Directory.GetFiles("cache/add"))
			{
				File.Delete(file);
			}
		}
		
		void AddClick(object sender, EventArgs e)
		{
			if(SongExists(SongArtist.Text, SongTitle.Text))
			{
				MessageBox.Show("Ta piosenka już istnieje");
				return;
			}
			
//			try {
				CreateSongFile();
				CreateLyricsFile();
				CreateChordsFile();
				PackFiles();
				CreateArtistIfNotExists();
				CreateAlbumIfNotExists();
				MoveFiles();
				AddEntryToList();
				(MdiParent as MainForm).LoadView(new SongsForm());
//			}
//			catch {
//				MessageBox.Show("Wystąpił błąd podczas dodawania piosenki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
		}
		
		private bool SongExists(string artist, string song)
		{
			string file = "song/" + artist + " - " + song + ".gc";
			return File.Exists(file);
		}
		
		private void CreateSongFile()
		{	
			Song song = new Song();
			song.Status = "ok";
			song.Name = SongTitle.Text.Trim();
			song.Url = SongLink.Text.Trim();
			song.Duration = (int)Duration.Value;
			song.ArtistName = SongArtist.Text.Trim();
			song.Position = (int)Position.Value;
			song.AlbumArtist = SongArtist.Text.Trim();
			song.AlbumTitle = SongAlbum.Text.Trim();
			song.WikiSummary = "Brak opisu";
			song.WikiContent = "Brak opisu";
			
			song.Release = (int)Release.Value;
			song.Metrum = Metrum.SelectedItem.ToString();
			song.Bpm = (int)Bpm.Value;
			song.Capo = (int)Capo.Value;
			song.AutoscrollSpeed = (int)AutoscrollSpeed.Value;
			song.AutoscrollDelay = (int)AutoscrollDelay.Value;
			
			foreach(string item in TagsList.CheckedItems)
			{
				string name = item.Trim().ToLower();
				song.Tags.Add(new ShortTag(name, "https://last.fm/tag/"+name.Replace(' ', '+')));
			}
			
			if(song.Tags.Count == 0)
				song.Tags.Add(new ShortTag("Nieotagowane", String.Empty));
			
			string file = "cache/add/"+song.ArtistName+" - "+song.Name+".xml";
			
			song.Save(file);
		}
		
		private void CreateLyricsFile()
		{
			string file = "cache/add/" + SongArtist.Text + " - " + SongTitle.Text + ".gcl";
			File.WriteAllText(file, Lyrics.Text);
		}
		
		private void CreateChordsFile()
		{
			string file = "cache/add/" + SongArtist.Text + " - " + SongTitle.Text + ".gcc";
			File.WriteAllText(file, Chords.Text);
		}
		
		void ChordAddClick(object sender, EventArgs e)
		{
			if(ChordsList.SelectedIndex == -1)
				return;
			
			string chord = ChordsList.SelectedItem.ToString();
			int count = (int)ChordCount.Value;
			
			for(int i=0; i<count; i++)
			{
				Chords.Text += chord + ";";
			}
		}
		
		private void PackFiles()
		{
			string filePattern = "cache/add/" + SongArtist.Text + " - " + SongTitle.Text;
			
			List<string> files = new List<string>();
			files.Add(filePattern+".xml");
			files.Add(filePattern+".gcl");
			files.Add(filePattern+".gcc");
			
			if(Tablature.Text.Contains(":"))
			{
				string[] tab = Tablature.Text.Split(new[] {'/', '\\', '.'});
				string extension = tab[tab.Length-1];
				files.Add(filePattern+"."+extension);
			}
			if(Midi.Text.Contains(":"))
			{
				string[] mid = Midi.Text.Split(new[] {'/', '\\', '.'});
				string extension = mid[mid.Length-1];
				MessageBox.Show(extension);
				files.Add(filePattern+"."+extension);
			}
			
			GcFile.Create(files.ToArray(), filePattern, true);
		}
		
		private void CreateArtistIfNotExists()
		{
			if(SongArtist.Text.Trim() == String.Empty)
				return;
			
			if(File.Exists("data/artist/"+SongArtist.Text.Trim()+".xml") == false)
			{
				Artist artist = new Artist();
				artist.Name = SongArtist.Text.Trim();
				artist.Save("data/artist/"+SongArtist.Text.Trim()+".xml");
			}
		}
		
		private void CreateAlbumIfNotExists()
		{
			if(SongArtist.Text.Trim() == String.Empty || SongAlbum.Text.Trim() == String.Empty)
				return;
			
			string file = SongArtist.Text + " - " + SongAlbum.Text + ".xml";
			if(File.Exists("data/album/"+file) == false)
			{
				Album album = new Album();
				album.Name = SongAlbum.Text.Trim();
				album.Save("data/album/"+file);
			}
		}
		
		private void MoveFiles()
		{
			string gcFile = SongArtist.Text + " - " + SongTitle.Text + ".gc";
			File.Move("cache/add/"+gcFile, "song/"+gcFile);
			
			string coverImage = SongArtist.Text + " - " + SongAlbum.Text + ".png";
			if(Cover.ImageLocation != String.Empty)
				File.Copy(Cover.ImageLocation, "assets/covers/"+coverImage);
			
			string artistImage = SongArtist.Text + ".png";
			if(ArtistPicture.ImageLocation != String.Empty)
				File.Copy(ArtistPicture.ImageLocation, "assets/artists/"+artistImage);
		}
		
		void PictureClick(object sender, System.EventArgs e)
		{
			PictureBox box = sender as PictureBox;
			
			if((e as MouseEventArgs).Button == MouseButtons.Right)
			{
				box.ImageLocation = String.Empty;
				return;
			}
			
			using(OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Filter = "PNG|*.png";
				dialog.Multiselect = false;
				dialog.RestoreDirectory = true;
				dialog.ShowReadOnly = true;
				dialog.SupportMultiDottedExtensions = true;
				
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					box.ImageLocation = dialog.FileName;
				}
			}
		}
		
		private void AddEntryToList()
		{
			string entry = SongArtist.Text.Trim() + ";" + SongTitle.Text.Trim() + ";" + SongAlbum.Text.Trim();
			
			if(ListTypeSongs.Checked == true)
				File.AppendAllText("data/songs.list" ,entry + Environment.NewLine);
			else
				File.AppendAllText("data/wish.list" ,entry + Environment.NewLine);
		}
	}
}
