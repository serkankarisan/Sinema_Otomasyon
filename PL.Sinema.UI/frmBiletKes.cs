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
    public partial class frmBiletKes : Form
    {
        public frmBiletKes()
        {
            InitializeComponent();
        }
        int pbWidth = 100, pbHeight = 75;
        int Dsayac = 0, Ysayac = 0;
        float YKalan = 0, YMaxUzunluk = 0, YSira = 0, YAralik = 0, Soldan = 0, Ustten = 0, YYuvarlamaFarki = 0;
        float DKalan = 0, DMaxUzunluk = 0, DSira = 0, DAralik = 0, DYuvarlamaFarki = 0;
        Seance s;
        Movie m;
        Hall h;
        int TicketID = 0;
        private void frmBiletKes_Load(object sender, EventArgs e)
        {
            SuresiDolanBiletSil();
            SuresiDolanSeansSil();
        }
        private void btnFilmeGoreSeansSec_Click(object sender, EventArgs e)
        {
            SuresiDolanBiletSil();
            SuresiDolanSeansSil();
            frmFilmSec frm = new frmFilmSec();
            frm.ShowDialog();
            m = Genel.Service.Movie.SelectById(Genel.Selected_Film_ID);
            if (m != null)
            {
                Genel.SeansByFilm = true;
                frmSeansSec frmSeansSec = new frmSeansSec();
                frmSeansSec.ShowDialog();
                s = Genel.Service.Seance.SelectById(Genel.Selected_Seance_ID);
                if (s != null)
                {
                    h = Genel.Service.Hall.SelectById(s.HallId);
                    SalonGetir(h.Hall_Code);
                    Genel.SeansByFilm = false;
                    BiletKes();
                }
            }
        }
        private void btnBiletOnayla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bilet kesilsin mi?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (txtTel.Text.Trim().Count() < 10)
                {
                    MessageBox.Show("Telefon numarası hatalı.", "Hata!");
                    txtTel.Focus();
                    return;
                }
                else
                {
                    List<int> SeatIDList = new List<int>();
                    foreach (Control p in this.pnlKoltuklar.Controls)
                    {
                        if (p is PictureBox && p.BackColor == Color.DarkOrange)
                        {
                            PictureBox pb = (PictureBox)p;
                            string[] pbName = pb.Name.Split('_');
                            SeatIDList.Add(Convert.ToInt32(pbName[1]));
                        }
                    }
                    if (SeatIDList.Count() != 0)
                    {

                        Ticket t = new Ticket();
                        t.SeanceId = s.Id;
                        t.Validity_Date = s.Start_Time;
                        Genel.BiletFiyatBelirleme();
                        t.Ticket_Amount = SeatIDList.Count() * Genel.BiletFiyat;
                        t.Ticket_Code = "T" + DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString();
                        Customer c = new Customer();
                        c.Name = txtAdi.Text;
                        c.Surname = txtSoyadi.Text;
                        c.Phone = txtTel.Text.Trim();
                        Genel.Service.Customer.Insert(c);
                        t.CustomerId = Genel.Service.Customer.SelectByPhone(c.Phone).Id;
                        Genel.Service.Ticket.Insert(t);
                        TicketID = Genel.Service.Ticket.SelectByTicketCode(t.Ticket_Code).Id;
                        foreach (int SeatID in SeatIDList)
                        {
                            Ticket_Seat ts = new Ticket_Seat();
                            ts.SeatId = SeatID;
                            ts.TicketId = Genel.Service.Ticket.SelectByTicketCode(t.Ticket_Code).Id;
                            Genel.Service.TicketSeat.Insert(ts);
                        }
                        string[] Bilet = t.Ticket_Code.Split('.');
                        string[] Devami = Bilet[2].Split(':');
                        string TCode = Bilet[0] + Bilet[1] + Devami[0] + Devami[1] + Devami[2];

                        MessageBox.Show(h.Hall_Code + " Numaralı salonda iyi seyirler dileriz.", "İşlem Başarılı");
                        Clipboard.SetText(TCode);
                        printPrwDialog1.Document.DocumentName = TCode;
                        printPrwDialog1.Focus();
                        printPrwDialog1.Width = this.FindForm().Width;
                        printPrwDialog1.Height = this.FindForm().Height+80;
                        printPrwDialog1.ShowDialog();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Koltuk seçmelisiniz.", "Hata!");
                        return;
                    }
                }

            }
        }
        private void btnAnamenu_Click(object sender, EventArgs e)
        {
            Genel.FormActive = false;
            this.Close();
        }
        private void btnSeansSec_Click(object sender, EventArgs e)
        {
            SuresiDolanBiletSil();
            SuresiDolanSeansSil();
            frmSeansSec frm = new frmSeansSec();
            frm.ShowDialog();
            s = Genel.Service.Seance.SelectById(Genel.Selected_Seance_ID);
            if (s != null)
            {
                h = Genel.Service.Hall.SelectById(s.HallId);
                SalonGetir(h.Hall_Code);
                BiletKes();
            }
        }

        private void BiletKes()
        {
            btnBiletOnayla.Visible = true;
            foreach (Control p in this.pnlKoltuklar.Controls)
            {
                if (p is PictureBox)
                {
                    PictureBox pb = (PictureBox)p;
                    if (pb.BackColor != Color.DarkRed)
                    {
                        pb.Enabled = true;
                    }
                    pb.Click += Pb_Click;
                }
            }

        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.BackColor == Color.Transparent)
            {
                pb.BackColor = Color.DarkOrange;
            }
            else
            {
                pb.BackColor = Color.Transparent;
            }
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTel.Clear();
            btnBiletOnayla.Visible = false;
            pnlKoltuklar.Controls.Clear();
            Genel.Selected_Film_ID = 0;
            Genel.Selected_Seance_ID = 0;
            s = null;
            m = null;
            h = null;
        }
        private void SalonGetir(string HallCode)
        {
            pnlKoltuklar.Controls.Clear();
            List<Ticket_Seat> SelectedSeatListIlk = Genel.Service.TicketSeat.Select();
            List<Seat> SeatList = Genel.Service.Seat.SelectByHallCode(HallCode);
            List<Seat> SeatList2 = Genel.Service.Seat.SelectByHallCode(HallCode);
            List<Seat> SelectedSeatList = Genel.Service.Seat.SelectByHallCode(HallCode);
            foreach (Seat koltuk in SeatList2)
            {
                foreach (Ticket_Seat ticketseat in SelectedSeatListIlk)
                {
                    Ticket bilet = Genel.Service.Ticket.SelectById(ticketseat.TicketId);
                    Seance Snc = Genel.Service.Seance.SelectById(bilet.SeanceId);
                    if (koltuk.Id == ticketseat.SeatId && Snc.Id == s.Id)
                    {
                        SeatList.Remove(koltuk);
                    }
                }
            }
            foreach (Seat koltuk in SeatList2)
            {
                foreach (Seat seat in SeatList)
                {
                    if (koltuk.Id == seat.Id)
                    {
                        SelectedSeatList.Remove(koltuk);
                    }
                }
            }
            int HallMaxCap = Genel.Service.Hall.SelectByHallCode(HallCode).Max_Capacity;
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
                    DSira = Convert.ToInt32(((DMaxUzunluk - pbHeight) / pbHeight) - DYuvarlamaFarki) - 1;
                }
                else
                {
                    DKalan = DMaxUzunluk % pbHeight;
                    DYuvarlamaFarki = DKalan / pbHeight;
                    DSira = Convert.ToInt32((DMaxUzunluk / pbHeight) - DYuvarlamaFarki);
                }
                foreach (Seat k in SeatList)
                {
                    if ((DSira - 1) * YSira < HallMaxCap)
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
                        BackgroundImage = null,
                        Enabled = false,
                    };
                    pnlKoltuklar.Controls.Add(pb);
                    pb.Location = new Point(k.Location_X, k.Location_Y);
                }
                foreach (Seat k in SelectedSeatList)
                {
                    if ((DSira - 1) * YSira < HallMaxCap)
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
                        BackColor = Color.DarkRed,
                        BackgroundImage = null,
                        Enabled = false,
                    };
                    pnlKoltuklar.Controls.Add(pb);
                    pb.Location = new Point(k.Location_X, k.Location_Y);
                }
                lblSalonKodu.Text = HallCode;
                lblSalon.Visible = true;
            }
            else
            {
                MessageBox.Show("Salon bulunamadı.", "Hata!");
                return;
            }
        }
        private void SuresiDolanSeansSil()
        {
            List<Seance> SuresiDolmusSeanslar = Genel.Service.Seance.Select().Where(s => s.Start_Time <= DateTime.Now).ToList();
            if (SuresiDolmusSeanslar.Count() != 0)
            {
                foreach (Seance seans in SuresiDolmusSeanslar)
                {
                    if (seans != null)
                    {
                        List<Ticket> BiletListe = Genel.Service.Ticket.Select().Where(t => t.SeanceId == seans.Id).ToList();
                        if (BiletListe.Count() != 0)
                        {
                            foreach (Ticket t in BiletListe)
                            {
                                List<Ticket_Seat> BiletKoltukListe = Genel.Service.TicketSeat.Select().Where(ts => ts.TicketId == t.Id).ToList();
                                if (BiletKoltukListe.Count() != 0)
                                {
                                    foreach (Ticket_Seat ts in BiletKoltukListe)
                                    {
                                        if (ts != null)
                                        {
                                            Genel.Service.TicketSeat.Delete(ts.Id);
                                        }
                                    }
                                }
                                Genel.Service.Ticket.Delete(t.Id);
                            }
                        }
                        Genel.Service.Seance.Delete(seans.Id);
                    }
                }
            }
        }

        private void SuresiDolanBiletSil()
        {
            List<Ticket> SuresiDolanBiletler = Genel.Service.Ticket.Select().Where(s => s.Validity_Date <= DateTime.Now).ToList();
            if (SuresiDolanBiletler != null)
            {
                foreach (Ticket ticket in SuresiDolanBiletler)
                {
                    if (ticket != null)
                    {
                        List<Ticket_Seat> BiletKoltukListe = Genel.Service.TicketSeat.Select().Where(ts => ts.TicketId == ticket.Id).ToList();
                        if (BiletKoltukListe.Count() != 0)
                        {
                            foreach (Ticket_Seat ts in BiletKoltukListe)
                            {
                                if (ts != null)
                                {
                                    Genel.Service.TicketSeat.Delete(ts.Id);
                                }
                            }
                        }
                    }
                    Genel.Service.Ticket.Delete(ticket.Id);
                }
            }
        }
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Ticket YazdirilacakBilet = Genel.Service.Ticket.SelectById(TicketID);
            List<Ticket_Seat> Koltuklar = Genel.Service.TicketSeat.Select().Where(ts => ts.TicketId == TicketID).ToList();
            Seance YazilacakSeans = Genel.Service.Seance.SelectById(YazdirilacakBilet.SeanceId);
            Movie YazilacakFilm = Genel.Service.Movie.SelectById(YazilacakSeans.MovieId);
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font Baslik = new Font("Calibri", 20);
            Font font2 = new Font("Calibri", 15,FontStyle.Bold);
            Font font = new Font("Calibri", 12);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 100, 100, 700, 100);
            e.Graphics.DrawLine(myPen, 100, 150, 700, 150);
            e.Graphics.DrawString("SİNEMA OTOMASYON", Baslik, sbrush, 250, 100);

            e.Graphics.DrawLine(myPen, 100, 200, 700, 200);

            e.Graphics.DrawString("Bilet Kodu", font, sbrush, 100, 225);
            e.Graphics.DrawString(YazdirilacakBilet.Ticket_Code, font, sbrush, 250, 225);
            e.Graphics.DrawString("Koltuk Sayısı", font, sbrush, 100, 250);
            e.Graphics.DrawString(Koltuklar.Count().ToString(), font, sbrush, 250, 250);
            e.Graphics.DrawString("Birim Fiyatı", font, sbrush, 100, 275);
            e.Graphics.DrawString((YazdirilacakBilet.Ticket_Amount / Koltuklar.Count()).ToString("c"), font, sbrush, 250, 275);

            e.Graphics.DrawString("Koltuklar", font, sbrush, 100, 300);
            for (int i = 0; i < Koltuklar.Count(); i++)
            {
                Seat SeciliKoltuk = Genel.Service.Seat.SelectById(Koltuklar[i].SeatId);
                e.Graphics.DrawString(SeciliKoltuk.Seat_Code, font, sbrush, 250, ((i * 25) + 325));
            }

            e.Graphics.DrawString("Film", font, sbrush, 100, (Koltuklar.Count() * 25 + 350));
            e.Graphics.DrawString(YazilacakFilm.Movie_Name, font, sbrush, 250, (Koltuklar.Count() * 25 + 350));
            e.Graphics.DrawString("Salon Kodu", font, sbrush, 100, (Koltuklar.Count() * 25 + 375));
            e.Graphics.DrawString(h.Hall_Code, font, sbrush, 250, (Koltuklar.Count() * 25 + 375));
            e.Graphics.DrawString("Tarih", font, sbrush, 100, (Koltuklar.Count() * 25 + 400));
            e.Graphics.DrawString(YazdirilacakBilet.Validity_Date.ToString(), font, sbrush, 250, (Koltuklar.Count() * 25 + 400));

            e.Graphics.DrawLine(myPen, 100, (Koltuklar.Count() * 25 + 425), 750, (Koltuklar.Count() * 25 + 425));
            e.Graphics.DrawString("Bilet Tutarı", font2, sbrush, 100, (Koltuklar.Count() * 25 + 425));
            e.Graphics.DrawString(YazdirilacakBilet.Ticket_Amount.ToString("c"), font2, sbrush, 250, (Koltuklar.Count() * 25 + 425));
            e.Graphics.DrawLine(myPen, 100, (Koltuklar.Count() * 25 + 450), 750, (Koltuklar.Count() * 25 + 450));

            e.Graphics.DrawString("İyi Seyirler...", Baslik, sbrush, 325, (Koltuklar.Count() * 25 + 500));
        }

    }
}
