/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-07
 * Time: 15:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using LastFmLib;

namespace GuitarConcert
{
	/// <summary>
	/// Description of TagDialog.
	/// </summary>
	public partial class TagDialog : Dialog
	{
		public string TagName
		{
			get {
				return TagNameField.Text.Trim();
			}
		}
		
		public string TagSummmary
		{
			get {
				return TagSummaryField.Text.Trim();
			}
		}
		
		public string TagDescription
		{
			get {
				return TagDescriptionField.Text.Trim();
			}
		}
		
		public TagDialog()
		{
			Tag = new Tag();
			InitializeComponent();
		}
		
		public void LoadTag(string tag)
		{
			Tag Tag = new Tag();
			Tag.Load("data/tags/"+tag+".xml");
			Title.Text = tag;
			TagNameField.Text = tag;
			TagSummaryField.Text = Tag.Summary;
			TagDescriptionField.Text = Tag.Description;
		}
	}
}
