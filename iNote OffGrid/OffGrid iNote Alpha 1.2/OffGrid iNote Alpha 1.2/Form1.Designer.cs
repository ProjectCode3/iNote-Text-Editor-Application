namespace OffGrid_iNote_Alpha_1._2
{
    partial class Form1
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
			this.lblCaption = new System.Windows.Forms.Label();
			this.lblOpenProj = new System.Windows.Forms.Label();
			this.lblRecent = new System.Windows.Forms.Label();
			this.lblConfigurations = new System.Windows.Forms.Label();
			this.lblExit = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Path = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlRecents = new System.Windows.Forms.Panel();
			this.cmbGetHelp = new System.Windows.Forms.ComboBox();
			this.pnlRecents.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCaption
			// 
			this.lblCaption.AutoSize = true;
			this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
			this.lblCaption.Location = new System.Drawing.Point(341, 104);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(219, 30);
			this.lblCaption.TabIndex = 0;
			this.lblCaption.Text = "iNote Editor Alpha";
			// 
			// lblOpenProj
			// 
			this.lblOpenProj.AutoSize = true;
			this.lblOpenProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblOpenProj.Location = new System.Drawing.Point(388, 211);
			this.lblOpenProj.Name = "lblOpenProj";
			this.lblOpenProj.Size = new System.Drawing.Size(108, 18);
			this.lblOpenProj.TabIndex = 1;
			this.lblOpenProj.Text = "+ Open Project";
			this.lblOpenProj.Click += new System.EventHandler(this.lblOpenProj_Click);
			this.lblOpenProj.MouseEnter += new System.EventHandler(this.lblOpenProj_MouseEnter);
			this.lblOpenProj.MouseLeave += new System.EventHandler(this.lblOpenProj_MouseLeave);
			// 
			// lblRecent
			// 
			this.lblRecent.AutoSize = true;
			this.lblRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblRecent.Location = new System.Drawing.Point(388, 250);
			this.lblRecent.Name = "lblRecent";
			this.lblRecent.Size = new System.Drawing.Size(106, 18);
			this.lblRecent.TabIndex = 2;
			this.lblRecent.Text = "Recent Project";
			this.lblRecent.Click += new System.EventHandler(this.lblRecent_Click);
			this.lblRecent.MouseEnter += new System.EventHandler(this.lblRecent_MouseEnter);
			this.lblRecent.MouseLeave += new System.EventHandler(this.lblRecent_MouseLeave);
			// 
			// lblConfigurations
			// 
			this.lblConfigurations.AutoSize = true;
			this.lblConfigurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblConfigurations.Location = new System.Drawing.Point(389, 298);
			this.lblConfigurations.Name = "lblConfigurations";
			this.lblConfigurations.Size = new System.Drawing.Size(104, 18);
			this.lblConfigurations.TabIndex = 3;
			this.lblConfigurations.Text = "Configurations";
			this.lblConfigurations.Click += new System.EventHandler(this.lblConfigurations_Click);
			this.lblConfigurations.MouseEnter += new System.EventHandler(this.lblConfigurations_MouseEnter);
			this.lblConfigurations.MouseLeave += new System.EventHandler(this.lblConfigurations_MouseLeave);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblExit.Location = new System.Drawing.Point(422, 343);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(32, 18);
			this.lblExit.TabIndex = 4;
			this.lblExit.Text = "Exit";
			this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
			this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
			this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(387, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "+ New Project";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
			this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
			// 
			// Path
			// 
			this.Path.FileName = "openFileDialog1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Recent Projects";
			// 
			// pnlRecents
			// 
			this.pnlRecents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlRecents.Controls.Add(this.label2);
			this.pnlRecents.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlRecents.Font = new System.Drawing.Font("Vivaldi", 8.25F);
			this.pnlRecents.Location = new System.Drawing.Point(0, 0);
			this.pnlRecents.Name = "pnlRecents";
			this.pnlRecents.Size = new System.Drawing.Size(241, 432);
			this.pnlRecents.TabIndex = 6;
			// 
			// cmbGetHelp
			// 
			this.cmbGetHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbGetHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.cmbGetHelp.FormattingEnabled = true;
			this.cmbGetHelp.Items.AddRange(new object[] {
            "Help",
            "About",
            "Tip Of The Day"});
			this.cmbGetHelp.Location = new System.Drawing.Point(636, 399);
			this.cmbGetHelp.Name = "cmbGetHelp";
			this.cmbGetHelp.Size = new System.Drawing.Size(105, 26);
			this.cmbGetHelp.TabIndex = 7;
			this.cmbGetHelp.Text = "Get Help";
			this.cmbGetHelp.SelectedIndexChanged += new System.EventHandler(this.cmbGetHelp_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 432);
			this.Controls.Add(this.cmbGetHelp);
			this.Controls.Add(this.pnlRecents);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.lblConfigurations);
			this.Controls.Add(this.lblRecent);
			this.Controls.Add(this.lblOpenProj);
			this.Controls.Add(this.lblCaption);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome To iNote Text Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlRecents.ResumeLayout(false);
			this.pnlRecents.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblOpenProj;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.Label lblConfigurations;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog Path;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnlRecents;
		private System.Windows.Forms.ComboBox cmbGetHelp;
	}
}

