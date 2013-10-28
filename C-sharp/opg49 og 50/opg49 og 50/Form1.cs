using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opg49_og_50
{
    public partial class Form1 : Form
    {
        minliste L = new minliste(); //laver et object af minliste kaldet "L"
        public Form1()
        {
            InitializeComponent();
            
            this.Controls.Add(L); //viser "L" som gui
            
           
            
            
            
        }
        public class minliste : ListBox //class jeg har lavet som indeholder metoden til at tilføje til listen "L"
        {
            public void plus(string line) //metode der tilføjer en linje til listen "L" med parameteren "line"
            {                             
                this.Items.Add(line);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            L.plus(textBox1.Text); //kalder metoden til at føje linje til listen, med parameteret fra textbox1
            
        }
    }
}
