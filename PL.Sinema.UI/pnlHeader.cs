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
            Genel.FormActive = false;
            Genel.Selected_Hall_Code = "";
            Genel.SeansByFilm = false;
            Genel.Selected_Film_ID = 0;
            Genel.Selected_Seance_ID = 0;
            Genel.HallByDate = false;
            this.FindForm().Close();
        }

        private void pnlHeader_Load(object sender, EventArgs e)
        {
            lblSayfaHeader.Text = this.FindForm().Text;
        }
    }
}
