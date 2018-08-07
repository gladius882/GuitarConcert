/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-07
 * Time: 13:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using LastFmLib;

namespace GuitarConcert
{
	/// <summary>
	/// Description of NewSongForm_Events.
	/// </summary>
	partial class NewSongForm
	{
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
		
		void AddClick(object sender, EventArgs e)
		{
			if(SongExists(SongArtist.Text, SongTitle.Text))
			{
				MessageBox.Show("Ta piosenka już istnieje");
				return;
			}
			
			try {
				CreateSongFile();
				CreateLyricsFile();
				CreateChordsFile();
				PackFiles();
				CreateArtistIfNotExists();
				CreateAlbumIfNotExists();
				MoveFiles();
				AddEntryToList();
				(MdiParent as MainForm).LoadView(new SongsForm());
			}
			catch {
				MessageBox.Show("Wystąpił błąd podczas dodawania piosenki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			(this.MdiParent as MainForm).LoadView(new SongsForm());
		}
		
		void GroupBoxDoubleClick(object sender, MouseEventArgs e)
		{
			GroupBox box = sender as GroupBox;
			if(box.Height == box.MinimumSize.Height)
				box.Size = box.MaximumSize;
//				box.Size = new Size(box.Width, box.MaximumSize.Height);
			else
				box.Size = box.MinimumSize;
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
		
		void MatchCover(object sender, EventArgs e)
		{
			string artist = SongArtist.Text.Trim();
			string album = SongAlbum.Text.Trim();
			string cover = "assets/covers/" + artist + " - " + album + ".png";
			
			if(File.Exists(cover))
				Cover.ImageLocation = cover;
		}
		
		void MatchArtistPicture(object sender, EventArgs e)
		{
			string artist = SongArtist.Text.Trim();
			string picture = "assets/artists/" + artist + ".png";
			
			if(File.Exists(picture))
				ArtistPicture.ImageLocation = picture;
		}
		
		void SongAlbumEnter(object sender, EventArgs e)
		{
			string formArtist = SongArtist.Text.Trim();
			
			if(formArtist != String.Empty)
			{
				SongAlbum.AutoCompleteCustomSource.Clear();
				
				foreach(string file in Directory.GetFiles("data/album/"))
				{
					string[] albumPath = file.Split(new[] {'/', '\\', '.'});
					string albumFile = albumPath[albumPath.Length-2];
					string albumName = albumFile.Split('-')[1].Trim();
					
					if(albumFile.StartsWith(formArtist))
						SongAlbum.AutoCompleteCustomSource.Add(albumName);
				}
			}
		}
	}
}
