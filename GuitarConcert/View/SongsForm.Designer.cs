/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-27
 * Time: 16:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GuitarConcert
{
	partial class SongsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongsForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSongs = new System.Windows.Forms.ToolStripButton();
			this.toolStripWishlist = new System.Windows.Forms.ToolStripButton();
			this.listViewSongs = new System.Windows.Forms.ListView();
			this.songArtist = new System.Windows.Forms.ColumnHeader();
			this.songTitle = new System.Windows.Forms.ColumnHeader();
			this.songAlbum = new System.Windows.Forms.ColumnHeader();
			this.songChords = new System.Windows.Forms.ColumnHeader();
			this.songTab = new System.Windows.Forms.ColumnHeader();
			this.songContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1.SuspendLayout();
			this.songContextMenu.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripAdd,
			this.toolStripDelete,
			this.toolStripEdit,
			this.toolStripSeparator1,
			this.toolStripSongs,
			this.toolStripWishlist});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(914, 39);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripAdd
			// 
			this.toolStripAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
			this.toolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripAdd.Name = "toolStripAdd";
			this.toolStripAdd.Size = new System.Drawing.Size(36, 36);
			this.toolStripAdd.Text = "Dodaj";
			// 
			// toolStripDelete
			// 
			this.toolStripDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
			this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDelete.Name = "toolStripDelete";
			this.toolStripDelete.Size = new System.Drawing.Size(36, 36);
			this.toolStripDelete.Text = "Usuń";
			this.toolStripDelete.Click += new System.EventHandler(this.ToolStripDeleteClick);
			// 
			// toolStripEdit
			// 
			this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
			this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripEdit.Name = "toolStripEdit";
			this.toolStripEdit.Size = new System.Drawing.Size(36, 36);
			this.toolStripEdit.Text = "Edytuj";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripSongs
			// 
			this.toolStripSongs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSongs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSongs.Image")));
			this.toolStripSongs.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSongs.Name = "toolStripSongs";
			this.toolStripSongs.Size = new System.Drawing.Size(36, 36);
			this.toolStripSongs.Text = "Piosenki";
			this.toolStripSongs.Click += new System.EventHandler(this.ToolStripSongsClick);
			// 
			// toolStripWishlist
			// 
			this.toolStripWishlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripWishlist.Image = ((System.Drawing.Image)(resources.GetObject("toolStripWishlist.Image")));
			this.toolStripWishlist.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripWishlist.Name = "toolStripWishlist";
			this.toolStripWishlist.Size = new System.Drawing.Size(36, 36);
			this.toolStripWishlist.Text = "Lista życzeń";
			this.toolStripWishlist.Click += new System.EventHandler(this.ToolStripWishlistClick);
			// 
			// listViewSongs
			// 
			this.listViewSongs.BackColor = System.Drawing.Color.Black;
			this.listViewSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.songArtist,
			this.songTitle,
			this.songAlbum,
			this.songChords,
			this.songTab});
			this.listViewSongs.ContextMenuStrip = this.songContextMenu;
			this.listViewSongs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewSongs.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.listViewSongs.ForeColor = System.Drawing.SystemColors.Menu;
			this.listViewSongs.FullRowSelect = true;
			this.listViewSongs.Location = new System.Drawing.Point(0, 39);
			this.listViewSongs.MultiSelect = false;
			this.listViewSongs.Name = "listViewSongs";
			this.listViewSongs.Size = new System.Drawing.Size(914, 222);
			this.listViewSongs.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewSongs.TabIndex = 1;
			this.listViewSongs.UseCompatibleStateImageBehavior = false;
			this.listViewSongs.View = System.Windows.Forms.View.Details;
			this.listViewSongs.DoubleClick += new System.EventHandler(this.ListViewSongsDoubleClick);
			// 
			// songArtist
			// 
			this.songArtist.Text = "Wykonawca";
			// 
			// songTitle
			// 
			this.songTitle.Text = "Tytuł";
			// 
			// songAlbum
			// 
			this.songAlbum.Text = "Album";
			// 
			// songChords
			// 
			this.songChords.Text = "CHRD";
			this.songChords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// songTab
			// 
			this.songTab.Text = "TAB";
			this.songTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// songContextMenu
			// 
			this.songContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.contextMenuItemAdd,
			this.contextMenuItemDelete,
			this.contextMenuItemEdit});
			this.songContextMenu.Name = "contextMenuStrip1";
			this.songContextMenu.Size = new System.Drawing.Size(108, 70);
			// 
			// contextMenuItemAdd
			// 
			this.contextMenuItemAdd.Name = "contextMenuItemAdd";
			this.contextMenuItemAdd.Size = new System.Drawing.Size(107, 22);
			this.contextMenuItemAdd.Text = "Dodaj";
			// 
			// contextMenuItemDelete
			// 
			this.contextMenuItemDelete.Name = "contextMenuItemDelete";
			this.contextMenuItemDelete.Size = new System.Drawing.Size(107, 22);
			this.contextMenuItemDelete.Text = "Usuń";
			this.contextMenuItemDelete.Click += new System.EventHandler(this.ToolStripDeleteClick);
			// 
			// contextMenuItemEdit
			// 
			this.contextMenuItemEdit.Name = "contextMenuItemEdit";
			this.contextMenuItemEdit.Size = new System.Drawing.Size(107, 22);
			this.contextMenuItemEdit.Text = "Edytuj";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 239);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(914, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// SongsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 261);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.listViewSongs);
			this.Controls.Add(this.toolStrip1);
			this.Name = "SongsForm";
			this.Text = "SongsForm";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.songContextMenu.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripButton toolStripDelete;
		private System.Windows.Forms.ColumnHeader songTab;
		private System.Windows.Forms.ColumnHeader songChords;
		private System.Windows.Forms.ColumnHeader songAlbum;
		private System.Windows.Forms.ColumnHeader songTitle;
		private System.Windows.Forms.ColumnHeader songArtist;
		private System.Windows.Forms.ListView listViewSongs;
		private System.Windows.Forms.ToolStripButton toolStripAdd;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripEdit;
		private System.Windows.Forms.ToolStripButton toolStripSongs;
		private System.Windows.Forms.ToolStripButton toolStripWishlist;
		private System.Windows.Forms.ContextMenuStrip songContextMenu;
		private System.Windows.Forms.ToolStripMenuItem contextMenuItemAdd;
		private System.Windows.Forms.ToolStripMenuItem contextMenuItemDelete;
		private System.Windows.Forms.ToolStripMenuItem contextMenuItemEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}
