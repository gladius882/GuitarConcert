/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-12-03
 * Time: 14:14
 * 
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace GuitarConcert
{
	/// <summary>
	/// Description of IniFile.
	/// </summary>
	public class IniFile
	{
		public static Dictionary<string, string> ReadOptions(string fileName)
		{	
			Dictionary<string, string> result = new Dictionary<string, string>();
			string[] lines = File.ReadAllLines(fileName);
			
			foreach(string line in lines)
			{
				if(ValidateOptionLine(line) == true) {
					string[] opt = line.Trim().Split(':');
					result.Add(opt[0], opt[1]);
				}
			}
			
			return result;
		}
		
		private static bool ValidateOptionLine(string line)
		{
			if(line.Trim() == String.Empty)
				return false;
			if(line.Trim()[0] == '#')
				return false;
			if(line.Trim().Split(':').Length != 2)
				return false;
			
			return true;
		}
		
		private IniFile()
		{
		}
	}
}
