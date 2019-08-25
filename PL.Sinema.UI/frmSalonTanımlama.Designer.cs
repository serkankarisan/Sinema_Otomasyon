namespace PL.Sinema.UI
{
    partial class frmSalonTanımlama
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
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKoltukKapasitesi = new System.Windows.Forms.TextBox();
            this.pnlSalon = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlKoltuklar = new System.Windows.Forms.Panel();
            this.lblSalonKodu = new System.Windows.Forms.Label();
            this.lblSalon = new System.Windows.Forms.Label();
            this.pnlHeader1 = new PL.Sinema.UI.pnlHeader();
            this.pnlSalon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Navy;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeni.Location = new System.Drawing.Point(17, 81);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 35);
            this.btnYeni.TabIndex = 112;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.DarkBlue;
            this.btnIptal.Enabled = false;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Location = new System.Drawing.Point(306, 81);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(71, 35);
            this.btnIptal.TabIndex = 111;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkBlue;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(200, 81);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnKaydet.TabIndex = 110;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 114;
            this.label4.Text = "Koltuk Kapasitesi";
            // 
            // txtKoltukKapasitesi
            // 
            this.txtKoltukKapasitesi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKoltukKapasitesi.Enabled = false;
            this.txtKoltukKapasitesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKoltukKapasitesi.Location = new System.Drawing.Point(151, 47);
            this.txtKoltukKapasitesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKoltukKapasitesi.MaxLength = 3;
            this.txtKoltukKapasitesi.Name = "txtKoltukKapasitesi";
            this.txtKoltukKapasitesi.Size = new System.Drawing.Size(149, 26);
            this.txtKoltukKapasitesi.TabIndex = 113;
            // 
            // pnlSalon
            // 
            this.pnlSalon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSalon.BackColor = System.Drawing.Color.Transparent;
            this.pnlSalon.Controls.Add(this.lblSalon);
            this.pnlSalon.Controls.Add(this.lblSalonKodu);
            this.pnlSalon.Controls.Add(this.panel1);
            this.pnlSalon.Controls.Add(this.pnlKoltuklar);
            this.pnlSalon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlSalon.Location = new System.Drawing.Point(15, 130);
            this.pnlSalon.Name = "pnlSalon";
            this.pnlSalon.Size = new System.Drawing.Size(770, 450);
            this.pnlSalon.TabIndex = 115;
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
            this.pnlKoltuklar.Location = new System.Drawing.Point(35, 50);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(700, 370);
            this.pnlKoltuklar.TabIndex = 117;
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
            // pnlHeader1
            // 
            this.pnlHeader1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader1.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader1.Name = "pnlHeader1";
            this.pnlHeader1.Size = new System.Drawing.Size(800, 30);
            this.pnlHeader1.TabIndex = 0;
            // 
            // frmSalonTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.pnlSalon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKoltukKapasitesi);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pnlHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalonTanımlama";
            this.Text = "Salon Tanımlama";
            this.Load += new System.EventHandler(this.frmSalonTanımlama_Load);
            this.pnlSalon.ResumeLayout(false);
            this.pnlSalon.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pnlHeader pnlHeader1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKoltukKapasitesi;
        private System.Windows.Forms.Panel pnlSalon;
        private System.Windows.Forms.Panel pnlKoltuklar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalonKodu;
        private System.Windows.Forms.Label lblSalon;
    }
}