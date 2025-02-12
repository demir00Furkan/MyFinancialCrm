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

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            LoginUsernameAndUserPasswordInfo.UserName = txtUserNameSignIn.Text;
            LoginUsernameAndUserPasswordInfo.UserPassword = txtUserPasswordSignIn.Text;



            var usernam = db.Users.Where(x => x.UserName == txtUserNameSignIn.Text).Select(x => x.UserName).FirstOrDefault();
            var userpass = db.Users.Where(x => x.UserPassword == txtUserPasswordSignIn.Text).Select(x => x.UserPassword).FirstOrDefault();
            if (usernam != null && userpass != null)
            {
                


                FrmBanks fr = new FrmBanks();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserPasswordSignUp.Text != txtUserPasswordSignUpVerify.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor Lütfen Tekrar Deneyin");
            }
            else
            {
                string username = txtUserNameSignUp.Text;
                string password = txtUserPasswordSignUp.Text;
                Users user = new Users();
                user.UserName = username;
                user.UserPassword = password;
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Yeni Kullanıcı Başarıyla Eklenedi");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }
    }
}
