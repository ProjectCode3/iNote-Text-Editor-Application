using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Linq;

namespace OffGrid_iNote_Alpha_1._2
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        OpenFileDialog Path = new OpenFileDialog();
        SaveFileDialog sPath = new SaveFileDialog();

        FontDialog Font_Theme = new FontDialog();       

        string[] file_ext = { "Text Document | *.txt", "C/c++ | *.c", "C# Source File | *.cs",
                              "Java File | *.java", "Word Document File | *.doc", "PDF File | *.pdf",
                              "RichTextFile Document | *.rtf", "Java File | *.java" };

        public Boolean isVisible = true;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            string ext;

            //Open A File to edit
            if (Path.ShowDialog() == DialogResult.OK)
            {
                path = Path.FileName;
                FileInfo f = new FileInfo(path);
                string FullPath = f.FullName;
                ext = f.Extension;
                Path.Title = "Choose A File";
                string text = File.ReadAllText(Path.FileName);
                txtTextArea.Text = text;
                tslblFileName.Text = Path.FileName;
                Properties.Config.Default.FileName = Path.FileName;
                Properties.Config.Default.File_Path = FullPath;
                Properties.Config.Default.File_Extension = ext;
                this.Text = Properties.Config.Default.FileName + " iNote Text Editor";
                Properties.Config.Default.Save();
            }
        }

        private void Interface_Load(object sender, EventArgs e)
        {          
           lblConnection.Text = "";
            if (Properties.Config.Default.ED_HEIGHT == 0 && Properties.Config.Default.ED_WIDTH == 0)
            {
                this.Size = new Size(1280, 720);
            } else
            {
                this.Size = new Size(Properties.Config.Default.ED_WIDTH, Properties.Config.Default.ED_HEIGHT);
            }
            
           txtTextArea.Font = new Font("Seriff", 13, FontStyle.Regular);           
           txtTextArea.ForeColor = Properties.Config.Default.Editor_F_Color;
           txtTextArea.BackColor = Properties.Config.Default.Editor_Theme;
           txtTextArea.Font = Properties.Config.Default.Editor_Font;                         

            if (NetworkisAvailable() == true)
            {
                lblConnection.Text = "Connected";
            } else if (!NetworkisAvailable() == true)
            {
                lblConnection.Text = "Disconnected";
            }           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Config.Default.FileName.Trim() == string.Empty)
            {
                DialogResult returnVal = MessageBox.Show("The File Is Not Saved"+
                                                         "\nDo You Wish To Save The File", "Save Document", MessageBoxButtons.YesNo); 

                if (returnVal == DialogResult.Yes)
                {
                    sPath.Filter = "Text Document | *.txt|C/c++  (.c)| *.c|C# Source File (.cs)|*.cs|Java File (.java)|*.java|Word Document(.docx)|*.docx|PDF File(.pdf)|*.pdf";                    
                    sPath.Title = "Save FileName";
                    sPath.ShowDialog();
                } 
            }else
            {
                txtTextArea.Clear();
                tslblFileName.Text = "";
                Properties.Config.Default.FileName = "";
                Properties.Config.Default.Save();

            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interface newInterface = new Interface();
            newInterface.ShowDialog();
            
        }

       
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string path = Properties.Config.Default.FileName;

            if (Properties.Config.Default.FileName.Trim() == string.Empty)
            {
                DialogResult returnVal = MessageBox.Show("The File Is Not Saved "+
                                                         "\nDo you Want To Save It", "Untitled File", MessageBoxButtons.YesNo);

                if (returnVal == DialogResult.Yes)
                {
                   
                      

                    sPath.Title = "Save File";
                    sPath.Filter = "Text Document | *.txt|C/c++  (.c)| *.c|C# Source File (.cs)|*.cs|Java File (.java)|*.java|Word Document(.docx)|*.docx|PDF File(.pdf)|*.pdf";
                    sPath.DefaultExt = "txt";
                    sPath.ShowDialog();

                    if (sPath.FileName != "")
                    {
                        System.IO.FileStream fs = (System.IO.FileStream)sPath.OpenFile();
                        Properties.Config.Default.FileName = sPath.FileName;
                        Properties.Config.Default.Save();
                        fs.Close();
                    }

                    tslblFileName.Text = Properties.Config.Default.FileName;
                }
            }

            txtTextArea.SaveFile(path, RichTextBoxStreamType.PlainText);
        }

        private void saveAssToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (Properties.Config.Default.FileName.Trim() == string.Empty)
            {
                DialogResult returnVal = MessageBox.Show("The Document is Not Saved" +
                                                         "\nWould You Like To Save It", "Untitled Document", MessageBoxButtons.YesNo);

                if (returnVal == DialogResult.Yes)
                {
                    sPath.Filter = "Text Files | *.txt";
                    sPath.Title = "Save FileName";
                    sPath.DefaultExt = "txt";
                    sPath.ShowDialog();

                    if (sPath.FileName != "")
                    {
                        System.IO.FileStream fs = (System.IO.FileStream)sPath.OpenFile();
                        Properties.Config.Default.FileName = sPath.FileName;
                        Properties.Config.Default.Save();
                        fs.Close();
                    }                   
                    tslblFileName.Text = Properties.Config.Default.FileName;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult returnVal = MessageBox.Show("Are You Sure You Wish To Exit The Application", "Exit Application", MessageBoxButtons.YesNo);

            if (returnVal == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1Dialog = new Form1();
                frm1Dialog.ShowDialog();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfaceSettings Settings = new interfaceSettings();
            Settings.ShowDialog();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isVisible = true;           

            if (isVisible)
            {
                MessageBox.Show("Status Bar Is Already Visible", "Status Bar");
            }

            statusStrip1.Visible = isVisible;
            Properties.Config.Default.StatusBar = isVisible;
            Properties.Config.Default.Save();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isVisible = false;           

            if (!isVisible)
            {
                MessageBox.Show("Status Bar Is Already Hidden", "Status Bar");
            }

            statusStrip1.Visible = isVisible;
            Properties.Config.Default.StatusBar = isVisible;
            Properties.Config.Default.Save();

        }

        private void editorThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.lblAboutiNote.Visible = false;
            config.lblAccountDets.Visible = false;
            config.ShowDialog();
        }      

        private void tsFindWord_Click(object sender, EventArgs e)
        {
            string[] words = txtBox1.Text.Split(',');

            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < txtTextArea.TextLength)
                {
                    int wordstartIndex = txtTextArea.Find(word, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        txtTextArea.SelectionStart = wordstartIndex;
                        txtTextArea.SelectionLength = word.Length;
                        txtTextArea.SelectionBackColor = Color.Yellow;
                        Properties.Config.Default.Find_Word = words.ToString();
                        Properties.Config.Default.Save();
                    }
                    else
                        break;
                    startIndex += wordstartIndex + word.Length;
                }
            }
        }
       
        private void fontThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Font_Theme.ShowDialog() == DialogResult.OK)
            {
                Properties.Config.Default.Editor_Font = Font_Theme.Font;
                Properties.Config.Default.Save();
                DialogResult returnVal = MessageBox.Show("The Editor Needs To Be Restarted " + "\nTo Apply The New Font."+
                                "\nRestart Now", "Editor Theme", MessageBoxButtons.YesNo);

                if (returnVal == DialogResult.Yes)
                {
                    this.Hide();
                    Form1 Dialog = new Form1();
                    Dialog.Show();

                    timer2.Interval = 1000;
                    timer2.Tick += new EventHandler(timer2_Tick);
                    timer2.Start();
                }
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AccName = Properties.Config.Default.UserName;
            int AccRegKey = Properties.Config.Default.ID_Key;
            Boolean Registered = Properties.Config.Default.Registered;

            MessageBox.Show("iNote Account Details" +
                            "\n******************" +
                            "\nAccount Name   " + "    " + AccName +
                            "\nAccount ID Key " + "     " + AccRegKey.ToString() +  
                            "\nRegistered:    " + "        " + Registered, "Account Details", MessageBoxButtons.OK);           
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For More Help Please Contact Support at project.code46@gmail.com", "Help", MessageBoxButtons.OK);
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("iNote Text Editor Version 1.02 Beta", "iNote Version", MessageBoxButtons.OK);
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdates updates = new frmUpdates();
            updates.lblCheckforUpdate.Text = "Checking For Updates";
            updates.ShowDialog();
            
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frmUpdates updates = new frmUpdates();

            if (updates.progressBar1.Value != 100)
            {
                updates.progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void resetUserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Config.Default.Reset();

            MessageBox.Show("All User Settings Have Been Reset To Default", "Reset User Settings", MessageBoxButtons.OK);
        }

        public static bool NetworkisAvailable()
        {
            try
            {
                using (var client = new WebClient())                
                    using (client.OpenRead("http://google.com/generate_204"))             
                return true;
            } catch
            {
                return false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Show();            
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace replace = new Replace();
            replace.ShowDialog();
        }        
    }
} 
