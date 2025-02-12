using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;
using Microsoft.VisualBasic;
using System.Deployment.Internal;

namespace MyFinancialCrm
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public int CategoryId { get; private set; }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedId = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[selectedId].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selectedId].Cells[1].Value.ToString();


        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["Spendings"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kategoriAdı = textBox2.Text;
            Categories categories = new Categories();
            categories.CategoryName = kategoriAdı;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Eklendi");
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["Spendings"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["Spendings"].Visible = false;
            MessageBox.Show("Kategori Listesi Güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            var removeValue = db.Categories.Find(id);
            if (removeValue != null)
            {
                DialogResult result = MessageBox.Show("Bu Veriyi silmek istediğinizden emin misiniz?",
                                      "Onay",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    db.Categories.Remove(removeValue);
                    db.SaveChanges();
                    MessageBox.Show("Veri Başarıyla Silindi");

                    var values = db.Categories.ToList();
                    dataGridView1.DataSource = values;
                    dataGridView1.Columns["Spendings"].Visible = false;
                }
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Silme İşleminden Vazgeçtiniz");
                }
                
                    
            }
            else
            {
                MessageBox.Show("Lütfen Girilen id'yi Kontrol Edin");
            }


        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            string kategoriAdı = textBox2.Text;
            int id = int.Parse(textBox1.Text);
            var updateValue = db.Categories.Find(id);
            updateValue.CategoryName = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Veri Başarıyla Günellendi");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["Spendings"].Visible = false;
        }

        

        private void btnBankalar_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankaHareketleri_Click(object sender, EventArgs e)
        {
            FrmBankProcceses frm = new FrmBankProcceses();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }
}
