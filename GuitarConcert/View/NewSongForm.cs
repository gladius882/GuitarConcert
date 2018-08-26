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
using System.Drawing.Imaging;
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
		private bool Edit = false;
		
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
			
			ArtistPicture.ImageLocation = String.Empty;
			Cover.ImageLocation = String.Empty;
		}
		
		public void LoadSong(string artist, string title)
		{
			Edit = true;
			string songFile = artist + " - " + title;
			using(GcFile gc = new GcFile("song/" + songFile + ".gc"))
			{
				gc.Extract("cache/add");
			}
			
			Song song = new Song();
			song.FromFile("cache/add/" + songFile + ".xml");
			
			SongTitle.Text = song.Name;
			SongArtist.Text = song.ArtistName;
			SongAlbum.Text = song.AlbumTitle;
			SongLink.Text = song.Url;
			Duration.Value = song.Duration;
			Release.Value = song.Release;
			Position.Value = song.Position;
			
			foreach(ShortTag tag in song.Tags)
			{
				for(int i=0; i<TagsList.Items.Count; i++)
				{
					if(tag.Name.ToLower() == TagsList.Items[i].ToString().ToLower())
						TagsList.SetItemChecked(i, true);
				}
			}
			
			Bpm.Value = song.Bpm;
			Metrum.Text = song.Metrum;
			AutoscrollSpeed.Value = song.AutoscrollSpeed;
			AutoscrollDelay.Value = song.AutoscrollDelay;
			Capo.Value = song.Capo;
			
			if(File.Exists("cache/add/" + artist + " - " + title + ".gp5"))
				Tablature.Text = Environment.CurrentDirectory + @"\cache\add\" + artist + " - " + title + ".gp5";
			
			if(File.Exists("cache/add/" + artist + " - " + title + ".mid"))
				Midi.Text = Environment.CurrentDirectory + @"\cache\add\" + artist + " - " + title + ".mid";
			
			if(File.Exists("cache/add/" + artist + " - " + title + ".pdf"))
				Pdf.Text = Environment.CurrentDirectory + @"\cache\add\" + artist + " - " + title + ".pdf";
			
			Lyrics.Text = File.ReadAllText("cache/add/" + artist + " - " + title + ".gcl");
			Chords.Text = File.ReadAllText("cache/add/" + artist + " - " + title + ".gcc");
			
			File.Delete("cache/add/" + songFile + ".xml");
			File.Delete("cache/add/" + songFile + ".gcl");
			File.Delete("cache/add/" + songFile + ".gcc");
			File.Delete("song/" + songFile + ".gc");
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
				files.Add(filePattern+"."+extension);
			}
			
			if(Pdf.Text.Contains(":"))
			{
				string[] pdf = Pdf.Text.Split(new[] {'/', '\\', '.'});
				string extension = pdf[pdf.Length-1];
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
			{
				if(File.Exists("assets/covers/"+coverImage) == false)
				{
					File.Copy(Cover.ImageLocation, "assets/covers/"+coverImage);
					File.Copy(Cover.ImageLocation, "assets/covers/thumbnails/"+coverImage);
					ResizeImage("assets/covers/thumbnails/"+coverImage, 64, 64);
				}
			}
			
			string artistImage = SongArtist.Text + ".png";
			if(ArtistPicture.ImageLocation != String.Empty)
			{
				if(File.Exists("assets/artists/"+artistImage) == false)
				{
					File.Copy(ArtistPicture.ImageLocation, "assets/artists/"+artistImage);
					File.Copy(ArtistPicture.ImageLocation, "assets/artists/thumbnails/"+artistImage);
					ResizeImage("assets/artists/thumbnails/"+artistImage, 64, 64);
				}
			}
		}
		
		private void AddEntryToList()
		{
			if(Edit == true)
				return;
			
			string entry = SongArtist.Text.Trim() + ";" + SongTitle.Text.Trim() + ";" + SongAlbum.Text.Trim();
			
			if(ListTypeSongs.Checked == true)
				File.AppendAllText("data/songs.list" ,entry + Environment.NewLine);
			else
				File.AppendAllText("data/wish.list" ,entry + Environment.NewLine);
		}
		
		private void ClearCache(string path)
		{
			foreach(string file in Directory.GetFiles(path))
			{
				File.Delete(file);
			}
		}
		
		private void ResizeImage(string path, int nWidth, int nHeight)
	    {
	        using (var result = new Bitmap(nWidth, nHeight))
	        {
	            using (var input = new Bitmap(path))
	            {
	                using (Graphics g = Graphics.FromImage((System.Drawing.Image)result))
	                {
	                    g.DrawImage(input, 0, 0, nWidth, nHeight);
	                }
	            }
	
	            var ici = ImageCodecInfo.GetImageEncoders().FirstOrDefault(ie => ie.MimeType == "image/jpeg");
	            var eps = new EncoderParameters(1);
	            eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
	            result.Save(path, ici, eps);
	        }
	    }
	}
}
