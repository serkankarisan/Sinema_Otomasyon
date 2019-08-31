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

        private void frmBiletKes_Load(object sender, EventArgs e)
        {
            foreach (Ticket item in Genel.Service.Ticket.Select().Where(s => s.Validity_Date <= DateTime.Now).ToList())
            {
                foreach (Ticket_Seat ts in item.Ticket_Seats)
                {
                    Genel.Service.TicketSeat.Delete(ts.Id);
                }
                Genel.Service.Ticket.Delete(item.Id);
            }
            foreach (Seance item in Genel.Service.Seance.Select().Where(s => s.Start_Time <= DateTime.Now).ToList())
            {
                Genel.Service.Seance.Delete(item.Id);
            }
        }

        Seance s;
        Movie m;
        Hall h;
        private void btnFilmeGoreSeansSec_Click(object sender, EventArgs e)
        {
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
                    return;
                }
                else
                {
                    Ticket t = new Ticket();
                    t.SeanceId = s.Id;
                    t.Validity_Date = s.Start_Time;
                    t.Ticket_Amount = 12;
                    t.Ticket_Code = "T" + DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString();
                    Customer c = new Customer();
                    c.Name = txtAdi.Text;
                    c.Surname = txtSoyadi.Text;
                    c.Phone = txtTel.Text.Trim();
                    Genel.Service.Customer.Insert(c);
                    t.CustomerId = Genel.Service.Customer.SelectByPhone(c.Phone).Id;
                    Genel.Service.Ticket.Insert(t);
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
                    foreach (int SeatID in SeatIDList)
                    {
                        Ticket_Seat ts = new Ticket_Seat();
                        ts.SeatId = SeatID;
                        ts.TicketId = Genel.Service.Ticket.SelectByTicketCode(t.Ticket_Code).Id;
                        Genel.Service.TicketSeat.Insert(ts);
                    }
                    MessageBox.Show(h.Hall_Code + " Numaralı salonda iyi seyirler dileriz.", "İşlem Başarılı");
                    Temizle();
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
                    if (pb.BackColor!=Color.DarkRed)
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
            List<int> SelectedSeatIDList = Genel.Service.TicketSeat.Select().Select(s => s.SeatId).ToList();
            List<Seat> SeatList = Genel.Service.Seat.SelectByHallCode(HallCode);
            List<Seat> SeatList2 = Genel.Service.Seat.SelectByHallCode(HallCode);
            List<Seat> SelectedSeatList = Genel.Service.Seat.SelectByHallCode(HallCode);
            foreach (Seat item in SeatList2)
            {
                foreach (int seatId in SelectedSeatIDList)
                {
                    if (item.Id == seatId)
                    {
                        SeatList.Remove(item);
                    }
                }
            }
            foreach (Seat item in SeatList2)
            {
                foreach (Seat seat in SeatList)
                {
                    if (item.Id == seat.Id)
                    {
                        SelectedSeatList.Remove(item);
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
    }
}
