using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // added to access "process.start"

namespace opg48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region METHODS & EVENTS
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // mboxes
        {
            MessageBox.Show("BEKLAGER, DER ER IKKE MERE KAFFE!");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BEKLAGER DER ER IKKE MERE KAGE");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DER ER INGEN IS...");
        }

        private void gOOGLEToolStripMenuItem_Click(object sender, EventArgs e) //launch iexplore @ google.com
        {
            Process.Start("firefox.exe", "www.google.com");
        }
        #endregion
        #region PROPERTIES
        private void sKIFTBAGRUNDToolStripMenuItem_Click(object sender, EventArgs e) //change background color
        {
            if (this.BackColor == Color.WhiteSmoke)
            {
                this.BackColor = Color.AntiqueWhite;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        #endregion
        }

    }
}
