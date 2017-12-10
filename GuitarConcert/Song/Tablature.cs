/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-08
 * Time: 19:20
 * 
 */
using System;
using System.Collections.Generic;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Tablature.
	/// </summary>
	public class Tablature
	{
		public string Title;
		public string Tuning;
		
		public string[] Content;
		
		public Tablature(string tabString)
		{
			Title = IniFile.ReadOption(tabString, "tabTitle");
			Tuning = IniFile.ReadOption(tabString, "guitarTuning");
			
			Content = tabString.Split(',')[1].Split('\n');
		}
	}
}
