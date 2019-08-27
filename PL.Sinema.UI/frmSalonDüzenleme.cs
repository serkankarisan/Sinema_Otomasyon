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
        bool SuruklemeDurumu = false;
        Point IlkKonum;
        int pbWidth = 100, pbHeight = 75;
        int Dsayac = 0, Ysayac = 0;
        float YKalan = 0, YMaxUzunluk = 0, YSira = 0, YAralik = 0, Soldan = 0, Ustten = 0, YYuvarlamaFarki = 0;
        float DKalan = 0, DMaxUzunluk = 0, DSira = 0, DAralik = 0, DYuvarlamaFarki = 0;
        int SalonID = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtSalon_Code.Text.Trim() == "" && lblSalonKodu.Text.Trim() == "")
                {
                    MessageBox.Show("Salon kodu girmelisiniz.", "Eksik Bilgi!");
                }
                else
                {
                    btnDuzeniKaydet.Enabled = false;
                    btnDuzeniKaydet.Visible = false;
                    pnlKoltuklar.Controls.Clear();
                    if (txtSalon_Code.Text.Trim() == "")
                    {
                        SalonID = Genel.Service.Hall.SelectByHallCode(txtSalon_Code.Text.Trim()).Id;
                    }
                    else
                    {
                        SalonID = Genel.Service.Hall.SelectByHallCode(lblSalonKodu.Text.Trim()).Id;
                    }
                    List<Seat> KoltukListe = Genel.Service.Seat.Select().Where(s => s.HallId == SalonID).ToList();
                    if (Genel.Service.Hall.SelectById(SalonID) == null)
                    {
                        MessageBox.Show("Salon bulunamadı.", "Hata!");
                        txtSalon_Code.Clear();
                        txtSalon_Code.Focus();
                    }
                    else
                    {
                        foreach (Seat k in KoltukListe)
                        {
                            Genel.Service.Seat.Delete(k.Id);
                        }
                    }
                    if (Genel.Service.Seat.Select().Where(s => s.HallId == SalonID).Count() == 0)
                    {
                        if (Genel.Service.Hall.Delete(SalonID) > 0)
                        {
                            MessageBox.Show("Salon başarıyla silindi.", "İşlem Başarılı");
                            lblSalon.Visible = false;
                            lblSalonKodu.Text = "";
                            btnDuzeniKaydet.Enabled = false;
                            btnDuzeniKaydet.Visible = false;
                            btnIptal.Enabled = false;
                            btnSalonDuzeni.Enabled = false;
                            btnSil.Enabled = false;
                            btnIptal.Visible = false;
                            btnSalonDuzeni.Visible = false;
                            btnSil.Visible = false;
                            txtSalon_Code.Clear();
                            txtSalon_Code.Focus();
                        }
                    }
                }
            }
        }

        private void btnDuzeniKaydet_Click(object sender, EventArgs e)
        {
            foreach (Control p in this.pnlKoltuklar.Controls)
            {
                if (p is PictureBox)
                {
                    PictureBox pb = (PictureBox)p;
                    string[] PbName = pb.Name.Split('_');
                    int KoltukID = Convert.ToInt32(PbName[1]);
                    Seat s = Genel.Service.Seat.SelectById(KoltukID);
                    s.Location_X = pb.Location.X;
                    s.Location_Y = pb.Location.Y;
                    Genel.Service.Seat.Update(s);
                    pb.Enabled = false;
                }
            }
            btnDuzeniKaydet.Enabled = false;
            btnDuzeniKaydet.Visible = false;
            MessageBox.Show("Yeni salon düzeni kaydedildi.", "İşlem Başarılı");
            pnlKoltuklar.Controls.Clear();
            SalonGetir(lblSalonKodu.Text.Trim());
        }

        private void frmSalonDüzenleme_Load(object sender, EventArgs e)
        {
            if (Genel.Selected_Hall_Code == "")
            {
                btnDuzeniKaydet.Enabled = false;
                btnDuzeniKaydet.Visible = false;
                btnIptal.Enabled = false;
                btnSalonDuzeni.Enabled = false;
                btnSil.Enabled = false;
                btnIptal.Visible = false;
                btnSalonDuzeni.Visible = false;
                btnSil.Visible = false;
                txtSalon_Code.Focus();
            }
            else
            {
                btnDuzeniKaydet.Enabled = false;
                btnDuzeniKaydet.Visible = false;
                btnIptal.Enabled = true;
                btnSalonDuzeni.Enabled = true;
                btnSil.Enabled = true;
                btnIptal.Visible = true;
                btnSalonDuzeni.Visible = true;
                btnSil.Visible = true;
                SalonGetir(Genel.Selected_Hall_Code);
                txtSalon_Code.Text = Genel.Selected_Hall_Code;
            }
        }


        private void btnSalonDuzeni_Click(object sender, EventArgs e)
        {
            btnDuzeniKaydet.Enabled = true;
            btnDuzeniKaydet.Visible = true;
            List<Seat> SeatList = Genel.Service.Seat.SelectByHallCode(lblSalonKodu.Text);
            foreach (Control p in this.pnlKoltuklar.Controls)
            {
                if (p is PictureBox)
                {
                    PictureBox pb = (PictureBox)p;
                    pb.Enabled = true;
                    pb.MouseDown += P_MouseDown;
                    pb.MouseMove += P_MouseMove;
                    pb.MouseUp += P_MouseUp;
                }
            }
        }


        private void P_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SuruklemeDurumu = true;
            IlkKonum = e.Location;
            pb.BackColor = Color.LightGray;
        }
        private void P_MouseMove(object sender, MouseEventArgs e)
        {
            if (SuruklemeDurumu)
            {
                PictureBox pb = (PictureBox)sender;
                pb.Left = e.X + pb.Left - (IlkKonum.X);
                pb.Top = e.Y + pb.Top - (IlkKonum.Y);
            }
        }
        private void P_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SuruklemeDurumu = false;
            pb.Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\KoltukOrange.png");
            pb.BackColor = Color.Transparent;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            btnIptal.Enabled = false;
            btnSalonDuzeni.Enabled = false;
            btnSil.Enabled = false;
            btnIptal.Visible = false;
            btnSalonDuzeni.Visible = false;
            btnSil.Visible = false;
            lblSalonKodu.Text = "";
            lblSalon.Visible = false;
            btnDuzeniKaydet.Enabled = false;
            btnDuzeniKaydet.Visible = false;
            pnlKoltuklar.Controls.Clear();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtSalon_Code.Text.Trim() != "")
            {
                btnDuzeniKaydet.Enabled = false;
                btnDuzeniKaydet.Visible = false;
                pnlKoltuklar.Controls.Clear();
                SalonGetir(txtSalon_Code.Text.Trim());
            }
            else
            {
                MessageBox.Show("Salon kodu girmelisiniz.", "Eksik Bilgi!");
            }
        }

        private void SalonGetir(string HallCode)
        {
            List<Seat> SeatList = Genel.Service.Seat.SelectByHallCode(HallCode);
            if (SeatList != null)
            {
                //Yatay hesap
                if (Genel.pnlKoltukWidth != 0)
                {
                    YMaxUzunluk = Genel.pnlKoltukWidth;
                }
                else
                {
                    YMaxUzunluk = pnlKoltuklar.Width;
                }

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

                //Dikey Hesap
                if (Genel.pnlKoltukHeight != 0)
                {
                    DMaxUzunluk = Genel.pnlKoltukHeight;
                }
                else
                {
                    DMaxUzunluk = pnlKoltuklar.Height;
                }
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
                foreach (Seat k in SeatList)
                {
                    if ((DSira - 1) * YSira < SeatList.Count())
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
                        BackColor = Color.Transparent,
                        BackgroundImage = null,
                        Enabled = false,
                    };
                    pnlKoltuklar.Controls.Add(pb);
                    pb.Location = new Point(k.Location_X, k.Location_Y);
                }
                lblSalonKodu.Text = HallCode;
                lblSalon.Visible = true;
                btnIptal.Enabled = true;
                btnSalonDuzeni.Enabled = true;
                btnSil.Enabled = true;
                btnIptal.Visible = true;
                btnSalonDuzeni.Visible = true;
                btnSil.Visible = true;
            }

            else
            {
                MessageBox.Show("Salon bulunamadı.", "Hata!");
                txtSalon_Code.Clear();
                txtSalon_Code.Focus();
                return;
            }
        }
    }
}
