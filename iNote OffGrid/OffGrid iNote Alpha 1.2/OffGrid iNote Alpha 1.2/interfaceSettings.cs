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
	public partial class interfaceSettings : Form
	{
		public interfaceSettings()
		{
			InitializeComponent();
		}

		private void interfaceSettings_Load(object sender, EventArgs e)
		{
			lblAppearance.Visible = false;
			lblAccDetails.Visible = false;
			lblAboutiNote.Visible = false;


			about1.Visible = false;
			accountDets1.Visible = false;
			editorApperance1.Visible = false;
			workSpace1.Visible = false;

			lblGeneral.Text = "► General";

			lblGeneral.Location = new Point(10, 72);
			lblWorkspace.Location = new Point(10, 104);
			lblSettings.Location = new Point(10, 140);
			lblNew1.Location = new Point(10, 170);
			lblNew2.Location = new Point(10, 204);
			lblNew3.Location = new Point(10, 241);
			lblNew4.Location = new Point(10, 276);
			lblNew5.Location = new Point(10, 313);
		}

		private void lblGeneral_Click(object sender, EventArgs e)
		{			

			if (lblGeneral.Text == "► General"){
				lblGeneral.Text = "▼ General";

				lblAppearance.Visible = true;
				lblAccDetails.Visible = true;
				lblAboutiNote.Visible = true;


				lblWorkspace.Location = new Point(10, 176);
				lblSettings.Location = new Point(10, 212);
				lblNew1.Location = new Point(10, 247);
				lblNew2.Location = new Point(10, 281);
				lblNew3.Location = new Point(10, 318);
				lblNew4.Location = new Point(10, 353);
				lblNew5.Location = new Point(10, 390);
			} else
			{
				lblAppearance.Visible = false;
				lblAccDetails.Visible = false;
				lblAboutiNote.Visible = false;			

				lblGeneral.Text = "► General";

				lblGeneral.Location = new Point(10, 72);
				lblWorkspace.Location = new Point(10, 104);
				lblSettings.Location = new Point(10, 140);
				lblNew1.Location = new Point(10, 170);
				lblNew2.Location = new Point(10, 204);
				lblNew3.Location = new Point(10, 241);
				lblNew4.Location = new Point(10, 276);
				lblNew5.Location = new Point(10, 313);
			}

			
		}

		private void lblGeneral_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblGeneral_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblAppearance_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblAppearance_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblAccDetails_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblAccDetails_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblAboutiNote_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblAboutiNote_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblWorkspace_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblWorkspace_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblSettings_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblSettings_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblNew1_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblNew1_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblNew2_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblNew2_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblNew3_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		private void lblNew3_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		private void lblAppearance_Click(object sender, EventArgs e)
		{
			accountDets1.Visible = false;
			about1.Visible = false;
			editorApperance1.Visible = true;
			workSpace1.Visible = false;
		}

		private void lblAccDetails_Click(object sender, EventArgs e)
		{
			accountDets1.Visible = true;
			about1.Visible = false;
			editorApperance1.Visible = false;
			workSpace1.Visible = false;
		}

		private void lblAboutiNote_Click(object sender, EventArgs e)
		{
			accountDets1.Visible = false;
			about1.Visible = true;
			editorApperance1.Visible = false;
			workSpace1.Visible = false;
		}
		
		private void lblWorkspace_Click(object sender, EventArgs e)
		{
			workSpace1.Visible = true;
		}
	}
}
