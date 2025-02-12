namespace MyFinancialCrm
{
    partial class FrmSpendings
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
            this.btnBankaHareketleri = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnUpdateSpendings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnRemoveSpendings = new System.Windows.Forms.Button();
            this.btnCreateSpendings = new System.Windows.Forms.Button();
            this.btnListSpendings = new System.Windows.Forms.Button();
            this.txtSpendingsAmount = new System.Windows.Forms.TextBox();
            this.txtSpendingsTitle = new System.Windows.Forms.TextBox();
            this.txtSpendingsId = new System.Windows.Forms.TextBox();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.btnBankalar = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSpendingsPeriyot = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBankaHareketleri
            // 
            this.btnBankaHareketleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankaHareketleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaHareketleri.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankaHareketleri.Location = new System.Drawing.Point(37, 157);
            this.btnBankaHareketleri.Name = "btnBankaHareketleri";
            this.btnBankaHareketleri.Size = new System.Drawing.Size(148, 28);
            this.btnBankaHareketleri.TabIndex = 1;
            this.btnBankaHareketleri.Text = "Banka Hareketleri";
            this.btnBankaHareketleri.UseVisualStyleBackColor = true;
            this.btnBankaHareketleri.Click += new System.EventHandler(this.btnBankaHareketleri_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturalar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFaturalar.Location = new System.Drawing.Point(37, 89);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(148, 28);
            this.btnFaturalar.TabIndex = 1;
            this.btnFaturalar.Text = "Faturalar";
            this.btnFaturalar.UseVisualStyleBackColor = true;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // btnUpdateSpendings
            // 
            this.btnUpdateSpendings.Location = new System.Drawing.Point(459, 178);
            this.btnUpdateSpendings.Name = "btnUpdateSpendings";
            this.btnUpdateSpendings.Size = new System.Drawing.Size(108, 29);
            this.btnUpdateSpendings.TabIndex = 2;
            this.btnUpdateSpendings.Text = "Gider Güncelle";
            this.btnUpdateSpendings.UseVisualStyleBackColor = true;
            this.btnUpdateSpendings.Click += new System.EventHandler(this.btnUpdateSpendings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(37, 191);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(148, 28);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnRemoveSpendings
            // 
            this.btnRemoveSpendings.Location = new System.Drawing.Point(345, 178);
            this.btnRemoveSpendings.Name = "btnRemoveSpendings";
            this.btnRemoveSpendings.Size = new System.Drawing.Size(108, 29);
            this.btnRemoveSpendings.TabIndex = 2;
            this.btnRemoveSpendings.Text = "Gider Sil";
            this.btnRemoveSpendings.UseVisualStyleBackColor = true;
            this.btnRemoveSpendings.Click += new System.EventHandler(this.btnRemoveSpendings_Click);
            // 
            // btnCreateSpendings
            // 
            this.btnCreateSpendings.Location = new System.Drawing.Point(231, 178);
            this.btnCreateSpendings.Name = "btnCreateSpendings";
            this.btnCreateSpendings.Size = new System.Drawing.Size(108, 29);
            this.btnCreateSpendings.TabIndex = 2;
            this.btnCreateSpendings.Text = "Yeni Gider";
            this.btnCreateSpendings.UseVisualStyleBackColor = true;
            this.btnCreateSpendings.Click += new System.EventHandler(this.btnCreateSpendings_Click);
            // 
            // btnListSpendings
            // 
            this.btnListSpendings.Location = new System.Drawing.Point(117, 178);
            this.btnListSpendings.Name = "btnListSpendings";
            this.btnListSpendings.Size = new System.Drawing.Size(108, 29);
            this.btnListSpendings.TabIndex = 2;
            this.btnListSpendings.Text = "Gider Listesi";
            this.btnListSpendings.UseVisualStyleBackColor = true;
            this.btnListSpendings.Click += new System.EventHandler(this.btnListSpendings_Click);
            // 
            // txtSpendingsAmount
            // 
            this.txtSpendingsAmount.BackColor = System.Drawing.Color.Moccasin;
            this.txtSpendingsAmount.Location = new System.Drawing.Point(103, 91);
            this.txtSpendingsAmount.Name = "txtSpendingsAmount";
            this.txtSpendingsAmount.Size = new System.Drawing.Size(481, 20);
            this.txtSpendingsAmount.TabIndex = 1;
            // 
            // txtSpendingsTitle
            // 
            this.txtSpendingsTitle.BackColor = System.Drawing.Color.Moccasin;
            this.txtSpendingsTitle.Location = new System.Drawing.Point(103, 57);
            this.txtSpendingsTitle.Name = "txtSpendingsTitle";
            this.txtSpendingsTitle.Size = new System.Drawing.Size(481, 20);
            this.txtSpendingsTitle.TabIndex = 1;
            // 
            // txtSpendingsId
            // 
            this.txtSpendingsId.BackColor = System.Drawing.Color.Moccasin;
            this.txtSpendingsId.Location = new System.Drawing.Point(103, 23);
            this.txtSpendingsId.Name = "txtSpendingsId";
            this.txtSpendingsId.Size = new System.Drawing.Size(481, 20);
            this.txtSpendingsId.TabIndex = 1;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ForeColor = System.Drawing.Color.Transparent;
            this.btnCikisYap.Location = new System.Drawing.Point(37, 259);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(148, 28);
            this.btnCikisYap.TabIndex = 1;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.Location = new System.Drawing.Point(37, 225);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(148, 28);
            this.btnAyarlar.TabIndex = 1;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCikisYap);
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankaHareketleri);
            this.panel1.Controls.Add(this.btnGiderler);
            this.panel1.Controls.Add(this.btnFaturalar);
            this.panel1.Controls.Add(this.btnBankalar);
            this.panel1.Controls.Add(this.btnKategoriler);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 450);
            this.panel1.TabIndex = 7;
            // 
            // btnGiderler
            // 
            this.btnGiderler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiderler.Location = new System.Drawing.Point(37, 123);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(148, 28);
            this.btnGiderler.TabIndex = 1;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // btnBankalar
            // 
            this.btnBankalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankalar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankalar.Location = new System.Drawing.Point(37, 55);
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.Size = new System.Drawing.Size(148, 28);
            this.btnBankalar.TabIndex = 1;
            this.btnBankalar.Text = "Bankalar";
            this.btnBankalar.UseVisualStyleBackColor = true;
            this.btnBankalar.Click += new System.EventHandler(this.btnBankalar_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.Transparent;
            this.btnKategoriler.Location = new System.Drawing.Point(37, 21);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(148, 28);
            this.btnKategoriler.TabIndex = 1;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Periyot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlık:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gider Id:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(202, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 191);
            this.panel3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateSpendings);
            this.panel2.Controls.Add(this.btnRemoveSpendings);
            this.panel2.Controls.Add(this.btnCreateSpendings);
            this.panel2.Controls.Add(this.btnListSpendings);
            this.panel2.Controls.Add(this.txtSpendingsPeriyot);
            this.panel2.Controls.Add(this.txtSpendingsAmount);
            this.panel2.Controls.Add(this.txtSpendingsTitle);
            this.panel2.Controls.Add(this.txtSpendingsId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 253);
            this.panel2.TabIndex = 8;
            // 
            // txtSpendingsPeriyot
            // 
            this.txtSpendingsPeriyot.BackColor = System.Drawing.Color.Moccasin;
            this.txtSpendingsPeriyot.Location = new System.Drawing.Point(103, 125);
            this.txtSpendingsPeriyot.Name = "txtSpendingsPeriyot";
            this.txtSpendingsPeriyot.Size = new System.Drawing.Size(481, 20);
            this.txtSpendingsPeriyot.TabIndex = 1;
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBankaHareketleri;
        private System.Windows.Forms.Button btnFaturalar;
        private System.Windows.Forms.Button btnUpdateSpendings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRemoveSpendings;
        private System.Windows.Forms.Button btnCreateSpendings;
        private System.Windows.Forms.Button btnListSpendings;
        private System.Windows.Forms.TextBox txtSpendingsAmount;
        private System.Windows.Forms.TextBox txtSpendingsTitle;
        private System.Windows.Forms.TextBox txtSpendingsId;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGiderler;
        private System.Windows.Forms.Button btnBankalar;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSpendingsPeriyot;
    }
}