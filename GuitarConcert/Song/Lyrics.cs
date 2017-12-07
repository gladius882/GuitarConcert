/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-07
 * Time: 17:56
 * 
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Lyrics.
	/// </summary>
	public class Lyrics
	{
		private string NoLyricsString;
		public string Text;
		
		public Lyrics()
		{
			this.NoLyricsString = "[BRAK TEKSTU]";
		}
		
		public Lyrics(string title, string artist)
		{
			this.NoLyricsString = "[BRAK TEKSTU]";
			this.Load(title, artist);
		}
		
		public void Load(string title, string artist)
		{
			try {
				string content = File.ReadAllText(String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					artist, title,
					SettingsSingleton.Instance.option["lyricsExtension"]));
				
				this.Text = content;
			}
			catch(Exception exception) {
				this.Text = this.NoLyricsString;
				Logger.ToFile(exception);
			}
		}
	}
}
