using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Sinema.UI
{
    public partial class frmFilmIslemleri : Form
    {
        public frmFilmIslemleri()
        {
            InitializeComponent();
        }
        ImageList imgList1 = new ImageList();
        string projeAdres = Application.StartupPath;
        int FilmID = 0;
        int film_sure;
        private void ShowListView(List<Movie> Movies)
        {
            lvFilmler.Items.Clear();
            imgList1.Images.Clear();
            imgList1.ImageSize = new Size(200, 220);
            lvFilmler.LargeImageList = imgList1;
            for (int i = 0; i < Movies.Count; i++)
            {
                imgList1.Images.Add(Image.FromFile(projeAdres + Movies[i].Banner));
                lvFilmler.Items.Add(Movies[i].Movie_Name, GoToImgIndex(Movies[i].Id));
                lvFilmler.Items[i].SubItems.Add(Movies[i].Id.ToString());
                lvFilmler.Items[i].SubItems.Add(Movies[i].Movie_Type);
                lvFilmler.Items[i].SubItems.Add(Movies[i].Director);
                lvFilmler.Items[i].SubItems.Add(Movies[i].Movie_Duration_InMinute.ToString());
                lvFilmler.Items[i].SubItems.Add(Movies[i].AddedDate.ToShortDateString());
            }
        }
        private int GoToImgIndex(int ID)
        {
            int index = 0;
            List<Movie> MovieList = Genel.Service.Movie.Select();
            int[] arrID = new int[MovieList.Count];
            for (int i = 0; i < MovieList.Count; i++)
            {
                arrID[i] = MovieList[i].Id;
            }
            for (int j = 0; j < MovieList.Count; j++)
            {
                if (ID == MovieList[j].Id)
                    index = Array.IndexOf(arrID, MovieList[j].Id);
            }
            return index;
        }
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string kopyalanacakDosyaIsmi = open.SafeFileName.ToString();
                string kopyalanacakDosya = open.FileName.ToString();
                string projeadres = Application.StartupPath;
                string adres = projeadres + @"\\Images\\Movies";
                Kopyala(kopyalanacakDosya, adres, kopyalanacakDosyaIsmi);
                if (kopyalanacakDosyaIsmi.Trim() != "")
                {
                    txtBanner.Text = @"\\Images\\Movies" + "\\" + kopyalanacakDosyaIsmi;
                }
                // image file path  
            }
            else
            {
                MessageBox.Show("Dosya Seçmediniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtBanner.Text.Trim() != "")
            {
                pbFoto.Image = Image.FromFile(Application.StartupPath + "" + txtBanner.Text);
            }
        }
        private void Kopyala(string kopyalanacakDosya, string dosyanınKopyanacagiKlasor, string kopyalanacakDosyaIsmi)
        {
            if (dosyanınKopyanacagiKlasor != "" && kopyalanacakDosya != "")
            {
                if (File.Exists(dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klasörde " + kopyalanacakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + kopyalanacakDosyaIsmi);
                    MessageBox.Show("Dosya Kopyalama İşlemi Başarılı", "Dosya Kopyalandı...");
                }
            }
            else if (kopyalanacakDosya == "")
            {
                MessageBox.Show("Dosya Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilmAdi.Text.Trim()) && (!string.IsNullOrEmpty(txtFilmTürü.Text.Trim())) && (!string.IsNullOrEmpty(txtYönetmen.Text.Trim())) && (!string.IsNullOrEmpty(txtBanner.Text.Trim())) && (!string.IsNullOrEmpty(txtFilmSüresi.Text.Trim())))
            {
                Movie m = new Movie();
                if (Genel.Service.Movie.SelectByMovieName(txtFilmAdi.Text.Trim()) != null)
                {
                    MessageBox.Show("Bu film kayıtlı!", "Hata!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    m.Movie_Name = txtFilmAdi.Text.Trim();
                    m.Movie_Type = txtFilmTürü.Text.Trim();
                    if (int.TryParse(txtFilmSüresi.Text.Trim(), out film_sure))
                    {
                        m.Movie_Duration_InMinute = film_sure;
                    }
                    else
                    {
                        MessageBox.Show("Film süresi sayılardan oluşmalı.", "Hata!");
                        return;
                    }
                    m.Director = txtYönetmen.Text.Trim();
                    m.Banner = txtBanner.Text.Trim();
                    Genel.Service.Movie.Insert(m);
                    MessageBox.Show("Film başarıyla eklendi.", "İşlem Başarılı");
                    btnKaydet.Enabled = false;
                    btnKaydet.Visible = false;
                    btnUpdate.Enabled = false;
                    btnUpdate.Visible = false;
                    btnIptal.Enabled = false;
                    btnIptal.Visible = false;
                    btnSil.Enabled = false;
                    btnSil.Visible = false;
                    btnResimEkle.Enabled = false;
                    Disabled();
                    Temizle();
                    ShowListView(Genel.Service.Movie.Select());
                }
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol edip tekrar deneyin.", "Eksik Bilgi Girişi!");
                txtFilmAdi.Focus();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Onaylıyor Musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (FilmID != 0)
                {
                    Movie m = Genel.Service.Movie.SelectById(FilmID);
                    Movie movienameToUser = Genel.Service.Movie.SelectByMovieName(txtFilmAdi.Text.Trim());
                    if (movienameToUser != null && movienameToUser.Id != m.Id)
                    {
                        MessageBox.Show("Bu film adı zaten kayıtlı.", "Hata!");
                        txtFilmAdi.Focus();
                    }
                    else
                    {
                        Genel.Service.Movie.Delete(FilmID);
                        MessageBox.Show("Film başarıyla silindi.", "İşlem Başarılı");
                        btnKaydet.Enabled = false;
                        btnKaydet.Visible = false;
                        btnUpdate.Enabled = false;
                        btnUpdate.Visible = false;
                        btnIptal.Enabled = false;
                        btnIptal.Visible = false;
                        btnSil.Enabled = false;
                        btnSil.Visible = false;
                        btnResimEkle.Enabled = false;
                        Disabled();
                        Temizle();
                        ShowListView(Genel.Service.Movie.Select());
                    }
                }
                else
                {
                    MessageBox.Show("Film seçmelisiniz.", "Hata!");
                    lvFilmler.Focus();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilmAdi.Text.Trim()) && (!string.IsNullOrEmpty(txtFilmTürü.Text.Trim())) && (!string.IsNullOrEmpty(txtYönetmen.Text.Trim())) && (!string.IsNullOrEmpty(txtBanner.Text.Trim())) && (!string.IsNullOrEmpty(txtFilmSüresi.Text.Trim())))
            {
                if (FilmID != 0)
                {
                    Movie m = Genel.Service.Movie.SelectById(FilmID);
                    Movie movienameToUser = Genel.Service.Movie.SelectByMovieName(txtFilmAdi.Text.Trim());
                    if (movienameToUser != null && movienameToUser.Id != m.Id)
                    {
                        MessageBox.Show("Bu film adı zaten kayıtlı.", "Hata!");
                        txtFilmAdi.Focus();
                    }
                    else
                    {
                        m.Movie_Name = txtFilmAdi.Text.Trim();
                        m.Movie_Type = txtFilmTürü.Text.Trim();
                        if (int.TryParse(txtFilmSüresi.Text.Trim(), out film_sure))
                        {
                            m.Movie_Duration_InMinute =film_sure;
                        }
                        else
                        {
                            MessageBox.Show("Film süresi sayılardan oluşmalı.", "Hata!");
                            return;
                        }
                        m.Director = txtYönetmen.Text.Trim();
                        m.Banner = txtBanner.Text.Trim();
                        Genel.Service.Movie.Update(m);
                        MessageBox.Show("Film başarıyla güncellendi.", "İşlem Başarılı");
                        btnKaydet.Enabled = false;
                        btnKaydet.Visible = false;
                        btnUpdate.Enabled = false;
                        btnUpdate.Visible = false;
                        btnIptal.Enabled = false;
                        btnIptal.Visible = false;
                        btnSil.Enabled = false;
                        btnSil.Visible = false;
                        btnResimEkle.Enabled = false;
                        Disabled();
                        Temizle();
                        ShowListView(Genel.Service.Movie.Select());
                    }
                }
                else
                {
                    MessageBox.Show("Film seçmelisiniz.", "Hata!");
                    lvFilmler.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol edip tekrar deneyin.", "Eksik Bilgi Girişi!");
                txtFilmAdi.Focus();
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Enabled();
            btnKaydet.Enabled = true;
            btnUpdate.Enabled = false;
            btnKaydet.Visible = true;
            btnUpdate.Visible = false;
            btnIptal.Enabled = true;
            btnIptal.Visible = true;
            btnResimEkle.Enabled = true;
        }
        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtBanner.Clear();
            txtFilmSüresi.Clear();
            txtFilmTürü.Clear();
            txtYönetmen.Clear();
            pbFoto.Image = null;
        }
        private void Enabled()
        {
            txtFilmAdi.Enabled = true;
            txtBanner.Enabled = true;
            txtFilmSüresi.Enabled = true;
            txtFilmTürü.Enabled = true;
            txtYönetmen.Enabled = true;
            btnResimEkle.Enabled = true;
        }
        private void Disabled()
        {
            txtFilmAdi.Enabled = false;
            txtBanner.Enabled = false;
            txtFilmSüresi.Enabled = false;
            txtFilmTürü.Enabled = false;
            txtYönetmen.Enabled = false;
            btnResimEkle.Enabled = false;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            Temizle();
            Disabled();
            btnResimEkle.Enabled = false;
            btnIptal.Enabled = false;
            btnIptal.Visible = false;
            btnKaydet.Enabled = false;
            btnKaydet.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnSil.Enabled = false;
            btnSil.Visible = false;
        }

        private void frmFilmIslemleri_Load(object sender, EventArgs e)
        {
            Disabled();
            btnKaydet.Enabled = false;
            btnKaydet.Visible = false;
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnSil.Enabled = false;
            btnSil.Visible = false;
            FilmID = 0;
            imgList1.ImageSize = new Size(200, 220);
            ShowListView(Genel.Service.Movie.Select());
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            List<Movie> MovieList = Genel.Service.Movie.Select();
            string MovieID = lvFilmler.SelectedItems[0].SubItems[1].Text;
            
            for (int i = 0; i < MovieList.Count; i++)
            {
                if (MovieID == MovieList[i].Id.ToString())
                {
                    FilmID = MovieList[i].Id;
                }
            }
            Movie m = Genel.Service.Movie.SelectById(FilmID);
            txtFilmAdi.Text = m.Movie_Name;
            txtFilmSüresi.Text = m.Movie_Duration_InMinute.ToString();
            txtFilmTürü.Text = m.Movie_Type;
            txtYönetmen.Text = m.Director;
            txtBanner.Text = m.Banner;
            if (txtBanner.Text.Trim() != "")
            {
                pbFoto.Image = Image.FromFile(Application.StartupPath + "" + txtBanner.Text);
            }
            Enabled();
            btnKaydet.Visible = false;
            btnKaydet.Enabled = false;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            btnIptal.Enabled = true;
            btnIptal.Visible = true;
            btnSil.Enabled = true;
            btnSil.Visible = true;
        }
    }
}
