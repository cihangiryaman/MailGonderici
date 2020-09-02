using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mail_Gonderme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("cihangiryaman3@gmail.com");
            mesaj.To.Add("cihangiryaman3200@gmail.com");
            mesaj.Subject = textBox2.Text;
            mesaj.Body = richTextBox1.Text;
            SmtpClient rc = new SmtpClient();
            // Gönderenin eposta giriş bilgileri
            rc.Credentials = new System.Net.NetworkCredential("cihangiryaman3@gmail.com", "cihangir12345");
            rc.Port = 587;
            rc.Host = "smtp.gmail.com";
            rc.EnableSsl = true;
            object userState = mesaj;
            bool kontrol = true;
            try
            {
                rc.SendAsync(mesaj, (object)mesaj);
                MessageBox.Show("Mesaj Gönderilmiştir");
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }


        }
    }
}
