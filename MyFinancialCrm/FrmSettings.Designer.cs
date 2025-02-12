namespace MyFinancialCrm
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpdateUserAndPassword = new System.Windows.Forms.Button();
            this.txtUserPasswordUpdateAndRemove = new System.Windows.Forms.TextBox();
            this.txtUserNameUpdateAndRemove = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ayarlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(130, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilgilendirme !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bu Ekrandan Sadece Kullanıcı Bilgileri İle İlgili Ayarlara Erişebilirsiniz.\r\nDaha" +
    " Fazlası İçin Lütfen Bankanızın Müşteri Temsilcisiyle İletişime Geçin";
            // 
            // BtnUpdateUserAndPassword
            // 
            this.BtnUpdateUserAndPassword.Location = new System.Drawing.Point(134, 107);
            this.BtnUpdateUserAndPassword.Name = "BtnUpdateUserAndPassword";
            this.BtnUpdateUserAndPassword.Size = new System.Drawing.Size(118, 23);
            this.BtnUpdateUserAndPassword.TabIndex = 17;
            this.BtnUpdateUserAndPassword.Text = "Güncelle";
            this.BtnUpdateUserAndPassword.UseVisualStyleBackColor = true;
            this.BtnUpdateUserAndPassword.Click += new System.EventHandler(this.BtnUpdateUserAndPassword_Click_1);
            // 
            // txtUserPasswordUpdateAndRemove
            // 
            this.txtUserPasswordUpdateAndRemove.Location = new System.Drawing.Point(134, 81);
            this.txtUserPasswordUpdateAndRemove.Name = "txtUserPasswordUpdateAndRemove";
            this.txtUserPasswordUpdateAndRemove.Size = new System.Drawing.Size(118, 20);
            this.txtUserPasswordUpdateAndRemove.TabIndex = 15;
            this.txtUserPasswordUpdateAndRemove.UseSystemPasswordChar = true;
            // 
            // txtUserNameUpdateAndRemove
            // 
            this.txtUserNameUpdateAndRemove.Location = new System.Drawing.Point(134, 55);
            this.txtUserNameUpdateAndRemove.Name = "txtUserNameUpdateAndRemove";
            this.txtUserNameUpdateAndRemove.Size = new System.Drawing.Size(118, 20);
            this.txtUserNameUpdateAndRemove.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Location = new System.Drawing.Point(134, 136);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveAccount.TabIndex = 17;
            this.btnRemoveAccount.Text = "Hesabımı Sil";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemovaAccount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(37, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hesap Silmenin Geri Dönüşü Olmaz !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Geri Dön";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hesabı Silmek İçin Kullanıcı Adı Ve Şifrenizi\r\nDoğrulayın Ardından Hesabımı Sil B" +
    "utonuna Basın.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Güncellemek için Yeni Kullanıcı Adınızı Ve\r\nYeni Şifrenizi Girip Güncelle Butonun" +
    "a Basın.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.LawnGreen;
            this.label10.Location = new System.Drawing.Point(37, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = ">";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.LawnGreen;
            this.label11.Location = new System.Drawing.Point(37, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = ">";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(362, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemoveAccount);
            this.Controls.Add(this.BtnUpdateUserAndPassword);
            this.Controls.Add(this.txtUserPasswordUpdateAndRemove);
            this.Controls.Add(this.txtUserNameUpdateAndRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdateUserAndPassword;
        private System.Windows.Forms.TextBox txtUserPasswordUpdateAndRemove;
        private System.Windows.Forms.TextBox txtUserNameUpdateAndRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}