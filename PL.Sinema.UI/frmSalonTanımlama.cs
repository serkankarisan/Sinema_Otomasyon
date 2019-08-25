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
    public partial class frmSalonTanımlama : Form
    {
        public frmSalonTanımlama()
        {
            InitializeComponent();
        }
        int salon_kapasite;
        private void frmSalonTanımlama_Load(object sender, EventArgs e)
        {
            txtKoltukKapasitesi.Enabled = false;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
            btnIptal.Visible = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtKoltukKapasitesi.Enabled = true;
            btnKaydet.Enabled = true;
            btnIptal.Enabled = true;
            btnIptal.Visible = true;
            KoltukTemizle(pnlKoltuklar);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtKoltukKapasitesi.Enabled = false;
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
            btnIptal.Visible = false;
            txtKoltukKapasitesi.Clear();
        }
        private void KoltukTemizle(Panel pnl)
        {
            foreach (Control pb in pnl.Controls)
            {
                if (pb is PictureBox)
                {
                    pnl.Controls.Remove(pb);
                }
            }
            lblSalonKodu.Text = "";
            lblSalon.Visible = false;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKoltukKapasitesi.Text.Trim()))
            {
                Hall s = new Hall();
                s.Hall_Code = "SLN" + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                if (int.TryParse(txtKoltukKapasitesi.Text.Trim(), out salon_kapasite))
                {
                    s.Seating_Capacity = salon_kapasite;
                }
                else
                {
                    MessageBox.Show("Kapasite sayılardan oluşmalı.", "Hata!");
                    return;
                }
                if (Genel.Service.Hall.Insert(s) > 0)
                {
                    int Soldan = 5, Ustten = 5;
                    Hall EklenenSalon = Genel.Service.Hall.SelectByHallCode(s.Hall_Code);
                    for (int i = 0; i < EklenenSalon.Seating_Capacity; i++)
                    {
                        Seat k = new Seat();
                        k.HallId = EklenenSalon.Id;
                        k.Seat_Code = "K" + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
                        if (Genel.Service.Seat.Insert(k) > 0)
                        {
                            Seat EklenenKoltuk = Genel.Service.Seat.SelectBySeatCode(k.Seat_Code);
                            PictureBox pb = new PictureBox()
                            {
                                Height = 75,
                                Width = 100,
                                Name = "pb_" + EklenenKoltuk.Id,
                                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                                Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\Koltuk.png"),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                            };
                            pnlKoltuklar.Controls.Add(pb);
                            if (Soldan >= ((pnlKoltuklar.Width-pb.Width)-5))
                            {
                                Soldan = 5;
                                Ustten += (pb.Height + 10);
                            }
                            pb.Location = new Point(Soldan, Ustten);
                            Soldan += (pb.Width+10);
                        }
                    }
                    MessageBox.Show("Salon başarıyla eklendi.", "İşlem Başarılı");
                    btnKaydet.Enabled = false;
                    btnIptal.Enabled = false;
                    btnIptal.Visible = false;
                    txtKoltukKapasitesi.Enabled = false;
                    txtKoltukKapasitesi.Clear();
                    lblSalonKodu.Text = EklenenSalon.Hall_Code;
                    lblSalon.Visible = true;
                }
            }

        }
    }
}
