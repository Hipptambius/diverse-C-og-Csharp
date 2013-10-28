using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opg58_forhojtforlavt
    //lavet af Jimmy schach
{
    public partial class Form1 : Form
    {
        FHFL forhojtforlavt;
        int it;
        public Form1()
        {
            InitializeComponent();
           
            forhojtforlavt = new FHFL(button1, textBox1, it);
            

        }
        public class FHFL 
        {
            Random R = new Random();
            Button AA;
            TextBox BB;
            int tal1;
            int r;
            int i;
            public FHFL(Button a, TextBox b,int tal)
            {
                tal1 = tal;
                r = R.Next(tal1);
                BB = b;
                AA = a;
                AA.Click += AA_Click;
                

            }

            public void AA_Click(object sender, EventArgs e)
            {
                i = Convert.ToInt32(BB.Text);
              
                if (r > i)
                {
                    AA.Text = "FOR LAVT";
                }
                if (r < i)
                {
                    AA.Text = "FOR HØJT";
                }
                if (r == i)
                {
                    AA.Text = "Rigtigt gættet";
                    start();
                }
            }
            public void start()
            {
                r = R.Next(tal1);
                AA.Text = "Nyt spil";
            }

        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                forhojtforlavt.AA_Click(sender, e);
                textBox1.Clear();
            }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           it = Convert.ToInt32(textBox2.Text);
           forhojtforlavt = new FHFL(button1, textBox1, it);
        }


    }
}
