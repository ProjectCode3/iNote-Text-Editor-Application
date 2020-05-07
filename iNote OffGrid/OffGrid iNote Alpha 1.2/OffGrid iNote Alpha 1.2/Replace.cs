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
	public partial class Replace : Form
	{
		public Replace()
		{
			InitializeComponent();
		}

        private void btnFind_Click(object sender, EventArgs e)
        {
            Interface iface = new Interface();
            string[] words = txtFindWord.Text.Split(',');

            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < iface.txtTextArea.TextLength)
                {
                    int wordstartIndex = iface.txtTextArea.Find(word, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        iface.txtTextArea.SelectionStart = wordstartIndex;
                        iface.txtTextArea.SelectionLength = word.Length;
                        iface.txtTextArea.SelectionBackColor = Color.Yellow;
                        Properties.Config.Default.Find_Word = words.ToString();
                        Properties.Config.Default.Save();
                    }
                    else
                        break;
                    startIndex += wordstartIndex + word.Length;
                }
            }
        }
	}
}
