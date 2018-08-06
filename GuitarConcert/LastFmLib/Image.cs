/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-03-20
 * Time: 18:34
 * 
 */
using System;
using System.Net;
using System.Xml;

namespace LastFmLib
{
	/// <summary>
	/// Description of Image.
	/// </summary>
	
	public enum ImageSize
	{
		Small = 34,
		Medium = 64,
		Large = 174,
		ExtraLarge = 300
	}
	
	public class Image
	{
		public string Small { get; set; }
		public string Medium { get; set; }
		public string Large { get; set; }
		public string ExtraLarge { get; set; }
		
		public Image()
		{
		}
		
		public string GetLink(ImageSize size)
		{
			switch(size)
			{
				case ImageSize.Small: return Small;
				case ImageSize.Medium: return Medium;
				case ImageSize.Large: return Large;
				case ImageSize.ExtraLarge: return ExtraLarge;
				default: return Small;
			}
		}
		
		// TODO add Image.DownloadAsync method
		public void Download(string destination, ImageSize size = ImageSize.Medium)
		{
			using(WebClient client = new WebClient())
			{
				client.DownloadFile(new Uri(GetLink(size)), destination);
			}
		}
	}
	
}
