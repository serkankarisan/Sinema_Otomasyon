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
    public partial class frmSalonDüzenleme : Form
    {
        public frmSalonDüzenleme()
        {
            InitializeComponent();
        }

        private void frmSalonDüzenleme_Load(object sender, EventArgs e)
        {
            if (Genel.Selected_Hall_Code == "")
            {
                btnIptal.Enabled = false;
                btnSalonDuzeni.Enabled = false;
                btnSil.Enabled = false;
                btnIptal.Visible = false;
                btnSalonDuzeni.Visible = false;
                btnSil.Visible = false;
            }
            else
            {
                btnIptal.Enabled = true;
                btnSalonDuzeni.Enabled = true;
                btnSil.Enabled = true;
                btnIptal.Visible = true;
                btnSalonDuzeni.Visible = true;
                btnSil.Visible = true;
                SalonGetir(Genel.Selected_Hall_Code);
            }
        }
        int pbWidth = 100, pbHeight = 75;
        int Dsayac = 0, Ysayac = 0;
        float YKalan = 0, YMaxUzunluk = 0, YSira = 0, YAralik = 0, Soldan = 0, Ustten = 0, YYuvarlamaFarki = 0;

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtSalon_Code.Text.Trim()!="")
            {

                SalonGetir(txtSalon_Code.Text.Trim());
            }
        }

        float DKalan = 0, DMaxUzunluk = 0, DSira = 0, DAralik = 0, DYuvarlamaFarki = 0;
        private void SalonGetir(string HallCode)
        {
            List<Seat> SeatList = Genel.Service.Seat.SelectByHallCode(HallCode);
            foreach (Seat k in SeatList)
            {
                //Yatay hesap
                YMaxUzunluk = pnlKoltuklar.Width;

                if (YMaxUzunluk % pbWidth == 0)
                {
                    YKalan = pbWidth;
                    YSira = Convert.ToInt32(((YMaxUzunluk - pbWidth) / pbWidth) - YYuvarlamaFarki);
                }
                else
                {
                    YKalan = YMaxUzunluk % pbWidth;
                    YYuvarlamaFarki = YKalan / pbWidth;
                    YSira = Convert.ToInt32((YMaxUzunluk / pbWidth) - YYuvarlamaFarki);
                }
                YAralik = (YKalan / (YSira - 1));

                //Dikey Hesap
                DMaxUzunluk = pnlKoltuklar.Height;

                if (DMaxUzunluk % pbHeight == 0)
                {
                    DKalan = pbHeight;
                    DSira = Convert.ToInt32(((DMaxUzunluk - pbHeight) / pbHeight) - DYuvarlamaFarki);
                }
                else
                {
                    DKalan = DMaxUzunluk % pbHeight;
                    DYuvarlamaFarki = DKalan / pbHeight;
                    DSira = Convert.ToInt32((DMaxUzunluk / pbHeight) - DYuvarlamaFarki);
                }
                DAralik = (DKalan / (DSira - 1));
                int kapasite =SeatList.Count();
                if ((DSira - 1) * YSira < kapasite)
                {
                    pbHeight -= 25;
                    pbWidth -= 25;
                    SalonGetir(HallCode);
                    return;
                }
                PictureBox pb = new PictureBox()
                {
                    Height = pbHeight,
                    Width = pbWidth,
                    Name = "pb_" + k.Id,
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\Koltuk.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                pnlKoltuklar.Controls.Add(pb);
                pb.Location = new Point(k.Location_X, k.Location_Y);
            }
        }
    }
}
