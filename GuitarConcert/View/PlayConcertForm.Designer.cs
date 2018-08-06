/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-11-29
 * Time: 16:32
 * 
 */
namespace GuitarConcert
{
	partial class PlayConcertForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer6;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripPlay;
		private System.Windows.Forms.PictureBox chordDiagramPicture;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox detailsList;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ListBox chordsListBox;
		private System.Windows.Forms.ToolStripButton toolStripStop;
		private System.Windows.Forms.ToolStripButton toolStripPause;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton toolStripBack;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private RichTextBoxLinks.RichTextBoxEx lyricsBox;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayConcertForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.detailsList = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripBack = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripPlay = new System.Windows.Forms.ToolStripButton();
			this.toolStripPause = new System.Windows.Forms.ToolStripButton();
			this.toolStripStop = new System.Windows.Forms.ToolStripButton();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer6 = new System.Windows.Forms.SplitContainer();
			this.lyricsBox = new RichTextBoxLinks.RichTextBoxEx();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.alphaTabControl1 = new AlphaTab.Platform.CSharp.WinForms.AlphaTabControl();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.chordDiagramPicture = new System.Windows.Forms.PictureBox();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.chordsListBox = new System.Windows.Forms.ListBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
			this.splitContainer6.Panel1.SuspendLayout();
			this.splitContainer6.Panel2.SuspendLayout();
			this.splitContainer6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chordDiagramPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(810, 592);
			this.splitContainer1.SplitterDistance = 242;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.detailsList);
			this.splitContainer3.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.toolStrip2);
			this.splitContainer3.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer3.Size = new System.Drawing.Size(242, 592);
			this.splitContainer3.SplitterDistance = 387;
			this.splitContainer3.TabIndex = 0;
			// 
			// detailsList
			// 
			this.detailsList.BackColor = System.Drawing.SystemColors.Control;
			this.detailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.detailsList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailsList.Enabled = false;
			this.detailsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.detailsList.FormattingEnabled = true;
			this.detailsList.Location = new System.Drawing.Point(0, 225);
			this.detailsList.Name = "detailsList";
			this.detailsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.detailsList.Size = new System.Drawing.Size(242, 162);
			this.detailsList.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.ImageLocation = "assets/covers/unknown.jpg";
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(242, 225);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(36, 36);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripBack});
			this.toolStrip2.Location = new System.Drawing.Point(0, 39);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(242, 43);
			this.toolStrip2.TabIndex = 1;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripBack
			// 
			this.toolStripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBack.Image")));
			this.toolStripBack.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBack.Name = "toolStripBack";
			this.toolStripBack.Size = new System.Drawing.Size(40, 40);
			this.toolStripBack.Text = "Wstecz";
			this.toolStripBack.Click += new System.EventHandler(this.ToolStripBackClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripPlay,
									this.toolStripPause,
									this.toolStripStop});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(242, 39);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripPlay
			// 
			this.toolStripPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPlay.Image")));
			this.toolStripPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPlay.Name = "toolStripPlay";
			this.toolStripPlay.Size = new System.Drawing.Size(36, 36);
			this.toolStripPlay.Text = "Play";
			this.toolStripPlay.Click += new System.EventHandler(this.ToolStripPlayClick);
			// 
			// toolStripPause
			// 
			this.toolStripPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPause.Image")));
			this.toolStripPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPause.Name = "toolStripPause";
			this.toolStripPause.Size = new System.Drawing.Size(36, 36);
			this.toolStripPause.Text = "Pauza";
			// 
			// toolStripStop
			// 
			this.toolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStop.Image")));
			this.toolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripStop.Name = "toolStripStop";
			this.toolStripStop.Size = new System.Drawing.Size(36, 36);
			this.toolStripStop.Text = "Stop";
			this.toolStripStop.Click += new System.EventHandler(this.ToolStripStopClick);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer6);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer2.Size = new System.Drawing.Size(564, 592);
			this.splitContainer2.SplitterDistance = 338;
			this.splitContainer2.TabIndex = 0;
			// 
			// splitContainer6
			// 
			this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer6.Location = new System.Drawing.Point(0, 0);
			this.splitContainer6.Name = "splitContainer6";
			this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer6.Panel1
			// 
			this.splitContainer6.Panel1.Controls.Add(this.lyricsBox);
			this.splitContainer6.Panel1.Controls.Add(this.vScrollBar1);
			// 
			// splitContainer6.Panel2
			// 
			this.splitContainer6.Panel2.Controls.Add(this.alphaTabControl1);
			this.splitContainer6.Size = new System.Drawing.Size(338, 592);
			this.splitContainer6.SplitterDistance = 388;
			this.splitContainer6.TabIndex = 0;
			// 
			// lyricsBox
			// 
			this.lyricsBox.DetectUrls = true;
			this.lyricsBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lyricsBox.Location = new System.Drawing.Point(0, 0);
			this.lyricsBox.Name = "lyricsBox";
			this.lyricsBox.ReadOnly = true;
			this.lyricsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.lyricsBox.Size = new System.Drawing.Size(321, 388);
			this.lyricsBox.TabIndex = 2;
			this.lyricsBox.Text = "";
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(321, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 388);
			this.vScrollBar1.TabIndex = 1;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1Scroll);
			this.vScrollBar1.ValueChanged += new System.EventHandler(this.VScrollBar1ValueChanged);
			// 
			// alphaTabControl1
			// 
			this.alphaTabControl1.AutoScroll = true;
			this.alphaTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(99)))), ((int)(((byte)(98)))));
			this.alphaTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alphaTabControl1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.alphaTabControl1.Location = new System.Drawing.Point(0, 0);
			this.alphaTabControl1.Name = "alphaTabControl1";
			this.alphaTabControl1.Padding = new System.Windows.Forms.Padding(10);
			this.alphaTabControl1.Size = new System.Drawing.Size(338, 200);
			this.alphaTabControl1.StavesMode = "default";
			this.alphaTabControl1.TabIndex = 0;
			this.alphaTabControl1.Text = "alphaTabControl1";
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.chordDiagramPicture);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
			this.splitContainer4.Size = new System.Drawing.Size(222, 592);
			this.splitContainer4.SplitterDistance = 183;
			this.splitContainer4.TabIndex = 0;
			// 
			// chordDiagramPicture
			// 
			this.chordDiagramPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chordDiagramPicture.Location = new System.Drawing.Point(0, 0);
			this.chordDiagramPicture.Name = "chordDiagramPicture";
			this.chordDiagramPicture.Size = new System.Drawing.Size(222, 183);
			this.chordDiagramPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.chordDiagramPicture.TabIndex = 0;
			this.chordDiagramPicture.TabStop = false;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.chordsListBox);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.checkedListBox1);
			this.splitContainer5.Size = new System.Drawing.Size(222, 405);
			this.splitContainer5.SplitterDistance = 199;
			this.splitContainer5.TabIndex = 0;
			// 
			// chordsListBox
			// 
			this.chordsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chordsListBox.FormattingEnabled = true;
			this.chordsListBox.ItemHeight = 39;
			this.chordsListBox.Location = new System.Drawing.Point(0, 0);
			this.chordsListBox.Name = "chordsListBox";
			this.chordsListBox.Size = new System.Drawing.Size(222, 199);
			this.chordsListBox.TabIndex = 0;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(222, 202);
			this.checkedListBox1.TabIndex = 0;
			// 
			// PlayConcertForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 592);
			this.Controls.Add(this.splitContainer1);
			this.Name = "PlayConcertForm";
			this.Text = "PlayConcertForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer6.Panel1.ResumeLayout(false);
			this.splitContainer6.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
			this.splitContainer6.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chordDiagramPicture)).EndInit();
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private AlphaTab.Platform.CSharp.WinForms.AlphaTabControl alphaTabControl1;
	}
}