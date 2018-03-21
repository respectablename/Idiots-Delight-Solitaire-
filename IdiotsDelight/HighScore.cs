using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;


namespace Cards
{
	/// <summary>
	/// Summary description for HighScore.
	/// </summary>
	public class HighScore : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName1;
		private System.Windows.Forms.Label lblName2;
		private System.Windows.Forms.Label lblName3;
		private System.Windows.Forms.Label lblName4;
		private System.Windows.Forms.Label lblName5;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblScore1;
		private System.Windows.Forms.Label lblScore2;
		private System.Windows.Forms.Label lblScore3;
		private System.Windows.Forms.Label lblScore4;
		private System.Windows.Forms.Label lblScore5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HighScore()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(HighScore));
			this.lblName1 = new System.Windows.Forms.Label();
			this.lblName2 = new System.Windows.Forms.Label();
			this.lblName3 = new System.Windows.Forms.Label();
			this.lblName4 = new System.Windows.Forms.Label();
			this.lblName5 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblScore1 = new System.Windows.Forms.Label();
			this.lblScore2 = new System.Windows.Forms.Label();
			this.lblScore3 = new System.Windows.Forms.Label();
			this.lblScore4 = new System.Windows.Forms.Label();
			this.lblScore5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblName1
			// 
			this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblName1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblName1.Location = new System.Drawing.Point(16, 24);
			this.lblName1.Name = "lblName1";
			this.lblName1.Size = new System.Drawing.Size(192, 16);
			this.lblName1.TabIndex = 0;
			this.lblName1.Text = "Homer Simpson";
			// 
			// lblName2
			// 
			this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblName2.Location = new System.Drawing.Point(16, 48);
			this.lblName2.Name = "lblName2";
			this.lblName2.Size = new System.Drawing.Size(192, 16);
			this.lblName2.TabIndex = 1;
			this.lblName2.Text = "Marge Simpson";
			// 
			// lblName3
			// 
			this.lblName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblName3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblName3.Location = new System.Drawing.Point(16, 72);
			this.lblName3.Name = "lblName3";
			this.lblName3.Size = new System.Drawing.Size(192, 16);
			this.lblName3.TabIndex = 2;
			this.lblName3.Text = "Bart Simpson";
			// 
			// lblName4
			// 
			this.lblName4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblName4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblName4.Location = new System.Drawing.Point(16, 96);
			this.lblName4.Name = "lblName4";
			this.lblName4.Size = new System.Drawing.Size(192, 16);
			this.lblName4.TabIndex = 3;
			this.lblName4.Text = "Lisa Simpson";
			// 
			// lblName5
			// 
			this.lblName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblName5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblName5.Location = new System.Drawing.Point(16, 120);
			this.lblName5.Name = "lblName5";
			this.lblName5.Size = new System.Drawing.Size(192, 16);
			this.lblName5.TabIndex = 4;
			this.lblName5.Text = "Maggie Simpson";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnClose.Location = new System.Drawing.Point(96, 160);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblScore1
			// 
			this.lblScore1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblScore1.Location = new System.Drawing.Point(216, 24);
			this.lblScore1.Name = "lblScore1";
			this.lblScore1.Size = new System.Drawing.Size(56, 16);
			this.lblScore1.TabIndex = 6;
			this.lblScore1.Text = "5";
			this.lblScore1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblScore2
			// 
			this.lblScore2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblScore2.Location = new System.Drawing.Point(216, 48);
			this.lblScore2.Name = "lblScore2";
			this.lblScore2.Size = new System.Drawing.Size(56, 16);
			this.lblScore2.TabIndex = 7;
			this.lblScore2.Text = "4";
			this.lblScore2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblScore3
			// 
			this.lblScore3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblScore3.Location = new System.Drawing.Point(216, 72);
			this.lblScore3.Name = "lblScore3";
			this.lblScore3.Size = new System.Drawing.Size(56, 16);
			this.lblScore3.TabIndex = 8;
			this.lblScore3.Text = "3";
			this.lblScore3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblScore4
			// 
			this.lblScore4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblScore4.Location = new System.Drawing.Point(216, 96);
			this.lblScore4.Name = "lblScore4";
			this.lblScore4.Size = new System.Drawing.Size(56, 16);
			this.lblScore4.TabIndex = 9;
			this.lblScore4.Text = "2";
			this.lblScore4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblScore5
			// 
			this.lblScore5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblScore5.Location = new System.Drawing.Point(216, 120);
			this.lblScore5.Name = "lblScore5";
			this.lblScore5.Size = new System.Drawing.Size(56, 16);
			this.lblScore5.TabIndex = 10;
			this.lblScore5.Text = "1";
			this.lblScore5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// HighScore
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.OliveDrab;
			this.ClientSize = new System.Drawing.Size(292, 190);
			this.Controls.Add(this.lblScore5);
			this.Controls.Add(this.lblScore4);
			this.Controls.Add(this.lblScore3);
			this.Controls.Add(this.lblScore2);
			this.Controls.Add(this.lblScore1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblName5);
			this.Controls.Add(this.lblName4);
			this.Controls.Add(this.lblName3);
			this.Controls.Add(this.lblName2);
			this.Controls.Add(this.lblName1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 224);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 224);
			this.Name = "HighScore";
			this.Text = "High Scores";
			this.Load += new System.EventHandler(this.HighScore_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void HighScore_Load(object sender, System.EventArgs e)
		{
			RegistryKey rk = Registry.LocalMachine;
			rk = rk.OpenSubKey("SOFTWARE\\RUNNINGSTICKMAN\\Idiot's Delight");
			if (rk.ValueCount > 0)
			{
				lblName1.Text = rk.GetValue("Name1").ToString();
				lblScore1.Text = rk.GetValue("Score1").ToString();
				lblName2.Text = rk.GetValue("Name2").ToString();
				lblScore2.Text = rk.GetValue("Score2").ToString();
				lblName3.Text = rk.GetValue("Name3").ToString();
				lblScore3.Text = rk.GetValue("Score3").ToString();
				lblName4.Text = rk.GetValue("Name4").ToString();
				lblScore4.Text = rk.GetValue("Score4").ToString();
				lblName5.Text = rk.GetValue("Name5").ToString();
				lblScore5.Text = rk.GetValue("Score5").ToString();
			}

		}
	}
}
