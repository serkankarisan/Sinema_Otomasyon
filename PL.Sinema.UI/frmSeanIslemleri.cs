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
    public partial class frmSeanIslemleri : Form
    {
        public frmSeanIslemleri()
        {
            InitializeComponent();
        }
        DateTime baslangic = new DateTime();
        DateTime bugun = new DateTime();
        DateTime Baslama_tarihi = new DateTime();
        DateTime Bitis_tarihi = new DateTime();
        Movie m;
        Hall h;
        Seance seance;
        int saat, dk;
        bool s = false, d = false;
        int Yenidk, Yenisaat;
        bool kontrol = false;
        private void btnSalonSec_Click(object sender, EventArgs e)
        {
            bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            baslangic = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            if (baslangic >= bugun)
            {
                if (txtdk.Text.Trim() == "")
                {
                    txtdk.Text = "00";
                    dk = 0;
                }
                if (int.TryParse(txtdk.Text.Trim(), out dk))
                {
                    if (dk <= 60 && dk >= 0)
                    {
                        d = true;
                    }
                    else
                    {
                        MessageBox.Show("Dakika 60 ile 0 arası bir değer olmalı.", "Eksik Bilgi!");
                        txtdk.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Dakika sayılardan oluşmalı.", "Hata!");
                    txtdk.Focus();
                    return;
                }
                if (txtSaat.Text.Trim() != "")
                {
                    if (int.TryParse(txtSaat.Text.Trim(), out saat))
                    {
                        if (saat < 24 && saat >= 0)
                        {
                            s = true;
                        }
                        else
                        {
                            MessageBox.Show("Saat 23 ile 0 arası bir değer olmalı.", "Eksik Bilgi!");
                            txtSaat.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saat sayılardan oluşmalı.", "Hata!");
                        txtSaat.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Saat girmelisiniz.", "Eksik Bilgi!");
                    txtSaat.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                dtpBaslangic.Value = DateTime.Now;
                return;
            }
            if (s && d)
            {
                TarihHesapla();
                Genel.BaslangicTarihi = Baslama_tarihi;
                Genel.BitisTarihi = Bitis_tarihi;
                Genel.HallByDate = true;
                frmSalonSec frm = new frmSalonSec();
                frm.ShowDialog();
                h = Genel.Service.Hall.SelectByHallCode(Genel.Selected_Hall_Code);
                if (h != null)
                {
                    btnSalonIptal.Visible = true;
                    txtdk.Enabled = false;
                    txtSaat.Enabled = false;
                    lblSalonKodu.Text = h.Hall_Code;
                    lblSalonKapasite.Text = h.Seating_Capacity.ToString();
                    if (seance == null)
                    {
                        btnSeansEkle.Visible = true;
                    }
                }
                else
                {
                    txtdk.Enabled = true;
                    txtSaat.Enabled = true;
                }
            }
        }

        private void frmSeanIslemleri_Load(object sender, EventArgs e)
        {
            SuresiDolanSeansSil();
            txtSaat.Focus();
        }
        
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if (!kontrol)
            {
                bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                baslangic = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
                if (!(baslangic >= bugun))
                {
                    MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                    dtpBaslangic.Value = DateTime.Now;
                    return;
                }
            }
        }
        private void SuresiDolanSeansSil()
        {
            List<Seance> SuresiDolmusSeanslar = Genel.Service.Seance.Select().Where(s => s.Start_Time <= DateTime.Now).ToList();
            if (SuresiDolmusSeanslar != null)
            {
                foreach (Seance seans in SuresiDolmusSeanslar)
                {
                    if (seans != null)
                    {
                        if (seans.Tickets != null)
                        {
                            foreach (Ticket t in seans.Tickets)
                            {
                                if (t.Ticket_Seats != null)
                                {
                                    foreach (Ticket_Seat ts in t.Ticket_Seats)
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
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            SuresiDolanSeansSil();
            Genel.SeansByFilm = false;
            frmSeansSec frm = new frmSeansSec();
            frm.ShowDialog();
            seance = Genel.Service.Seance.SelectById(Genel.Selected_Seance_ID);
            if (seance != null)
            {
                Movie FilmBySeans = Genel.Service.Movie.SelectById(seance.MovieId);
                Hall SalonBySeans = Genel.Service.Hall.SelectById(seance.HallId);
                btnIptal.Visible = true;
                btnKaydet.Visible = true;
                btnSil.Visible = true;
                btnSalonSec.Enabled = true;
                kontrol = true;
                lblFilmAdi.Text = FilmBySeans.Movie_Name;
                lblSure.Text = FilmBySeans.Movie_Duration_InMinute.ToString();
                lblTur.Text = FilmBySeans.Movie_Type;
                lblSalonKodu.Text = SalonBySeans.Hall_Code;
                lblSalonKapasite.Text = SalonBySeans.Seating_Capacity.ToString();

                string[] date = seance.Start_Time.ToString().Split(' ');
                string[] hour = date[1].Split(':');

                txtSaat.Text = hour[0];
                txtdk.Text = (Convert.ToInt32(hour[1]) + 10).ToString();
                dtpBaslangic.Value = seance.Start_Time;
            }
            else
            {
                Genel.Selected_Seance_ID = 0;
                Genel.Selected_Film_ID = 0;
                Genel.Selected_Hall_Code = "";
                seance = null;
                h = null;
                m = null;
                btnSil.Visible = false;
                btnKaydet.Visible = false;
                btnIptal.Visible = false;
                btnSeansEkle.Visible = false;
                lblFilmAdi.Text = "";
                lblSure.Text = "";
                lblTur.Text = "";
                lblSalonKodu.Text = "";
                lblSalonKapasite.Text = "";
                dtpBaslangic.Value = DateTime.Now;
                txtdk.Clear();
                txtSaat.Clear();
                btnSalonSec.Enabled = false;
                btnSalonIptal.Visible = false;
                txtdk.Enabled = true;
                txtSaat.Enabled = true;
                Genel.HallByDate = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            baslangic = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            if (baslangic >= bugun)
            {
                if (txtdk.Text.Trim() == "")
                {
                    txtdk.Text = "00";
                    dk = 0;
                }
                if (int.TryParse(txtdk.Text.Trim(), out dk))
                {
                    if (dk <= 60 && dk >= 0)
                    {
                        d = true;
                    }
                    else
                    {
                        MessageBox.Show("Dakika 60 ile 0 arası bir değer olmalı.", "Eksik Bilgi!");
                        txtdk.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Dakika sayılardan oluşmalı.", "Hata!");
                    txtdk.Focus();
                    return;
                }
                if (txtSaat.Text.Trim() != "")
                {
                    if (int.TryParse(txtSaat.Text.Trim(), out saat))
                    {
                        if (saat < 24 && saat >= 0)
                        {
                            s = true;
                        }
                        else
                        {
                            MessageBox.Show("Saat 23 ile 0 arası bir değer olmalı.", "Eksik Bilgi!");
                            txtSaat.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saat sayılardan oluşmalı.", "Hata!");
                        txtSaat.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Saat girmelisiniz.", "Eksik Bilgi!");
                    txtSaat.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                dtpBaslangic.Value = DateTime.Now;
                return;
            }
            if (s && d)
            {
                TarihHesapla();
                seance.Start_Time = Baslama_tarihi;
                seance.End_Time = Bitis_tarihi;
                if (h != null)
                {
                    seance.HallId = h.Id;
                }
                if (m != null)
                {
                    seance.MovieId = m.Id;
                }
                Genel.Service.Seance.Update(seance);
                Genel.Selected_Seance_ID = 0;
                Genel.Selected_Film_ID = 0;
                Genel.Selected_Hall_Code = "";
                seance = null;
                h = null;
                m = null;
                btnSil.Visible = false;
                btnKaydet.Visible = false;
                btnIptal.Visible = false;
                btnSeansEkle.Visible = false;
                lblFilmAdi.Text = "";
                lblSure.Text = "";
                lblTur.Text = "";
                lblSalonKodu.Text = "";
                lblSalonKapasite.Text = "";
                dtpBaslangic.Value = DateTime.Now;
                txtdk.Clear();
                txtSaat.Clear();
                btnSalonSec.Enabled = false;
                btnSalonIptal.Visible = false;
                txtdk.Enabled = true;
                txtSaat.Enabled = true;
                Genel.HallByDate = false;
                MessageBox.Show("Seans başarıyla güncellendi.", "İşlem Başarılı");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Genel.Selected_Seance_ID = 0;
            Genel.Selected_Film_ID = 0;
            Genel.Selected_Hall_Code = "";
            seance = null;
            h = null;
            m = null;
            btnSil.Visible = false;
            btnKaydet.Visible = false;
            btnIptal.Visible = false;
            btnSeansEkle.Visible = false;
            lblFilmAdi.Text = "";
            lblSure.Text = "";
            lblTur.Text = "";
            lblSalonKodu.Text = "";
            lblSalonKapasite.Text = "";
            dtpBaslangic.Value = DateTime.Now;
            txtdk.Clear();
            txtSaat.Clear();
            btnSalonSec.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seance != null && MessageBox.Show("Silmek İstiyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Genel.Service.Seance.Delete(seance.Id) > 0)
                {
                    Genel.Selected_Seance_ID = 0;
                    Genel.Selected_Film_ID = 0;
                    Genel.Selected_Hall_Code = "";
                    seance = null;
                    h = null;
                    m = null;
                    btnSil.Visible = false;
                    btnKaydet.Visible = false;
                    btnIptal.Visible = false;
                    btnSeansEkle.Visible = false;
                    lblFilmAdi.Text = "";
                    lblSure.Text = "";
                    lblTur.Text = "";
                    lblSalonKodu.Text = "";
                    lblSalonKapasite.Text = "";
                    dtpBaslangic.Value = DateTime.Now;
                    txtdk.Clear();
                    txtSaat.Clear();
                    btnSalonSec.Enabled = false;
                    btnSalonIptal.Visible = false;
                    txtdk.Enabled = true;
                    txtSaat.Enabled = true;
                    Genel.HallByDate = false;
                    MessageBox.Show("Seans başarıyla silindi.", "İşlem Başarılı");
                }
            }
        }

        private void btnSalonIptal_Click(object sender, EventArgs e)
        {
            txtSaat.Enabled = true;
            txtdk.Enabled = true;
            lblSalonKodu.Text = "";
            lblSalonKapasite.Text = "";
            Genel.Selected_Hall_Code = "";
            btnSalonIptal.Visible = false;
            btnSeansEkle.Visible = false;
        }

        private void btnFilmSec_Click(object sender, EventArgs e)
        {
            bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            baslangic = Convert.ToDateTime(dtpBaslangic.Value.ToShortDateString());
            if (baslangic >= bugun)
            {
                if (txtdk.Text.Trim() == "")
                {
                    txtdk.Text = "00";
                    dk = 0;
                }
                if (int.TryParse(txtdk.Text.Trim(), out dk))
                {
                    if (dk <= 60 && dk >= 0)
                    {
                        d = true;
                    }
                    else
                    {
                        MessageBox.Show("Dakika 60 ile 0 arası bir değer olmalı.", "Eksik Bilgi!");
                        txtdk.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Dakika sayılardan oluşmalı.", "Hata!");
                    txtdk.Focus();
                    return;
                }
                if (txtSaat.Text.Trim() != "")
                {
                    if (int.TryParse(txtSaat.Text.Trim(), out saat))
                    {
                        if (saat < 24 && saat >= 0)
                        {
                            s = true;
                        }
                        else
                        {
                            MessageBox.Show("Saat 23 ile 0 arası bir değer olmalı.", "Eksik Bilgi!");
                            txtSaat.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saat sayılardan oluşmalı.", "Hata!");
                        txtSaat.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Saat girmelisiniz.", "Eksik Bilgi!");
                    txtSaat.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                dtpBaslangic.Value = DateTime.Now;
                return;
            }
            if (s && d)
            {
                frmFilmSec frm = new frmFilmSec();
                frm.ShowDialog();
                m = Genel.Service.Movie.SelectById(Genel.Selected_Film_ID);
                if (m != null)
                {
                    lblFilmAdi.Text = m.Movie_Name;
                    lblSure.Text = m.Movie_Duration_InMinute.ToString();
                    lblTur.Text = m.Movie_Type;
                    btnSalonSec.Enabled = true;
                }
            }

        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            if (m != null && h != null)
            {
                Seance s = new Seance();
                s.HallId = h.Id;
                s.MovieId = m.Id;
                s.Start_Time = Baslama_tarihi;
                s.End_Time = Bitis_tarihi;
                if (Genel.Service.Seance.Insert(s) > 0)
                {
                    MessageBox.Show("Seans başarıyla eklendi.", "İşlem Başarılı");
                    Genel.Selected_Seance_ID = 0;
                    Genel.Selected_Film_ID = 0;
                    Genel.Selected_Hall_Code = "";
                    seance = null;
                    h = null;
                    m = null;
                    btnSil.Visible = false;
                    btnKaydet.Visible = false;
                    btnIptal.Visible = false;
                    btnSeansEkle.Visible = false;
                    lblFilmAdi.Text = "";
                    lblSure.Text = "";
                    lblTur.Text = "";
                    lblSalonKodu.Text = "";
                    lblSalonKapasite.Text = "";
                    dtpBaslangic.Value = DateTime.Now;
                    txtdk.Clear();
                    txtSaat.Clear();
                    btnSalonSec.Enabled = false;
                    btnSalonIptal.Visible = false;
                    txtdk.Enabled = true;
                    txtSaat.Enabled = true;
                    Genel.HallByDate = false;
                }
                else
                {
                    MessageBox.Show("Seans eklenemedi.", "Hata!");
                    return;
                }

            }
        }
        private void TarihHesapla()
        {
            string[] date = baslangic.ToString().Split(' ');
            string[] hour = date[1].Split(':');
            if (dk < 10)
            {
                Yenidk = 60 - dk;
                if (saat == 0)
                {
                    hour[0] = "23";
                }
                else
                {
                    saat = saat - 1;
                    hour[0] = saat.ToString();
                }
                hour[1] = (Yenidk - (10)).ToString();
            }
            else
            {
                Yenidk = dk;
                hour[0] = saat.ToString();
                hour[1] = (Yenidk - 10).ToString();
            }
            Baslama_tarihi = Convert.ToDateTime(date[0] + " " + hour[0] + ":" + hour[1] + ":00");
            int filmSaat = (Convert.ToInt32(lblSure.Text) / 60);
            int filmDk = (Convert.ToInt32(lblSure.Text) % 60);
            bool NextDay = false;
            if (saat + filmSaat >= 24)
            {
                saat = (saat + filmSaat) % 24;
                NextDay = true;
                hour[0] = (saat).ToString();
                hour[1] = (Yenidk + filmDk).ToString();
            }
            else
            {
                if (Yenidk + filmDk >= 60)
                {
                    hour[0] = (saat + filmSaat + ((Yenidk + filmDk) / 60)).ToString();
                    hour[1] = (((Yenidk + filmDk) % 60)).ToString();
                }
                else
                {
                    hour[0] = (saat + filmSaat).ToString();
                    hour[1] = (Yenidk + filmDk).ToString();
                }
            }
            Bitis_tarihi = Convert.ToDateTime(date[0] + " " + hour[0] + ":" + hour[1] + ":00");
            if (NextDay)
            {
                Bitis_tarihi = Bitis_tarihi.AddDays(1);
                NextDay = false;
            }
        }
    }
}
