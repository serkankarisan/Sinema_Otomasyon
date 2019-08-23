using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Sinema.UI
{
    public partial class MaxMinExit : UserControl
    {
        public MaxMinExit()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (this.FindForm().WindowState == FormWindowState.Minimized || this.FindForm().WindowState == FormWindowState.Normal)
            {
                this.FindForm().WindowState = FormWindowState.Maximized;
            }
            else if (this.FindForm().WindowState == FormWindowState.Maximized || this.FindForm().WindowState == FormWindowState.Minimized)
            {
                this.FindForm().WindowState = FormWindowState.Normal;
            }
        }

        private void btnSimgeDurumu_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }
    }
}
