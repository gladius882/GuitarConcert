/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-03-20
 * Time: 18:22
 * 
 */
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace LastFmLib
{
	/// <summary>
	/// Description of Artist.
	/// </summary>
	public class Artist
	{
		public string Name;
		public string Mbid;
		public string Url;
		
		public Image Image;
		
		public int Streamable;
		public int OnTuor;
		
		public int Listeners;
		public int PlayCount;
		
		public DateTime Published;
		public string Summary;
		public string Description;
		
		public string Status;
		
		public List<ShortArtist> SimilarArtists;
		public List<ShortTag> Tags;
		
		public Artist()
		{
			Name = "No name";
			Mbid = String.Empty;
			Url = String.Empty;
			Image = new Image();
			Streamable = 0;
			OnTuor = 0;
			Listeners = 0;
			PlayCount = 0;
			Published = DateTime.Now;
			Status = "ok";
			SimilarArtists = new List<ShortArtist>();
			Tags = new List<ShortTag>();
		}
		
		public void Load(string file)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(file);
			
			this.Name = doc.SelectNodes("lfm/artist/name")[0].InnerText;
			this.Mbid = doc.GetElementsByTagName("mbid")[0].InnerText;
			this.Url = doc.SelectNodes("lfm/artist/url")[0].InnerText;
			
			this.Image = new Image();
			this.Image.Small = doc.SelectNodes("lfm/artist/image[@size=\"small\"]")[0].InnerText;
			this.Image.Medium = doc.SelectNodes("lfm/artist/image[@size=\"medium\"]")[0].InnerText;
			this.Image.Large = doc.SelectNodes("lfm/artist/image[@size=\"large\"]")[0].InnerText;
			this.Image.ExtraLarge = doc.SelectNodes("lfm/artist/image[@size=\"extralarge\"]")[0].InnerText;
			
			this.Streamable = int.Parse(doc.SelectNodes("lfm/artist/streamable")[0].InnerText);
			this.OnTuor = int.Parse(doc.SelectNodes("lfm/artist/ontour")[0].InnerText);
			
			this.Listeners = int.Parse(doc.SelectNodes("lfm/artist/stats/listeners")[0].InnerText);
			this.PlayCount = int.Parse(doc.SelectNodes("lfm/artist/stats/playcount")[0].InnerText);
			
			this.Published = DateTime.Parse(doc.SelectNodes("lfm/artist/bio/published")[0].InnerText);
			this.Summary = doc.SelectNodes("lfm/artist/bio/summary")[0].InnerText;
			this.Description = doc.SelectNodes("lfm/artist/bio/content")[0].InnerText;
			
			this.Status = doc.SelectNodes("lfm/@status")[0].InnerText;
			
			XmlNodeList selectedTags = doc.SelectNodes("lfm/artist/tags/tag");
			foreach(XmlNode tag in selectedTags)
			{
				ShortTag currentTag = new ShortTag();
				currentTag.Name = tag.SelectNodes("name")[0].InnerText;
				currentTag.Url = tag.SelectNodes("url")[0].InnerText;
				this.Tags.Add(currentTag);
			}
			
			XmlNodeList selectedArtists = doc.SelectNodes("lfm/artist/similar/artist");
			foreach(XmlNode a in selectedArtists)
			{
				ShortArtist artist = new ShortArtist();
				artist.Name = a.SelectNodes("name")[0].InnerText;
				artist.Url = a.SelectNodes("url")[0].InnerText;
				artist.Image.Small = a.SelectNodes("image[@size=\"small\"]")[0].InnerText;
				artist.Image.Medium = a.SelectNodes("image[@size=\"medium\"]")[0].InnerText;
				artist.Image.Large = a.SelectNodes("image[@size=\"large\"]")[0].InnerText;
				artist.Image.ExtraLarge = a.SelectNodes("image[@size=\"extralarge\"]")[0].InnerText;
				this.SimilarArtists.Add(artist);
			}
		}
		
		public void Save(string file)
		{
			XmlDocument doc = new XmlDocument();
			XmlElement lfm = doc.CreateElement("lfm");
			XmlElement artist = doc.CreateElement("artist");
			XmlElement name = doc.CreateElement("name");
			XmlElement url = doc.CreateElement("url");
			XmlElement mbid = doc.CreateElement("mbid");
			XmlElement imageSmall = doc.CreateElement("image");
			XmlElement imageMedium = doc.CreateElement("image");
			XmlElement imageLarge = doc.CreateElement("image");
			XmlElement imageExtraLarge = doc.CreateElement("image");
			XmlElement streamable = doc.CreateElement("streamable");
			XmlElement ontour = doc.CreateElement("ontour");
			XmlElement stats = doc.CreateElement("stats");
			XmlElement listeners = doc.CreateElement("listeners");
			XmlElement playcount = doc.CreateElement("playcount");
			XmlElement similar = doc.CreateElement("similar");
			XmlElement tags = doc.CreateElement("tags");
			XmlElement bio = doc.CreateElement("bio");
			XmlElement links = doc.CreateElement("links");
			XmlElement published = doc.CreateElement("published");
			XmlElement summary = doc.CreateElement("summary");
			XmlElement content = doc.CreateElement("content");
			
			lfm.SetAttribute("status", "ok");
			imageSmall.SetAttribute("size", "small");
			imageMedium.SetAttribute("size", "medium");
			imageLarge.SetAttribute("size", "large");
			imageExtraLarge.SetAttribute("size", "extralarge");
			
			name.InnerText = Name;
			mbid.InnerText = Mbid;
			url.InnerText = Url;
			imageSmall.InnerText = Image.GetLink(ImageSize.Small);
			imageMedium.InnerText = Image.GetLink(ImageSize.Medium);
			imageLarge.InnerText = Image.GetLink(ImageSize.Large);
			imageExtraLarge.InnerText = Image.GetLink(ImageSize.ExtraLarge);
			streamable.InnerText = Streamable.ToString();
			ontour.InnerText = OnTuor.ToString();
			listeners.InnerText = Listeners.ToString();
			playcount.InnerText = PlayCount.ToString();
			published.InnerText = DateTime.Now.ToString();
			summary.InnerText = Summary;
			content.InnerText = Description;
			
			foreach(ShortArtist a in SimilarArtists)
			{
				XmlElement sArtist = doc.CreateElement("artist");
				XmlElement sName = doc.CreateElement("name");
				XmlElement sUrl = doc.CreateElement("url");
				XmlElement sImageSmall = doc.CreateElement("image");
				XmlElement sImageMedium = doc.CreateElement("image");
				XmlElement sImageLarge = doc.CreateElement("image");
				XmlElement sImageExtraLarge = doc.CreateElement("image");
				
				sImageSmall.SetAttribute("size", "small");
				sImageMedium.SetAttribute("size", "medium");
				sImageLarge.SetAttribute("size", "large");
				sImageExtraLarge.SetAttribute("size", "extralarge");
				
				sName.InnerText = a.Name;
				sUrl.InnerText = a.Url;
				sImageSmall.InnerText = a.Image.GetLink(ImageSize.Small);
				sImageMedium.InnerText = a.Image.GetLink(ImageSize.Medium);
				sImageLarge.InnerText = a.Image.GetLink(ImageSize.Large);
				sImageExtraLarge.InnerText = a.Image.GetLink(ImageSize.ExtraLarge);
				
				sArtist.AppendChild(sName);
				sArtist.AppendChild(sUrl);
				sArtist.AppendChild(sImageSmall);
				sArtist.AppendChild(sImageMedium);
				sArtist.AppendChild(sImageLarge);
				sArtist.AppendChild(sImageExtraLarge);
				
				similar.AppendChild(sArtist);
			}
			
			foreach(ShortTag t in Tags)
			{
				XmlElement tag = doc.CreateElement("tag");
				XmlElement tName = doc.CreateElement("name");
				XmlElement tUrl = doc.CreateElement("url");
				
				tName.InnerText = t.Name;
				tUrl.InnerText = t.Url;
				
				tag.AppendChild(tName);
				tag.AppendChild(tUrl);
				tags.AppendChild(tag);
			}
			
			bio.AppendChild(published);
			bio.AppendChild(summary);
			bio.AppendChild(content);
			stats.AppendChild(listeners);
			stats.AppendChild(playcount);
			artist.AppendChild(name);
			artist.AppendChild(mbid);
			artist.AppendChild(url);
			artist.AppendChild(imageSmall);
			artist.AppendChild(imageMedium);
			artist.AppendChild(imageLarge);
			artist.AppendChild(imageExtraLarge);
			artist.AppendChild(streamable);
			artist.AppendChild(ontour);
			artist.AppendChild(stats);
			artist.AppendChild(similar);
			artist.AppendChild(tags);
			artist.AppendChild(bio);
			lfm.AppendChild(artist);
			doc.AppendChild(lfm);
			
			doc.Save(file);
		}
	}
}
