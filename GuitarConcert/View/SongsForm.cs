/*
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

namespace GuitarConcert
{
	public enum List
	{
		SONGS,
		WISHLIST
	}
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
			onCreate();
			this.parent = (MainForm)this.MdiParent;
			CurrentList = List.SONGS;
		}
		
		private void onCreate()
		{
			this.calcColummnsWidth();
			this.loadList(SettingsSingleton.Instance.option["songsListPath"]);
			this.listViewSongs.Font = new Font(SettingsSingleton.Instance.option["fontName"], float.Parse(SettingsSingleton.Instance.option["fontSize"]), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
		}
		
		private void calcColummnsWidth()
		{
			int windowWidth = Screen.PrimaryScreen.WorkingArea.Width;
			
			this.songArtist.Width = (int)(0.3*windowWidth);
			this.songTitle.Width = (int)(0.3*windowWidth);
			this.songAlbum.Width = (int)(0.3*windowWidth);
			this.songChords.Width = (int)(0.05*windowWidth);
			this.songTab.Width = (int)(0.048*windowWidth);
		}
		
		private void loadList(string fileName)
		{
			this.listViewSongs.Items.Clear();
			string[] songs = File.ReadAllLines(fileName);	
			
			foreach(string row in songs)
			{
				string[] details = row.Split(';');
				this.listViewSongs.Items.Add(new ListViewItem(details));
			}
			
			this.toolStripStatusLabel.Text = "Piosenek na liście: " + this.listViewSongs.Items.Count.ToString();
		}
		
		void ListViewSongsDoubleClick(object sender, EventArgs e)
		{
			string artist = this.listViewSongs.SelectedItems[0].SubItems[0].Text;
			string title = this.listViewSongs.SelectedItems[0].SubItems[1].Text;
			
			Song sng = new Song(String.Format("{0}/{1} - {2}.{3}",
			                                  SettingsSingleton.Instance.option["songDirectory"],
			                                  artist, title,
			                                  SettingsSingleton.Instance.option["songInfoExtension"]));
			
			PlayConcertForm form = new PlayConcertForm(sng);
			
			MainForm main = (MainForm)this.MdiParent;
			main.loadView(form);
		}
		
		void ToolStripSongsClick(object sender, EventArgs e)
		{
			this.loadList(SettingsSingleton.Instance.option["songsListPath"]);
			CurrentList = List.SONGS;
		}
		
		void ToolStripWishlistClick(object sender, EventArgs e)
		{
			this.loadList(SettingsSingleton.Instance.option["wishListPath"]);
			CurrentList = List.WISHLIST;
		}
	}
}
