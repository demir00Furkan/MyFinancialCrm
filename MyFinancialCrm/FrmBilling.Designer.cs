namespace MyFinancialCrm
{
    partial class FrmBilling
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnListBill = new System.Windows.Forms.Button();
            this.txtBillPeriyot = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankaHareketleri = new System.Windows.Forms.Button();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnBankalar = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(202, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 191);
            this.panel3.TabIndex = 6;
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Location = new System.Drawing.Point(459, 178);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(108, 29);
            this.btnUpdateBill.TabIndex = 2;
            this.btnUpdateBill.Text = "Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = true;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateBill);
            this.panel2.Controls.Add(this.btnRemoveBill);
            this.panel2.Controls.Add(this.btnCreateBill);
            this.panel2.Controls.Add(this.btnListBill);
            this.panel2.Controls.Add(this.txtBillPeriyot);
            this.panel2.Controls.Add(this.txtBillAmount);
            this.panel2.Controls.Add(this.txtBillTitle);
            this.panel2.Controls.Add(this.txtBillId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 253);
            this.panel2.TabIndex = 5;
            // 
            // btnRemoveBill
            // 
            this.btnRemoveBill.Location = new System.Drawing.Point(345, 178);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(108, 29);
            this.btnRemoveBill.TabIndex = 2;
            this.btnRemoveBill.Text = "Ödeme Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = true;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Location = new System.Drawing.Point(231, 178);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(108, 29);
            this.btnCreateBill.TabIndex = 2;
            this.btnCreateBill.Text = "Yeni Ödeme";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnListBill
            // 
            this.btnListBill.Location = new System.Drawing.Point(117, 178);
            this.btnListBill.Name = "btnListBill";
            this.btnListBill.Size = new System.Drawing.Size(108, 29);
            this.btnListBill.TabIndex = 2;
            this.btnListBill.Text = "Ödeme Listesi";
            this.btnListBill.UseVisualStyleBackColor = true;
            this.btnListBill.Click += new System.EventHandler(this.btnListBill_Click);
            // 
            // txtBillPeriyot
            // 
            this.txtBillPeriyot.BackColor = System.Drawing.Color.Moccasin;
            this.txtBillPeriyot.Location = new System.Drawing.Point(103, 125);
            this.txtBillPeriyot.Name = "txtBillPeriyot";
            this.txtBillPeriyot.Size = new System.Drawing.Size(481, 20);
            this.txtBillPeriyot.TabIndex = 1;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.Color.Moccasin;
            this.txtBillAmount.Location = new System.Drawing.Point(103, 91);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(481, 20);
            this.txtBillAmount.TabIndex = 1;
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.BackColor = System.Drawing.Color.Moccasin;
            this.txtBillTitle.Location = new System.Drawing.Point(103, 57);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(481, 20);
            this.txtBillTitle.TabIndex = 1;
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.Color.Moccasin;
            this.txtBillId.Location = new System.Drawing.Point(103, 23);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(481, 20);
            this.txtBillId.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Id:";
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
            this.panel1.TabIndex = 4;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ForeColor = System.Drawing.Color.Transparent;
            this.btnCikisYap.Location = new System.Drawing.Point(37, 261);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(148, 28);
            this.btnCikisYap.TabIndex = 2;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.Location = new System.Drawing.Point(37, 227);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(148, 28);
            this.btnAyarlar.TabIndex = 3;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(37, 193);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(148, 28);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankaHareketleri
            // 
            this.btnBankaHareketleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankaHareketleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaHareketleri.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankaHareketleri.Location = new System.Drawing.Point(37, 159);
            this.btnBankaHareketleri.Name = "btnBankaHareketleri";
            this.btnBankaHareketleri.Size = new System.Drawing.Size(148, 28);
            this.btnBankaHareketleri.TabIndex = 5;
            this.btnBankaHareketleri.Text = "Banka Hareketleri";
            this.btnBankaHareketleri.UseVisualStyleBackColor = true;
            this.btnBankaHareketleri.Click += new System.EventHandler(this.btnBankaHareketleri_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiderler.Location = new System.Drawing.Point(37, 125);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(148, 28);
            this.btnGiderler.TabIndex = 6;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturalar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFaturalar.Location = new System.Drawing.Point(37, 91);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(148, 28);
            this.btnFaturalar.TabIndex = 7;
            this.btnFaturalar.Text = "Faturalar";
            this.btnFaturalar.UseVisualStyleBackColor = true;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // btnBankalar
            // 
            this.btnBankalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankalar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBankalar.Location = new System.Drawing.Point(37, 57);
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.Size = new System.Drawing.Size(148, 28);
            this.btnBankalar.TabIndex = 8;
            this.btnBankalar.Text = "Bankalar";
            this.btnBankalar.UseVisualStyleBackColor = true;
            this.btnBankalar.Click += new System.EventHandler(this.btnBankalar_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.Transparent;
            this.btnKategoriler.Location = new System.Drawing.Point(37, 23);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(148, 28);
            this.btnKategoriler.TabIndex = 9;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 447);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnListBill;
        private System.Windows.Forms.TextBox txtBillPeriyot;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankaHareketleri;
        private System.Windows.Forms.Button btnGiderler;
        private System.Windows.Forms.Button btnFaturalar;
        private System.Windows.Forms.Button btnBankalar;
        private System.Windows.Forms.Button btnKategoriler;
    }
}