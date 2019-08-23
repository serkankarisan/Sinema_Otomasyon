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
        private void frmKullanıcıIslemleri_Load(object sender, EventArgs e)
        {
            cbRol.DataSource = Genel.Service.Role.Select();
            txtName.Enabled = false;
            txtSurname.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            cbRol.Enabled = false;
            btnKaydet.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            Listele();
        }

        private void Listele()
        {
            dgvKullanicilar.DataSource = Genel.Service.User.Select();
            dgvKullanicilar.Columns[1].Visible = false;
            dgvKullanicilar.Columns[0].HeaderText = "Kullanıcı Adı";
            dgvKullanicilar.Columns[0].Width = 100;
            dgvKullanicilar.Columns[4].Visible = false;
            dgvKullanicilar.Columns[2].HeaderText = "Adı";
            dgvKullanicilar.Columns[2].Width = 110;
            dgvKullanicilar.Columns[3].HeaderText = "Soyadı";
            dgvKullanicilar.Columns[3].Width = 100;
            dgvKullanicilar.Columns[5].Visible = false;
            dgvKullanicilar.Columns[6].Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            btnKaydet.Enabled = true;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            cbRol.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
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
                Genel.Service.User.Insert(u);
                User_Role ur = new User_Role();
                ur.UserId = Genel.Service.User.SelectByUserName(u.UserName).Id;
                ur.RoleId = Genel.Service.Role.SelectByRoleName("User").Id;
                Genel.Service.UserRole.Insert(ur);
                MessageBox.Show("Kullanıcı Başarıyla Eklendi.", "İşlem Başarılı");
                btnKaydet.Enabled = false;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtPassword.Enabled = false;
                txtUsername.Enabled = false;
                cbRol.Enabled = false;
                Temizle();
                Listele();

            }
        }
        private void Temizle()
        {
            txtUsername.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            cbRol.SelectedIndex=0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvKullanicilar_DoubleClick(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtSurname.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            btnKaydet.Enabled = false;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            cbRol.Enabled = true;
            ID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells[4].Value);
            txtName.Text = dgvKullanicilar.SelectedRows[0].Cells[2].Value.ToString();
            txtSurname.Text = dgvKullanicilar.SelectedRows[0].Cells[3].Value.ToString();
            txtUsername.Text = dgvKullanicilar.SelectedRows[0].Cells[0].Value.ToString();
            cbRol.Text = Genel.Service.UserRole.Select().Where(s => s.UserId == ID).FirstOrDefault().Role.RoleName;

        }
    }
}
