/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-08-07
 * Time: 15:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GuitarConcert
{
	partial class TagDialog
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TagDescriptionField = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TagNameField = new System.Windows.Forms.TextBox();
			this.TagSummaryField = new System.Windows.Forms.RichTextBox();
			this.Body.SuspendLayout();
			this.Header.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Footer
			// 
			this.Footer.Location = new System.Drawing.Point(0, 415);
			// 
			// Body
			// 
			this.Body.Controls.Add(this.tableLayoutPanel1);
			this.Body.Size = new System.Drawing.Size(588, 390);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.4898F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.5102F));
			this.tableLayoutPanel1.Controls.Add(this.TagDescriptionField, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.TagNameField, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TagSummaryField, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.38806F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.61194F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 390);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// TagDescriptionField
			// 
			this.TagDescriptionField.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TagDescriptionField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TagDescriptionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TagDescriptionField.Location = new System.Drawing.Point(147, 204);
			this.TagDescriptionField.Name = "TagDescriptionField";
			this.TagDescriptionField.Size = new System.Drawing.Size(438, 183);
			this.TagDescriptionField.TabIndex = 5;
			this.TagDescriptionField.Text = "";
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.CadetBlue;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10);
			this.label1.Size = new System.Drawing.Size(138, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nazwa";
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.CadetBlue;
			this.label2.Location = new System.Drawing.Point(3, 45);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10);
			this.label2.Size = new System.Drawing.Size(138, 156);
			this.label2.TabIndex = 1;
			this.label2.Text = "Krótki opis";
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.CadetBlue;
			this.label3.Location = new System.Drawing.Point(3, 201);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10);
			this.label3.Size = new System.Drawing.Size(138, 189);
			this.label3.TabIndex = 2;
			this.label3.Text = "Pełny opis";
			// 
			// TagNameField
			// 
			this.TagNameField.Dock = System.Windows.Forms.DockStyle.Top;
			this.TagNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TagNameField.Location = new System.Drawing.Point(147, 10);
			this.TagNameField.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.TagNameField.Name = "TagNameField";
			this.TagNameField.Size = new System.Drawing.Size(438, 26);
			this.TagNameField.TabIndex = 3;
			// 
			// TagSummaryField
			// 
			this.TagSummaryField.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TagSummaryField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TagSummaryField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TagSummaryField.Location = new System.Drawing.Point(147, 48);
			this.TagSummaryField.Name = "TagSummaryField";
			this.TagSummaryField.Size = new System.Drawing.Size(438, 150);
			this.TagSummaryField.TabIndex = 4;
			this.TagSummaryField.Text = "";
			// 
			// TagDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 456);
			this.Name = "TagDialog";
			this.Text = "TagDialog";
			this.Body.ResumeLayout(false);
			this.Header.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox TagNameField;
		private System.Windows.Forms.RichTextBox TagSummaryField;
		private System.Windows.Forms.RichTextBox TagDescriptionField;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
