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
            this.pnlHeader1 = new PL.Sinema.UI.pnlHeader();
            this.SuspendLayout();
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
            // frmFilmIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilmIslemleri";
            this.Text = "Film İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private pnlHeader pnlHeader1;
    }
}