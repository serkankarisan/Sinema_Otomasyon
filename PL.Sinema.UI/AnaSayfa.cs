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

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            User_Role ur = new User_Role();
            User u = Genel.Service.User.SelectByUserName(Genel.ActiveUser.UserName);
            lblKullanici.Text = u.Name + " " + u.SurName;
            ur = u.User_Roles.FirstOrDefault();
            lblYetki.Text = ur.Role.RoleName;
            lblTarih.Text = DateTime.Now.Date.ToLongDateString();
            tmrClock.Start();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
