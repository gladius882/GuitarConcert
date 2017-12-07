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

namespace GuitarConcert
{
	/// <summary>
	/// Description of Song.
	/// </summary>
	public class Song
	{
		public readonly string errorString;
		public ChordsSongBook SongBook;
		public SongLyrics Lyrics;
		private Dictionary<string, string> info;
		
		public Song(string fileName)
		{
			this.errorString = "undefined";
			this.info = IniFile.ReadOptions(fileName);
			
			this.SongBook = new ChordsSongBook();
			this.SongBook.Load(info["songTitle"], info["songArtist"]);
			
			this.Lyrics = new SongLyrics();
			this.Lyrics.Load(info["songTitle"], info["songArtist"]);
		}
		
		public string getString(string key)
		{
			try {
				return info[key];
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
				return errorString;
			}
		}
		
		public int getInt(string key)
		{
			try {
				return int.Parse(info[key]);
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
				return -1;
			}
		}
		
		public float getFloat(string key)
		{
			try {
				return float.Parse(info[key]);
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
				return -1;
			}
		}
		
		public void PlayMP3()
		{
			// TODO Play mp3 from file
		}
	}
}
