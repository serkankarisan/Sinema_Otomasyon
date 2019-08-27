namespace PL.Sinema.UI
{
    partial class frmSalonDüzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalonDüzenleme));
            this.btnSalonDuzeni = new System.Windows.Forms.Button();
            this.pnlSalon = new System.Windows.Forms.Panel();
            this.btnKoltukEkle = new System.Windows.Forms.Button();
            this.lblSalon = new System.Windows.Forms.Label();
            this.lblSalonKodu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlKoltuklar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalon_Code = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzeniKaydet = new System.Windows.Forms.Button();
            this.pnlHeader1 = new PL.Sinema.UI.pnlHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSalon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalonDuzeni
            // 
            this.btnSalonDuzeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalonDuzeni.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSalonDuzeni.Enabled = false;
            this.btnSalonDuzeni.FlatAppearance.BorderSize = 0;
            this.btnSalonDuzeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonDuzeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonDuzeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalonDuzeni.Location = new System.Drawing.Point(514, 80);
            this.btnSalonDuzeni.Name = "btnSalonDuzeni";
            this.btnSalonDuzeni.Size = new System.Drawing.Size(272, 35);
            this.btnSalonDuzeni.TabIndex = 123;
            this.btnSalonDuzeni.Text = "Salon Düzenini Değiştir";
            this.btnSalonDuzeni.UseVisualStyleBackColor = false;
            this.btnSalonDuzeni.Visible = false;
            this.btnSalonDuzeni.Click += new System.EventHandler(this.btnSalonDuzeni_Click);
            // 
            // pnlSalon
            // 
            this.pnlSalon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSalon.BackColor = System.Drawing.Color.Transparent;
            this.pnlSalon.Controls.Add(this.btnKoltukEkle);
            this.pnlSalon.Controls.Add(this.lblSalon);
            this.pnlSalon.Controls.Add(this.lblSalonKodu);
            this.pnlSalon.Controls.Add(this.panel1);
            this.pnlSalon.Controls.Add(this.pnlKoltuklar);
            this.pnlSalon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSalon.Location = new System.Drawing.Point(16, 129);
            this.pnlSalon.Name = "pnlSalon";
            this.pnlSalon.Size = new System.Drawing.Size(770, 450);
            this.pnlSalon.TabIndex = 122;
            // 
            // btnKoltukEkle
            // 
            this.btnKoltukEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnKoltukEkle.Enabled = false;
            this.btnKoltukEkle.FlatAppearance.BorderSize = 0;
            this.btnKoltukEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKoltukEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKoltukEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKoltukEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKoltukEkle.Image")));
            this.btnKoltukEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKoltukEkle.Location = new System.Drawing.Point(35, 3);
            this.btnKoltukEkle.Name = "btnKoltukEkle";
            this.btnKoltukEkle.Size = new System.Drawing.Size(153, 45);
            this.btnKoltukEkle.TabIndex = 126;
            this.btnKoltukEkle.Text = "Koltuk Ekle";
            this.btnKoltukEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKoltukEkle.UseVisualStyleBackColor = false;
            this.btnKoltukEkle.Visible = false;
            // 
            // lblSalon
            // 
            this.lblSalon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalon.Location = new System.Drawing.Point(235, 13);
            this.lblSalon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(62, 20);
            this.lblSalon.TabIndex = 116;
            this.lblSalon.Text = "Salon : ";
            this.lblSalon.Visible = false;
            // 
            // lblSalonKodu
            // 
            this.lblSalonKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalonKodu.AutoSize = true;
            this.lblSalonKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonKodu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalonKodu.Location = new System.Drawing.Point(305, 13);
            this.lblSalonKodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalonKodu.Name = "lblSalonKodu";
            this.lblSalonKodu.Size = new System.Drawing.Size(0, 20);
            this.lblSalonKodu.TabIndex = 116;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(198, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 25);
            this.panel1.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(168, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 116;
            this.label1.Text = "Perde";
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKoltuklar.BackColor = System.Drawing.Color.Transparent;
            this.pnlKoltuklar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlKoltuklar.Location = new System.Drawing.Point(35, 50);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(700, 370);
            this.pnlKoltuklar.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 121;
            this.label4.Text = "Salon Kodu";
            // 
            // txtSalon_Code
            // 
            this.txtSalon_Code.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalon_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalon_Code.Location = new System.Drawing.Point(152, 46);
            this.txtSalon_Code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalon_Code.MaxLength = 100;
            this.txtSalon_Code.Name = "txtSalon_Code";
            this.txtSalon_Code.Size = new System.Drawing.Size(226, 26);
            this.txtSalon_Code.TabIndex = 120;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Navy;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBul.Location = new System.Drawing.Point(18, 80);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(128, 35);
            this.btnBul.TabIndex = 119;
            this.btnBul.Text = "Salon Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.DarkBlue;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Enabled = false;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Location = new System.Drawing.Point(384, 80);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(71, 35);
            this.btnIptal.TabIndex = 118;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSil.Enabled = false;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(229, 80);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(149, 35);
            this.btnSil.TabIndex = 124;
            this.btnSil.Text = "Salonu Kaldır";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzeniKaydet
            // 
            this.btnDuzeniKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzeniKaydet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnDuzeniKaydet.Enabled = false;
            this.btnDuzeniKaydet.FlatAppearance.BorderSize = 0;
            this.btnDuzeniKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzeniKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzeniKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDuzeniKaydet.Location = new System.Drawing.Point(516, 39);
            this.btnDuzeniKaydet.Name = "btnDuzeniKaydet";
            this.btnDuzeniKaydet.Size = new System.Drawing.Size(272, 35);
            this.btnDuzeniKaydet.TabIndex = 125;
            this.btnDuzeniKaydet.Text = "Yeni Düzeni Kaydet";
            this.btnDuzeniKaydet.UseVisualStyleBackColor = false;
            this.btnDuzeniKaydet.Visible = false;
            this.btnDuzeniKaydet.Click += new System.EventHandler(this.btnDuzeniKaydet_Click);
            // 
            // pnlHeader1
            // 
            this.pnlHeader1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader1.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader1.Name = "pnlHeader1";
            this.pnlHeader1.Size = new System.Drawing.Size(800, 30);
            this.pnlHeader1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 25);
            this.label2.TabIndex = 126;
            this.label2.Text = "Koltuğu silmek için bu alana sürükleyin.";
            // 
            // frmSalonDüzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnDuzeniKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSalonDuzeni);
            this.Controls.Add(this.pnlSalon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalon_Code);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pnlHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalonDüzenleme";
            this.Text = "Salon Düzenleme";
            this.Load += new System.EventHandler(this.frmSalonDüzenleme_Load);
            this.pnlSalon.ResumeLayout(false);
            this.pnlSalon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pnlHeader pnlHeader1;
        private System.Windows.Forms.Button btnSalonDuzeni;
        private System.Windows.Forms.Panel pnlSalon;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblSalonKodu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlKoltuklar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalon_Code;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzeniKaydet;
        private System.Windows.Forms.Button btnKoltukEkle;
        private System.Windows.Forms.Label label2;
    }
}