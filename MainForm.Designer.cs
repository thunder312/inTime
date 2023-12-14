/*
 * Created by SharpDevelop.
 * User: der
 * Date: 08.07.2015
 * Time: 15:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace inTime
{
	
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		private About about;
		
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
			System.Windows.Forms.Button savePlan;
			System.Windows.Forms.Button load;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.calStart = new System.Windows.Forms.MonthCalendar();
			this.label1 = new System.Windows.Forms.Label();
			this.addBookGroup = new System.Windows.Forms.GroupBox();
			this.diffRatio = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.countRepeats = new System.Windows.Forms.NumericUpDown();
			this.countPages = new System.Windows.Forms.NumericUpDown();
			this.bookName = new System.Windows.Forms.TextBox();
			this.addBook = new System.Windows.Forms.Button();
			this.lrepeats = new System.Windows.Forms.Label();
			this.lPages = new System.Windows.Forms.Label();
			this.lBookName = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.export = new System.Windows.Forms.Button();
			this.actualBooksGroup = new System.Windows.Forms.GroupBox();
			this.lvBookList = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.freeDays = new System.Windows.Forms.NumericUpDown();
			this.calEnd = new System.Windows.Forms.MonthCalendar();
			this.label3 = new System.Windows.Forms.Label();
			this.learnPlan = new System.Windows.Forms.TextBox();
			this.delete = new System.Windows.Forms.Button();
			this.planName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
			savePlan = new System.Windows.Forms.Button();
			load = new System.Windows.Forms.Button();
			this.addBookGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.diffRatio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countRepeats)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countPages)).BeginInit();
			this.actualBooksGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.freeDays)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// savePlan
			// 
			savePlan.Location = new System.Drawing.Point(1032, 495);
			savePlan.Name = "savePlan";
			savePlan.Size = new System.Drawing.Size(75, 23);
			savePlan.TabIndex = 11;
			savePlan.Text = "speichern";
			savePlan.UseVisualStyleBackColor = true;
			savePlan.Click += new System.EventHandler(this.SavePlanClick);
			// 
			// load
			// 
			load.Location = new System.Drawing.Point(425, 38);
			load.Name = "load";
			load.Size = new System.Drawing.Size(75, 23);
			load.TabIndex = 20;
			load.Text = "laden";
			load.UseVisualStyleBackColor = true;
			load.Click += new System.EventHandler(this.LoadClick);
			// 
			// calStart
			// 
			this.calStart.BackColor = System.Drawing.SystemColors.Window;
			this.calStart.Location = new System.Drawing.Point(540, 64);
			this.calStart.MaxSelectionCount = 1000;
			this.calStart.Name = "calStart";
			this.calStart.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(539, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lernperiode von";
			// 
			// addBookGroup
			// 
			this.addBookGroup.Controls.Add(this.diffRatio);
			this.addBookGroup.Controls.Add(this.label4);
			this.addBookGroup.Controls.Add(this.countRepeats);
			this.addBookGroup.Controls.Add(this.countPages);
			this.addBookGroup.Controls.Add(this.bookName);
			this.addBookGroup.Controls.Add(this.addBook);
			this.addBookGroup.Controls.Add(this.lrepeats);
			this.addBookGroup.Controls.Add(this.lPages);
			this.addBookGroup.Controls.Add(this.lBookName);
			this.addBookGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBookGroup.Location = new System.Drawing.Point(12, 73);
			this.addBookGroup.Name = "addBookGroup";
			this.addBookGroup.Size = new System.Drawing.Size(500, 176);
			this.addBookGroup.TabIndex = 4;
			this.addBookGroup.TabStop = false;
			this.addBookGroup.Text = "Buch hinzufügen";
			// 
			// diffRatio
			// 
			this.diffRatio.DecimalPlaces = 1;
			this.diffRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diffRatio.Increment = new decimal(new int[] {
			                                       	1,
			                                       	0,
			                                       	0,
			                                       	65536});
			this.diffRatio.Location = new System.Drawing.Point(141, 127);
			this.diffRatio.Maximum = new decimal(new int[] {
			                                     	3,
			                                     	0,
			                                     	0,
			                                     	0});
			this.diffRatio.Minimum = new decimal(new int[] {
			                                     	1,
			                                     	0,
			                                     	0,
			                                     	65536});
			this.diffRatio.Name = "diffRatio";
			this.diffRatio.Size = new System.Drawing.Size(120, 22);
			this.diffRatio.TabIndex = 4;
			this.diffRatio.Value = new decimal(new int[] {
			                                   	1,
			                                   	0,
			                                   	0,
			                                   	0});
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Härtegrad:";
			this.label4.UseWaitCursor = true;
			// 
			// countRepeats
			// 
			this.countRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countRepeats.Location = new System.Drawing.Point(141, 100);
			this.countRepeats.Minimum = new decimal(new int[] {
			                                        	1,
			                                        	0,
			                                        	0,
			                                        	0});
			this.countRepeats.Name = "countRepeats";
			this.countRepeats.Size = new System.Drawing.Size(120, 22);
			this.countRepeats.TabIndex = 3;
			this.countRepeats.Value = new decimal(new int[] {
			                                      	1,
			                                      	0,
			                                      	0,
			                                      	0});
			// 
			// countPages
			// 
			this.countPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countPages.Location = new System.Drawing.Point(141, 72);
			this.countPages.Maximum = new decimal(new int[] {
			                                      	10000,
			                                      	0,
			                                      	0,
			                                      	0});
			this.countPages.Minimum = new decimal(new int[] {
			                                      	1,
			                                      	0,
			                                      	0,
			                                      	0});
			this.countPages.Name = "countPages";
			this.countPages.Size = new System.Drawing.Size(120, 22);
			this.countPages.TabIndex = 2;
			this.countPages.Value = new decimal(new int[] {
			                                    	1,
			                                    	0,
			                                    	0,
			                                    	0});
			// 
			// bookName
			// 
			this.bookName.Cursor = System.Windows.Forms.Cursors.Default;
			this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bookName.Location = new System.Drawing.Point(141, 44);
			this.bookName.Name = "bookName";
			this.bookName.Size = new System.Drawing.Size(347, 22);
			this.bookName.TabIndex = 1;
			this.bookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookName_PressEnter);
			// 
			// addBook
			// 
			this.addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBook.Location = new System.Drawing.Point(395, 135);
			this.addBook.Name = "addBook";
			this.addBook.Size = new System.Drawing.Size(93, 28);
			this.addBook.TabIndex = 5;
			this.addBook.Text = "Hinzufügen";
			this.addBook.UseVisualStyleBackColor = true;
			this.addBook.Click += new System.EventHandler(this.AddBookClick);
			// 
			// lrepeats
			// 
			this.lrepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lrepeats.Location = new System.Drawing.Point(6, 102);
			this.lrepeats.Name = "lrepeats";
			this.lrepeats.Size = new System.Drawing.Size(113, 23);
			this.lrepeats.TabIndex = 2;
			this.lrepeats.Text = "Wiederholungen:";
			this.lrepeats.UseWaitCursor = true;
			// 
			// lPages
			// 
			this.lPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lPages.Location = new System.Drawing.Point(6, 78);
			this.lPages.Name = "lPages";
			this.lPages.Size = new System.Drawing.Size(102, 23);
			this.lPages.TabIndex = 1;
			this.lPages.Text = "Seiten:";
			this.lPages.UseWaitCursor = true;
			// 
			// lBookName
			// 
			this.lBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lBookName.Location = new System.Drawing.Point(6, 44);
			this.lBookName.Name = "lBookName";
			this.lBookName.Size = new System.Drawing.Size(102, 23);
			this.lBookName.TabIndex = 0;
			this.lBookName.Text = "Buch Name:";
			this.lBookName.UseWaitCursor = true;
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(870, 495);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(75, 23);
			this.calculate.TabIndex = 9;
			this.calculate.Text = "berechnen";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.CalculateClick);
			// 
			// export
			// 
			this.export.Location = new System.Drawing.Point(951, 495);
			this.export.Name = "export";
			this.export.Size = new System.Drawing.Size(75, 23);
			this.export.TabIndex = 10;
			this.export.Text = "exportieren";
			this.export.UseVisualStyleBackColor = true;
			this.export.Click += new System.EventHandler(this.ExportClick);
			// 
			// actualBooksGroup
			// 
			this.actualBooksGroup.Controls.Add(this.lvBookList);
			this.actualBooksGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.actualBooksGroup.Location = new System.Drawing.Point(12, 256);
			this.actualBooksGroup.Name = "actualBooksGroup";
			this.actualBooksGroup.Size = new System.Drawing.Size(500, 192);
			this.actualBooksGroup.TabIndex = 12;
			this.actualBooksGroup.TabStop = false;
			this.actualBooksGroup.Text = "Bücher";
			// 
			// lvBookList
			// 
			this.lvBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			                                 	this.columnHeader1,
			                                 	this.columnHeader2,
			                                 	this.columnHeader3,
			                                 	this.columnHeader4});
			this.lvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvBookList.Location = new System.Drawing.Point(3, 22);
			this.lvBookList.Name = "lvBookList";
			this.lvBookList.Size = new System.Drawing.Size(494, 167);
			this.lvBookList.TabIndex = 0;
			this.lvBookList.UseCompatibleStateImageBehavior = false;
			this.lvBookList.View = System.Windows.Forms.View.Details;
			this.lvBookList.MouseDoubleClick += new MouseEventHandler(this.LvBookListLoadBook);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Buch";
			this.columnHeader1.Width = 253;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Seiten";
			this.columnHeader2.Width = 74;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Wiederh.";
			this.columnHeader3.Width = 87;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Härtegrad";
			this.columnHeader4.Width = 74;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(724, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 34);
			this.label5.TabIndex = 13;
			this.label5.Text = "Lernplan nach den Vorgaben";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(538, 425);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 34);
			this.label2.TabIndex = 14;
			this.label2.Text = "freie Tage";
			// 
			// freeDays
			// 
			this.freeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.freeDays.Location = new System.Drawing.Point(540, 447);
			this.freeDays.Maximum = new decimal(new int[] {
			                                    	500,
			                                    	0,
			                                    	0,
			                                    	0});
			this.freeDays.Name = "freeDays";
			this.freeDays.Size = new System.Drawing.Size(177, 22);
			this.freeDays.TabIndex = 6;
			// 
			// calEnd
			// 
			this.calEnd.BackColor = System.Drawing.SystemColors.Window;
			this.calEnd.Location = new System.Drawing.Point(540, 257);
			this.calEnd.MaxSelectionCount = 1000;
			this.calEnd.Name = "calEnd";
			this.calEnd.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(538, 235);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 34);
			this.label3.TabIndex = 17;
			this.label3.Text = "bis";
			// 
			// learnPlan
			// 
			this.learnPlan.Location = new System.Drawing.Point(724, 67);
			this.learnPlan.Multiline = true;
			this.learnPlan.Name = "learnPlan";
			this.learnPlan.Size = new System.Drawing.Size(383, 402);
			this.learnPlan.TabIndex = 18;
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(407, 446);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(102, 23);
			this.delete.TabIndex = 19;
			this.delete.Text = "lösche Buch";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// planName
			// 
			this.planName.Cursor = System.Windows.Forms.Cursors.Default;
			this.planName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.planName.Location = new System.Drawing.Point(153, 38);
			this.planName.Name = "planName";
			this.planName.Size = new System.Drawing.Size(266, 22);
			this.planName.TabIndex = 0;
			this.planName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlanName_PressEnter);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Lernplan";
			this.label6.UseWaitCursor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			                               	this.toolStripMenuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
			this.menuStrip1.TabIndex = 21;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuHelp
			// 
			this.toolStripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			                                              	this.toolStripMenuItemAbout});
			this.toolStripMenuHelp.Name = "toolStripMenuHelp";
			this.toolStripMenuHelp.Size = new System.Drawing.Size(44, 20);
			this.toolStripMenuHelp.Text = "Hilfe";
			// 
			// toolStripMenuItemAbout
			// 
			this.toolStripMenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAbout.Image")));
			this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
			this.toolStripMenuItemAbout.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItemAbout.Text = "Über";
			this.toolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAboutClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1119, 526);
			this.Controls.Add(load);
			this.Controls.Add(this.planName);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.learnPlan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.calEnd);
			this.Controls.Add(this.freeDays);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.export);
			this.Controls.Add(savePlan);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.addBookGroup);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.calStart);
			this.Controls.Add(this.actualBooksGroup);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "inTime";
			this.addBookGroup.ResumeLayout(false);
			this.addBookGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.diffRatio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countRepeats)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countPages)).EndInit();
			this.actualBooksGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.freeDays)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox planName;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown diffRatio;
		private System.Windows.Forms.TextBox learnPlan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MonthCalendar calEnd;
		private System.Windows.Forms.NumericUpDown freeDays;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvBookList;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox actualBooksGroup;
		private System.Windows.Forms.Button export;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.NumericUpDown countPages;
		private System.Windows.Forms.NumericUpDown countRepeats;
		private System.Windows.Forms.TextBox bookName;
		private System.Windows.Forms.Button addBook;
		private System.Windows.Forms.Label lPages;
		private System.Windows.Forms.Label lrepeats;
		private System.Windows.Forms.Label lBookName;
		private System.Windows.Forms.GroupBox addBookGroup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MonthCalendar calStart;
		
		void ToolStripMenuItemAboutClick(object sender, EventArgs e)
		{
			about = new About();
			about.Show();
		}
	}
}
