/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-30
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GuitarConcert
{
	partial class SettingsForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.tabShortcuts = new System.Windows.Forms.TabPage();
			this.tabSchemas = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Controls.Add(this.tabShortcuts);
			this.tabControl1.Controls.Add(this.tabSchemas);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(691, 375);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 0;
			// 
			// tabGeneral
			// 
			this.tabGeneral.BackColor = System.Drawing.Color.Transparent;
			this.tabGeneral.Location = new System.Drawing.Point(4, 29);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(683, 342);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "Ogólne";
			// 
			// tabShortcuts
			// 
			this.tabShortcuts.BackColor = System.Drawing.SystemColors.Control;
			this.tabShortcuts.Location = new System.Drawing.Point(4, 29);
			this.tabShortcuts.Name = "tabShortcuts";
			this.tabShortcuts.Size = new System.Drawing.Size(502, 261);
			this.tabShortcuts.TabIndex = 1;
			this.tabShortcuts.Text = "Skróty klawiaturowe";
			// 
			// tabSchemas
			// 
			this.tabSchemas.BackColor = System.Drawing.SystemColors.Control;
			this.tabSchemas.Location = new System.Drawing.Point(4, 29);
			this.tabSchemas.Name = "tabSchemas";
			this.tabSchemas.Size = new System.Drawing.Size(502, 261);
			this.tabSchemas.TabIndex = 2;
			this.tabSchemas.Text = "Style";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(691, 375);
			this.Controls.Add(this.tabControl1);
			this.Name = "SettingsForm";
			this.Text = "Ustawienia";
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TabPage tabSchemas;
		private System.Windows.Forms.TabPage tabShortcuts;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
