/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-23
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GuitarConcert
{
	/// <summary>
	/// Description of LyricsBox.
	/// </summary>
	public partial class LyricsBox : UserControl
	{
		public LyricsBox()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void LoadLyrics(string file)
		{
			this.webBrowser1.Url = new Uri("file://" + file);
		}
		
		public void ScrollTo(int n)
		{
			HtmlDocument doc = this.webBrowser1.Document;
			doc.Body.ScrollTop = n;
		}
	}
}
