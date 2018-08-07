/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-07
 * Time: 12:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuitarConcert
{
	/// <summary>
	/// Description of Dialog.
	/// </summary>
	public partial class Dialog : Form
	{	
		public Dialog()
		{
			InitializeComponent();
		}
		
		void DialogKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
		
		public new void Show()
		{
			ShowDialog();
		}
	}
}
