namespace PL.Sinema.UI
{
    partial class pnlHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlHeader));
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblSayfaHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(625, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(25, 25);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSayfaHeader
            // 
            this.lblSayfaHeader.AutoSize = true;
            this.lblSayfaHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfaHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSayfaHeader.Location = new System.Drawing.Point(4, 4);
            this.lblSayfaHeader.Name = "lblSayfaHeader";
            this.lblSayfaHeader.Size = new System.Drawing.Size(103, 25);
            this.lblSayfaHeader.TabIndex = 15;
            this.lblSayfaHeader.Text = "Sayfa İsmi";
            // 
            // pnlHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.lblSayfaHeader);
            this.Controls.Add(this.btnCikis);
            this.Name = "pnlHeader";
            this.Size = new System.Drawing.Size(653, 30);
            this.Load += new System.EventHandler(this.pnlHeader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSayfaHeader;
    }
}
