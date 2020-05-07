using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OffGrid_iNote_Alpha_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Interface iface = new Interface();        
        Config config = new Config();
        String[] tips = new string[3] { "iNote was written in C#", "The Creator Is OffGrid Inc", "iNote is a multi-operational Software"};

        private void lblOpenProj_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblOpenProj.ForeColor = Color.FromArgb(219, 102, 0);
        }

        private void lblOpenProj_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default; 
            lblOpenProj.ForeColor = Properties.Config.Default.Editor_F_Color; 
        }

        private void lblRecent_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblRecent.ForeColor = Color.FromArgb(219, 102, 0);
        }

        private void lblRecent_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblRecent.ForeColor = Properties.Config.Default.Editor_F_Color; 
        }

        private void lblConfigurations_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblConfigurations.ForeColor = Color.FromArgb(219, 102, 0);
        }

        private void lblConfigurations_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblConfigurations.ForeColor = Properties.Config.Default.Editor_F_Color; 
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            lblExit.ForeColor = Color.FromArgb(219, 102, 0);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            lblExit.ForeColor = Properties.Config.Default.Editor_F_Color;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            label1.ForeColor = Color.FromArgb(219, 102, 0);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            label1.ForeColor = Properties.Config.Default.Editor_F_Color;
        }

        private void lblOpenProj_Click(object sender, EventArgs e)
        {
            if (Path.ShowDialog() == DialogResult.OK)
            {                   
                    string text = File.ReadAllText(Path.FileName);
                    iface.txtTextArea.Text = text;
                    iface.tslblFileName.Text = Path.FileName;
                    Properties.Config.Default.FileName = Path.FileName;
                    Properties.Config.Default.Save();
                    iface.Text = Properties.Config.Default.FileName + " iNote Editor";                 
                    iface.ShowDialog();                             
            }                       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            iface.tslblFileName.Text = "New Document";
            Properties.Config.Default.FileName = "";
            Properties.Config.Default.Save();
            iface.txtTextArea.Clear();
            iface.ShowDialog();
        }

        private void lblRecent_Click(object sender, EventArgs e)
        {
                        
            if (Properties.Config.Default.FileName.Trim() == string.Empty)
            {
                MessageBox.Show("No Recent File Has Been Opened"+ 
                                "\nPlease Select A Project From File System"+
                                "\nOr Create A New Project", "Invalid File Path", MessageBoxButtons.OK);
            } else
            {
                String text = File.ReadAllText(Properties.Config.Default.FileName);
                iface.txtTextArea.Text = text;
                iface.ShowDialog(); 
            }            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblConfigurations_Click(object sender, EventArgs e)
        {
            config.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Config.Default.Editor_Theme;
            this.ForeColor = Properties.Config.Default.Editor_F_Color;
            cmbGetHelp.BackColor = Properties.Config.Default.Editor_Theme;
            cmbGetHelp.ForeColor = Properties.Config.Default.Editor_F_Color;            
         

            Label myLabel = new Label();
            if (Properties.Config.Default.FileName.Trim() != string.Empty)
            {
                FileInfo info = new FileInfo(Properties.Config.Default.FileName);
                myLabel.Text = info.Name;
            }else
            {
                myLabel.Text = "Recent Project";
            }


            myLabel.MouseEnter += new EventHandler(myLabel_MouseEnter);
            myLabel.MouseLeave += new EventHandler(myLabel_MouseLeave);
            myLabel.Click += new EventHandler(myLabel_Click);


            myLabel.Location = new Point(50, 81);
            myLabel.AutoSize = true;
            myLabel.Font = new Font("Calibri", 12);
            myLabel.ForeColor = Properties.Config.Default.Editor_F_Color;
            myLabel.Padding = new Padding(6);

            Label Mylabel = new Label();
            if (Properties.Config.Default.FileName.Trim() != string.Empty)
            {
                Mylabel.Text = Properties.Config.Default.FileName;
            } else
            {
                Mylabel.Text = "Recent Project Path";
            }
            Mylabel.Text = Properties.Config.Default.FileName;
            Mylabel.Location = new Point(5, 103);
            Mylabel.AutoSize = true;
            Mylabel.Font = new Font("Calibri", 8);
            Mylabel.ForeColor = Properties.Config.Default.Editor_F_Color;
            Mylabel.Padding = new Padding(6);


            pnlRecents.Controls.Add(myLabel);
            pnlRecents.Controls.Add(Mylabel);

        }

        protected void myLabel_MouseEnter(object sender, EventArgs e)
        {
            Label myLabel = sender as Label;
            this.Cursor = Cursors.Hand;
            myLabel.ForeColor = Color.FromArgb(219, 102, 0);
        }

        protected void myLabel_MouseLeave(object sender, EventArgs e)
        {
            Label myLabel = sender as Label;
            this.Cursor = Cursors.Default;
            myLabel.ForeColor = Properties.Config.Default.Editor_F_Color;
        }

        protected void myLabel_Click(object sender, EventArgs e)
        {
            if (Properties.Config.Default.FileName.Trim() != string.Empty)
            {
                string text = File.ReadAllText(Properties.Config.Default.FileName);
                iface.txtTextArea.Text = text;
                iface.tslblFileName.Text = Properties.Config.Default.FileName;
                iface.ShowDialog();
            } else
            {
                MessageBox.Show("[ Exception ] Path Not Specified Error 445", "Path Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void cmbGetHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmbGetHelp.Text == "Tip Of The Day")
            {
                Random rand = new Random();
                int index = rand.Next(tips.Length);
                MessageBox.Show(tips[index], "Tip Of The Day");
            }
        }
    }
}
