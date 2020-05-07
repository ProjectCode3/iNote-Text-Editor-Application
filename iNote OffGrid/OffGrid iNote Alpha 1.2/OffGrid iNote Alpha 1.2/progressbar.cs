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
	public partial class frmUpdates : Form
	{
		public frmUpdates()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmUpdates_Load(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			timer1.Interval = 100;
			progressBar1.Maximum = 100;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value != 100)
			{
				progressBar1.Value++;
				lblPercentage.Text = progressBar1.Value.ToString() + "% Complete";
			}
			else
			{
				timer1.Stop();
				if (progressBar1.Value == 100)
				{
					MessageBox.Show("No Updates Were Found", "Updates", MessageBoxButtons.OK);
				}
							
			}
		}

		private void frmUpdates_FormClosing(object sender, FormClosingEventArgs e)
		{
			//MessageBox.Show("No New Version Could Be Found", "Updates", MessageBoxButtons.OK);
		}
	}
}
