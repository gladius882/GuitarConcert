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
		private GcFile gc;
		private IniFile ini;
		private Tablature Tablature;
		
		public readonly string errorString;
		public ChordsSongBook SongBook;
		public Lyrics Lyrics;
		
		#region Properties
		
		public object GpTablature
		{
			get
			{
				return Tablature;
			}
		}
		
		public object TextTablature
		{
			get
			{
				return Tablature;
			}
		}
		
		#endregion
		
		public Song(string artist, string title)
		{
			this.errorString = "None";
			
			DirectoryInfo dir = new DirectoryInfo("cache/song");
			foreach(FileInfo file in dir.GetFiles())
			{
				file.Delete();
			}
			
			gc = new GcFile("song/"+artist+" - "+title+".gc");
			gc.Extract("cache/song");
			
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
			catch {
				return this.errorString;
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
