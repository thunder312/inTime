/*
 * Created by SharpDevelop.
 * User: der
 * Date: 28.07.2015
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace inTime
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.version = new System.Windows.Forms.Label();
			this.versionValue = new System.Windows.Forms.Label();
			this.creator = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// version
			// 
			this.version.Location = new System.Drawing.Point(12, 9);
			this.version.Name = "version";
			this.version.Size = new System.Drawing.Size(61, 23);
			this.version.TabIndex = 0;
			this.version.Text = "Version:";
			// 
			// versionValue
			// 
			this.versionValue.Location = new System.Drawing.Point(112, 9);
			this.versionValue.Name = "versionValue";
			this.versionValue.Size = new System.Drawing.Size(202, 23);
			this.versionValue.TabIndex = 1;
			this.versionValue.Text = System.Windows.Forms.Application.ProductVersion;
			
			// 
			// creator
			// 
			this.creator.Location = new System.Drawing.Point(12, 32);
			this.creator.Name = "creator";
			this.creator.Size = new System.Drawing.Size(94, 23);
			this.creator.TabIndex = 2;
			this.creator.Text = "Programmiert von:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Gewidmet:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Dieses Programm ist Freeware!!";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(112, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Daniel Ertl (daniel.ertl@email.com)";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(112, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(202, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Marion Berer";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 150);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.creator);
			this.Controls.Add(this.versionValue);
			this.Controls.Add(this.version);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "About";
			this.Text = "Über inTime";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label creator;
		private System.Windows.Forms.Label versionValue;
		private System.Windows.Forms.Label version;
	}
}
