/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-03-26
 * Time: 21:12
 * 
 */
using System;

namespace LastFmLib
{
	/// <summary>
	/// Description of ShortTag.
	/// </summary>
	public class ShortTag
	{
		public string Name;
		public string Url;
		
		public ShortTag()
		{
			Name = "No name";
			Url = String.Empty;
		}
		
		public ShortTag(string name, string url)
		{
			Name = name;
			Url = url;
		}
	}
}
