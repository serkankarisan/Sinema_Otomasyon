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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        int pnlMaxboyut = 460;
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        ToolTip ttMenuEnabled = new ToolTip();
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            ttMenuEnabled.SetToolTip(lblMenuUyari, "Menü'nün aktif olması için açık sayfaları kapatmalısınız!");
            btnSeansMenu.Location = new Point(7, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 258);
            pnlFiyat.Height = 0;
            pnlMenu.Height = 0;
            User u = Genel.Service.User.SelectByUserName(Genel.ActiveUser.UserName);
            lblKullanici.Text = u.Name + " " + u.SurName;
            Role r = Genel.Service.Role.SelectById(u.RoleId);
            lblYetki.Text = r.RoleName;
            //User testuser = new User();
            //testuser.Name = "Serkan";
            //testuser.SurName = "Karışan";
            //Role testrole = new Role();
            //testrole.RoleName = "Admin";
            //testuser.Role = testrole;
            //lblKullanici.Text = testuser.Name + " " + testuser.SurName;
            //lblYetki.Text = testuser.Role.RoleName;
            if (u.Role.RoleName != "Admin")
            {
                pnlUser.Location = new Point(10, 0);
                btnMenu.Enabled = false;
                btnMenu.Visible = false;
            }
            lblTarih.Text = DateTime.Now.Date.ToLongDateString();
            tmrClock.Start();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            if (Genel.FormActive)
            {
                pnlGiris.Visible = false;
                btnMenu.Enabled = false;
                ttMenuEnabled.Active = true;
                lblMenuUyari.Visible = true;
            }
            else
            {
                ttMenuEnabled.Active = false;
                btnMenu.Enabled = true;
                pnlGiris.Visible = true;
                lblMenuUyari.Visible = false;
            }
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    Genel.FormActive = false;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            Genel.FormActive = true;
            AF.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == 0)
            {
                pnlMenu.Height = pnlMaxboyut;
            }
            else if (pnlMenu.Height == pnlMaxboyut)
            {
                pnlMenu.Height = 0;
            }
        }

        private void pnlContent_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == pnlMaxboyut)
            {
                pnlMenu.Height = 0;
            }
        }

        private void maxMinExit1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void maxMinExit1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void maxMinExit1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging && this.FindForm().WindowState == FormWindowState.Normal)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btnKullanıcıMenu_Click(object sender, EventArgs e)
        {
            frmKullanıcıIslemleri frm = new frmKullanıcıIslemleri();
            FormAc(frm);
            pnlMenu.Height = 0;
            pnlFiyat.Height = 0;
            btnSeansMenu.Location = new Point(9, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 300);
            btnSalonDüzenleme.Visible = false;
            btnSalonTanımlama.Visible = false;
        }

        private void btnFilmMenu_Click(object sender, EventArgs e)
        {
            frmFilmIslemleri frm = new frmFilmIslemleri();
            FormAc(frm);
            pnlMenu.Height = 0;
            pnlFiyat.Height = 0;
            btnSeansMenu.Location = new Point(9, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 300);
            btnSalonDüzenleme.Visible = false;
            btnSalonTanımlama.Visible = false;
        }

        private void btnSalonMenu_Click(object sender, EventArgs e)
        {
            if (btnSalonDüzenleme.Visible == false && btnSalonDüzenleme.Visible == false)
            {
                btnSalonDüzenleme.Visible = true;
                btnSalonTanımlama.Visible = true;
                btnSeansMenu.Location = new Point(9, 254);
                btnBiletFiyat.Location = new Point(9, 300);
                pnlFiyat.Location = new Point(9, 346);
                pnlFiyat.Height = 0;
            }
            else if (btnSalonDüzenleme.Visible == true && btnSalonDüzenleme.Visible == true)
            {
                btnSalonDüzenleme.Visible = false;
                btnSalonTanımlama.Visible = false;
                btnSeansMenu.Location = new Point(9, 166);
                btnBiletFiyat.Location = new Point(9, 212);
                pnlFiyat.Location = new Point(9, 300);
                pnlFiyat.Height = 0;
            }
        }

        private void btnSeansMenu_Click(object sender, EventArgs e)
        {
            frmSeanIslemleri frm = new frmSeanIslemleri();
            FormAc(frm);
            pnlMenu.Height = 0;
            pnlFiyat.Height = 0;
            btnSeansMenu.Location = new Point(9, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 300);
            btnSalonDüzenleme.Visible = false;
            btnSalonTanımlama.Visible = false;
        }

        private void btnSalonTanımlama_Click(object sender, EventArgs e)
        {
            frmSalonTanımlama frm = new frmSalonTanımlama();
            FormAc(frm);
            pnlMenu.Height = 0;
            pnlFiyat.Height = 0;
            btnSeansMenu.Location = new Point(9, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 300);
            btnSalonDüzenleme.Visible = false;
            btnSalonTanımlama.Visible = false;
        }

        private void btnSalonDüzenleme_Click(object sender, EventArgs e)
        {
            frmSalonDüzenleme frm = new frmSalonDüzenleme();
            FormAc(frm);
            pnlMenu.Height = 0;
            pnlFiyat.Height = 0;
            btnSeansMenu.Location = new Point(9, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 300);
            btnSalonDüzenleme.Visible = false;
            btnSalonTanımlama.Visible = false;
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Genel.ActiveUser = null;
            Genel.FormActive = false;
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            frmBiletKes frm = new frmBiletKes();
            FormAc(frm);
            pnlMenu.Height = 0;
            pnlFiyat.Height = 0;
            btnSeansMenu.Location = new Point(9, 166);
            btnBiletFiyat.Location = new Point(9, 212);
            pnlFiyat.Location = new Point(9, 300);
            btnSalonDüzenleme.Visible = false;
            btnSalonTanımlama.Visible = false;
        }

        private void btnBiletFiyat_Click(object sender, EventArgs e)
        {
            if (btnSalonDüzenleme.Visible == false && btnSalonDüzenleme.Visible == false)
            {
                btnBiletFiyat.Location = new Point(9, 212);
                pnlFiyat.Location = new Point(9, 258);
            }
            else if (btnSalonDüzenleme.Visible == true && btnSalonDüzenleme.Visible == true)
            {

                btnBiletFiyat.Location = new Point(9, 300);
                pnlFiyat.Location = new Point(9, 346);
            }
            if (pnlFiyat.Height==0)
            {
                pnlFiyat.Height = 100;
            }
            else if (pnlFiyat.Height==100)
            {
                pnlFiyat.Height = 0;
            }
        }

        private void btnFiyatOnayla_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Application.LocalUserAppDataPath + "\\BiletFiyat.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(txtYeniFiyat.Text.Trim());
            sw.Close();
            txtYeniFiyat.Clear();
            Genel.BiletFiyatBelirleme();
            if (btnSalonDüzenleme.Visible == false && btnSalonDüzenleme.Visible == false)
            {
                btnBiletFiyat.Location = new Point(9, 212);
                pnlFiyat.Location = new Point(9, 258);
            }
            else if (btnSalonDüzenleme.Visible == true && btnSalonDüzenleme.Visible == true)
            {

                btnBiletFiyat.Location = new Point(9, 300);
                pnlFiyat.Location = new Point(9, 346);
            }
            pnlFiyat.Height = 0;
            MessageBox.Show("Yeni bilet fiyatınız başarıyla değiştirildi.", "İşlem Başarılı");
        }
    }

}
