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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnRemovaAccount_Click(object sender, EventArgs e)
        {
            string KullaniciAdı = txtUserNameUpdateAndRemove.Text;
            string KullaniciSifre = txtUserPasswordUpdateAndRemove.Text;
            var silinecekKullanici = db.Users.Where(x => x.UserName == KullaniciAdı && x.UserPassword == KullaniciSifre)
                .Select(y => y.UserId).FirstOrDefault();
            var removeValue =db.Users.Find(silinecekKullanici);
            if (removeValue != null)
            {
                DialogResult result = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?",
                                      "Onay",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    db.Users.Remove(removeValue);
                    db.SaveChanges();
                    MessageBox.Show("Hesabınızı Başarıyla Sildiniz", "Uyarı");
                }
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Silme İşleminden Vazgeçtiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz");
            }

        }


       

        private void BtnUpdateUserAndPassword_Click_1(object sender, EventArgs e)
        {
            string KullaniciAdı = LoginUsernameAndUserPasswordInfo.UserName;
            string KullaniciSifre = LoginUsernameAndUserPasswordInfo.UserPassword;

            var guncellenecekKullanici = db.Users.Where(x => x.UserName == KullaniciAdı && x.UserPassword == KullaniciSifre)
                .Select(y => y.UserId).FirstOrDefault();
            var removeValue = db.Users.Find(guncellenecekKullanici);

            removeValue.UserName = txtUserNameUpdateAndRemove.Text;
            removeValue.UserPassword = txtUserPasswordUpdateAndRemove.Text;
            db.SaveChanges();
            MessageBox.Show("Güncellendi");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBanks frm = new FrmBanks();
            frm.Show();

        }

        
    }
}
