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
        Label lblSil = new Label();
        PictureBox pbSil = new PictureBox();
        Panel pnlSil = new Panel();
        bool SuruklemeDurumu = false;
        Point IlkKonum,EskiKonum;
        int pbWidth = 100, pbHeight = 75;
        int Dsayac = 0, Ysayac = 0;
        float YKalan = 0, YMaxUzunluk = 0, YSira = 0, YAralik = 0, Soldan = 0, Ustten = 0, YYuvarlamaFarki = 0;
        float DKalan = 0, DMaxUzunluk = 0, DSira = 0, DAralik = 0, DYuvarlamaFarki = 0;
        int SalonID = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istiyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtSalon_Code.Text.Trim() == "" && lblSalonKodu.Text.Trim() == "")
                {
                    MessageBox.Show("Salon kodu girmelisiniz.", "Eksik Bilgi!");
                }
                else
                {
                    btnDuzeniKaydet.Enabled = false;
                    btnDuzeniKaydet.Visible = false;
                    btnKoltukEkle.Enabled = false;
                    btnKoltukEkle.Visible = false;
                    pnlSil.Visible = false;
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
            btnKoltukEkle.Enabled = false;
            btnKoltukEkle.Visible = false;
            pnlSil.Visible = false;
            MessageBox.Show("Yeni salon düzeni kaydedildi.", "İşlem Başarılı");
            pnlKoltuklar.Controls.Clear();
            SalonGetir(lblSalonKodu.Text.Trim());
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
                txtSalon_Code.Focus();
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
                txtSalon_Code.Text = Genel.Selected_Hall_Code;
            }
            btnDuzeniKaydet.Enabled = false;
            btnDuzeniKaydet.Visible = false;
            btnKoltukEkle.Enabled = false;
            btnKoltukEkle.Visible = false;
            pnlSil.Visible = false;
        }


        private void btnSalonDuzeni_Click(object sender, EventArgs e)
        {
            SilmeAlanıGörsel();
            pnlSil.Visible = true;
            btnKoltukEkle.Enabled = true;
            btnKoltukEkle.Visible = true;
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
        private void SilmeAlanıGörsel( )
        {
            pnlSil.Controls.Clear();
            lblSil.Text= "Koltuğu silmek için bu alana sürükleyin.";
            lblSil.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblSil.Width = 400;
            lblSil.Height = 25;
            lblSil.Location=new Point(500,10);
            lblSil.BackColor = Color.Transparent;
            lblSil.ForeColor = Color.White;
            lblSil.Font = new Font("Arial", 15, FontStyle.Bold);

            Label lblUyari = new Label();
            lblUyari.Text = "Uyarı!Koltuk ekleme ve silme işlemi koltuk düzeninden bağımsızdır onaylarsanız iptal edilemez.";
            lblUyari.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            lblUyari.Width = 400;
            lblUyari.Height = 50;
            lblUyari.Location = new Point(0, 5);
            lblUyari.BackColor = Color.Transparent;
            lblUyari.ForeColor = Color.White;
            lblUyari.Font = new Font("Arial", 10,FontStyle.Bold);

            pbSil.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            pbSil.Width = 45;
            pbSil.Height = 45;
            pbSil.Location = new Point(900, 0);
            pbSil.Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\minus.ico");
            pbSil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSil.BackColor = Color.Transparent;

            pnlSil.Controls.Add(lblSil);
            pnlSil.Controls.Add(pbSil);
            pnlSil.Controls.Add(lblUyari);
            pnlSil.Dock = DockStyle.Top;
            pnlSil.BackColor = Color.Transparent;
            pnlSil.Height = 45;
            pnlSil.BorderStyle = BorderStyle.Fixed3D;

            pnlKoltuklar.Controls.Add(pnlSil);
        }

        private void P_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            EskiKonum = pb.Location;
            SuruklemeDurumu = true;
            IlkKonum = e.Location;
            pb.BackColor = Color.LightGray;
        }
        private void P_MouseMove(object sender, MouseEventArgs e)
        {
            if (SuruklemeDurumu)
            {
                PictureBox pb = (PictureBox)sender;
                if (e.X + pb.Left - (IlkKonum.X) > 0 && e.Y + pb.Top - (IlkKonum.Y) > 0)
                {
                    pb.Left = e.X + pb.Left - (IlkKonum.X);
                    pb.Top = e.Y + pb.Top - (IlkKonum.Y);
                }
                pnlSil.BackColor = Color.LightSalmon;
                lblSil.ForeColor = Color.Black;
            }
        }
        private void P_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SuruklemeDurumu = false;
            pb.Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\KoltukOrange.png");
            pb.BackColor = Color.Transparent;
            pnlSil.BackColor = Color.Transparent;
            lblSil.ForeColor = Color.White;
            if (pb.Top < 45)
            {
                if (MessageBox.Show("Koltuğu silmek istiyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] PbName = pb.Name.Split('_');
                    int KoltukID = Convert.ToInt32(PbName[1]);
                    int  hallID = Genel.Service.Seat.SelectById(KoltukID).HallId;
                    Hall h = Genel.Service.Hall.SelectById(hallID);
                    if (h.Seating_Capacity!=0)
                    {
                        h.Seating_Capacity -= 1;
                        Genel.Service.Hall.Update(h);
                    }
                    Genel.Service.Seat.Delete(KoltukID);
                    pnlKoltuklar.Controls.Remove(pb);
                }
                else
                {
                    pb.Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\Koltuk.png");
                    pb.Location = EskiKonum;
                }
            }
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
            btnKoltukEkle.Enabled = false;
            btnKoltukEkle.Visible = false;
            pnlSil.Visible = false;
            pnlKoltuklar.Controls.Clear();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtSalon_Code.Text.Trim() != "")
            {
                btnDuzeniKaydet.Enabled = false;
                btnDuzeniKaydet.Visible = false;
                btnKoltukEkle.Enabled = false;
                btnKoltukEkle.Visible = false;
                pnlSil.Visible = false;
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
                    DSira = Convert.ToInt32(((DMaxUzunluk - pbHeight) / pbHeight) - DYuvarlamaFarki)-1;
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
