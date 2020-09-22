using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Net.Mail;
using System.Windows.Forms;

namespace mail_Gonderme
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void mail_gonderme_egitim_Load(object sender, EventArgs e)
        {
         
        }

        string dosyaYolu;
        bool dosyaDolu = false;

        private void MailGonderbtn_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            MailAdresiKontrolu mailAdresiKontrolu_class = new MailAdresiKontrolu();

            List<string> listboxItems = new List<string>();

            try
            {
                foreach (string emailAdres in listBox1.Items)
                {
                    listboxItems.Add(emailAdres);
                }

                if (mailAdresiKontrolu_class.MailAdresKontrolu(listboxItems))
                {
                    istemci.Credentials = new System.Net.NetworkCredential("cihanyama.cy@gmail.com", "cihangir12345");
                    istemci.Port = 587;
                    istemci.Host = "smtp.gmail.com";
                    istemci.EnableSsl = true;
                    foreach (string e_mailAdresi in listBox1.Items)
                    {
                        mail.To.Add(e_mailAdresi);
                    }
                    mail.IsBodyHtml = true;
                    mail.From = new MailAddress("cihanyama.cy@gmail.com");
                    mail.Subject = textBox2.Text;
                    mail.Body = textBox3.Text;
                    if (dosyaDolu)
                    {
                        Attachment attachment = new Attachment(dosyaYolu);
                        mail.Attachments.Add(attachment);
                    }
                    string htmlBody;
                    htmlBody = mail.Body;
                    mail.Body = htmlBody;
                    while (listBox1.Items == null)
                    {
                        MessageBox.Show("en az bir alıcı e-posta adresi girmelisiniz ", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    istemci.Send(mail);

                    MessageBox.Show("Mesaj Gönderildi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alıcı e-posta adreslerinin tamamının doğru olduğundan emin olun ", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("bir hata oluştu hatanın kaynağı :" + ex, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void e_mailEklebtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void e_mailSilbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void dosyaEklebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "ofd.";
            dosya.ShowDialog();
            if (dosya.FileName == null)
            {
                dosyaDolu = false;
            }
            else
            {
                dosyaYolu = dosya.FileName;
                dosyaDolu = true;
            }
        }
    }
}
