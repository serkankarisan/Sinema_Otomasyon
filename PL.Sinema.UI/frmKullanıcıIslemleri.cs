using Entities.Sinema.Entity;
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
    public partial class frmKullanıcıIslemleri : Form
    {
        public frmKullanıcıIslemleri()
        {
            InitializeComponent();
        }

        int ID = 0;
        Role selectedRole;
        private void frmKullanıcıIslemleri_Load(object sender, EventArgs e)
        {
            cbRol.DataSource = Genel.Service.Role.Select();
            Disabled();
            btnKaydet.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnSil.Enabled = false;
            btnSil.Visible = false;
            ID = 0;
            Listele();
        }

        private void Listele()
        {
            dgvKullanicilar.DataSource = Genel.Service.User.Select();
            dgvKullanicilar.Columns["Id"].Visible = false;
            dgvKullanicilar.Columns["UserName"].HeaderText = "Kullanıcı Adı";
            dgvKullanicilar.Columns["RoleId"].Visible = false;
            dgvKullanicilar.Columns["Name"].HeaderText = "Adı";
            dgvKullanicilar.Columns["SurName"].HeaderText = "Soyadı";
            dgvKullanicilar.Columns["Role"].HeaderText = "Rol";
            dgvKullanicilar.Columns["AddedDate"].Visible = false;
            dgvKullanicilar.Columns["IsActive"].Visible = false;
            dgvKullanicilar.Columns["Password"].Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Enabled();
            btnKaydet.Enabled = true;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnIptal.Enabled = true;
            btnIptal.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text.Trim()) && (!string.IsNullOrEmpty(txtSurname.Text.Trim())) && (!string.IsNullOrEmpty(txtUsername.Text.Trim())) && (!string.IsNullOrEmpty(txtPassword.Text.Trim())))
            {
                User u = new User();
                if (Genel.Service.User.SelectByUserName(txtUsername.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu Kullanıcı İsmi Kayıtlı!", "Hata!");
                    txtUsername.Focus();
                }
                else
                {
                    u.UserName = txtUsername.Text.Trim();
                    u.Name = txtName.Text.Trim();
                    u.SurName = txtSurname.Text.Trim();
                    u.Password = Genel.Hash(txtUsername.Text.Trim());
                    u.RoleId = selectedRole.Id;
                    Genel.Service.User.Insert(u);
                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "İşlem Başarılı");
                    btnKaydet.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnUpdate.Visible = false;
                    btnIptal.Enabled = false;
                    btnIptal.Visible = false;
                    btnSil.Enabled = false;
                    btnSil.Visible = false;
                    Disabled();
                    Temizle();
                    Listele();

                }
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol edip tekrar deneyin.", "Eksik Bilgi Girişi!");
                txtUsername.Focus();
            }
        }
        private void Temizle()
        {
            txtUsername.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            cbRol.SelectedIndex = 0;
        }
        private void Enabled()
        {
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            cbRol.Enabled = true;
        }
        private void Disabled()
        {
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            cbRol.Enabled = false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text.Trim()) && (!string.IsNullOrEmpty(txtSurname.Text.Trim())) && (!string.IsNullOrEmpty(txtUsername.Text.Trim())) && (!string.IsNullOrEmpty(txtPassword.Text.Trim())))
            {

                if (ID != 0)
                {
                    User u = Genel.Service.User.SelectById(ID);
                    User usernameToUser = Genel.Service.User.SelectByUserName(txtUsername.Text.Trim());
                    if (usernameToUser != null && usernameToUser.Id != u.Id)
                    {
                        MessageBox.Show("Bu kullanıcı adı başka birine ait.", "Hata!"); txtUsername.Focus();
                    }
                    else
                    {
                        u.UserName = txtUsername.Text.Trim();
                        u.Name = txtName.Text.Trim();
                        u.SurName = txtSurname.Text.Trim();
                        u.Password = Genel.Hash(txtUsername.Text.Trim());
                        u.RoleId = selectedRole.Id;
                        Genel.Service.User.Update(u);
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.", "İşlem Başarılı");
                        btnKaydet.Enabled = false;
                        btnUpdate.Enabled = false;
                        btnUpdate.Visible = false;
                        btnIptal.Enabled = false;
                        btnIptal.Visible = false;
                        btnSil.Enabled = false;
                        btnSil.Visible = false;
                        ID = 0;
                        Disabled();
                        Temizle();
                        Listele();

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı seçmelisiniz.", "Hata!");
                    dgvKullanicilar.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol edip tekrar deneyin.", "Eksik Bilgi Girişi!");
                txtUsername.Focus();
            }
        }

        private void dgvKullanicilar_DoubleClick(object sender, EventArgs e)
        {
            Enabled();
            btnKaydet.Enabled = false;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            btnIptal.Enabled = true;
            btnIptal.Visible = true;
            btnSil.Enabled = true;
            btnSil.Visible = true;
            ID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["Id"].Value);
            txtName.Text = dgvKullanicilar.SelectedRows[0].Cells["Name"].Value.ToString();
            txtSurname.Text = dgvKullanicilar.SelectedRows[0].Cells["SurName"].Value.ToString();
            txtUsername.Text = dgvKullanicilar.SelectedRows[0].Cells["UserName"].Value.ToString();
            cbRol.Text = Genel.Service.User.Select().Where(s => s.Id == ID).FirstOrDefault().Role.RoleName;

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Temizle();
            Disabled();
            btnIptal.Enabled = false;
            btnIptal.Visible = false;
            btnKaydet.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnSil.Enabled = false;
            btnSil.Visible = false;
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedRole = (Role)cbRol.SelectedItem;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ID != 0)
                {
                    User u = Genel.Service.User.SelectById(ID);
                    User usernameToUser = Genel.Service.User.SelectByUserName(txtUsername.Text.Trim());
                    if (usernameToUser != null && usernameToUser.Id != u.Id)
                    {
                        MessageBox.Show("Bu kullanıcı adı başka birine ait.", "Hata!"); txtUsername.Focus();
                    }
                    else
                    {
                        Genel.Service.User.Delete(ID);
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "İşlem Başarılı");
                        btnKaydet.Enabled = false;
                        btnUpdate.Enabled = false;
                        btnUpdate.Visible = false;
                        btnIptal.Enabled = false;
                        btnIptal.Visible = false;
                        btnSil.Enabled = false;
                        btnSil.Visible = false;
                        ID = 0;
                        Disabled();
                        Temizle();
                        Listele();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı seçmelisiniz.", "Hata!");
                    dgvKullanicilar.Focus();
                }
            }
        }

        private void pbSifreGizle_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
