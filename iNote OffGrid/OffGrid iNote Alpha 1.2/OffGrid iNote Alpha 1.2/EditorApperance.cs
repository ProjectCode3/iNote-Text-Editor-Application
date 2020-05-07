using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffGrid_iNote_Alpha_1._2
{
    public partial class EditorApperance : UserControl
    {
        public EditorApperance()
        {
            InitializeComponent();
        }

        public int WIDTH, HEIGHT;

        public Color Theme;
        public Color FontClr;

        public ColorDialog ThemeColor = new ColorDialog();
        public ColorDialog FontColor = new ColorDialog();
        public FontDialog fontDialog = new FontDialog();
       

        private void btnApply_Click(object sender, EventArgs e)
        {

         /*            
            Dark
            Light
            Dark[Windows]
            Dark[Linux]
            Dark[Macos X]
            Custom
          */

            //Editor Theme Color Combobox
            switch (cmbThemes.SelectedIndex)
            {
                case 0:
                    Theme = System.Drawing.Color.FromArgb(77, 79, 82);
                    FontClr = System.Drawing.Color.FromArgb(255, 255, 255);
                    Properties.Config.Default.Editor_Theme = Theme;
                    Properties.Config.Default.Editor_F_Color = FontClr;
                    break;
                case 1:
                    Theme = System.Drawing.Color.FromArgb(255, 255, 255);
                    FontClr = System.Drawing.Color.FromArgb(0, 0, 0);
                    Properties.Config.Default.Editor_Theme = Theme;
                    Properties.Config.Default.Editor_F_Color = FontClr;
                    break;
                case 2:
                    Theme = System.Drawing.Color.FromArgb(44, 45, 46);
                    FontClr = System.Drawing.Color.FromArgb(255, 255, 255);
                    Properties.Config.Default.Editor_Theme = Theme;
                    break;
                case 3:
                    Theme = System.Drawing.Color.FromArgb(27, 28, 31);
                    FontClr = System.Drawing.Color.FromArgb(255, 255, 255);
                    Properties.Config.Default.Editor_Theme = Theme; 
                    Properties.Config.Default.Editor_F_Color = FontClr;
                    break;
                case 4:
                    Theme = System.Drawing.Color.FromArgb(20, 20, 20);
                    FontClr = System.Drawing.Color.FromArgb(255, 255, 255);
                    Properties.Config.Default.Editor_Theme = Theme;
                    Properties.Config.Default.Editor_F_Color = FontClr;
                    break;
                case 5:
                    ThemeColor.ShowDialog();
                    Theme = ThemeColor.Color;
                    Properties.Config.Default.Editor_Theme = Theme;
                    Properties.Config.Default.Editor_F_Color = FontClr;
                    break;                      
            }

            /*
             Normal
             Large 
             FullScreen
            */

            //Editor Window Size combobox
            switch (cmbSize.SelectedIndex)
            {
                case 1:
                    WIDTH = 1280;
                    HEIGHT = 720;
                    break;
                case 2:
                    WIDTH = 1600;
                    HEIGHT = 900;
                    break;
                case 3:
                    WIDTH = 1920;
                    HEIGHT = 1080;
                    break;
            }

            Properties.Config.Default.ED_WIDTH = WIDTH;
            Properties.Config.Default.ED_HEIGHT = HEIGHT;
            Properties.Config.Default.Save();

            MessageBox.Show("Please Restart The Editor if It Is Still Opened", "Editor Theme", MessageBoxButtons.YesNo);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FontColor.ShowDialog();
            FontClr = FontColor.Color;
            Properties.Config.Default.Editor_F_Color = FontClr;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            Properties.Config.Default.Editor_Font = fontDialog.Font;
            Properties.Config.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("Are Your Sure You Want To Exit"+
                                                   "\n Any Unsaved Data Will Be Discarded", "Exit Editor Preferences", MessageBoxButtons.YesNo);

            if (Answer == DialogResult.Yes)
            {
                cmbThemes.Text = "";
                cmbSize.Text = "";
                this.Hide();              
            }else
            {
                MessageBox.Show(" [Cancelled By User] Cancelled Application Terminate", "Exit Application");
            }
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
