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

using System.Windows.Forms;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Song.
	/// </summary>
	public class Song
	{
		private string cachePath = "cache/";
		private GcFile gc;
		private Dictionary<string, string> info;
		private IniFile ini;
		
		public readonly string errorString;
		public ChordsSongBook SongBook;
		public Lyrics Lyrics;
		public Tablature Tablature;
		
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
			
//			this.info = IniFile.ReadAllOptions("cache/song/"+artist+" - "+title+".gcs");
			this.ini = new IniFile("cache/song/"+artist+" - "+title+".gcs");
			
			this.SongBook = new ChordsSongBook();
			this.SongBook.Load("cache/song/"+artist+" - "+title+".gcc");
			
			this.Lyrics = new Lyrics("cache/song/"+artist+" - "+title+".gcl");
		}
		
		public string getString(string key)
		{
			try {
				return ini.Option[key];
			}
			catch(Exception exception) {
				return errorString;
			}
		}
		
		public int getInt(string key)
		{
			try {
				return int.Parse(ini.Option[key]);
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
				return -1;
			}
		}
		
		public float getFloat(string key)
		{
			try {
				return float.Parse(ini.Option[key]);
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
				return -1;
			}
		}
	}
}
