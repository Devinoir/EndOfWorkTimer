/*
 * Created by SharpDevelop.
 * User: neugebauer
 * Date: 28.01.2020
 * Time: 14:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EndOfWorkTimer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem uhrzeitÄndernToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem farbeÄndernToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripMenuItem hintergrundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem schriftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hintergrundToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem schriftToolStripMenuItem1;
		private System.Windows.Forms.Timer timer3;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.uhrzeitÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.farbeÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hintergrundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.schriftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.hintergrundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.schriftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label1.ContextMenuStrip = this.contextMenuStrip2;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(0, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(734, 213);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.uhrzeitÄndernToolStripMenuItem,
			this.farbeÄndernToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(161, 48);
			// 
			// uhrzeitÄndernToolStripMenuItem
			// 
			this.uhrzeitÄndernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uhrzeitÄndernToolStripMenuItem.Image")));
			this.uhrzeitÄndernToolStripMenuItem.Name = "uhrzeitÄndernToolStripMenuItem";
			this.uhrzeitÄndernToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.uhrzeitÄndernToolStripMenuItem.Text = "Uhrzeit ändern...";
			this.uhrzeitÄndernToolStripMenuItem.Click += new System.EventHandler(this.UhrzeitÄndernToolStripMenuItemClick);
			// 
			// farbeÄndernToolStripMenuItem
			// 
			this.farbeÄndernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.hintergrundToolStripMenuItem1,
			this.schriftToolStripMenuItem1});
			this.farbeÄndernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("farbeÄndernToolStripMenuItem.Image")));
			this.farbeÄndernToolStripMenuItem.Name = "farbeÄndernToolStripMenuItem";
			this.farbeÄndernToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.farbeÄndernToolStripMenuItem.Text = "Farbe ändern...";
			// 
			// hintergrundToolStripMenuItem1
			// 
			this.hintergrundToolStripMenuItem1.Name = "hintergrundToolStripMenuItem1";
			this.hintergrundToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
			this.hintergrundToolStripMenuItem1.Text = "Hintergrund";
			this.hintergrundToolStripMenuItem1.Click += new System.EventHandler(this.HintergrundToolStripMenuItem1Click);
			// 
			// schriftToolStripMenuItem1
			// 
			this.schriftToolStripMenuItem1.Name = "schriftToolStripMenuItem1";
			this.schriftToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
			this.schriftToolStripMenuItem1.Text = "Schrift";
			this.schriftToolStripMenuItem1.Click += new System.EventHandler(this.SchriftToolStripMenuItem1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label2.ContextMenuStrip = this.contextMenuStrip1;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(734, 180);
			this.label2.TabIndex = 1;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem2});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.hintergrundToolStripMenuItem,
			this.schriftToolStripMenuItem});
			this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem2.Text = "Farbe ändern...";
			// 
			// hintergrundToolStripMenuItem
			// 
			this.hintergrundToolStripMenuItem.Name = "hintergrundToolStripMenuItem";
			this.hintergrundToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.hintergrundToolStripMenuItem.Text = "Hintergrund";
			this.hintergrundToolStripMenuItem.Click += new System.EventHandler(this.HintergrundToolStripMenuItemClick);
			// 
			// schriftToolStripMenuItem
			// 
			this.schriftToolStripMenuItem.Name = "schriftToolStripMenuItem";
			this.schriftToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.schriftToolStripMenuItem.Text = "Schrift";
			this.schriftToolStripMenuItem.Click += new System.EventHandler(this.SchriftToolStripMenuItemClick);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Feierabend Countdown";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 393);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Feierabend Countdown 17:00:00";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.contextMenuStrip2.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
