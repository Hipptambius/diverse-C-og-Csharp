using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RS232_InOut2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            SerialPort COM4 = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            COM4.Open();
            COM4.Write("Velkommen");
            COM4.DataReceived += COM4_DataReceived;

            
        }

        void COM4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show("I have recieved data");
        }
        
    }
}
