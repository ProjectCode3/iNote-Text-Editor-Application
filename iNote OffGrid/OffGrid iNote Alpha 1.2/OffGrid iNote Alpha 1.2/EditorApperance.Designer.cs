namespace OffGrid_iNote_Alpha_1._2
{
    partial class EditorApperance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gpEditorTheme = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbtnFontColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbThemes = new System.Windows.Forms.ComboBox();
            this.lblThemeColor = new System.Windows.Forms.Label();
            this.gpEditorTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.Location = new System.Drawing.Point(167, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor Appearance";
            // 
            // gpEditorTheme
            // 
            this.gpEditorTheme.Controls.Add(this.btnCancel);
            this.gpEditorTheme.Controls.Add(this.btnApply);
            this.gpEditorTheme.Controls.Add(this.label4);
            this.gpEditorTheme.Controls.Add(this.label5);
            this.gpEditorTheme.Controls.Add(this.label6);
            this.gpEditorTheme.Controls.Add(this.lblbtnFontColor);
            this.gpEditorTheme.Controls.Add(this.label3);
            this.gpEditorTheme.Controls.Add(this.cmbSize);
            this.gpEditorTheme.Controls.Add(this.label2);
            this.gpEditorTheme.Controls.Add(this.cmbThemes);
            this.gpEditorTheme.Controls.Add(this.lblThemeColor);
            this.gpEditorTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gpEditorTheme.Location = new System.Drawing.Point(0, 89);
            this.gpEditorTheme.Name = "gpEditorTheme";
            this.gpEditorTheme.Size = new System.Drawing.Size(564, 514);
            this.gpEditorTheme.TabIndex = 1;
            this.gpEditorTheme.TabStop = false;
            this.gpEditorTheme.Text = "Editor Appearance";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(466, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(368, 473);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(92, 39);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Font";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Font";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Font Color";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // lblbtnFontColor
            // 
            this.lblbtnFontColor.AutoSize = true;
            this.lblbtnFontColor.Location = new System.Drawing.Point(243, 227);
            this.lblbtnFontColor.Name = "lblbtnFontColor";
            this.lblbtnFontColor.Size = new System.Drawing.Size(98, 24);
            this.lblbtnFontColor.TabIndex = 5;
            this.lblbtnFontColor.Text = "Font Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font Color";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Normal",
            "Large",
            "FullScreen"});
            this.cmbSize.Location = new System.Drawing.Point(247, 146);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(162, 32);
            this.cmbSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Window Size";
            // 
            // cmbThemes
            // 
            this.cmbThemes.FormattingEnabled = true;
            this.cmbThemes.Items.AddRange(new object[] {
            "Dark",
            "Light",
            "Dark[Windows]",
            "Dark[Linux]",
            "Dark[Macos X]",
            "Custom"});
            this.cmbThemes.Location = new System.Drawing.Point(247, 59);
            this.cmbThemes.Name = "cmbThemes";
            this.cmbThemes.Size = new System.Drawing.Size(162, 32);
            this.cmbThemes.TabIndex = 1;
            // 
            // lblThemeColor
            // 
            this.lblThemeColor.AutoSize = true;
            this.lblThemeColor.Location = new System.Drawing.Point(16, 62);
            this.lblThemeColor.Name = "lblThemeColor";
            this.lblThemeColor.Size = new System.Drawing.Size(125, 24);
            this.lblThemeColor.TabIndex = 0;
            this.lblThemeColor.Text = "Editor Theme";
            // 
            // EditorApperance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpEditorTheme);
            this.Controls.Add(this.label1);
            this.Name = "EditorApperance";
            this.Size = new System.Drawing.Size(564, 606);
            this.gpEditorTheme.ResumeLayout(false);
            this.gpEditorTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpEditorTheme;
        private System.Windows.Forms.Label lblThemeColor;
        private System.Windows.Forms.ComboBox cmbThemes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbtnFontColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}
