using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Reflection;

namespace Cards
{
	/// <summary>
	/// Summary description for About.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblFileVersion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblJunk;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ImageList imageList;
		public string m_sVersion;

		System.Timers.Timer timer = new System.Timers.Timer();
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtAssemblies;
		private System.Windows.Forms.Label label3;
		int c;

		public About(string sVersion)
		{
			m_sVersion = sVersion;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			c = 0;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		private string GetFileVersion() 
		{
			FileVersionInfo fversinfo;
			//FileInfo        finfo;
			string          filepath;
            
			//declare an absolute path to a file to retrieve information about
			filepath = "Cards.exe";

			//ensure file exists
			if (File.Exists(filepath))
			{
				//get version information
				fversinfo = FileVersionInfo.GetVersionInfo(filepath);
				return fversinfo.FileVersion;    
			}
			return "Unknown";
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(About));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblFileVersion = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblJunk = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.btnClose = new System.Windows.Forms.Button();
			this.txtAssemblies = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Idiot\'s Delight (a solitaire game)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Product Version :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(112, 88);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(164, 16);
			this.lblVersion.TabIndex = 2;
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFileVersion
			// 
			this.lblFileVersion.Location = new System.Drawing.Point(112, 104);
			this.lblFileVersion.Name = "lblFileVersion";
			this.lblFileVersion.Size = new System.Drawing.Size(164, 16);
			this.lblFileVersion.TabIndex = 4;
			this.lblFileVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "File Version :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblJunk
			// 
			this.lblJunk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblJunk.Location = new System.Drawing.Point(184, 232);
			this.lblJunk.Name = "lblJunk";
			this.lblJunk.Size = new System.Drawing.Size(188, 20);
			this.lblJunk.TabIndex = 5;
			this.lblJunk.Text = "Built on running stickman technology";
			this.lblJunk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(372, 228);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(25, 25);
			this.pictureBox.TabIndex = 6;
			this.pictureBox.TabStop = false;
			// 
			// imageList
			// 
			this.imageList.ImageSize = new System.Drawing.Size(25, 25);
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(180, 264);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtAssemblies
			// 
			this.txtAssemblies.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtAssemblies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAssemblies.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtAssemblies.Location = new System.Drawing.Point(8, 128);
			this.txtAssemblies.Multiline = true;
			this.txtAssemblies.Name = "txtAssemblies";
			this.txtAssemblies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAssemblies.Size = new System.Drawing.Size(408, 92);
			this.txtAssemblies.TabIndex = 8;
			this.txtAssemblies.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(136, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "By: Jonathan Kroupa";
			// 
			// About
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(428, 302);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAssemblies);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.lblJunk);
			this.Controls.Add(this.lblFileVersion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(436, 336);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(436, 336);
			this.Name = "About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.Load += new System.EventHandler(this.About_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void About_Load(object sender, System.EventArgs e)
		{
			lblVersion.Text = m_sVersion;
			lblFileVersion.Text = GetFileVersion();

			timer.Elapsed+= new ElapsedEventHandler(RotateFrame);
			timer.Interval = 200;
			timer.Enabled = true;

			int iMaxLen = 0;
			foreach(Assembly a in AppDomain.CurrentDomain.GetAssemblies())
			{
				if(a.GetName().Name.Length > iMaxLen)
					iMaxLen = a.GetName().Name.Length;
			}
			iMaxLen += 2;

			foreach(Assembly a in AppDomain.CurrentDomain.GetAssemblies())
			{
				txtAssemblies.Text += a.GetName().Name.PadRight(iMaxLen, (char)46) +  "Version: " + a.GetName().Version + "\r\n";
			}
		}
		public void RotateFrame(object source, ElapsedEventArgs e) 
		{	
			pictureBox.Image = imageList.Images[c];
			c++;
			if (c >2)
				c = 0;
			pictureBox.Show();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			timer.Enabled = false;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
