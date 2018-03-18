/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-28
 * Time: 21:19
 * 
 */
namespace GuitarConcert
{
	partial class GuideForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TreeView treeIndex;
		private System.Windows.Forms.WebBrowser webBrowser1;
		
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Akordy");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Budowa gitary");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gitara", new System.Windows.Forms.TreeNode[] {
			treeNode1,
			treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GuitarConcert");
			this.treeIndex = new System.Windows.Forms.TreeView();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// treeIndex
			// 
			this.treeIndex.Cursor = System.Windows.Forms.Cursors.Default;
			this.treeIndex.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.treeIndex.ForeColor = System.Drawing.Color.SteelBlue;
			this.treeIndex.Location = new System.Drawing.Point(0, 0);
			this.treeIndex.Name = "treeIndex";
			treeNode1.Name = "Chords";
			treeNode1.Text = "Akordy";
			treeNode2.Name = "GuitarBuldi";
			treeNode2.Text = "Budowa gitary";
			treeNode3.Name = "Guitar";
			treeNode3.Text = "Gitara";
			treeNode4.Name = "Node0";
			treeNode4.Text = "GuitarConcert";
			this.treeIndex.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode3,
			treeNode4});
			this.treeIndex.Size = new System.Drawing.Size(218, 664);
			this.treeIndex.TabIndex = 0;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(218, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(566, 664);
			this.webBrowser1.TabIndex = 1;
			// 
			// GuideForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 664);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.treeIndex);
			this.Name = "GuideForm";
			this.Text = "GuideForm";
			this.ResumeLayout(false);

		}
	}
}
