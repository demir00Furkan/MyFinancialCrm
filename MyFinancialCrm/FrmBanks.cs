using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasıBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakıfbankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblIsBankasıBalance.Text = isBankasıBalance.ToString() + " ₺";

            //Banka Hareketleri
            var bankProcces1 = db.BankProcceses.OrderByDescending(x => x.BankProccesId).Take(1).FirstOrDefault();
            lblBankProcces1.Text = bankProcces1.Description + " / " + bankProcces1.Amount + " / " + bankProcces1.ProccesDate;

            var bankProcces2 = db.BankProcceses.OrderByDescending(x => x.BankProccesId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcces2.Text = bankProcces2.Description + " / " + bankProcces2.Amount + " / " + bankProcces2.ProccesDate;

            var bankProcces3 = db.BankProcceses.OrderByDescending(x => x.BankProccesId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcces3.Text = bankProcces3.Description + " / " + bankProcces3.Amount + " / " + bankProcces3.ProccesDate;

            var bankProcces4 = db.BankProcceses.OrderByDescending(x => x.BankProccesId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcces4.Text = bankProcces4.Description + " / " + bankProcces4.Amount + " / " + bankProcces4.ProccesDate;

            var bankProcces5 = db.BankProcceses.OrderByDescending(x => x.BankProccesId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcces5.Text = bankProcces5.Description + " / " + bankProcces5.Amount + " / " + bankProcces5.ProccesDate;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void btnBankaHareketleri_Click(object sender, EventArgs e)
        {
            FrmBankProcceses frm = new FrmBankProcceses();
            frm.Show();
            this.Hide();
        }

        private void btnBankalar_Click(object sender, EventArgs e)
        {

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
