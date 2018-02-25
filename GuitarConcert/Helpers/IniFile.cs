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
		private Dictionary<string, string> options = new Dictionary<string, string>();
		private Dictionary<int, string> comments = new Dictionary<int, string>();
		
		#region Properties
		
		public Dictionary<string, string> Option
		{
			get
			{
				return options;
			}
		}
		
		public int Count
		{
			get
			{
				return options.Count;
			}
		}
		
		#endregion
		
		#region Construct
		
		public IniFile() {}
		
		public IniFile(string fileName)
		{
			Load(fileName);
		}
		
		#endregion
		
		public void Load(string fileName)
		{
			options = IniFile.ReadAllOptions(fileName);
		}
		
		public void SetValue(string key, string value)
		{
			if(options.ContainsKey(key) == false)
				AddOption(key, value);
			else
				options[key] = value;
			
		}
		
		public void AddOption(string key, string value)
		{
			options.Add(key, value);
		}
		
		public void AddComment(string comment, int line)
		{
			comments.Add(line, comment);
		}
		
		public void AddNewLine(int line)
		{
			comments.Add(line, "#");
		}
		
		public void Save(string path)
		{
			List<string> lines = new List<string>();
			
			foreach(KeyValuePair<string, string> value in this.options)
			{
				lines.Add(value.Key + ":" + value.Value);
			}
			
			foreach(KeyValuePair <int, string> value in comments)
			{
				string content = value.Value;
				if(content.Trim().StartsWith("#") == false)
					content = "# " + content;
				
				lines.Insert(value.Key-1, content);
			}
			
			File.WriteAllLines(path, lines.ToArray());
		}
		
		#region Static methods
		
		public static Dictionary<string, string> ReadAllOptions(string fileName)
		{	
			Dictionary<string, string> result = new Dictionary<string, string>();
			string[] lines = new string[0];
			
			if(File.Exists(fileName)) {
				lines = File.ReadAllLines(fileName);
			} else {
				lines = fileName.Split('\n');
			}
			
			
			foreach(string line in lines)
			{
				if(ValidateOptionLine(line) == true) {
					string[] opt = line.Trim().Split(':');
					result.Add(opt[0], opt[1]);
				}
			}
			
			return result;
		}
		
		public static string ReadOption(string fileName, string key)
		{
			string[] lines = new string[0];
			
			if(File.Exists(fileName)) {
				lines = File.ReadAllLines(fileName);
			} else {
				lines = fileName.Split('\n');
			}
			
			foreach(string line in lines)
			{
				if(ValidateOptionLine(line) == true) {
					string[] opt = line.Trim().Split(':');
					
					if(opt[0] == key) {
						return opt[1];
					}
				}
			}
			
			return String.Empty;
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
		
		#endregion
	}
}
