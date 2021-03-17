using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
	
namespace EndOfWorkTimer{
	public partial class MainForm : Form{
		
		public MainForm(){
			InitializeComponent();
		    timer1.Start();
		    timer2.Start();
		    createFolder();
		    getDate();
		    loadColorFromFile();
		   	loadFromFile();
		   	MessageBox.Show("Task failed successfully!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		public TimeSpan ts;
		public DateTime endTime;
		
		void createFolder(){
			if (System.IO.Directory.Exists(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\"))) {}
			
			else{
			System.IO.Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\"));
			}
		}
		
		void getDate(){
			System.DateTime moment = DateTime.Now;
			endTime = new DateTime(moment.Year, moment.Month, moment.Day, 17, 00, 00);
		}
		
		void loadFromFileArray(){
			string[] lines = System.IO.File.ReadAllLines(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\time.txt"));
			
	        foreach (string line in lines){
	            MessageBox.Show("\t" + line);
	        }
		}
		
		void loadFromFile(){
			if (System.IO.File.Exists(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\time.txt"))){
				DateTime temp;
				string text = System.IO.File.ReadAllText(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\time.txt"));
				
				if (DateTime.TryParse(text, out temp)){
					endTime = DateTime.Parse(text);
					
					if (ts.Seconds <= 0){
						endTime = endTime.AddDays(1);
					}	
					
					Text = "Feierabend Countdown " + endTime.ToString("HH:mm:ss");
					}
				
				else{
					string lines = endTime.ToString();
					System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\time.txt"));
					file.Write(lines);
					file.Close();
				}
			}
		}
		
		void Timer1Tick(object sender, EventArgs e){
			ts = endTime.Subtract(DateTime.Now);
			
			if (ts.Seconds <= -1){
				timer1.Stop();
				label1.Text = "Ende";
				MessageBox.Show("Der Countdown ist abgelaufen","");
			}
			
			else{
				ts = endTime.Subtract(DateTime.Now);
			    label1.Text = ts.ToString("hh':'mm':'ss''");
				notifyIcon1.Text = "Feierabend Countdown " + ts.ToString("hh':'mm':'ss''");			    
			}
		}
		
		void UhrzeitÄndernToolStripMenuItemClick(object sender, EventArgs e){
			string input = Interaction.InputBox("Neue Uhrzeit", "Feierabend Countdown", "17:00:00", -1, -1);
			
			if (input!=""){
				DateTime temp;
				
				if (DateTime.TryParse(input, out temp)){
					TimeSpan newTime = TimeSpan.Parse(input);
					
					if (ts.Seconds <= 0){
						endTime = endTime.AddDays(1);
					}
					
					endTime = endTime.Date + newTime;
					timer1.Start();
					Text = "Feierabend Countdown " + endTime.ToString("HH:mm:ss");
					
					//Save
				    string lines = endTime.ToString();
					
					// Write the string to a file.
					System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\time.txt"));
					file.Write(lines);
					file.Close();
				}
				
				else{
					MessageBox.Show("Bitte geben Sie eine Korrekte Uhrzeit an!" + "\n" + "Format: 17:00:00");
					UhrzeitÄndernToolStripMenuItemClick(sender, e);
				}
			}	
		}
		
		void Timer2Tick(object sender, EventArgs e){
			label2.Text = DateTime.Now.ToString("HH:mm:ss");
		}
		
		void HintergrundToolStripMenuItemClick(object sender, EventArgs e){
			if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)  
			{  
				label2.BackColor = colorDialog1.Color;  
				saveColor();
			}
		}
		
		void HintergrundToolStripMenuItem1Click(object sender, EventArgs e){
			if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)  
			{  
				label1.BackColor = colorDialog1.Color;  
				saveColor();
			}
		}
		void SchriftToolStripMenuItem1Click(object sender, EventArgs e){
			if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)  
			{  
				label1.ForeColor = colorDialog1.Color;  
				saveColor();
			}
		}
		void SchriftToolStripMenuItemClick(object sender, EventArgs e){
			if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)  
			{  
				label2.ForeColor = colorDialog1.Color;
				saveColor();
			} 
		}
		
		void saveColor(){
			int topBackColor = label2.BackColor.ToArgb();
			int topTextColor = label2.ForeColor.ToArgb();
			int botBackColor = label1.BackColor.ToArgb();
			int botTextColor = label1.ForeColor.ToArgb();
			
			string topBackColorStr = topBackColor.ToString();
			string topTextColorStr = topTextColor.ToString();
			string botBackColorStr = botBackColor.ToString();
			string botTextColorStr = botTextColor.ToString();

			string[] lines = {topBackColorStr, topTextColorStr, botBackColorStr, botTextColorStr};
			
			// Write the string to a file.
			System.IO.File.WriteAllLines(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\color.txt"), lines);
		}
		
		void loadColorFromFile(){
			if (System.IO.File.Exists(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\color.txt"))){
				string[] lines = System.IO.File.ReadAllLines(Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\EndOfWorkTimer\color.txt"));
			
				label2.BackColor = Color.FromArgb(Int32.Parse(lines[0]));
				label2.ForeColor = Color.FromArgb(Int32.Parse(lines[1]));
				label1.BackColor = Color.FromArgb(Int32.Parse(lines[2]));
				label1.ForeColor = Color.FromArgb(Int32.Parse(lines[3]));

			}
			else{
				saveColor();
			}
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e){
        if (CloseCancel()==false)
        {
            e.Cancel = true;
        }
		}
		
	    public static bool CloseCancel(){
	        const string message = "Sind Sie sicher das Sie den Timer schließen wollen?";
	        const string caption = "Schließen";
	        var result = MessageBox.Show(message, caption,
	                                     MessageBoxButtons.YesNo,
	                                     MessageBoxIcon.Question);
	
	        if (result == DialogResult.Yes)
	            return true;
	        else
	            return false;
	    }
		void NotifyIcon1MouseDoubleClick(object sender, MouseEventArgs e){
			Show();
            WindowState = FormWindowState.Normal;
		}
		
		void MainFormResize(object sender, EventArgs e){
		    if ( WindowState == FormWindowState.Minimized )
		    {
		    	ShowInTaskbar = false;
		    }
		}
	}
}