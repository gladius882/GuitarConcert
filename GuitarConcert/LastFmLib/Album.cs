/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-02
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;
using System.Collections.Generic;

namespace LastFmLib
{
	/// <summary>
	/// Description of Album.
	/// </summary>
	public class Album
	{
		public string Name;
		public string Artist;
		public string Mbid;
		public string Url;
		
		public Image Image;
		
		public int Listeners;
		public int PlayCount;
		
		public List<ShortTrack> Tracks;
		public List<ShortTag> Tags;
		
		public DateTime Published;
		public string Summary;
		public string Description;
		
		public string Status;
		
		public Album()
		{
			Name = "No name";
			Artist = "No artist";
			Mbid = String.Empty;
			Url = String.Empty;
			Listeners = 0;
			PlayCount = 0;
			Published = DateTime.Now;
			Summary = "No description";
			Description = "No description";
			Status = "ok";
			Image = new Image();
			Tracks = new List<ShortTrack>();
			Tags = new List<ShortTag>();
		}
		
		public void Load(string file)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(file);
			
			Name = doc.SelectNodes("lfm/album/name")[0].InnerText;
			Artist = doc.SelectNodes("lfm/album/artist")[0].InnerText;
			Mbid = doc.SelectNodes("lfm/album/mbid")[0].InnerText;
			Url = doc.SelectNodes("lfm/album/url")[0].InnerText;
			
			Image.Small = doc.SelectNodes("lfm/album/image[@size=\"small\"]")[0].InnerText;
			Image.Medium = doc.SelectNodes("lfm/album/image[@size=\"medium\"]")[0].InnerText;
			Image.Large = doc.SelectNodes("lfm/album/image[@size=\"large\"]")[0].InnerText;
			Image.ExtraLarge = doc.SelectNodes("lfm/album/image[@size=\"extralarge\"]")[0].InnerText;
			
			Listeners = int.Parse(doc.SelectNodes("lfm/album/listeners")[0].InnerText);
			PlayCount = int.Parse(doc.SelectNodes("lfm/album/playcount")[0].InnerText);
			
			Published = DateTime.Parse(doc.SelectNodes("lfm/album/wiki/published")[0].InnerText);
			Summary = doc.SelectNodes("lfm/album/wiki/summary")[0].InnerText;
			Description = doc.SelectNodes("lfm/album/wiki/content")[0].InnerText;
			
			Status = doc.SelectNodes("lfm/@status")[0].InnerText;
			
			XmlNodeList selectedTracks = doc.SelectNodes("lfm/album/tracks/track");
			foreach(XmlNode node in selectedTracks)
			{
				ShortTrack track = new ShortTrack();
				track.Position = int.Parse(node.Attributes[0].InnerText);
				track.Name = node.SelectNodes("name")[0].InnerText;
				track.Url = node.SelectNodes("url")[0].InnerText;
				track.Duration = int.Parse(node.SelectNodes("duration")[0].InnerText);
				track.Streamable = int.Parse(node.SelectNodes("streamable")[0].InnerText);
				track.ArtistName = node.SelectNodes("artist/name")[0].InnerText;
				track.ArtistMbid = node.SelectNodes("artist/mbid")[0].InnerText;
				track.ArtistUrl = node.SelectNodes("artist/url")[0].InnerText;
				this.Tracks.Add(track);
			}
			
			XmlNodeList selectedTags = doc.SelectNodes("lfm/album/tags/tag");
			foreach(XmlNode node in selectedTags)
			{
				ShortTag tag = new ShortTag();
				tag.Name = node.SelectNodes("name")[0].InnerText;
				tag.Url = node.SelectNodes("url")[0].InnerText;
				
				Tags.Add(tag);
			}
		}
		
		public void Save(string file)
		{
			XmlDocument doc = new XmlDocument();
			XmlElement lfm = doc.CreateElement("lfm");
			XmlElement album = doc.CreateElement("album");
			XmlElement name = doc.CreateElement("name");
			XmlElement artist = doc.CreateElement("artist");
			XmlElement mbid = doc.CreateElement("mbid");
			XmlElement url = doc.CreateElement("url");
			XmlElement imageSmall = doc.CreateElement("image");
			XmlElement imageMedium = doc.CreateElement("image");
			XmlElement imageLarge = doc.CreateElement("image");
			XmlElement imageExtraLarge = doc.CreateElement("image");
			XmlElement listeners = doc.CreateElement("listeners");
			XmlElement playcount = doc.CreateElement("playcount");
			XmlElement tracks = doc.CreateElement("tracks");
			XmlElement tags = doc.CreateElement("tags");
			XmlElement wiki = doc.CreateElement("wiki");
			XmlElement published = doc.CreateElement("published");
			XmlElement summary = doc.CreateElement("summary");
			XmlElement content = doc.CreateElement("content");
			
			lfm.SetAttribute("status", "ok");
			imageSmall.SetAttribute("size", "small");
			imageMedium.SetAttribute("size", "medium");
			imageLarge.SetAttribute("size", "large");
			imageExtraLarge.SetAttribute("size", "extralarge");
			
			
			name.InnerText = Name;
			artist.InnerText = Artist;
			mbid.InnerText = Mbid;
			url.InnerText = Url;
			imageSmall.InnerText = Image.GetLink(ImageSize.Small);
			imageMedium.InnerText = Image.GetLink(ImageSize.Medium);
			imageLarge.InnerText = Image.GetLink(ImageSize.Large);
			imageExtraLarge.InnerText = Image.GetLink(ImageSize.ExtraLarge);
			listeners.InnerText = Listeners.ToString();
			playcount.InnerText = PlayCount.ToString();
			published.InnerText = DateTime.Now.ToString();
			summary.InnerText = Summary;
			content.InnerText = Description;
			
			foreach(ShortTrack t in Tracks)
			{
				XmlElement track = doc.CreateElement("track");
				XmlElement tName = doc.CreateElement("name");
				XmlElement tUrl = doc.CreateElement("url");
				XmlElement tDuration = doc.CreateElement("duration");
				XmlElement tStreamable = doc.CreateElement("streamable");
				XmlElement tArtist = doc.CreateElement("artist");
				XmlElement tArtistName = doc.CreateElement("name");
				XmlElement tArtistMbid = doc.CreateElement("mbid");
				XmlElement tArtistUrl = doc.CreateElement("url");
				
				track.SetAttribute("rank", t.Position.ToString());
				tStreamable.SetAttribute("fulltrack", "0");
				
				tName.InnerText = t.Name;
				tUrl.InnerText = t.Url;
				tDuration.InnerText = t.Duration.ToString();
				tStreamable.InnerText = t.Streamable.ToString();
				tArtistName.InnerText = t.ArtistName;
				tArtistMbid.InnerText = t.ArtistMbid;
				tArtistUrl.InnerText = t.ArtistUrl;
				
				tArtist.AppendChild(tArtistName);
				tArtist.AppendChild(tArtistMbid);
				tArtist.AppendChild(tArtistUrl);
				track.AppendChild(tName);
				track.AppendChild(tUrl);
				track.AppendChild(tDuration);
				track.AppendChild(tStreamable);
				track.AppendChild(tArtist);
				tracks.AppendChild(track);
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
			
			wiki.AppendChild(published);
			wiki.AppendChild(summary);
			wiki.AppendChild(content);
			album.AppendChild(name);
			album.AppendChild(artist);
			album.AppendChild(mbid);
			album.AppendChild(url);
			album.AppendChild(imageSmall);
			album.AppendChild(imageMedium);
			album.AppendChild(imageLarge);
			album.AppendChild(imageExtraLarge);
			album.AppendChild(listeners);
			album.AppendChild(playcount);
			album.AppendChild(tracks);
			album.AppendChild(tags);
			album.AppendChild(wiki);
			lfm.AppendChild(album);
			doc.AppendChild(lfm);
			doc.Save(file);
		}
	}
}
