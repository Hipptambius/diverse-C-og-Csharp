using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace temp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            minknap knap1 = new minknap();
            this.Controls.Add(knap1);
            knap1.velkommen();
            
            
        }

        public class minknap : Button
        {
            public int Tæller { get; set; }

            public void velkommen()
            {
                Tæller++;
                this.Text = "Velkommen";
            }
        }
    }
}
