namespace PL.Sinema.UI
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxMinExit1 = new PL.Sinema.UI.MaxMinExit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSeansMenu = new System.Windows.Forms.Button();
            this.btnSalonDüzenleme = new System.Windows.Forms.Button();
            this.btnSalonMenu = new System.Windows.Forms.Button();
            this.btnFilmMenu = new System.Windows.Forms.Button();
            this.btnSalonTanımlama = new System.Windows.Forms.Button();
            this.btnKullanıcıMenu = new System.Windows.Forms.Button();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxMinExit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 44);
            this.panel1.TabIndex = 0;
            // 
            // maxMinExit1
            // 
            this.maxMinExit1.BackColor = System.Drawing.Color.Transparent;
            this.maxMinExit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxMinExit1.BackgroundImage")));
            this.maxMinExit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxMinExit1.Location = new System.Drawing.Point(0, 0);
            this.maxMinExit1.Name = "maxMinExit1";
            this.maxMinExit1.Size = new System.Drawing.Size(943, 44);
            this.maxMinExit1.TabIndex = 0;
            this.maxMinExit1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maxMinExit1_MouseDown);
            this.maxMinExit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.maxMinExit1_MouseMove);
            this.maxMinExit1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.maxMinExit1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 468);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.pnlContent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 426);
            this.panel4.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.pnlMenu);
            this.pnlContent.Controls.Add(this.pnlGiris);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(943, 426);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Click += new System.EventHandler(this.pnlContent_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnSeansMenu);
            this.pnlMenu.Controls.Add(this.btnSalonDüzenleme);
            this.pnlMenu.Controls.Add(this.btnSalonMenu);
            this.pnlMenu.Controls.Add(this.btnFilmMenu);
            this.pnlMenu.Controls.Add(this.btnSalonTanımlama);
            this.pnlMenu.Controls.Add(this.btnKullanıcıMenu);
            this.pnlMenu.Location = new System.Drawing.Point(12, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 0);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSeansMenu
            // 
            this.btnSeansMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeansMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeansMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSeansMenu.Image")));
            this.btnSeansMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeansMenu.Location = new System.Drawing.Point(7, 254);
            this.btnSeansMenu.Name = "btnSeansMenu";
            this.btnSeansMenu.Size = new System.Drawing.Size(230, 40);
            this.btnSeansMenu.TabIndex = 23;
            this.btnSeansMenu.Text = "Seans İşlemleri";
            this.btnSeansMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeansMenu.UseVisualStyleBackColor = true;
            this.btnSeansMenu.Click += new System.EventHandler(this.btnSeansMenu_Click);
            // 
            // btnSalonDüzenleme
            // 
            this.btnSalonDüzenleme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalonDüzenleme.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalonDüzenleme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalonDüzenleme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalonDüzenleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalonDüzenleme.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonDüzenleme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalonDüzenleme.Location = new System.Drawing.Point(9, 208);
            this.btnSalonDüzenleme.Name = "btnSalonDüzenleme";
            this.btnSalonDüzenleme.Size = new System.Drawing.Size(230, 40);
            this.btnSalonDüzenleme.TabIndex = 22;
            this.btnSalonDüzenleme.Text = "Salon Düzenleme";
            this.btnSalonDüzenleme.UseVisualStyleBackColor = true;
            this.btnSalonDüzenleme.Visible = false;
            this.btnSalonDüzenleme.Click += new System.EventHandler(this.btnSalonDüzenleme_Click);
            // 
            // btnSalonMenu
            // 
            this.btnSalonMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalonMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalonMenu.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalonMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSalonMenu.Image")));
            this.btnSalonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalonMenu.Location = new System.Drawing.Point(9, 120);
            this.btnSalonMenu.Name = "btnSalonMenu";
            this.btnSalonMenu.Size = new System.Drawing.Size(230, 40);
            this.btnSalonMenu.TabIndex = 20;
            this.btnSalonMenu.Text = "Salon İşlemleri";
            this.btnSalonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalonMenu.UseVisualStyleBackColor = true;
            this.btnSalonMenu.Click += new System.EventHandler(this.btnSalonMenu_Click);
            // 
            // btnFilmMenu
            // 
            this.btnFilmMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilmMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFilmMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFilmMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFilmMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmMenu.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilmMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnFilmMenu.Image")));
            this.btnFilmMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmMenu.Location = new System.Drawing.Point(9, 68);
            this.btnFilmMenu.Name = "btnFilmMenu";
            this.btnFilmMenu.Size = new System.Drawing.Size(230, 40);
            this.btnFilmMenu.TabIndex = 19;
            this.btnFilmMenu.Text = "Film İşlemleri";
            this.btnFilmMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilmMenu.UseVisualStyleBackColor = true;
            this.btnFilmMenu.Click += new System.EventHandler(this.btnFilmMenu_Click);
            // 
            // btnSalonTanımlama
            // 
            this.btnSalonTanımlama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalonTanımlama.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalonTanımlama.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalonTanımlama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalonTanımlama.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalonTanımlama.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonTanımlama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalonTanımlama.Location = new System.Drawing.Point(9, 166);
            this.btnSalonTanımlama.Name = "btnSalonTanımlama";
            this.btnSalonTanımlama.Size = new System.Drawing.Size(230, 40);
            this.btnSalonTanımlama.TabIndex = 21;
            this.btnSalonTanımlama.Text = "Salon Tanımlama";
            this.btnSalonTanımlama.UseVisualStyleBackColor = true;
            this.btnSalonTanımlama.Visible = false;
            this.btnSalonTanımlama.Click += new System.EventHandler(this.btnSalonTanımlama_Click);
            // 
            // btnKullanıcıMenu
            // 
            this.btnKullanıcıMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKullanıcıMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnKullanıcıMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKullanıcıMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKullanıcıMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKullanıcıMenu.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKullanıcıMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcıMenu.Image")));
            this.btnKullanıcıMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKullanıcıMenu.Location = new System.Drawing.Point(9, 16);
            this.btnKullanıcıMenu.Name = "btnKullanıcıMenu";
            this.btnKullanıcıMenu.Size = new System.Drawing.Size(230, 40);
            this.btnKullanıcıMenu.TabIndex = 18;
            this.btnKullanıcıMenu.Text = "Kullanıcı İşlemleri";
            this.btnKullanıcıMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullanıcıMenu.UseVisualStyleBackColor = true;
            this.btnKullanıcıMenu.Click += new System.EventHandler(this.btnKullanıcıMenu_Click);
            // 
            // pnlGiris
            // 
            this.pnlGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGiris.BackgroundImage")));
            this.pnlGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGiris.Controls.Add(this.pictureBox3);
            this.pnlGiris.Controls.Add(this.button1);
            this.pnlGiris.Location = new System.Drawing.Point(65, 40);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(810, 350);
            this.pnlGiris.TabIndex = 27;
            this.pnlGiris.Click += new System.EventHandler(this.pnlContent_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(103, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(603, 199);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pnlContent_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("High Tower Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(321, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 55);
            this.button1.TabIndex = 27;
            this.button1.Text = "Bilet Kes";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pnlUser);
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Controls.Add(this.lblSaat);
            this.panel3.Controls.Add(this.lblTarih);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 42);
            this.panel3.TabIndex = 0;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblYetki);
            this.pnlUser.Controls.Add(this.lblKullanici);
            this.pnlUser.Controls.Add(this.label18);
            this.pnlUser.Location = new System.Drawing.Point(260, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(294, 40);
            this.pnlUser.TabIndex = 18;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYetki.Location = new System.Drawing.Point(3, 10);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(55, 22);
            this.lblYetki.TabIndex = 13;
            this.lblYetki.Text = "Yetki";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullanici.Location = new System.Drawing.Point(109, 10);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(121, 22);
            this.lblKullanici.TabIndex = 10;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(76, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 39);
            this.label18.TabIndex = 15;
            this.label18.Text = "I";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("High Tower Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(70, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(108, 30);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "MENÜ";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaat.Location = new System.Drawing.Point(824, 10);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(51, 22);
            this.lblSaat.TabIndex = 14;
            this.lblSaat.Text = "Saat";
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTarih.Location = new System.Drawing.Point(540, 10);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(57, 22);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "Tarih";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(791, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 39);
            this.label19.TabIndex = 16;
            this.label19.Text = "I";
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaxMinExit maxMinExit1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSalonMenu;
        private System.Windows.Forms.Button btnFilmMenu;
        private System.Windows.Forms.Button btnKullanıcıMenu;
        private System.Windows.Forms.Button btnSalonDüzenleme;
        private System.Windows.Forms.Button btnSalonTanımlama;
        private System.Windows.Forms.Button btnSeansMenu;
        private System.Windows.Forms.Panel pnlUser;
    }
}