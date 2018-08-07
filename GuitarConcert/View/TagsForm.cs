/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-07
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using LastFmLib;

namespace GuitarConcert
{
	/// <summary>
	/// Description of TagsForm.
	/// </summary>
	public partial class TagsForm : Form
	{
		public TagsForm()
		{
			InitializeComponent();
			LoadTags();
		}
		
		private void LoadTags()
		{
			foreach(string file in Directory.GetFiles("data/tags"))
			{
				string[] path = file.Split(new[] {'/', '\\', '.'});
				string tag = path[path.Length-2];

				flowLayoutPanel1.Controls.Add(CreateTagLabel(tag));
			}
		}
		
		private Label CreateTagLabel(string tagName)
		{
			Label label = new Label();
			label.Text = tagName;
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.Width = (tagName.Length*12)+15;
			label.Height = 30;
			label.Font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			label.ForeColor = Color.Navy;
			label.BackColor = Color.WhiteSmoke;
			label.BorderStyle = BorderStyle.FixedSingle;
			label.FlatStyle = FlatStyle.Popup;
			label.Margin = new Padding(5, 5, 5, 5);
			label.Cursor = Cursors.Hand;
			label.MouseHover += new EventHandler(TagMouseHover);
			label.MouseLeave += new EventHandler(TagMouseLeave);
			label.MouseClick += new MouseEventHandler(TagMouseClick);
			return label;
		}
		
		void TagMouseHover(object sender, EventArgs e)
		{
			Label label = sender as Label;
			label.BackColor = Color.White;
		}
		
		void TagMouseLeave(object sender, EventArgs e)
		{
			Label label = sender as Label;
			label.BackColor = Color.WhiteSmoke;
		}
		
		void TagMouseClick(object sender, MouseEventArgs e)
		{
			Label label = sender as Label;
			using(TagDialog dialog = new TagDialog())
			{
				dialog.LoadTag(label.Text);
				if(dialog.ShowDialog() == DialogResult.OK)
				{
					Tag tag = new Tag();
					tag.Name = dialog.TagName.ToLower();
					tag.Summary = dialog.TagSummmary;
					tag.Description = dialog.TagDescription;
					tag.Save("data/tags/"+tag.Name+".xml");
				}
			}
		}
	}
}
