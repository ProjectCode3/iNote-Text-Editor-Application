using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffGrid_iNote_Alpha_1._2
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void lblEditorAppearance_Click(object sender, EventArgs e)
        {
            editorApperance1.Show();
            accountDets1.Hide();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            editorApperance1.Hide();
            accountDets1.Hide();
            about1.Hide();
        }

        private void lblAccountDets_Click(object sender, EventArgs e)
        {
            //Show Account Details User Control
            editorApperance1.Hide();
            accountDets1.Show();
        }

        private void accountDets1_Load(object sender, EventArgs e)
        {

        }

        private void lblAboutiNote_Click(object sender, EventArgs e)
        {
            about1.Show();
        }
    }
}
