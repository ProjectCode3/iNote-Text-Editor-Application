namespace OffGrid_iNote_Alpha_1._2
{
	partial class frmUpdates
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblCheckforUpdate = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblPercentage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(-2, 46);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(337, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 0;
			// 
			// lblCheckforUpdate
			// 
			this.lblCheckforUpdate.AutoSize = true;
			this.lblCheckforUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCheckforUpdate.Location = new System.Drawing.Point(3, 19);
			this.lblCheckforUpdate.Name = "lblCheckforUpdate";
			this.lblCheckforUpdate.Size = new System.Drawing.Size(198, 24);
			this.lblCheckforUpdate.TabIndex = 1;
			this.lblCheckforUpdate.Text = "Checking For Updates";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(100, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblPercentage
			// 
			this.lblPercentage.AutoSize = true;
			this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPercentage.Location = new System.Drawing.Point(207, 25);
			this.lblPercentage.Name = "lblPercentage";
			this.lblPercentage.Size = new System.Drawing.Size(51, 16);
			this.lblPercentage.TabIndex = 3;
			this.lblPercentage.Text = "label1";
			// 
			// frmUpdates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 124);
			this.ControlBox = false;
			this.Controls.Add(this.lblPercentage);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblCheckforUpdate);
			this.Controls.Add(this.progressBar1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUpdates";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdates_FormClosing);
			this.Load += new System.EventHandler(this.frmUpdates_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.ProgressBar progressBar1;
		public System.Windows.Forms.Label lblCheckforUpdate;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblPercentage;
	}
}