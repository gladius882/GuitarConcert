/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-08
 * Time: 19:22
 * 
 */
using System;

namespace GuitarConcert
{
	/// <summary>
	/// Description of PathBuilder.
	/// </summary>
	public class PathGenerator
	{
		public PathGenerator()
		{
		}
		
		public static string SongInfoPath(string artist, string title)
		{
			string result = String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					artist, title,
					SettingsSingleton.Instance.option["songInfoExtension"]);
			
			return result;
		}
		
		public static string SongLyricsPath(string artist, string title)
		{
			string result = String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					artist, title,
					SettingsSingleton.Instance.option["lyricsExtension"]);
			
			return result;
		}
		
		public static string SongLyricsPath(Song sng)
		{
			string result = String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					sng.getString("songArtist"), sng.getString("songTitle"),
					SettingsSingleton.Instance.option["lyricsExtension"]);
			
			return result;
		}
		
		public static string SongChordsPath(string artist, string title)
		{
			string result = String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					artist, title,
					SettingsSingleton.Instance.option["chordsExtension"]);
			
			return result;
		}
		
		public static string SongChordsPath(Song sng)
		{
			string result = String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					sng.getString("songArtist"), sng.getString("songTitle"),
					"gcc");
			
			return result;
		}
		
		public static string SongTablaturePath(string artist, string title)
		{
			string result = String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					artist, title,
					SettingsSingleton.Instance.option["tabExtension"]);
			
			return result;
		}
		
		public static string ChordDiagramPath(string chord)
		{
			string result = String.Format("{0}/{1}.{2}",
						SettingsSingleton.Instance.option["chordsDirectory"],
						chord,
						SettingsSingleton.Instance.option["chordDiagramExtension"]);
			
			return result;
		}
	}
}
