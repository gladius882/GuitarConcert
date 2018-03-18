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
		
		public Lyrics(string fileName)
		{
			this.NoLyricsString = "[BRAK TEKSTU]";
			this.Load(fileName);
		}
		
		public void Load(string fileName)
		{
			try {
				string content = File.ReadAllText(fileName);	
				this.Text = content;
			}
			catch {
				this.Text = this.NoLyricsString;
			}
		}
	}
}
