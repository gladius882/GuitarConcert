/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-07
 * Time: 12:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GuitarConcert
{
	partial class Dialog
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
			this.Container = new System.Windows.Forms.Panel();
			this.Body = new System.Windows.Forms.Panel();
			this.Footer = new System.Windows.Forms.Panel();
			this.Header = new System.Windows.Forms.Panel();
			this.Title = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.Add = new System.Windows.Forms.Button();
			this.Container.SuspendLayout();
			this.Footer.SuspendLayout();
			this.Header.SuspendLayout();
			this.SuspendLayout();
			// 
			// Container
			// 
			this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Container.Controls.Add(this.Body);
			this.Container.Controls.Add(this.Footer);
			this.Container.Controls.Add(this.Header);
			this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container.Location = new System.Drawing.Point(0, 0);
			this.Container.Name = "Container";
			this.Container.Size = new System.Drawing.Size(590, 210);
			this.Container.TabIndex = 0;
			// 
			// Body
			// 
			this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Body.Location = new System.Drawing.Point(0, 25);
			this.Body.Name = "Body";
			this.Body.Size = new System.Drawing.Size(588, 144);
			this.Body.TabIndex = 4;
			// 
			// Footer
			// 
			this.Footer.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Footer.Controls.Add(this.Add);
			this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Footer.Location = new System.Drawing.Point(0, 169);
			this.Footer.Name = "Footer";
			this.Footer.Size = new System.Drawing.Size(588, 39);
			this.Footer.TabIndex = 2;
			// 
			// Header
			// 
			this.Header.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Header.Controls.Add(this.Title);
			this.Header.Controls.Add(this.buttonClose);
			this.Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Header.Location = new System.Drawing.Point(0, 0);
			this.Header.Margin = new System.Windows.Forms.Padding(0);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(588, 25);
			this.Header.TabIndex = 1;
			// 
			// Title
			// 
			this.Title.Dock = System.Windows.Forms.DockStyle.Left;
			this.Title.Location = new System.Drawing.Point(0, 0);
			this.Title.Margin = new System.Windows.Forms.Padding(3);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(363, 25);
			this.Title.TabIndex = 1;
			this.Title.Text = "DialogTitle";
			// 
			// buttonClose
			// 
			this.buttonClose.AutoEllipsis = true;
			this.buttonClose.BackColor = System.Drawing.Color.Salmon;
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonClose.ForeColor = System.Drawing.Color.White;
			this.buttonClose.Location = new System.Drawing.Point(559, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(29, 25);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "X";
			this.buttonClose.UseVisualStyleBackColor = false;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Add.ForeColor = System.Drawing.Color.ForestGreen;
			this.Add.Location = new System.Drawing.Point(11, 6);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(87, 24);
			this.Add.TabIndex = 1;
			this.Add.Text = "OK";
			this.Add.UseVisualStyleBackColor = false;
			// 
			// Dialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 210);
			this.Controls.Add(this.Container);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "Dialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dialog";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DialogKeyDown);
			this.Container.ResumeLayout(false);
			this.Footer.ResumeLayout(false);
			this.Header.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Add;
		public System.Windows.Forms.Label Title;
		protected System.Windows.Forms.Panel Footer;
		protected System.Windows.Forms.Panel Body;
		protected System.Windows.Forms.Panel Header;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel Container;
	}
}
