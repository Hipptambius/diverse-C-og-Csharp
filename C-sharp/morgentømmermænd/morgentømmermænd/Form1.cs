using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace morgentømmermænd
{
    public partial class Form1 : Form
    {
        Int32 antal = 0;
        Int32 vægt = 0;
        Label label4 = new System.Windows.Forms.Label();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true && checkBox2.Checked == true) //printer en fejlbesked hvis begge
                                                                        //boxe er "checked"
            {
                this.Controls.Add (label4);
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(110, 218);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(35, 13);
                this.label4.TabIndex = 10;
                this.label4.Text = "Vælg MAND eller KVINDE";
                this.label4.Click += new System.EventHandler(this.label4_Click);

            }
            if (checkBox1.Checked == false && checkBox2.Checked == false) // samme bare boxe ikke er
            {
                this.Controls.Add(label4);
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(110, 218);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(35, 13);
                this.label4.TabIndex = 10;
                this.label4.Text = "Vælg MAND eller KVINDE";
                this.label4.Click += new System.EventHandler(this.label4_Click);

            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                this.Controls.Remove(label4); //selve beregningen
               antal = Convert.ToInt32(textBox1.Text);
               vægt = Convert.ToInt32(textBox2.Text);
               double result = ((antal*12) / (vægt * 0.68));
               textBox3.Text = Convert.ToString(result);
               if (result > 0.51)
               {
                   double timer = Convert.ToDouble(textBox4.Text); //time beregning
                   button1.BackColor = Color.Red;
                   button1.Text = "VENT";
                   double result2 = result - (timer * 0.15);
                   MessageBox.Show("din promille er " + Convert.ToString(result2) + " efter " + textBox4.Text + " timer");
               }
               else
               {
                   button1.BackColor = Color.LimeGreen;
                   button1.Text = "KØR";
               }
            }
            if (checkBox2.Checked == true && checkBox1.Checked == false)
            {
                this.Controls.Remove(label4); //samme bare med den anden checkbox
                antal = Convert.ToInt32(textBox1.Text);
                vægt = Convert.ToInt32(textBox2.Text);
                double result = ((antal*12) / (vægt * 0.55));
                textBox3.Text = Convert.ToString(result);
                if (result > 0.51)
                {
                    double timer = Convert.ToDouble(textBox4.Text); //time beregning            
                    button1.BackColor = Color.Red;
                    button1.Text = "VENT";
                    double result2 = result - (timer * 0.15);                    
                    MessageBox.Show("din promille er "+Convert.ToString(result2)+" efter "+textBox4.Text+" timer");
                }
                else
                {
                    button1.BackColor = Color.LimeGreen;
                    button1.Text = "KØR";
                }
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // så man kan trykke "enter" i stedet for 
                                         // at skulle trykke på knappen
            {
                button1_Click(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }

        private void label2_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // citat på den lange måde
            string M = "people falling";
            string C2 = "you can´t love";
            string E = "blame gravity";
            E = C2.Substring(0, 10) + E; //starter fra 0 og tager de næste 10 karaktere
            C2 = C2.Substring(10, 04); // starter fra 10 og tager de næste 4 karaktere
            MessageBox.Show(E + " for " + M + " - in " + C2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void label3_Click(object sender, EventArgs e)
        {
   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
