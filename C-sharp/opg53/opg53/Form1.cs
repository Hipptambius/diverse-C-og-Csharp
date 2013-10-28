using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opg53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Matematik minklasse = new Matematik();
            // double x = minklasse.Sinus(22);
            // MessageBox.Show(x.ToString());
        }
    }
    public class Matematik
    {

        public Matematik()
        {
            MessageBox.Show("Test");
        }

        public double Sinus(double x)
        {
            return Math.Sin(x);
        }
    }
}
