/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-03
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GuitarConcert
{
	partial class NewSongForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSongForm));
			this.groupInfo = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.TagName = new System.Windows.Forms.TextBox();
			this.TagAdd = new System.Windows.Forms.Button();
			this.TagsList = new System.Windows.Forms.CheckedListBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.Position = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.Duration = new System.Windows.Forms.NumericUpDown();
			this.Release = new System.Windows.Forms.NumericUpDown();
			this.ListTypeWish = new System.Windows.Forms.RadioButton();
			this.ListTypeSongs = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label13 = new System.Windows.Forms.Label();
			this.SongLink = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SongAlbum = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SongArtist = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SongTitle = new System.Windows.Forms.TextBox();
			this.groupPlayer = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Bpm = new System.Windows.Forms.NumericUpDown();
			this.Metrum = new System.Windows.Forms.ComboBox();
			this.AutoscrollSpeed = new System.Windows.Forms.NumericUpDown();
			this.AutoscrollDelay = new System.Windows.Forms.NumericUpDown();
			this.Capo = new System.Windows.Forms.NumericUpDown();
			this.groupActions = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Clear = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.groupAttachments = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.Tablature = new System.Windows.Forms.TextBox();
			this.Midi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupLyrics = new System.Windows.Forms.GroupBox();
			this.Lyrics = new System.Windows.Forms.RichTextBox();
			this.groupChords = new System.Windows.Forms.GroupBox();
			this.Chords = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ChordAdd = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.ChordCount = new System.Windows.Forms.NumericUpDown();
			this.ChordsList = new System.Windows.Forms.ComboBox();
			this.groupGraphics = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.ArtistPicture = new System.Windows.Forms.PictureBox();
			this.Cover = new System.Windows.Forms.PictureBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.groupInfo.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Position)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Duration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Release)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupPlayer.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Bpm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AutoscrollSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AutoscrollDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Capo)).BeginInit();
			this.groupActions.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupAttachments.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.groupLyrics.SuspendLayout();
			this.groupChords.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChordCount)).BeginInit();
			this.groupGraphics.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ArtistPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
			this.SuspendLayout();
			// 
			// groupInfo
			// 
			this.groupInfo.BackColor = System.Drawing.SystemColors.Control;
			this.groupInfo.Controls.Add(this.tableLayoutPanel6);
			this.groupInfo.Controls.Add(this.tableLayoutPanel5);
			this.groupInfo.Controls.Add(this.ListTypeWish);
			this.groupInfo.Controls.Add(this.ListTypeSongs);
			this.groupInfo.Controls.Add(this.tableLayoutPanel1);
			this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupInfo.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupInfo.Location = new System.Drawing.Point(30, 30);
			this.groupInfo.MaximumSize = new System.Drawing.Size(0, 506);
			this.groupInfo.MinimumSize = new System.Drawing.Size(0, 30);
			this.groupInfo.Name = "groupInfo";
			this.groupInfo.Padding = new System.Windows.Forms.Padding(25);
			this.groupInfo.Size = new System.Drawing.Size(618, 30);
			this.groupInfo.TabIndex = 0;
			this.groupInfo.TabStop = false;
			this.groupInfo.Text = "Informacje o piosence";
			this.groupInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBoxDoubleClick);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel6.Controls.Add(this.label16, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.label15, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.TagName, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.TagAdd, 2, 0);
			this.tableLayoutPanel6.Controls.Add(this.TagsList, 1, 1);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(25, 294);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.65517F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.34483F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(568, 163);
			this.tableLayoutPanel6.TabIndex = 3;
			// 
			// label16
			// 
			this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label16.ForeColor = System.Drawing.Color.CadetBlue;
			this.label16.Location = new System.Drawing.Point(5, 53);
			this.label16.Margin = new System.Windows.Forms.Padding(5);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(190, 105);
			this.label16.TabIndex = 13;
			this.label16.Text = "Dostępne tagi";
			// 
			// label15
			// 
			this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label15.ForeColor = System.Drawing.Color.CadetBlue;
			this.label15.Location = new System.Drawing.Point(5, 5);
			this.label15.Margin = new System.Windows.Forms.Padding(5);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(190, 38);
			this.label15.TabIndex = 10;
			this.label15.Text = "Dodaj tag";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TagName
			// 
			this.TagName.Dock = System.Windows.Forms.DockStyle.Top;
			this.TagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TagName.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.TagName.Location = new System.Drawing.Point(203, 10);
			this.TagName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.TagName.Name = "TagName";
			this.TagName.Size = new System.Drawing.Size(322, 26);
			this.TagName.TabIndex = 11;
			// 
			// TagAdd
			// 
			this.TagAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.TagAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TagAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TagAdd.ForeColor = System.Drawing.Color.ForestGreen;
			this.TagAdd.Location = new System.Drawing.Point(533, 10);
			this.TagAdd.Margin = new System.Windows.Forms.Padding(5, 10, 5, 3);
			this.TagAdd.Name = "TagAdd";
			this.TagAdd.Size = new System.Drawing.Size(30, 23);
			this.TagAdd.TabIndex = 12;
			this.TagAdd.Text = "+";
			this.TagAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.TagAdd.UseVisualStyleBackColor = true;
			this.TagAdd.Click += new System.EventHandler(this.TagAddClick);
			// 
			// TagsList
			// 
			this.TagsList.CheckOnClick = true;
			this.tableLayoutPanel6.SetColumnSpan(this.TagsList, 2);
			this.TagsList.ColumnWidth = 200;
			this.TagsList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TagsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TagsList.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.TagsList.FormattingEnabled = true;
			this.TagsList.Location = new System.Drawing.Point(203, 51);
			this.TagsList.MultiColumn = true;
			this.TagsList.Name = "TagsList";
			this.TagsList.Size = new System.Drawing.Size(362, 109);
			this.TagsList.Sorted = true;
			this.TagsList.TabIndex = 14;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 4;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.Position, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.label14, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.label12, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.label11, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.Duration, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.Release, 3, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(25, 210);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(568, 84);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// Position
			// 
			this.Position.Dock = System.Windows.Forms.DockStyle.Top;
			this.Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Position.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Position.Location = new System.Drawing.Point(203, 52);
			this.Position.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Position.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.Position.Name = "Position";
			this.Position.Size = new System.Drawing.Size(78, 26);
			this.Position.TabIndex = 10;
			this.Position.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label14
			// 
			this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label14.ForeColor = System.Drawing.Color.CadetBlue;
			this.label14.Location = new System.Drawing.Point(5, 47);
			this.label14.Margin = new System.Windows.Forms.Padding(5);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(190, 32);
			this.label14.TabIndex = 9;
			this.label14.Text = "Pozycja w albumie";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.ForeColor = System.Drawing.Color.CadetBlue;
			this.label12.Location = new System.Drawing.Point(304, 0);
			this.label12.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(180, 42);
			this.label12.TabIndex = 7;
			this.label12.Text = "Rok wydania";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.ForeColor = System.Drawing.Color.CadetBlue;
			this.label11.Location = new System.Drawing.Point(5, 5);
			this.label11.Margin = new System.Windows.Forms.Padding(5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(190, 32);
			this.label11.TabIndex = 5;
			this.label11.Text = "Długość (sekundy)";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Duration
			// 
			this.Duration.Dock = System.Windows.Forms.DockStyle.Top;
			this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Duration.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Duration.Location = new System.Drawing.Point(203, 10);
			this.Duration.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Duration.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.Duration.Name = "Duration";
			this.Duration.Size = new System.Drawing.Size(78, 26);
			this.Duration.TabIndex = 6;
			this.Duration.Value = new decimal(new int[] {
									180,
									0,
									0,
									0});
			// 
			// Release
			// 
			this.Release.Dock = System.Windows.Forms.DockStyle.Top;
			this.Release.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Release.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Release.Location = new System.Drawing.Point(487, 10);
			this.Release.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Release.Maximum = new decimal(new int[] {
									3000,
									0,
									0,
									0});
			this.Release.Minimum = new decimal(new int[] {
									1410,
									0,
									0,
									0});
			this.Release.Name = "Release";
			this.Release.Size = new System.Drawing.Size(78, 26);
			this.Release.TabIndex = 8;
			this.Release.Value = new decimal(new int[] {
									2000,
									0,
									0,
									0});
			// 
			// ListTypeWish
			// 
			this.ListTypeWish.Appearance = System.Windows.Forms.Appearance.Button;
			this.ListTypeWish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ListTypeWish.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ListTypeWish.Checked = true;
			this.ListTypeWish.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ListTypeWish.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.ListTypeWish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.ListTypeWish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.ListTypeWish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ListTypeWish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ListTypeWish.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.ListTypeWish.Location = new System.Drawing.Point(146, 470);
			this.ListTypeWish.Name = "ListTypeWish";
			this.ListTypeWish.Size = new System.Drawing.Size(120, 30);
			this.ListTypeWish.TabIndex = 1;
			this.ListTypeWish.TabStop = true;
			this.ListTypeWish.Text = "Uczę się";
			this.ListTypeWish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ListTypeWish.UseVisualStyleBackColor = false;
			// 
			// ListTypeSongs
			// 
			this.ListTypeSongs.Appearance = System.Windows.Forms.Appearance.Button;
			this.ListTypeSongs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ListTypeSongs.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ListTypeSongs.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ListTypeSongs.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.ListTypeSongs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
			this.ListTypeSongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.ListTypeSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ListTypeSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ListTypeSongs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.ListTypeSongs.Location = new System.Drawing.Point(30, 470);
			this.ListTypeSongs.Name = "ListTypeSongs";
			this.ListTypeSongs.Size = new System.Drawing.Size(120, 30);
			this.ListTypeSongs.TabIndex = 1;
			this.ListTypeSongs.Text = "Umiem";
			this.ListTypeSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ListTypeSongs.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.SongLink, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.SongAlbum, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.SongArtist, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SongTitle, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 40);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 170);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label13.ForeColor = System.Drawing.Color.CadetBlue;
			this.label13.Location = new System.Drawing.Point(5, 134);
			this.label13.Margin = new System.Windows.Forms.Padding(5);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(190, 31);
			this.label13.TabIndex = 6;
			this.label13.Text = "Link do last.fm";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SongLink
			// 
			this.SongLink.Dock = System.Windows.Forms.DockStyle.Top;
			this.SongLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SongLink.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.SongLink.Location = new System.Drawing.Point(200, 139);
			this.SongLink.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.SongLink.Name = "SongLink";
			this.SongLink.Size = new System.Drawing.Size(368, 26);
			this.SongLink.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.CadetBlue;
			this.label3.Location = new System.Drawing.Point(5, 92);
			this.label3.Margin = new System.Windows.Forms.Padding(5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Album";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SongAlbum
			// 
			this.SongAlbum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.SongAlbum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.SongAlbum.Dock = System.Windows.Forms.DockStyle.Top;
			this.SongAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SongAlbum.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.SongAlbum.Location = new System.Drawing.Point(200, 97);
			this.SongAlbum.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.SongAlbum.Name = "SongAlbum";
			this.SongAlbum.Size = new System.Drawing.Size(368, 26);
			this.SongAlbum.TabIndex = 5;
			this.SongAlbum.Enter += new System.EventHandler(this.SongAlbumEnter);
			this.SongAlbum.Leave += new System.EventHandler(this.MatchCover);
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.CadetBlue;
			this.label2.Location = new System.Drawing.Point(5, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 33);
			this.label2.TabIndex = 2;
			this.label2.Text = "Wykonawca";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SongArtist
			// 
			this.SongArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.SongArtist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.SongArtist.Dock = System.Windows.Forms.DockStyle.Top;
			this.SongArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SongArtist.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.SongArtist.Location = new System.Drawing.Point(200, 54);
			this.SongArtist.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.SongArtist.Name = "SongArtist";
			this.SongArtist.Size = new System.Drawing.Size(368, 26);
			this.SongArtist.TabIndex = 3;
			this.SongArtist.Text = "Led Zeppelin";
			this.SongArtist.Leave += new System.EventHandler(this.MatchArtistPicture);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.CadetBlue;
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tytuł piosenki";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SongTitle
			// 
			this.SongTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.SongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SongTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.SongTitle.Location = new System.Drawing.Point(200, 10);
			this.SongTitle.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.SongTitle.Name = "SongTitle";
			this.SongTitle.Size = new System.Drawing.Size(368, 26);
			this.SongTitle.TabIndex = 1;
			this.SongTitle.Text = "Stairway to heaven";
			// 
			// groupPlayer
			// 
			this.groupPlayer.Controls.Add(this.tableLayoutPanel3);
			this.groupPlayer.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupPlayer.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupPlayer.Location = new System.Drawing.Point(30, 90);
			this.groupPlayer.MaximumSize = new System.Drawing.Size(0, 195);
			this.groupPlayer.MinimumSize = new System.Drawing.Size(0, 30);
			this.groupPlayer.Name = "groupPlayer";
			this.groupPlayer.Padding = new System.Windows.Forms.Padding(20);
			this.groupPlayer.Size = new System.Drawing.Size(618, 30);
			this.groupPlayer.TabIndex = 1;
			this.groupPlayer.TabStop = false;
			this.groupPlayer.Text = "Odtwarzanie";
			this.groupPlayer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBoxDoubleClick);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label9, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.Bpm, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.Metrum, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.AutoscrollSpeed, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.AutoscrollDelay, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.Capo, 1, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 35);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.42529F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.57471F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 0);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.CadetBlue;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 1);
			this.label4.TabIndex = 0;
			this.label4.Text = "BPM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.Color.CadetBlue;
			this.label5.Location = new System.Drawing.Point(309, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(180, 1);
			this.label5.TabIndex = 1;
			this.label5.Text = "Metrum";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.ForeColor = System.Drawing.Color.CadetBlue;
			this.label8.Location = new System.Drawing.Point(3, -22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(194, 1);
			this.label8.TabIndex = 2;
			this.label8.Text = "Szybkość przewijania";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.ForeColor = System.Drawing.Color.CadetBlue;
			this.label9.Location = new System.Drawing.Point(309, -22);
			this.label9.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(177, 1);
			this.label9.TabIndex = 3;
			this.label9.Text = "Opóźnienie";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.ForeColor = System.Drawing.Color.CadetBlue;
			this.label10.Location = new System.Drawing.Point(3, -44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(194, 46);
			this.label10.TabIndex = 4;
			this.label10.Text = "Kapo";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Bpm
			// 
			this.Bpm.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Bpm.Dock = System.Windows.Forms.DockStyle.Top;
			this.Bpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Bpm.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Bpm.Location = new System.Drawing.Point(203, 10);
			this.Bpm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Bpm.Maximum = new decimal(new int[] {
									300,
									0,
									0,
									0});
			this.Bpm.Name = "Bpm";
			this.Bpm.Size = new System.Drawing.Size(83, 22);
			this.Bpm.TabIndex = 5;
			this.Bpm.Value = new decimal(new int[] {
									120,
									0,
									0,
									0});
			// 
			// Metrum
			// 
			this.Metrum.Dock = System.Windows.Forms.DockStyle.Top;
			this.Metrum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Metrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Metrum.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Metrum.FormattingEnabled = true;
			this.Metrum.Items.AddRange(new object[] {
									"1/1",
									"1/2",
									"1/4",
									"1/8",
									"2/2",
									"2/4",
									"2/8",
									"3/4",
									"3/8",
									"4/4",
									"4/8",
									"5/8",
									"6/8",
									"7/8",
									"8/8"});
			this.Metrum.Location = new System.Drawing.Point(492, 10);
			this.Metrum.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Metrum.Name = "Metrum";
			this.Metrum.Size = new System.Drawing.Size(83, 28);
			this.Metrum.Sorted = true;
			this.Metrum.TabIndex = 6;
			this.Metrum.Text = "4/4";
			// 
			// AutoscrollSpeed
			// 
			this.AutoscrollSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AutoscrollSpeed.Dock = System.Windows.Forms.DockStyle.Top;
			this.AutoscrollSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AutoscrollSpeed.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.AutoscrollSpeed.Location = new System.Drawing.Point(203, -12);
			this.AutoscrollSpeed.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.AutoscrollSpeed.Name = "AutoscrollSpeed";
			this.AutoscrollSpeed.Size = new System.Drawing.Size(83, 22);
			this.AutoscrollSpeed.TabIndex = 7;
			this.AutoscrollSpeed.Value = new decimal(new int[] {
									4,
									0,
									0,
									0});
			// 
			// AutoscrollDelay
			// 
			this.AutoscrollDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AutoscrollDelay.Dock = System.Windows.Forms.DockStyle.Top;
			this.AutoscrollDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AutoscrollDelay.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.AutoscrollDelay.Location = new System.Drawing.Point(492, -12);
			this.AutoscrollDelay.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.AutoscrollDelay.Maximum = new decimal(new int[] {
									100000,
									0,
									0,
									0});
			this.AutoscrollDelay.Name = "AutoscrollDelay";
			this.AutoscrollDelay.Size = new System.Drawing.Size(83, 22);
			this.AutoscrollDelay.TabIndex = 8;
			// 
			// Capo
			// 
			this.Capo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Capo.Dock = System.Windows.Forms.DockStyle.Top;
			this.Capo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Capo.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Capo.Location = new System.Drawing.Point(203, -34);
			this.Capo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Capo.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.Capo.Name = "Capo";
			this.Capo.Size = new System.Drawing.Size(83, 22);
			this.Capo.TabIndex = 9;
			// 
			// groupActions
			// 
			this.groupActions.Controls.Add(this.tableLayoutPanel2);
			this.groupActions.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupActions.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupActions.Location = new System.Drawing.Point(30, 210);
			this.groupActions.Name = "groupActions";
			this.groupActions.Padding = new System.Windows.Forms.Padding(10);
			this.groupActions.Size = new System.Drawing.Size(618, 71);
			this.groupActions.TabIndex = 3;
			this.groupActions.TabStop = false;
			this.groupActions.Text = "Akcje";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.Clear, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.Cancel, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.Add, 0, 0);
			this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 25);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 36);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// Clear
			// 
			this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Clear.Dock = System.Windows.Forms.DockStyle.Left;
			this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Clear.ForeColor = System.Drawing.Color.DarkBlue;
			this.Clear.Location = new System.Drawing.Point(223, 3);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(101, 30);
			this.Clear.TabIndex = 2;
			this.Clear.Text = "Wyczyść";
			this.Clear.UseVisualStyleBackColor = false;
			this.Clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cancel.Dock = System.Windows.Forms.DockStyle.Left;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.ForeColor = System.Drawing.Color.IndianRed;
			this.Cancel.Location = new System.Drawing.Point(113, 3);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(100, 30);
			this.Cancel.TabIndex = 1;
			this.Cancel.Text = "Anuluj";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Add.Dock = System.Windows.Forms.DockStyle.Left;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.ForeColor = System.Drawing.Color.ForestGreen;
			this.Add.Location = new System.Drawing.Point(3, 3);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(100, 30);
			this.Add.TabIndex = 0;
			this.Add.Text = "Dodaj";
			this.Add.UseVisualStyleBackColor = false;
			this.Add.Click += new System.EventHandler(this.AddClick);
			// 
			// groupAttachments
			// 
			this.groupAttachments.Controls.Add(this.tableLayoutPanel4);
			this.groupAttachments.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupAttachments.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupAttachments.Location = new System.Drawing.Point(30, 120);
			this.groupAttachments.MaximumSize = new System.Drawing.Size(0, 150);
			this.groupAttachments.MinimumSize = new System.Drawing.Size(0, 30);
			this.groupAttachments.Name = "groupAttachments";
			this.groupAttachments.Padding = new System.Windows.Forms.Padding(20);
			this.groupAttachments.Size = new System.Drawing.Size(618, 30);
			this.groupAttachments.TabIndex = 2;
			this.groupAttachments.TabStop = false;
			this.groupAttachments.Text = "Załączniki";
			this.groupAttachments.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBoxDoubleClick);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.Tablature, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.Midi, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 35);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(578, 0);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.ForeColor = System.Drawing.Color.CadetBlue;
			this.label7.Location = new System.Drawing.Point(5, 5);
			this.label7.Margin = new System.Windows.Forms.Padding(5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(190, 1);
			this.label7.TabIndex = 12;
			this.label7.Text = "Tabulatura";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Tablature
			// 
			this.Tablature.Dock = System.Windows.Forms.DockStyle.Top;
			this.Tablature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Tablature.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Tablature.Location = new System.Drawing.Point(203, 10);
			this.Tablature.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Tablature.Name = "Tablature";
			this.Tablature.ReadOnly = true;
			this.Tablature.Size = new System.Drawing.Size(372, 26);
			this.Tablature.TabIndex = 11;
			this.Tablature.Text = "Kliknij tutai dwukrotnie LPM";
			this.Tablature.DoubleClick += new System.EventHandler(this.TablatureDoubleClick);
			// 
			// Midi
			// 
			this.Midi.Dock = System.Windows.Forms.DockStyle.Top;
			this.Midi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Midi.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Midi.Location = new System.Drawing.Point(203, 10);
			this.Midi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.Midi.Name = "Midi";
			this.Midi.ReadOnly = true;
			this.Midi.Size = new System.Drawing.Size(372, 26);
			this.Midi.TabIndex = 13;
			this.Midi.Text = "Kliknij tutaj dwukrotnie LPM";
			this.Midi.DoubleClick += new System.EventHandler(this.MidiDoubleClick);
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.CadetBlue;
			this.label6.Location = new System.Drawing.Point(5, 5);
			this.label6.Margin = new System.Windows.Forms.Padding(5);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(190, 1);
			this.label6.TabIndex = 8;
			this.label6.Text = "Plik MIDI";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(600, 10);
			this.button2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(29, 100);
			this.button2.TabIndex = 7;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// groupLyrics
			// 
			this.groupLyrics.Controls.Add(this.Lyrics);
			this.groupLyrics.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupLyrics.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupLyrics.Location = new System.Drawing.Point(30, 150);
			this.groupLyrics.MaximumSize = new System.Drawing.Size(0, 410);
			this.groupLyrics.MinimumSize = new System.Drawing.Size(0, 30);
			this.groupLyrics.Name = "groupLyrics";
			this.groupLyrics.Padding = new System.Windows.Forms.Padding(10);
			this.groupLyrics.Size = new System.Drawing.Size(618, 30);
			this.groupLyrics.TabIndex = 4;
			this.groupLyrics.TabStop = false;
			this.groupLyrics.Text = "Tekst";
			this.groupLyrics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBoxDoubleClick);
			// 
			// Lyrics
			// 
			this.Lyrics.AcceptsTab = true;
			this.Lyrics.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Lyrics.DetectUrls = false;
			this.Lyrics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Lyrics.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Lyrics.Location = new System.Drawing.Point(10, 25);
			this.Lyrics.Name = "Lyrics";
			this.Lyrics.Size = new System.Drawing.Size(598, 0);
			this.Lyrics.TabIndex = 0;
			this.Lyrics.Text = "";
			// 
			// groupChords
			// 
			this.groupChords.Controls.Add(this.Chords);
			this.groupChords.Controls.Add(this.panel1);
			this.groupChords.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupChords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupChords.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupChords.Location = new System.Drawing.Point(30, 180);
			this.groupChords.MaximumSize = new System.Drawing.Size(0, 410);
			this.groupChords.MinimumSize = new System.Drawing.Size(0, 30);
			this.groupChords.Name = "groupChords";
			this.groupChords.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
			this.groupChords.Size = new System.Drawing.Size(618, 30);
			this.groupChords.TabIndex = 5;
			this.groupChords.TabStop = false;
			this.groupChords.Text = "Chwyty";
			this.groupChords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBoxDoubleClick);
			// 
			// Chords
			// 
			this.Chords.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Chords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Chords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Chords.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Chords.Location = new System.Drawing.Point(10, 61);
			this.Chords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.Chords.Name = "Chords";
			this.Chords.Size = new System.Drawing.Size(598, 0);
			this.Chords.TabIndex = 5;
			this.Chords.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ChordAdd);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.ChordCount);
			this.panel1.Controls.Add(this.ChordsList);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 30);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(598, 31);
			this.panel1.TabIndex = 4;
			// 
			// ChordAdd
			// 
			this.ChordAdd.ForeColor = System.Drawing.Color.DarkGreen;
			this.ChordAdd.Location = new System.Drawing.Point(297, 3);
			this.ChordAdd.Name = "ChordAdd";
			this.ChordAdd.Size = new System.Drawing.Size(75, 23);
			this.ChordAdd.TabIndex = 5;
			this.ChordAdd.Text = "Dodaj";
			this.ChordAdd.UseVisualStyleBackColor = true;
			this.ChordAdd.Click += new System.EventHandler(this.ChordAddClick);
			// 
			// label18
			// 
			this.label18.ForeColor = System.Drawing.Color.DarkGreen;
			this.label18.Location = new System.Drawing.Point(248, 6);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(43, 23);
			this.label18.TabIndex = 4;
			this.label18.Text = "razy";
			// 
			// label17
			// 
			this.label17.ForeColor = System.Drawing.Color.DarkGreen;
			this.label17.Location = new System.Drawing.Point(10, 6);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(52, 18);
			this.label17.TabIndex = 0;
			this.label17.Text = "Akord";
			// 
			// ChordCount
			// 
			this.ChordCount.Location = new System.Drawing.Point(195, 4);
			this.ChordCount.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.ChordCount.Name = "ChordCount";
			this.ChordCount.Size = new System.Drawing.Size(47, 22);
			this.ChordCount.TabIndex = 3;
			this.ChordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ChordCount.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// ChordsList
			// 
			this.ChordsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChordsList.FormattingEnabled = true;
			this.ChordsList.Location = new System.Drawing.Point(68, 3);
			this.ChordsList.Name = "ChordsList";
			this.ChordsList.Size = new System.Drawing.Size(121, 24);
			this.ChordsList.TabIndex = 2;
			// 
			// groupGraphics
			// 
			this.groupGraphics.Controls.Add(this.tableLayoutPanel7);
			this.groupGraphics.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupGraphics.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupGraphics.Location = new System.Drawing.Point(30, 60);
			this.groupGraphics.MaximumSize = new System.Drawing.Size(0, 330);
			this.groupGraphics.MinimumSize = new System.Drawing.Size(0, 30);
			this.groupGraphics.Name = "groupGraphics";
			this.groupGraphics.Padding = new System.Windows.Forms.Padding(10);
			this.groupGraphics.Size = new System.Drawing.Size(618, 30);
			this.groupGraphics.TabIndex = 4;
			this.groupGraphics.TabStop = false;
			this.groupGraphics.Text = "Grafika";
			this.groupGraphics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBoxDoubleClick);
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.Controls.Add(this.ArtistPicture, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.Cover, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.label19, 0, 1);
			this.tableLayoutPanel7.Controls.Add(this.label20, 1, 1);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(10, 25);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 2;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.44068F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.55932F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(598, 0);
			this.tableLayoutPanel7.TabIndex = 0;
			// 
			// ArtistPicture
			// 
			this.ArtistPicture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ArtistPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ArtistPicture.Image = ((System.Drawing.Image)(resources.GetObject("ArtistPicture.Image")));
			this.ArtistPicture.Location = new System.Drawing.Point(302, 4);
			this.ArtistPicture.Name = "ArtistPicture";
			this.ArtistPicture.Size = new System.Drawing.Size(292, 1);
			this.ArtistPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ArtistPicture.TabIndex = 3;
			this.ArtistPicture.TabStop = false;
			this.ArtistPicture.Click += new System.EventHandler(this.PictureClick);
			// 
			// Cover
			// 
			this.Cover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cover.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cover.Image = ((System.Drawing.Image)(resources.GetObject("Cover.Image")));
			this.Cover.Location = new System.Drawing.Point(4, 4);
			this.Cover.Name = "Cover";
			this.Cover.Size = new System.Drawing.Size(291, 1);
			this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Cover.TabIndex = 0;
			this.Cover.TabStop = false;
			this.Cover.Click += new System.EventHandler(this.PictureClick);
			// 
			// label19
			// 
			this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label19.Location = new System.Drawing.Point(4, 2);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(291, 1);
			this.label19.TabIndex = 1;
			this.label19.Text = "Okładka albumu";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label20.Location = new System.Drawing.Point(302, 2);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(292, 1);
			this.label20.TabIndex = 2;
			this.label20.Text = "Grafika zespołu";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NewSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(678, 733);
			this.Controls.Add(this.groupActions);
			this.Controls.Add(this.groupChords);
			this.Controls.Add(this.groupLyrics);
			this.Controls.Add(this.groupAttachments);
			this.Controls.Add(this.groupPlayer);
			this.Controls.Add(this.groupGraphics);
			this.Controls.Add(this.groupInfo);
			this.Name = "NewSongForm";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "Dodaj piosenkę";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewSongFormFormClosed);
			this.groupInfo.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Position)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Duration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Release)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupPlayer.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Bpm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AutoscrollSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AutoscrollDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Capo)).EndInit();
			this.groupActions.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupAttachments.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.groupLyrics.ResumeLayout(false);
			this.groupChords.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ChordCount)).EndInit();
			this.groupGraphics.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ArtistPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.PictureBox ArtistPicture;
		private System.Windows.Forms.PictureBox Cover;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.GroupBox groupGraphics;
		private System.Windows.Forms.Button ChordAdd;
		private System.Windows.Forms.ComboBox ChordsList;
		private System.Windows.Forms.NumericUpDown ChordCount;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox Chords;
		private System.Windows.Forms.GroupBox groupChords;
		private System.Windows.Forms.RichTextBox Lyrics;
		private System.Windows.Forms.GroupBox groupLyrics;
		private System.Windows.Forms.TextBox Midi;
		private System.Windows.Forms.TextBox Tablature;
		private System.Windows.Forms.CheckedListBox TagsList;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button TagAdd;
		private System.Windows.Forms.TextBox TagName;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.TextBox SongLink;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown Release;
		private System.Windows.Forms.NumericUpDown Duration;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown Position;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.GroupBox groupAttachments;
		private System.Windows.Forms.NumericUpDown Capo;
		private System.Windows.Forms.NumericUpDown AutoscrollDelay;
		private System.Windows.Forms.NumericUpDown AutoscrollSpeed;
		private System.Windows.Forms.ComboBox Metrum;
		private System.Windows.Forms.NumericUpDown Bpm;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton ListTypeSongs;
		private System.Windows.Forms.RadioButton ListTypeWish;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.GroupBox groupActions;
		private System.Windows.Forms.TextBox SongArtist;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SongAlbum;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox SongTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupPlayer;
		private System.Windows.Forms.GroupBox groupInfo;
	}
}
