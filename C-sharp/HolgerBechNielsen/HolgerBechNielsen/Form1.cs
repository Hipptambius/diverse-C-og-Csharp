using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HolgerBechNielsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //opretter 10 knapper
            for (int i = 0; i < 10; i++)
            {
                Button button1 = new Button();
                button1.Location = new Point(i * 20, i * 20);
                button1.Text = "knap nr" + i;
                button1.Click += button1_Click;
                this.Controls.Add(button1);
            }



        }

        void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
