/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-10-02
 * Time: 06:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using System.Windows.Forms;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Song.
	/// </summary>
	public class Song : LastFmLib.Track
	{
		public string Metrum;
		public int Bpm;
		public int Capo;
		public int AutoscrollSpeed;
		public int AutoscrollDelay;
		public int Release;
		
		public Lyrics Lyrics = new Lyrics();
		public ChordsSongBook SongBook = new ChordsSongBook();
		
		private GcFile gc;
		private string errorString;
		
		public Song() : base()
		{
			Metrum = "4/4";
			Bpm = 120;
			Capo = 0;
			AutoscrollDelay = 0;
			AutoscrollSpeed = 4;
			Release = 2000;
		}
		
		public Song(string artist, string title)
		{
			this.errorString = "None";
			
			DirectoryInfo dir = new DirectoryInfo("cache/song");
			foreach(FileInfo file in dir.GetFiles())
			{
				file.Delete();
			}
			
			
			gc = new GcFile(PathGenerator.SongPath(artist, title));
			gc.Extract("cache/song");
			string filePattern = "cache/song/"+artist+" - "+title;
			
			Lyrics.Text = File.ReadAllText(filePattern+".gcl");
			SongBook.Load(filePattern+".gcc");
			
			this.Load(filePattern+".xml");
			
			XmlDocument doc = new XmlDocument();
			doc.Load(filePattern+".xml");
			
			this.Metrum = doc.SelectNodes("lfm/track/gc/metrum")[0].InnerText;
			this.Bpm = int.Parse(doc.SelectNodes("lfm/track/gc/bpm")[0].InnerText);
			this.Capo = int.Parse(doc.SelectNodes("lfm/track/gc/capo")[0].InnerText);
			this.AutoscrollSpeed = int.Parse(doc.SelectNodes("lfm/track/gc/autoscroll/speed")[0].InnerText);
			this.AutoscrollDelay = int.Parse(doc.SelectNodes("lfm/track/gc/autoscroll/delay")[0].InnerText);
			this.Release = int.Parse(doc.SelectNodes("lfm/track/gc/release")[0].InnerText);
		}
		
		public void Save(string file)
		{
			base.Save(file);
			
			XmlDocument doc = new XmlDocument();
			doc.Load(file);
			
			XmlElement gc = doc.CreateElement("gc");
			XmlElement release = doc.CreateElement("release");
			XmlElement metrum = doc.CreateElement("metrum");
			XmlElement bpm = doc.CreateElement("bpm");
			XmlElement capo = doc.CreateElement("capo");
			XmlElement autoscroll = doc.CreateElement("autoscroll");
			XmlElement autoscrollSpeed = doc.CreateElement("speed");
			XmlElement autoscrollDelay = doc.CreateElement("delay");
			
			release.InnerText = Release.ToString();
			metrum.InnerText = Metrum;
			bpm.InnerText = Bpm.ToString();
			capo.InnerText = Capo.ToString();
			autoscrollSpeed.InnerText = AutoscrollSpeed.ToString();
			autoscrollDelay.InnerText = AutoscrollDelay.ToString();
			
			autoscroll.AppendChild(autoscrollSpeed);
			autoscroll.AppendChild(autoscrollDelay);
			gc.AppendChild(release);
			gc.AppendChild(metrum);
			gc.AppendChild(bpm);
			gc.AppendChild(capo);
			gc.AppendChild(autoscroll);
			
			XmlNode track = doc.SelectNodes("lfm/track")[0];
			track.AppendChild(gc);
			
			doc.Save(file);
		}
	}
}
