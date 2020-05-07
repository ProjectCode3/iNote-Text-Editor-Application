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
	public partial class WorkSpace : UserControl
	{
		public WorkSpace()
		{
			InitializeComponent();
		}

		private void WorkSpace_Load(object sender, EventArgs e)
		{
			txtExtensions.ReadOnly = true;
			txtPath.ReadOnly = true;

			txtPath.Text = Properties.Config.Default.File_Path;
			txtExtensions.Text = Properties.Config.Default.File_Extension;
		}
	}
}
