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
    public partial class frmSeanIslemleri : Form
    {
        public frmSeanIslemleri()
        {
            InitializeComponent();
        }
        bool SuruklemeDurumu = false;
        Point IlkKonum;
        private void P_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SuruklemeDurumu = true;
            IlkKonum = e.Location;
            //pb.BackColor = Color.AliceBlue;
        }
        private void P_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void P_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SuruklemeDurumu = false;
            //pb.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
