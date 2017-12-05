/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-05
 * Time: 19:34
 * 
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace GuitarConcert
{
	/// <summary>
	/// Description of ChordsSongBook.
	/// </summary>
	public class ChordsSongBook
	{
		public List<string> ChordsList;
		
		public ChordsSongBook()
		{
			ChordsList = new List<string>();
		}
		
		public void Load(string title, string band)
		{
			string content = File.ReadAllText(String.Format("{0}/{1} - {2}.{3}",
					SettingsSingleton.Instance.option["songDirectory"],
					band, title,
					SettingsSingleton.Instance.option["chordsExtension"]));
			
			string[] chords = content.Split(';');
			
			foreach(string chrd in chords)
			{
				ChordsList.Add(chrd);
			}
			
		}
	}
}
