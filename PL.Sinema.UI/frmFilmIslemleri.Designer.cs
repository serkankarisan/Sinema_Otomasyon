namespace PL.Sinema.UI
{
    partial class frmFilmIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmIslemleri));
            this.lvFilmler = new System.Windows.Forms.ListView();
            this.txtBanner = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYönetmen = new System.Windows.Forms.TextBox();
            this.txtFilmSüresi = new System.Windows.Forms.TextBox();
            this.txtFilmTürü = new System.Windows.Forms.TextBox();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.pnlHeader1 = new PL.Sinema.UI.pnlHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lvFilmler
            // 
            this.lvFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilmler.BackColor = System.Drawing.Color.LightGray;
            this.lvFilmler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvFilmler.BackgroundImage")));
            this.lvFilmler.BackgroundImageTiled = true;
            this.lvFilmler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFilmler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvFilmler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvFilmler.FullRowSelect = true;
            this.lvFilmler.Location = new System.Drawing.Point(460, 71);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(283, 410);
            this.lvFilmler.TabIndex = 11;
            this.lvFilmler.UseCompatibleStateImageBehavior = false;
            this.lvFilmler.DoubleClick += new System.EventHandler(this.lvFilmler_DoubleClick);
            // 
            // txtBanner
            // 
            this.txtBanner.Location = new System.Drawing.Point(140, 232);
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(100, 20);
            this.txtBanner.TabIndex = 12;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(61, 261);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(272, 220);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 91;
            this.pbFoto.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnResimEkle.Enabled = false;
            this.btnResimEkle.FlatAppearance.BorderSize = 0;
            this.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResimEkle.Location = new System.Drawing.Point(136, 222);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(109, 33);
            this.btnResimEkle.TabIndex = 92;
            this.btnResimEkle.Text = "Afiş Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Yönetmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(57, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Film Süresi(dk)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 102;
            this.label2.Text = "Film Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Film Adı";
            // 
            // txtYönetmen
            // 
            this.txtYönetmen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtYönetmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYönetmen.Location = new System.Drawing.Point(184, 181);
            this.txtYönetmen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYönetmen.Name = "txtYönetmen";
            this.txtYönetmen.Size = new System.Drawing.Size(149, 26);
            this.txtYönetmen.TabIndex = 96;
            // 
            // txtFilmSüresi
            // 
            this.txtFilmSüresi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilmSüresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmSüresi.Location = new System.Drawing.Point(184, 149);
            this.txtFilmSüresi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilmSüresi.MaxLength = 3;
            this.txtFilmSüresi.Name = "txtFilmSüresi";
            this.txtFilmSüresi.Size = new System.Drawing.Size(149, 26);
            this.txtFilmSüresi.TabIndex = 95;
            // 
            // txtFilmTürü
            // 
            this.txtFilmTürü.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilmTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmTürü.Location = new System.Drawing.Point(184, 117);
            this.txtFilmTürü.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilmTürü.MaxLength = 50;
            this.txtFilmTürü.Name = "txtFilmTürü";
            this.txtFilmTürü.Size = new System.Drawing.Size(149, 26);
            this.txtFilmTürü.TabIndex = 94;
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAdi.Location = new System.Drawing.Point(184, 85);
            this.txtFilmAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(149, 26);
            this.txtFilmAdi.TabIndex = 93;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(167, 505);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnKaydet.TabIndex = 105;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSil.Enabled = false;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(61, 546);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(206, 35);
            this.btnSil.TabIndex = 106;
            this.btnSil.Text = "Filmi Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(167, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 107;
            this.btnUpdate.Text = "Kaydet";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.DarkBlue;
            this.btnIptal.Enabled = false;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Location = new System.Drawing.Point(273, 505);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(60, 35);
            this.btnIptal.TabIndex = 108;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Navy;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeni.Location = new System.Drawing.Point(61, 505);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 35);
            this.btnYeni.TabIndex = 109;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // pnlHeader1
            // 
            this.pnlHeader1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlHeader1.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader1.Name = "pnlHeader1";
            this.pnlHeader1.Size = new System.Drawing.Size(885, 30);
            this.pnlHeader1.TabIndex = 0;
            // 
            // frmFilmIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(885, 606);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYönetmen);
            this.Controls.Add(this.txtFilmSüresi);
            this.Controls.Add(this.txtFilmTürü);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtBanner);
            this.Controls.Add(this.lvFilmler);
            this.Controls.Add(this.pnlHeader1);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilmIslemleri";
            this.Text = "Film İşlemleri";
            this.Load += new System.EventHandler(this.frmFilmIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pnlHeader pnlHeader1;
        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.TextBox txtBanner;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYönetmen;
        private System.Windows.Forms.TextBox txtFilmSüresi;
        private System.Windows.Forms.TextBox txtFilmTürü;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnYeni;
    }
}