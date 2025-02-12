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

namespace MyFinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
            
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

        private void btnBankaHareketleri_Click(object sender, EventArgs e)
        {
            FrmBankProcceses frm = new FrmBankProcceses();
            frm.Show();
            this.Hide();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnListSpendings_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateSpendings_Click(object sender, EventArgs e)
        {
            string title = txtSpendingsTitle.Text;
            decimal amount = decimal.Parse(txtSpendingsAmount.Text);
            string period = txtSpendingsPeriyot.Text;

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = DateTime.Parse(period);
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sisteme Eklendi");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveSpendings_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingsId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);

            db.SaveChanges();
            MessageBox.Show("Gider Başarılı Bir Şekilde Sistemden Silindi");

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;


        }

        private void btnUpdateSpendings_Click(object sender, EventArgs e)
        {
            string title = txtSpendingsTitle.Text;
            decimal amount = decimal.Parse(txtSpendingsAmount.Text);
            string period = txtSpendingsPeriyot.Text;
            int id = int.Parse(txtSpendingsId.Text);

           var updateValues = db.Spendings.Find(id);
            updateValues.SpendingTitle = title;
            updateValues.SpendingAmount = amount;
            updateValues.SpendingDate = DateTime.Parse(period);
            db.SaveChanges();

            MessageBox.Show("Gider Başarılı Bir Şekilde Sistemde Güncellendi");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }
    }
}
