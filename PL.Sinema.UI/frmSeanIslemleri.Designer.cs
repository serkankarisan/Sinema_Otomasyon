namespace PL.Sinema.UI
{
    partial class frmSeanIslemleri
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
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtdk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalonSec = new System.Windows.Forms.Button();
            this.btnFilmSec = new System.Windows.Forms.Button();
            this.pnlSalon = new System.Windows.Forms.Panel();
            this.lblSalonKapasite = new System.Windows.Forms.Label();
            this.lblSalonKodu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFilm = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader1 = new PL.Sinema.UI.pnlHeader();
            this.pnlSalon.SuspendLayout();
            this.pnlFilm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Location = new System.Drawing.Point(166, 42);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(241, 26);
            this.dtpBaslangic.TabIndex = 2;
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(40, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 116;
            this.label1.Text = "Başlangıç Saati";
            // 
            // txtSaat
            // 
            this.txtSaat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaat.Location = new System.Drawing.Point(170, 78);
            this.txtSaat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaat.MaxLength = 2;
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(30, 26);
            this.txtSaat.TabIndex = 0;
            // 
            // txtdk
            // 
            this.txtdk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdk.Location = new System.Drawing.Point(226, 78);
            this.txtdk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdk.MaxLength = 2;
            this.txtdk.Name = "txtdk";
            this.txtdk.Size = new System.Drawing.Size(30, 26);
            this.txtdk.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(204, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(264, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "örn.(16:30)";
            // 
            // btnSalonSec
            // 
            this.btnSalonSec.BackColor = System.Drawing.Color.Navy;
            this.btnSalonSec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalonSec.Enabled = false;
            this.btnSalonSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalonSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalonSec.Location = new System.Drawing.Point(0, 0);
            this.btnSalonSec.Name = "btnSalonSec";
            this.btnSalonSec.Size = new System.Drawing.Size(300, 35);
            this.btnSalonSec.TabIndex = 0;
            this.btnSalonSec.Text = "Salon Seç";
            this.btnSalonSec.UseVisualStyleBackColor = false;
            this.btnSalonSec.Click += new System.EventHandler(this.btnSalonSec_Click);
            // 
            // btnFilmSec
            // 
            this.btnFilmSec.BackColor = System.Drawing.Color.Navy;
            this.btnFilmSec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilmSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmSec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilmSec.Location = new System.Drawing.Point(0, 0);
            this.btnFilmSec.Name = "btnFilmSec";
            this.btnFilmSec.Size = new System.Drawing.Size(400, 35);
            this.btnFilmSec.TabIndex = 0;
            this.btnFilmSec.Text = "Film Seç";
            this.btnFilmSec.UseVisualStyleBackColor = false;
            this.btnFilmSec.Click += new System.EventHandler(this.btnFilmSec_Click);
            // 
            // pnlSalon
            // 
            this.pnlSalon.Controls.Add(this.lblSalonKapasite);
            this.pnlSalon.Controls.Add(this.lblSalonKodu);
            this.pnlSalon.Controls.Add(this.label6);
            this.pnlSalon.Controls.Add(this.label5);
            this.pnlSalon.Controls.Add(this.btnSalonSec);
            this.pnlSalon.Location = new System.Drawing.Point(450, 123);
            this.pnlSalon.Name = "pnlSalon";
            this.pnlSalon.Size = new System.Drawing.Size(300, 150);
            this.pnlSalon.TabIndex = 129;
            // 
            // lblSalonKapasite
            // 
            this.lblSalonKapasite.AutoSize = true;
            this.lblSalonKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonKapasite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalonKapasite.Location = new System.Drawing.Point(106, 81);
            this.lblSalonKapasite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalonKapasite.Name = "lblSalonKapasite";
            this.lblSalonKapasite.Size = new System.Drawing.Size(0, 20);
            this.lblSalonKapasite.TabIndex = 134;
            // 
            // lblSalonKodu
            // 
            this.lblSalonKodu.AutoSize = true;
            this.lblSalonKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonKodu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalonKodu.Location = new System.Drawing.Point(106, 48);
            this.lblSalonKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalonKodu.Name = "lblSalonKodu";
            this.lblSalonKodu.Size = new System.Drawing.Size(0, 20);
            this.lblSalonKodu.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(4, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 132;
            this.label6.Text = "Kapasite      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 131;
            this.label5.Text = "Salon Kodu : ";
            // 
            // pnlFilm
            // 
            this.pnlFilm.Controls.Add(this.lblSure);
            this.pnlFilm.Controls.Add(this.lblTur);
            this.pnlFilm.Controls.Add(this.lblFilmAdi);
            this.pnlFilm.Controls.Add(this.label9);
            this.pnlFilm.Controls.Add(this.label8);
            this.pnlFilm.Controls.Add(this.label7);
            this.pnlFilm.Controls.Add(this.btnFilmSec);
            this.pnlFilm.Location = new System.Drawing.Point(44, 123);
            this.pnlFilm.Name = "pnlFilm";
            this.pnlFilm.Size = new System.Drawing.Size(400, 150);
            this.pnlFilm.TabIndex = 130;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSure.Location = new System.Drawing.Point(93, 110);
            this.lblSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 20);
            this.lblSure.TabIndex = 137;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTur.Location = new System.Drawing.Point(93, 79);
            this.lblTur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(0, 20);
            this.lblTur.TabIndex = 136;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFilmAdi.Location = new System.Drawing.Point(93, 48);
            this.lblFilmAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(0, 20);
            this.lblFilmAdi.TabIndex = 135;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(4, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 135;
            this.label9.Text = "Süre       : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(4, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 134;
            this.label8.Text = "Tür          : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 133;
            this.label7.Text = "Film Adı  : ";
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.Navy;
            this.btnSeansEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeansEkle.Location = new System.Drawing.Point(251, 317);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(182, 35);
            this.btnSeansEkle.TabIndex = 3;
            this.btnSeansEkle.Text = "Seansı Ekle";
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Visible = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.pnlFilm);
            this.panel1.Controls.Add(this.btnSeansEkle);
            this.panel1.Controls.Add(this.dtpBaslangic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlSalon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSaat);
            this.panel1.Controls.Add(this.txtdk);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 360);
            this.panel1.TabIndex = 134;
            // 
            // pnlHeader1
            // 
            this.pnlHeader1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader1.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader1.Name = "pnlHeader1";
            this.pnlHeader1.Size = new System.Drawing.Size(816, 30);
            this.pnlHeader1.TabIndex = 0;
            // 
            // frmSeanIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeanIslemleri";
            this.Text = "Seans İşlemleri";
            this.Load += new System.EventHandler(this.frmSeanIslemleri_Load);
            this.pnlSalon.ResumeLayout(false);
            this.pnlSalon.PerformLayout();
            this.pnlFilm.ResumeLayout(false);
            this.pnlFilm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private pnlHeader pnlHeader1;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.TextBox txtdk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalonSec;
        private System.Windows.Forms.Button btnFilmSec;
        private System.Windows.Forms.Panel pnlSalon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlFilm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Label lblSalonKapasite;
        private System.Windows.Forms.Label lblSalonKodu;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Panel panel1;
    }
}