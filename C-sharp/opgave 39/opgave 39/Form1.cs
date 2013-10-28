using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opgave_39
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }
        public class Bold : PictureBox
        {


            int x = 0;
            int y = 0;
            int a = 1;
            int b = 1;
            public Bold() //konstruktor
            {
                //random generator, og sætter x og y akse til random på den nye picturebox
                Random R = new Random();
                x = R.Next(400);
                y = R.Next(400);
                // opretter en ny picturebox
                PictureBox picturebox1 = new PictureBox();
                this.Controls.Add(picturebox1);
                this.BackColor = System.Drawing.Color.Transparent;
                this.Image = global::opgave_39.Properties.Resources.pic_det_belgiske_oel_forside;
                this.Location = new Point(x, y);
                this.Size = new System.Drawing.Size(83, 55);
                this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                

                Timer T = new Timer();//laver en timer der hedder "T"   
            
                //definere timer("T") instillinger
                T.Tick += T_Tick;
                T.Interval = 1;
                T.Start();
            }
                public void T_Tick(object sender, EventArgs e)
                {
           

                    this.Location = new Point(x, y);

                    // x
                    if (x > Parent.ClientSize.Width - this.Width)
                    {
                        a = -1;
                    }
                    if (x < 1)
                    {                
                        a = 1;
                    }
                    // y
                    if (y > Parent.ClientSize.Height - this.Height)
                    {
                        b = -1;
                    }
                    if (y < 1)
                    {
                        b = 1;
                    }

                    x = x + a;
                    y = y + b; 
            
               }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bold B = new Bold();
            this.Controls.Add(B);
        }
        
    }
}
