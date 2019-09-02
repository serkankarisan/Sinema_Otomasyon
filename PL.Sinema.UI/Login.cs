﻿using DAL.Sinema.Context;
using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            else if (txtKullaniciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kullanıcı adı girmelisiniz.", "Eksik Bilgi!");
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.Focus();
            }
            else
            {
                if (txtSifre.Text.Trim() == "Şifre")
                {
                    MessageBox.Show("Şifre girmelisiniz.", "Eksik Bilgi!");
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
                else if (txtSifre.Text.Trim() == "")
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
            FileStream fs = new FileStream(Application.LocalUserAppDataPath + "\\BiletFiyat.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string okunan = sr.ReadLine();
            if(okunan == null)
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("12");
                sw.Close();
            }
            sr.Close();
            Genel.BiletFiyatBelirleme();
            using (SinemaContext ent = new SinemaContext())
            {
                ent.Database.CreateIfNotExists();
                User u = new User { Id = 1, UserName = "serkan", Name = "Serkan", SurName = "Karışan", IsActive = true, Password = "NieQminDE4Ggcewn98nKl3Jhgq7Smn3dLlQ1MyLPswq7njpt8qwsIP4jQ2MR1nhWTQyNMFkwV19g4tPQSBhNeQ==", AddedDate = DateTime.Now, RoleId = 1 };
                Role r1 = new Role { Id = 1, RoleName = "Admin", AddedDate = DateTime.Now, IsActive = true };
                Role r2 = new Role { Id = 2, RoleName = "User", AddedDate = DateTime.Now, IsActive = true };
                if (ent.Roles.Where(rl => rl.Id == r1.Id && rl.RoleName == r1.RoleName).FirstOrDefault() == null)
                {
                    ent.Roles.Add(r1);
                    ent.SaveChanges();
                }
                if (ent.Roles.Where(rl => rl.Id == r2.Id && rl.RoleName == r2.RoleName).FirstOrDefault() == null)
                {
                    ent.Roles.Add(r2);
                    ent.SaveChanges();
                }
                if (ent.Users.Where(us=>us.Id==u.Id && us.UserName==u.UserName && us.Name==u.Name && us.SurName == u.SurName).FirstOrDefault() == null)
                {
                    ent.Users.Add(u);
                    ent.SaveChanges();
                }

            }
        }
    }
}
