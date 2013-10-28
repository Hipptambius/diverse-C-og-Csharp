using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        Random tilfældig = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = tilfældig.Next(100).ToString();
            if (checkBox1.Checked == true)
            {
                
                if (button1.Text == "SQUEEZE ME!")
                {




                    Thread.Sleep(100);
                    progressBar1.Value = 0;
                    Thread.Sleep(100);
                    progressBar1.Value = 10;
                    Thread.Sleep(100);
                    progressBar1.Value = 20;
                    Thread.Sleep(100);
                    progressBar1.Value = 30;
                    Thread.Sleep(100);
                    progressBar1.Value = 40;
                    Thread.Sleep(100);
                    progressBar1.Value = 50;
                    Thread.Sleep(100);
                    progressBar1.Value = 60;
                    Thread.Sleep(100);
                    progressBar1.Value = 70;
                    Thread.Sleep(100);
                    progressBar1.Value = 80;
                    Thread.Sleep(100);
                    progressBar1.Value = 90;
                    Thread.Sleep(100);
                    button1.BackColor = Color.MediumAquamarine;
                    button1.Text = "Farvel!";
                    progressBar1.Value = 100;
                    Thread.Sleep(100);
                    label1.Text = "c: Formatted, u are now fucked!";
                    Thread.Sleep(100);
                }
                else
                {
                    progressBar1.Value = 0;
                    button1.BackColor = Color.Transparent;
                    button1.Text = "SQUEEZE ME!";
                    label1.Font = new System.Drawing.Font("Wide Latin", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label1.Text = "format c:?";
                }
            }
                if (checkBox2.Checked == true)
                {
                    Process.Start("firefox.exe", "http://www.google.com");
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "c: Formatting!";
                label1.Font = new System.Drawing.Font("Wide Latin", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
