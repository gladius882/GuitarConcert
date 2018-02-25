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
		
		public void Load(string fileName)
		{
			try {
				string content = File.ReadAllText(fileName);
			
				string[] chords = content.Split(';');
				
				foreach(string chrd in chords)
				{
					ChordsList.Add(chrd.Replace(' ', '/'));
				}
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
			}
			
		}
	}
}
