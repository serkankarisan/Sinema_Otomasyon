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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        int pnlMaxboyut = 400;
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            pnlMenu.Height = 0;
            User u = Genel.Service.User.SelectByUserName(Genel.ActiveUser.UserName);
            lblKullanici.Text = u.Name + " " + u.SurName;
            lblYetki.Text = u.Role.RoleName;
            lblTarih.Text = DateTime.Now.Date.ToLongDateString();
            tmrClock.Start();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormAc(Form AF)
        {
            foreach (Control F in this.pnlContent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    MF.Close();
                }
            }
            AF.TopLevel = false;
            this.pnlContent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            AF.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == 0)
            {
                pnlNavLeft.Width = 260;
                pnlMenu.Height = pnlMaxboyut;
            }
            else if (pnlMenu.Height == pnlMaxboyut)
            {
                pnlNavLeft.Width = 0;
                pnlMenu.Height = 0;
            }
        }

        private void pnlNavLeft_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == pnlMaxboyut)
            {
                pnlNavLeft.Width = 0;
                pnlMenu.Height = 0;
            }
        }

        private void pnlContent_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == pnlMaxboyut)
            {
                pnlNavLeft.Width = 0;
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
            pnlNavLeft.Width = 0;
            pnlGiris.Width = 0;
        }
    }

}
