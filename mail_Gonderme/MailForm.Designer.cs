namespace mail_Gonderme
{
    partial class MailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MailGonderbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.e_mailEklebtn = new System.Windows.Forms.Button();
            this.e_mailSilbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dosyaEklebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MailGonderbtn
            // 
            this.MailGonderbtn.BackColor = System.Drawing.Color.DarkGray;
            this.MailGonderbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.MailGonderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MailGonderbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailGonderbtn.Location = new System.Drawing.Point(16, 232);
            this.MailGonderbtn.Name = "MailGonderbtn";
            this.MailGonderbtn.Size = new System.Drawing.Size(122, 36);
            this.MailGonderbtn.TabIndex = 0;
            this.MailGonderbtn.Text = "Mail Gönder";
            this.MailGonderbtn.UseVisualStyleBackColor = false;
            this.MailGonderbtn.Click += new System.EventHandler(this.MailGonderbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesaj İçeriği :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Başlık :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(423, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 77);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 132);
            this.textBox3.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(332, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 134);
            this.listBox1.TabIndex = 7;
            // 
            // e_mailEklebtn
            // 
            this.e_mailEklebtn.BackColor = System.Drawing.Color.DarkGray;
            this.e_mailEklebtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.e_mailEklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_mailEklebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e_mailEklebtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.e_mailEklebtn.Location = new System.Drawing.Point(348, 231);
            this.e_mailEklebtn.Name = "e_mailEklebtn";
            this.e_mailEklebtn.Size = new System.Drawing.Size(119, 37);
            this.e_mailEklebtn.TabIndex = 8;
            this.e_mailEklebtn.Text = "Ekle";
            this.e_mailEklebtn.UseVisualStyleBackColor = false;
            this.e_mailEklebtn.Click += new System.EventHandler(this.e_mailEklebtn_Click);
            // 
            // e_mailSilbtn
            // 
            this.e_mailSilbtn.BackColor = System.Drawing.Color.DarkGray;
            this.e_mailSilbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.e_mailSilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.e_mailSilbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e_mailSilbtn.ForeColor = System.Drawing.Color.Maroon;
            this.e_mailSilbtn.Location = new System.Drawing.Point(493, 231);
            this.e_mailSilbtn.Name = "e_mailSilbtn";
            this.e_mailSilbtn.Size = new System.Drawing.Size(113, 37);
            this.e_mailSilbtn.TabIndex = 9;
            this.e_mailSilbtn.Text = "Sil";
            this.e_mailSilbtn.UseVisualStyleBackColor = false;
            this.e_mailSilbtn.Click += new System.EventHandler(this.e_mailSilbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaEklebtn
            // 
            this.dosyaEklebtn.BackColor = System.Drawing.Color.DarkGray;
            this.dosyaEklebtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.dosyaEklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dosyaEklebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaEklebtn.Location = new System.Drawing.Point(188, 232);
            this.dosyaEklebtn.Name = "dosyaEklebtn";
            this.dosyaEklebtn.Size = new System.Drawing.Size(122, 36);
            this.dosyaEklebtn.TabIndex = 10;
            this.dosyaEklebtn.Text = "Dosya Ekle";
            this.dosyaEklebtn.UseVisualStyleBackColor = false;
            this.dosyaEklebtn.Click += new System.EventHandler(this.dosyaEklebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(328, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yeni Alıcı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*alıcıyı listeden çıkarmak için alıcıyı seçip sil butonuna tıklayın";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(559, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "@gmail.com";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dosyaEklebtn);
            this.Controls.Add(this.e_mailSilbtn);
            this.Controls.Add(this.e_mailEklebtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MailGonderbtn);
            this.Name = "MailForm";
            this.Text = "Mail gönderme sayfası";
            this.Load += new System.EventHandler(this.mail_gonderme_egitim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MailGonderbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button e_mailEklebtn;
        private System.Windows.Forms.Button e_mailSilbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button dosyaEklebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}