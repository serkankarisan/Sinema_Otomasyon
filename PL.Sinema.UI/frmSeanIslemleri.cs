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
        int saat, dk;
        bool s = false, d = false;
        private void btnSalonSec_Click(object sender, EventArgs e)
        {
            if (s && d)
            {
                string[] date = baslangic.ToString().Split(' ');
                string[] hour = date[1].Split(':');
                hour[0] = saat.ToString();
                hour[1] = dk.ToString();
                Baslama_tarihi = Convert.ToDateTime(date[0] + " " + hour[0] + ":" + hour[1] + ":00");
                int filmSaat = (Convert.ToInt32(lblSure.Text) / 60);
                int filmDk = (Convert.ToInt32(lblSure.Text) % 60);
                hour[0] = (saat + filmSaat).ToString();
                hour[1] = (dk + filmDk).ToString();
                Bitis_tarihi = Convert.ToDateTime(date[0] + " " + hour[0] + ":" + hour[1] + ":00");
                Genel.BaslangicTarihi = Baslama_tarihi;
                Genel.BitisTarihi = Bitis_tarihi;
                Genel.Filter = true;
                frmSalonSec frm = new frmSalonSec();
                frm.ShowDialog();
                h = Genel.Service.Hall.SelectByHallCode(Genel.Selected_Hall_Code);
                if (h != null)
                {
                    lblSalonKodu.Text = h.Hall_Code;
                    lblSalonKapasite.Text = h.Seating_Capacity.ToString();
                    btnSeansEkle.Visible = true;
                }
            }

        }

        private void frmSeanIslemleri_Load(object sender, EventArgs e)
        {
            txtSaat.Focus();
        }

        //private void txtSaat_TextChanged(object sender, EventArgs e)
        //{
        //    int st;
        //    if (int.TryParse(txtSaat.Text.Trim(), out st))
        //    {
        //    }
        //    else
        //    {
        //        MessageBox.Show("Saat sayılardan oluşmalı.", "Hata!");
        //        txtSaat.Focus();
        //        return;
        //    }
        //}

        //private void txtdk_TextChanged(object sender, EventArgs e)
        //{
        //    int st;
        //    if (int.TryParse(txtdk.Text.Trim(), out st))
        //    {
        //    }
        //    else
        //    {
        //        MessageBox.Show("Dakika sayılardan oluşmalı.", "Hata!");
        //        txtdk.Focus();
        //        return;
        //    }
        //}

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("İleri Bir Tarih Seçin!", "Tarih Hatalı!");
                dtpBaslangic.Value = DateTime.Now;
                return;
            }
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            if (m!=null && h!=null)
            {
                Seance s = new Seance();
                s.HallId = h.Id;
                s.MovieId = m.Id;
                s.Start_Time = Baslama_tarihi;
                s.End_Time = Bitis_tarihi;
                if (Genel.Service.Seance.Insert(s)>0)
                {
                    MessageBox.Show("Seans başarıyla eklendi.", "İşlem Başarılı");
                    dtpBaslangic.Value = DateTime.Now;
                    txtdk.Clear();
                    txtSaat.Clear();
                    btnSalonSec.Enabled = false;
                    btnSeansEkle.Visible = false;
                    lblFilmAdi.Text = "";
                    lblSalonKapasite.Text = "";
                    lblSalonKodu.Text = "";
                    lblSure.Text = "";
                    lblTur.Text = "";
                }
                else
                {
                    MessageBox.Show("Seans eklenemedi.", "Hata!");
                    return;
                }
                
            }
        }
    }
}
