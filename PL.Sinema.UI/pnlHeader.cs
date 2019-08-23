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
    public partial class pnlHeader : UserControl
    {
        public pnlHeader()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void pnlHeader_Load(object sender, EventArgs e)
        {
            lblSayfaHeader.Text = this.FindForm().Text;
        }
    }
}
