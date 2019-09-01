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
        int pbWidth = 100, pbHeight = 75;
        int Dsayac = 0, Ysayac = 0;
        float YKalan = 0, YMaxUzunluk = 0, YSira = 0, YAralik = 0, Soldan = 0, Ustten = 0, YYuvarlamaFarki = 0;
        float DKalan = 0, DMaxUzunluk = 0, DSira = 0, DAralik = 0, DYuvarlamaFarki = 0;
        bool KapasiteAsimi = false;
        bool Salon_Eklendi = false;
        string EklenenSalonKodu = "";
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
            btnSalonDuzeni.Enabled = false;
            btnSalonDuzeni.Visible = false;
            txtKoltukKapasitesi.Clear();
        }
        private void KoltukTemizle(Panel pnl)
        {
            pnl.Controls.Clear();
            lblSalonKodu.Text = "";
            lblSalon.Visible = false;
            btnSalonDuzeni.Enabled = false;
            btnSalonDuzeni.Visible = false;
        }
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKoltukKapasitesi.Text.Trim()))
            {
                if (Convert.ToInt32(txtKoltukKapasitesi.Text.Trim()) <= 153)
                {
                    if (!KapasiteAsimi)
                    {
                        Hall s = new Hall();
                        s.Hall_Code = "SLN" + DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString();
                        if (int.TryParse(txtKoltukKapasitesi.Text.Trim(), out salon_kapasite))
                        {
                            s.Seating_Capacity = salon_kapasite;
                            s.Max_Capacity = salon_kapasite;
                        }
                        else
                        {
                            MessageBox.Show("Kapasite sayılardan oluşmalı.", "Hata!");
                            return;
                        }
                        if (Genel.Service.Hall.Insert(s) > 0)
                        {
                            Salon_Eklendi = true;
                            EklenenSalonKodu = Genel.Service.Hall.SelectByHallCode(s.Hall_Code).Hall_Code;
                            pnlKoltuklar.Controls.Clear();
                        }
                    }
                    if (Salon_Eklendi)
                    {
                        //Yatay hesap
                        YMaxUzunluk = pnlKoltuklar.Width;
                        Genel.pnlKoltukWidth = YMaxUzunluk;
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
                        Genel.pnlKoltukHeight = DMaxUzunluk;
                        if (DMaxUzunluk % pbHeight == 0)
                        {
                            DKalan = pbHeight;
                            DSira = Convert.ToInt32(((DMaxUzunluk - pbHeight) / pbHeight) - DYuvarlamaFarki)-1;
                        }
                        else
                        {
                            DKalan = DMaxUzunluk % pbHeight;
                            DYuvarlamaFarki = DKalan / pbHeight;
                            DSira = Convert.ToInt32((DMaxUzunluk / pbHeight) - DYuvarlamaFarki) - 1;
                        }
                        DAralik = (DKalan / (DSira - 1));
                        Ustten = (pbHeight + DAralik) * (DSira - 1);
                        Hall EklenenSalon = Genel.Service.Hall.SelectByHallCode(EklenenSalonKodu);
                        if ((DSira - 1) * YSira < EklenenSalon.Max_Capacity)
                        {
                            KapasiteAsimi = true;
                            pbHeight -= 25;
                            pbWidth -= 25;
                            btnKaydet_Click(sender, e);
                            return;
                        }
                        int kod = 0;
                        for (int i = 0; i < EklenenSalon.Seating_Capacity; i++)
                        {
                            Seat k = new Seat();
                            k.HallId = EklenenSalon.Id;
                            k.Seat_Code = "K" + DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString() + kod;
                            if (Genel.Service.Seat.Insert(k) > 0)
                            {
                                kod += 1;
                                Seat EklenenKoltuk = Genel.Service.Seat.SelectBySeatCode(k.Seat_Code);
                                PictureBox pb = new PictureBox()
                                {
                                    Height = pbHeight,
                                    Width = pbWidth,
                                    Name = "pb_" + EklenenKoltuk.Id,
                                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                                    Image = Image.FromFile(Application.StartupPath + "" + "\\Images\\Koltuk.png"),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    BackColor = Color.Transparent,
                                    BackgroundImage=null,
                                };
                                pnlKoltuklar.Controls.Add(pb);
                                if (Ysayac == YSira)
                                {
                                    Ysayac = 0;
                                    Soldan = YAralik;
                                    Ustten -= (pb.Height + DAralik);
                                    Dsayac += 1;
                                }
                                pb.Location = new Point(Convert.ToInt32(Soldan), Convert.ToInt32(Ustten));
                                EklenenKoltuk.Location_X = Convert.ToInt32(Soldan);
                                EklenenKoltuk.Location_Y = Convert.ToInt32(Ustten);
                                Genel.Service.Seat.Update(EklenenKoltuk);
                                Soldan += (pb.Width + YAralik);
                                Ysayac += 1;
                            }
                        }
                        MessageBox.Show("Salon başarıyla eklendi.", "İşlem Başarılı");
                        Genel.Selected_Hall_Code = EklenenSalon.Hall_Code;
                        Bitti();
                    }
                }
                else
                {
                    MessageBox.Show("Salon kapasitesi Max Koltuk Kapasitesi(153)'ni geçemez.", "Hata!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Salon kapasitesi girmelisiniz.", "Eksik Bilgi!");
                return;
            }
        }

        private void btnSalonDuzeni_Click(object sender, EventArgs e)
        {
            frmSalonDüzenleme frm = new frmSalonDüzenleme();
            FormAcAnasayfa(frm);
            this.Hide();
        }
        private void FormAcAnasayfa(Form AF)
        {
            foreach (Control F in this.Parent.Controls)
            {
                if (F is Form)
                {
                    Form MF = (Form)F;
                    Genel.FormActive = false;
                    MF.Hide();
                }
            }
            AF.TopLevel = false;
            this.Parent.Controls.Add(AF);
            AF.Dock = DockStyle.Fill;
            Genel.FormActive = true;
            AF.Show();
        }
        private void Bitti()
        {
            btnKaydet.Enabled = false;
            btnIptal.Enabled = false;
            btnIptal.Visible = false;
            btnSalonDuzeni.Enabled = true;
            btnSalonDuzeni.Visible = true;
            txtKoltukKapasitesi.Enabled = false;
            txtKoltukKapasitesi.Clear();
            lblSalonKodu.Text = EklenenSalonKodu;
            lblSalon.Visible = true;
            KapasiteAsimi = false;
            Salon_Eklendi = false;
            pbWidth = 100;
            pbHeight = 75;
            Dsayac = 0;
            Ysayac = 0;
            YKalan = 0;
            YMaxUzunluk = 0;
            YSira = 0;
            YAralik = 0;
            Soldan = 0;
            Ustten = 0;
            YYuvarlamaFarki = 0;
            DKalan = 0;
            DMaxUzunluk = 0;
            DSira = 0;
            DAralik = 0;
            DYuvarlamaFarki = 0;
            EklenenSalonKodu = "";
        }
    }
}
