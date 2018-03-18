/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2017-09-26
 * Time: 06:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;

namespace GuitarConcert
{
	public partial class MainForm : MetroForm
	{
		private Form View;
		
		public MainForm()
		{
			InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.LoadView(new SongsForm());
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
		
		#region Events
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			// Clear cache
			foreach(FileInfo file in new DirectoryInfo("cache/song").GetFiles())
			{
				file.Delete();
			}
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Modifiers == Keys.Control)
			{
				if(e.KeyCode == Keys.F)
				{
					;
				}
			}
		}

		void ToolStripGuideClick(object sender, EventArgs e)
		{
			GuideForm f = new GuideForm();
			f.Show();
		}
		
		#endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Dispose();
            }
        }
	}
}
