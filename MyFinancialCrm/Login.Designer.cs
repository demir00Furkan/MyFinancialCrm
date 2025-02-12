namespace MyFinancialCrm
{
    partial class Login
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserPasswordSignUpVerify = new System.Windows.Forms.TextBox();
            this.txtUserNameSignUp = new System.Windows.Forms.TextBox();
            this.txtUserPasswordSignUp = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserPasswordSignIn = new System.Windows.Forms.TextBox();
            this.txtUserNameSignIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(112, 332);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(118, 23);
            this.btnSignUp.TabIndex = 21;
            this.btnSignUp.Text = "Üye Ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifreyi Tekrar Giriniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Şifre:";
            // 
            // txtUserPasswordSignUpVerify
            // 
            this.txtUserPasswordSignUpVerify.Location = new System.Drawing.Point(112, 306);
            this.txtUserPasswordSignUpVerify.Name = "txtUserPasswordSignUpVerify";
            this.txtUserPasswordSignUpVerify.Size = new System.Drawing.Size(118, 20);
            this.txtUserPasswordSignUpVerify.TabIndex = 15;
            this.txtUserPasswordSignUpVerify.UseSystemPasswordChar = true;
            // 
            // txtUserNameSignUp
            // 
            this.txtUserNameSignUp.Location = new System.Drawing.Point(112, 254);
            this.txtUserNameSignUp.Name = "txtUserNameSignUp";
            this.txtUserNameSignUp.Size = new System.Drawing.Size(118, 20);
            this.txtUserNameSignUp.TabIndex = 16;
            // 
            // txtUserPasswordSignUp
            // 
            this.txtUserPasswordSignUp.Location = new System.Drawing.Point(112, 280);
            this.txtUserPasswordSignUp.Name = "txtUserPasswordSignUp";
            this.txtUserPasswordSignUp.Size = new System.Drawing.Size(118, 20);
            this.txtUserPasswordSignUp.TabIndex = 17;
            this.txtUserPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.Location = new System.Drawing.Point(115, 145);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(118, 23);
            this.BtnSignIn.TabIndex = 14;
            this.BtnSignIn.Text = "Giriş Yap";
            this.BtnSignIn.UseVisualStyleBackColor = true;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(105, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 39);
            this.label8.TabIndex = 11;
            this.label8.Text = "Üye Ol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(123, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtUserPasswordSignIn
            // 
            this.txtUserPasswordSignIn.Location = new System.Drawing.Point(115, 100);
            this.txtUserPasswordSignIn.Name = "txtUserPasswordSignIn";
            this.txtUserPasswordSignIn.Size = new System.Drawing.Size(118, 20);
            this.txtUserPasswordSignIn.TabIndex = 8;
            this.txtUserPasswordSignIn.UseSystemPasswordChar = true;
            // 
            // txtUserNameSignIn
            // 
            this.txtUserNameSignIn.Location = new System.Drawing.Point(115, 74);
            this.txtUserNameSignIn.Name = "txtUserNameSignIn";
            this.txtUserNameSignIn.Size = new System.Drawing.Size(118, 20);
            this.txtUserNameSignIn.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 371);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserPasswordSignUpVerify);
            this.Controls.Add(this.txtUserNameSignUp);
            this.Controls.Add(this.txtUserPasswordSignUp);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserPasswordSignIn);
            this.Controls.Add(this.txtUserNameSignIn);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login And Register";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserPasswordSignUpVerify;
        private System.Windows.Forms.TextBox txtUserNameSignUp;
        private System.Windows.Forms.TextBox txtUserPasswordSignUp;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserPasswordSignIn;
        private System.Windows.Forms.TextBox txtUserNameSignIn;
    }
}