/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-05
 * Time: 17:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LastFmLib
{
	/// <summary>
	/// Description of ShortArtist.
	/// </summary>
	public class ShortArtist
	{
		public string Name;
		public string Url;
		public Image Image;
		
		public ShortArtist()
		{
			Image = new Image();
		}
		
		public ShortArtist(string name, string url)
		{
			Image = new Image();
			Name = name;
			Url = url;
		}
	}
}
