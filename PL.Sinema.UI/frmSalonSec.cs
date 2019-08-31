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
    public partial class frmSalonSec : Form
    {
        public frmSalonSec()
        {
            InitializeComponent();
        }

        private void dgvSalonlar_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSalonlar.SelectedRows.Count == 1)
            {
                Genel.Selected_Hall_Code = dgvSalonlar.SelectedRows[0].Cells["Hall_Code"].Value.ToString();
            }
            else
            {
                Genel.Selected_Hall_Code = "";
            }
            this.Close();
        }

        private void frmSalonSec_Load(object sender, EventArgs e)
        {
            if (!Genel.HallByDate)
            {
                Listele(Genel.Service.Hall.Select());
            }
            else
            {
                Listele(Genel.Service.Hall.SelectBySeance(Genel.BaslangicTarihi, Genel.BitisTarihi));
            }
        }
        private void Listele(List<Hall> Liste)
        {
            dgvSalonlar.DataSource = Liste;
            dgvSalonlar.Columns["Id"].Visible = false;
            dgvSalonlar.Columns["AddedDate"].HeaderText = "Eklenme Tarihi";
            dgvSalonlar.Columns["Hall_Code"].HeaderText = "Salon Kodu";
            dgvSalonlar.Columns["Seating_Capacity"].HeaderText = "Koltuk Sayısı";
            dgvSalonlar.Columns["Max_Capacity"].Visible = false;
            dgvSalonlar.Columns["IsActive"].Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Genel.Selected_Hall_Code = "";
            this.Close();
        }
    }
}
