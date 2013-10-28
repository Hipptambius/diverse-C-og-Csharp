using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sammenhæng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bold B = new Bold();
            B.DingDong += B_DingDong; 
            B.fontsize = 18; // set fontsize            
            button1.Font = new Font("Times New Roman",B.fontsize);
            
            
        }

        void B_DingDong()
        {
            MessageBox.Show("du har ændre størelsen");
        }
        public class Bold : Button
        {
            float size = 14;
            public delegate void klokkenerhel();
            public event klokkenerhel DingDong;
            public void start()
            {
                
            }
         
            public float fontsize 
            {
                get { return size; }
                set 
                { 
                    size = value;
                    DingDong();
                }
            }

        }
    }
}
