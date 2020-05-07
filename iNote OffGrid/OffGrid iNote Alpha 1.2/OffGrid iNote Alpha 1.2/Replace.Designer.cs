namespace OffGrid_iNote_Alpha_1._2
{
	partial class Replace
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
			this.btnReplace = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtFindWord = new System.Windows.Forms.TextBox();
			this.txtReplaceWord = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReplace
			// 
			this.btnReplace.Location = new System.Drawing.Point(264, 38);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(75, 29);
			this.btnReplace.TabIndex = 0;
			this.btnReplace.Text = "Replace";
			this.btnReplace.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(264, 73);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 29);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtFindWord
			// 
			this.txtFindWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtFindWord.Location = new System.Drawing.Point(12, 28);
			this.txtFindWord.Name = "txtFindWord";
			this.txtFindWord.Size = new System.Drawing.Size(206, 23);
			this.txtFindWord.TabIndex = 2;
			// 
			// txtReplaceWord
			// 
			this.txtReplaceWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.txtReplaceWord.Location = new System.Drawing.Point(12, 105);
			this.txtReplaceWord.Name = "txtReplaceWord";
			this.txtReplaceWord.Size = new System.Drawing.Size(206, 23);
			this.txtReplaceWord.TabIndex = 3;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(264, 3);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(75, 29);
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Find Word";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Replace";
			// 
			// Replace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 131);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtReplaceWord);
			this.Controls.Add(this.txtFindWord);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReplace);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Replace";
			this.ShowIcon = false;
			this.Text = "Replace";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtReplaceWord;
		public System.Windows.Forms.TextBox txtFindWord;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}