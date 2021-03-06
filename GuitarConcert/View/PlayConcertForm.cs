﻿/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-11-29
 * Time: 16:32
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GuitarConcert
{
	/// <summary>
	/// Description of PlayConcertForm.
	/// </summary>
	public partial class PlayConcertForm : Form
	{
		private Song currentSong;
		
		public PlayConcertForm(Song sng)
		{
			InitializeComponent();
			this.loadSong(sng);
			
			this.lyricsBox.Font = new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabBox.Font = new Font(SettingsSingleton.Instance.option["tabFontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			
			this.detailsList.Font = new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			
			this.splitContainer1.SplitterDistance = int.Parse(SettingsSingleton.Instance.option["leftPanelWidth"]);
			int tmp = int.Parse(SettingsSingleton.Instance.option["rightPanelWidth"]);
			this.splitContainer2.SplitterDistance = this.ClientSize.Width -this.splitContainer1.SplitterDistance-tmp;
			
			Chord Am = new Chord();
			this.chordDiagramPicture.Image = Am.CreateBitmap();
		}
		
		public void loadSong(Song sng)
		{
			this.currentSong = sng;
			
			try {
				string content = File.ReadAllText(String.Format("{0}/{1} - {2}.{3}",
				                                            SettingsSingleton.Instance.option["songDirectory"],
				                                            sng.getString("songArtist"), sng.getString("songTitle"),
				                                            SettingsSingleton.Instance.option["lyricsExtension"]));
			
				this.lyricsBox.Clear();
				this.lyricsBox.Text = content;
				this.lyricsBox.Lines[0].Remove(0, lyricsBox.Lines[0].Length);
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
			}
			
			try {
				string tab = File.ReadAllText(String.Format("{0}/{1} - {2}.{3}",
				                                            SettingsSingleton.Instance.option["songDirectory"],
				                                            sng.getString("songArtist"), sng.getString("songTitle"),
				                                            SettingsSingleton.Instance.option["tabExtension"]));
			
				this.tabBox.Clear();
				this.tabBox.Text = tab;
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
			}
			
			try {
				this.pictureBox1.ImageLocation = "assets/covers/"+sng.getString("songArtist")+" - "+sng.getString("songAlbum")+".png";
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
			}
			
			try {
				this.detailsList.Items.Add(sng.getString("songTitle"));
				this.detailsList.Items.Add(sng.getString("songArtist"));
				this.detailsList.Items.Add(sng.getString("songAlbum")+" ("+sng.getString("releaseYear")+")");
				this.detailsList.Items.Add(String.Empty);
				this.detailsList.Items.Add("Gatunek: " + sng.getString("genre"));
				this.detailsList.Items.Add("Metrum: " + sng.getString("metrum"));
			}
			catch(Exception exception) {
				Logger.ToFile(exception);
			}
		}
	}
}
