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
    public partial class frmSeansSec : Form
    {
        public frmSeansSec()
        {
            InitializeComponent();
        }

        private void frmSeansSec_Load(object sender, EventArgs e)
        {
            List<Seance> Liste = Genel.Service.Seance.Select();
            Listele(Liste);
        }

        private void dgvSalonlar_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSeanslar.SelectedRows.Count == 1)
            {
                Genel.Selected_Seance_ID = Convert.ToInt32(dgvSeanslar.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                Genel.Selected_Seance_ID = 0;
            }
            this.Close();
        }
        private void Listele(List<Seance> Liste)
        {
            dgvSeanslar.DataSource = Liste;
            dgvSeanslar.Columns["Id"].Visible = false;
            dgvSeanslar.Columns["AddedDate"].Visible = false;
            dgvSeanslar.Columns["HallId"].Visible = false;
            dgvSeanslar.Columns["MovieId"].Visible = false;
            dgvSeanslar.Columns["Movie"].HeaderText = "Film Adı";
            dgvSeanslar.Columns["Movie"].Width = 250;
            dgvSeanslar.Columns["Hall"].HeaderText = "Salon Kodu";
            dgvSeanslar.Columns["Start_Time"].HeaderText = "Başlangıç Zamanı";
            dgvSeanslar.Columns["End_Time"].HeaderText = "Bitiş Zamanı";
            dgvSeanslar.Columns["IsActive"].Visible = false;
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Genel.Selected_Seance_ID = 0;
            this.Close();
        }
    }
}
