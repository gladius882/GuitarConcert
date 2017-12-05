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
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.widokToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ustawieniaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.informacjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.plikToolStripMenuItem,
			this.widokToolStripMenuItem1,
			this.ustawieniaToolStripMenuItem1,
			this.informacjeToolStripMenuItem1});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(845, 24);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// plikToolStripMenuItem
			// 
			this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
			this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.plikToolStripMenuItem.Text = "Plik";
			// 
			// widokToolStripMenuItem1
			// 
			this.widokToolStripMenuItem1.Name = "widokToolStripMenuItem1";
			this.widokToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
			this.widokToolStripMenuItem1.Text = "Widok";
			// 
			// ustawieniaToolStripMenuItem1
			// 
			this.ustawieniaToolStripMenuItem1.Name = "ustawieniaToolStripMenuItem1";
			this.ustawieniaToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
			this.ustawieniaToolStripMenuItem1.Text = "Ustawienia";
			// 
			// informacjeToolStripMenuItem1
			// 
			this.informacjeToolStripMenuItem1.Name = "informacjeToolStripMenuItem1";
			this.informacjeToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
			this.informacjeToolStripMenuItem1.Text = "Informacje";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(845, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 256);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GuitarConcert";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
