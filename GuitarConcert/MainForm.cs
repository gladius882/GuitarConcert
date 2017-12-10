/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-26
 * Time: 06:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace GuitarConcert
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Form View;
		
		public MainForm()
		{
			InitializeComponent();
			
			View  = new SongsForm();
			this.LoadView(View);
			
			
		}
		
		public void LoadView(Form view)
		{
			this.CloseAllMdiChilds();
			
			View = view;
			View.MdiParent = this;
			View.Show();
			View.WindowState = FormWindowState.Maximized;
		}
		
		void UstawieniaToolStripMenuItemClick(object sender, EventArgs e)
		{	
			this.CloseAllMdiChilds();
			
			Form settings = new SettingsForm();
			settings.MdiParent = this;			
			settings.Show();
			settings.WindowState = FormWindowState.Maximized;
			
		}
		
		public void CloseAllMdiChilds()
		{
			foreach (Form child in this.MdiChildren)
			{
				child.Close();
			}
		}
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			// TODO Fullscreen switch when Ctrl + F has been pressed
		}
	}
}
