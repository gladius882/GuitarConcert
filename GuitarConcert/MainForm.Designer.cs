/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-26
 * Time: 06:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GuitarConcert
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.SongsView = new System.Windows.Forms.ToolStripButton();
			this.TagsView = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.SettingsView = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(845, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.SongsView,
									this.TagsView,
									this.toolStripSeparator1,
									this.SettingsView});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(845, 39);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// SongsView
			// 
			this.SongsView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SongsView.Image = ((System.Drawing.Image)(resources.GetObject("SongsView.Image")));
			this.SongsView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SongsView.Name = "SongsView";
			this.SongsView.Size = new System.Drawing.Size(36, 36);
			this.SongsView.Text = "Lista piosenek";
			this.SongsView.Click += new System.EventHandler(this.SongsViewClick);
			// 
			// TagsView
			// 
			this.TagsView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TagsView.Image = ((System.Drawing.Image)(resources.GetObject("TagsView.Image")));
			this.TagsView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TagsView.Name = "TagsView";
			this.TagsView.Size = new System.Drawing.Size(36, 36);
			this.TagsView.Text = "Zarządzaj tagami";
			this.TagsView.Click += new System.EventHandler(this.TagsViewClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// SettingsView
			// 
			this.SettingsView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SettingsView.Image = ((System.Drawing.Image)(resources.GetObject("SettingsView.Image")));
			this.SettingsView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SettingsView.Name = "SettingsView";
			this.SettingsView.Size = new System.Drawing.Size(36, 36);
			this.SettingsView.Text = "Ustawienia";
			this.SettingsView.Click += new System.EventHandler(this.SettingsViewClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(845, 256);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GuitarConcert";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton SettingsView;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton SongsView;
		private System.Windows.Forms.ToolStripButton TagsView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
