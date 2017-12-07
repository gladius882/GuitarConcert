/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-07
 * Time: 17:56
 * 
 */
using System;
using System.IO;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Lyrics.
	/// </summary>
	public class SongLyrics
	{
		public string Text;
		
		public SongLyrics()
		{
			this.Text = "[BRAK TEKSTU]";
		}
		
		public void Load(string title, string artist)
		{
			string content = File.ReadAllText(String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					artist, title,
					SettingsSingleton.Instance.option["lyricsExtension"]));
			
			this.Text = content;
		}
	}
}
