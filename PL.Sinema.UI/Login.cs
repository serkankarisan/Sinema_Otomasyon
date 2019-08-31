using DAL.Sinema.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Sinema.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSifreGizle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Clear();
            }
            if (txtSifre.PasswordChar == '*')
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                txtKullaniciAdi.Clear();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim() == "Kullanıcı Adı")
            {
                MessageBox.Show("Kullanıcı adı girmelisiniz.", "Eksik Bilgi!");
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.Focus();
            }
            else if (txtKullaniciAdi.Text.Trim()=="")
            {
                MessageBox.Show("Kullanıcı adı girmelisiniz.", "Eksik Bilgi!");
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.Focus();
            }
            else
            {
                if (txtSifre.Text.Trim()=="Şifre")
                {
                    MessageBox.Show("Şifre girmelisiniz.", "Eksik Bilgi!");
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
                else if (txtSifre.Text.Trim()=="")
                {
                    MessageBox.Show("Şifre girmelisiniz.", "Eksik Bilgi!");
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
                else
                {
                    string result = Genel.CheckUser(txtKullaniciAdi.Text, txtSifre.Text);
                    if (result == "1")
                    {
                        AnaSayfa frm = new AnaSayfa();
                        frm.Show();
                        this.Hide();
                    }
                    else if (result == "err_username")
                    {
                        MessageBox.Show("Kullanıcı adınızı kontrol edin.", "Kullanıcı Bulunamadı!");
                        txtKullaniciAdi.Focus();
                        txtSifre.PasswordChar = '*';
                    }
                    else if (result == "err_password")
                    {
                        MessageBox.Show("Şifrenizi kontrol edin.", "Şifre Hatalı!");
                        txtSifre.PasswordChar = '\0';
                        txtSifre.Clear();
                        txtSifre.Focus();
                    }
                }
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Clear();
            }
            txtSifre.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using (SinemaContext ent = new SinemaContext())
            {
                ent.Database.CreateIfNotExists();
            }
        }
    }
}
