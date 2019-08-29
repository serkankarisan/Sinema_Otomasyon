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
    public partial class frmFilmSec : Form
    {
        public frmFilmSec()
        {
            InitializeComponent();
        }

        private void frmFilmSec_Load(object sender, EventArgs e)
        {
            Listele(Genel.Service.Movie.Select());
        }

        private void dgvSalonlar_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFilmler.SelectedRows.Count == 1)
            {
                Genel.Selected_Film_ID = Convert.ToInt32(dgvFilmler.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                Genel.Selected_Film_ID = 0;
            }
            this.Close();
        }
        private void Listele(List<Movie> Liste)
        {
            dgvFilmler.DataSource = Liste;
            dgvFilmler.Columns["Id"].Visible = false;
            dgvFilmler.Columns["AddedDate"].Visible = false;
            dgvFilmler.Columns["Banner"].Visible = false;
            dgvFilmler.Columns["Movie_Name"].HeaderText = "Film Adı           ";
            dgvFilmler.Columns["Movie_Type"].HeaderText = "Film Türü";
            dgvFilmler.Columns["Movie_Duration_InMinute"].HeaderText = "Film Süresi";
            dgvFilmler.Columns["Director"].HeaderText = "Yönetmen       ";
            dgvFilmler.Columns["IsActive"].Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Genel.Selected_Film_ID = 0;
            this.Close();
        }
    }
}
