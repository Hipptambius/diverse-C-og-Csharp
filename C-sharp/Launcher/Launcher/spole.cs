using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luftspole_beregner
{
    public partial class Form1 : Form
    {

        double temp;
        double D;
        double N;
        double L;
        double R;
        int x = 0;
        
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Loop der sikre at der er 3 felter udfyldt
            x = 0;
            if(n.Text == string.Empty)
            {
                x = x+1;
            }
            if(l.Text == string.Empty)
            {
                x = x+1;
            }
            if(d.Text == string.Empty)
            {
                x = x+1;
            }
            if(res.Text == string.Empty)
            {
                x = x+1;
            }




            if (x == 1)
            {

                if (n.Text == string.Empty) //bregner antal vindinger
                {
                    R = Convert.ToDouble(res.Text);
                    L = Convert.ToDouble(l.Text);
                    D = Convert.ToDouble(d.Text);
                    temp = 10 * Math.Sqrt(.43 * D + L) * Math.Sqrt(R) / D;
                    n.Text = temp.ToString("f4");
                }
                if (l.Text == string.Empty) //beregner længde
                {
                    R = Convert.ToDouble(res.Text);
                    N = Convert.ToDouble(n.Text);
                    D = Convert.ToDouble(d.Text);
                    temp = D * D * N * N / (100 * R) - 0.43 * D;
                    l.Text = temp.ToString("f4");
                }
                if (d.Text == string.Empty) //bregner diameter
                {
                    R = Convert.ToDouble(res.Text);
                    N = Convert.ToDouble(n.Text);
                    L = Convert.ToDouble(l.Text);
                    temp = (43 * R + Math.Sqrt(1849 * R * R + 400 * N * N * R * L)) / (2 * N * N);
                    d.Text = temp.ToString("f4");
                }
                if (res.Text == string.Empty) //beregner spolens værdi i µH
                {
                    D = Convert.ToDouble(d.Text);
                    N = Convert.ToDouble(n.Text);
                    L = Convert.ToDouble(l.Text);
                    temp = (D * (N * N)) / (((L / D) + 0.43) * 100);
                    res.Text = temp.ToString("f4");
                }
            }
            else
            {
                MessageBox.Show("FEJL I INDTASTNING \r\nUdfyld 3 af felterne!");
            }
            
            
        }
    }
}
