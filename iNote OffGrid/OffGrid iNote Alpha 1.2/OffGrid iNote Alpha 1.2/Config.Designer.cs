namespace OffGrid_iNote_Alpha_1._2
{
    partial class Config
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblAboutiNote = new System.Windows.Forms.Label();
			this.lblAccountDets = new System.Windows.Forms.Label();
			this.lblEditorAppearance = new System.Windows.Forms.Label();
			this.lblCaption = new System.Windows.Forms.Label();
			this.accountDets1 = new OffGrid_iNote_Alpha_1._2.AccountDets();
			this.editorApperance1 = new OffGrid_iNote_Alpha_1._2.EditorApperance();
			this.about1 = new OffGrid_iNote_Alpha_1._2.about();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblAboutiNote);
			this.panel1.Controls.Add(this.lblAccountDets);
			this.panel1.Controls.Add(this.lblEditorAppearance);
			this.panel1.Controls.Add(this.lblCaption);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(189, 606);
			this.panel1.TabIndex = 0;
			// 
			// lblAboutiNote
			// 
			this.lblAboutiNote.AutoSize = true;
			this.lblAboutiNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblAboutiNote.Location = new System.Drawing.Point(38, 330);
			this.lblAboutiNote.Name = "lblAboutiNote";
			this.lblAboutiNote.Size = new System.Drawing.Size(93, 20);
			this.lblAboutiNote.TabIndex = 3;
			this.lblAboutiNote.Text = "About iNote";
			this.lblAboutiNote.Click += new System.EventHandler(this.lblAboutiNote_Click);
			this.lblAboutiNote.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
			this.lblAboutiNote.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
			// 
			// lblAccountDets
			// 
			this.lblAccountDets.AutoSize = true;
			this.lblAccountDets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblAccountDets.Location = new System.Drawing.Point(38, 206);
			this.lblAccountDets.Name = "lblAccountDets";
			this.lblAccountDets.Size = new System.Drawing.Size(121, 20);
			this.lblAccountDets.TabIndex = 2;
			this.lblAccountDets.Text = "Account Details";
			this.lblAccountDets.Click += new System.EventHandler(this.lblAccountDets_Click);
			this.lblAccountDets.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
			this.lblAccountDets.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
			// 
			// lblEditorAppearance
			// 
			this.lblEditorAppearance.AutoSize = true;
			this.lblEditorAppearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblEditorAppearance.Location = new System.Drawing.Point(21, 107);
			this.lblEditorAppearance.Name = "lblEditorAppearance";
			this.lblEditorAppearance.Size = new System.Drawing.Size(142, 20);
			this.lblEditorAppearance.TabIndex = 1;
			this.lblEditorAppearance.Text = "Editor Appearance";
			this.lblEditorAppearance.Click += new System.EventHandler(this.lblEditorAppearance_Click);
			this.lblEditorAppearance.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
			this.lblEditorAppearance.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
			// 
			// lblCaption
			// 
			this.lblCaption.AutoSize = true;
			this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCaption.Location = new System.Drawing.Point(38, 19);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(96, 20);
			this.lblCaption.TabIndex = 0;
			this.lblCaption.Text = "iNote Config";
			// 
			// accountDets1
			// 
			this.accountDets1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountDets1.Location = new System.Drawing.Point(189, 0);
			this.accountDets1.Name = "accountDets1";
			this.accountDets1.Size = new System.Drawing.Size(564, 606);
			this.accountDets1.TabIndex = 2;
			this.accountDets1.Load += new System.EventHandler(this.accountDets1_Load);
			// 
			// editorApperance1
			// 
			this.editorApperance1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editorApperance1.Location = new System.Drawing.Point(189, 0);
			this.editorApperance1.Name = "editorApperance1";
			this.editorApperance1.Size = new System.Drawing.Size(564, 606);
			this.editorApperance1.TabIndex = 1;
			// 
			// about1
			// 
			this.about1.Location = new System.Drawing.Point(189, 0);
			this.about1.Name = "about1";
			this.about1.Size = new System.Drawing.Size(564, 606);
			this.about1.TabIndex = 3;
			// 
			// Config
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 606);
			this.Controls.Add(this.about1);
			this.Controls.Add(this.accountDets1);
			this.Controls.Add(this.editorApperance1);
			this.Controls.Add(this.panel1);
			this.Name = "Config";
			this.Text = "iNote Software Configurations";
			this.Load += new System.EventHandler(this.Config_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCaption;
        private EditorApperance editorApperance1;
        private AccountDets accountDets1;
		private about about1;
		public System.Windows.Forms.Label lblEditorAppearance;
		public System.Windows.Forms.Label lblAboutiNote;
		public System.Windows.Forms.Label lblAccountDets;
	}
}