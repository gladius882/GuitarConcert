﻿/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-27
 * Time: 16:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Sanford.Multimedia.Midi;
namespace GuitarConcert
{
	/// <summary>
	/// Description of SongsForm.
	/// </summary>
	public partial class SongsForm : Form
	{
		// TODO Other displays (icons, list, details)
		private MainForm parent;
		private List CurrentList;
		
		public SongsForm()
		{
			InitializeComponent();
			OnCreate();
			this.parent = (MainForm)this.MdiParent;
			CurrentList = List.SONGS;
		}
		
		private void OnCreate()
		{
			this.CalcColummnsWidth();
			string listName = SettingsSingleton.Instance.option["defaultList"];
			
			if(listName.ToUpper() == "SONGS")
				this.LoadList(SettingsSingleton.Instance.option["songsListPath"]);
			else if(listName.ToUpper() == "WISHLIST")
				this.LoadList(SettingsSingleton.Instance.option["wishListPath"]);
			
			this.listViewSongs.Font = new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
		}
		
		private void CalcColummnsWidth()
		{
			int windowWidth = Screen.PrimaryScreen.WorkingArea.Width;
			
			this.songArtist.Width = (int)(0.33*windowWidth);
			this.songTitle.Width = (int)(0.34*windowWidth);
			this.songAlbum.Width = (int)(0.33*windowWidth);
		}
		
		private void LoadList(string fileName)
		{
			this.listViewSongs.Items.Clear();
			string[] songs = File.ReadAllLines(fileName);	
			
			foreach(string row in songs)
			{
				if(row == String.Empty)
					continue;
				string[] details = row.Split(';');
				if(details.Length != 3)
					continue;
				this.listViewSongs.Items.Add(new ListViewItem(details));
			}
			
			this.toolStripStatusLabel.Text = "Piosenek na liście: " + this.listViewSongs.Items.Count.ToString();
		}
		
		void ListViewSongsDoubleClick(object sender, EventArgs e)
		{
			string artist = this.listViewSongs.SelectedItems[0].SubItems[0].Text;
			string title = this.listViewSongs.SelectedItems[0].SubItems[1].Text;
			
			Song sng = new Song(artist, title);
			
			PlayConcertForm form = new PlayConcertForm(sng);
			
			MainForm main = (MainForm)this.MdiParent;
			main.LoadView(form);
		}
		
		void ToolStripSongsClick(object sender, EventArgs e)
		{
			this.LoadList(SettingsSingleton.Instance.option["songsListPath"]);
			CurrentList = List.SONGS;
		}
		
		void ToolStripWishlistClick(object sender, EventArgs e)
		{
			this.LoadList(SettingsSingleton.Instance.option["wishListPath"]);
			CurrentList = List.WISHLIST;
		}
		void ToolStripDeleteClick(object sender, EventArgs e)
		{
			if(this.listViewSongs.SelectedItems.Count != 0)
			{
				string artist = this.listViewSongs.SelectedItems[0].SubItems[0].Text;
				string title = this.listViewSongs.SelectedItems[0].SubItems[1].Text;
				string album = this.listViewSongs.SelectedItems[0].SubItems[2].Text;
				
				string rowString = artist+";"+title+";"+album;
				
				string file = "";
				if(CurrentList == List.SONGS)
					file = SettingsSingleton.Instance.option["songsListPath"];
				else if(CurrentList == List.WISHLIST)
					file = SettingsSingleton.Instance.option["wishListPath"];
					
				
				string content = File.ReadAllText(file);
				content = content.Replace(rowString, "");
				
				File.WriteAllText(file, content);
				File.Delete("song/" + artist + " - " + title + ".gc");
				
				this.listViewSongs.Items.RemoveAt(this.listViewSongs.SelectedItems[0].Index);
			}
		}
		
		void ToolStripAddClick(object sender, EventArgs e)
		{
			MainForm parent = (MainForm)this.MdiParent;
			parent.LoadView(new NewSongForm());
		}
	}
	
	public enum List
	{
		SONGS,
		WISHLIST
	}
}
