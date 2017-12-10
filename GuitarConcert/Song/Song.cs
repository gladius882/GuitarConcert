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
		private Dictionary<string, string> info;
		
		public readonly string errorString;
		public ChordsSongBook SongBook;
		public Lyrics Lyrics;
		
		public Song(string fileName)
		{
			this.errorString = "None";
			this.info = IniFile.ReadAllOptions(fileName);
			
			this.SongBook = new ChordsSongBook();
			this.SongBook.Load(PathBuilder.SongChordsPath(this));
			
			this.Lyrics = new Lyrics(getString("songTitle"), getString("songArtist"));
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
		
		public void PlayMidi()
		{
			// TODO Play midi from file
		}
		
		public void PlayMP3()
		{
			// TODO Play mp3 from file
		}
	}
}
