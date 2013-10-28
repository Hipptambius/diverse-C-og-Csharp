using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace mail_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
            

            
        }
        public void succes()
        {            
            System.Media.SoundPlayer p = new System.Media.SoundPlayer();
            p.SoundLocation = @"C:\Users\Jimmy\Desktop\Arbejde-programmering\projects\C-sharp\succes.wav";
            p.Play();
            MessageBox.Show("Messege Sent");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            string sub = "NILL";
            string res = "NILL";
            string body = "NILL";
            sub = textBox3.Text;
            res = textBox2.Text;
            body = textBox1.Text;
            SmtpClient SMTP = new SmtpClient("smtp.gmail.com");
            SMTP.Port = 587;
            SMTP.EnableSsl = true;
            SMTP.UseDefaultCredentials = false;           
            SMTP.Credentials = new NetworkCredential("shapri.dk@gmail.com", "wYyg7ANyER");
            SMTP.Send("shapri.dk@gmail.com", res, sub, body);
            succes();
        }
    }
}
