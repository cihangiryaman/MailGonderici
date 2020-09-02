using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mail_Gonderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string DosyaYolu;
        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            string kime = textBox1.Text;
            string konu = textBox2.Text;
            string icerik = textBox3.Text;

            sc.Credentials = new NetworkCredential("cihangiryaman3200@gmail.com", "cihangir12345");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("cihangiryaman3200@gmail.com", "Cihangir Yaman");
            //mail.To.Add(kime);
            mail.To.Add("cihanyama.cy@gmail.com");
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            mail.Attachments.Add(new Attachment(DosyaYolu));
            sc.Send(mail);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "www.yazilimkodlama.com";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
            label3.Text = "Dosya Eklendi";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
