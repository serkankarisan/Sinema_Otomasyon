namespace PL.Sinema.UI
{
    partial class MaxMinExit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxMinExit));
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnSimgeDurumu = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxMin.FlatAppearance.BorderSize = 0;
            this.btnMaxMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxMin.Image")));
            this.btnMaxMin.Location = new System.Drawing.Point(780, 12);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(25, 25);
            this.btnMaxMin.TabIndex = 16;
            this.btnMaxMin.UseVisualStyleBackColor = false;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnSimgeDurumu
            // 
            this.btnSimgeDurumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimgeDurumu.BackColor = System.Drawing.Color.Transparent;
            this.btnSimgeDurumu.FlatAppearance.BorderSize = 0;
            this.btnSimgeDurumu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSimgeDurumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimgeDurumu.Image = ((System.Drawing.Image)(resources.GetObject("btnSimgeDurumu.Image")));
            this.btnSimgeDurumu.Location = new System.Drawing.Point(749, 12);
            this.btnSimgeDurumu.Name = "btnSimgeDurumu";
            this.btnSimgeDurumu.Size = new System.Drawing.Size(25, 25);
            this.btnSimgeDurumu.TabIndex = 15;
            this.btnSimgeDurumu.UseVisualStyleBackColor = false;
            this.btnSimgeDurumu.Click += new System.EventHandler(this.btnSimgeDurumu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(140, 31);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(811, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 25);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MaxMinExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnSimgeDurumu);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnCikis);
            this.Name = "MaxMinExit";
            this.Size = new System.Drawing.Size(850, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnSimgeDurumu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCikis;
    }
}
