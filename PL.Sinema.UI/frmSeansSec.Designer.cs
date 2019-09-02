namespace PL.Sinema.UI
{
    partial class frmSeansSec
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.dgvSeanslar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeanslar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(133, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 33);
            this.label1.TabIndex = 114;
            this.label1.Text = "Seçmek için seansa çift tıklamanız yeterli.";
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.LightGray;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVazgec.Location = new System.Drawing.Point(43, 307);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(83, 33);
            this.btnVazgec.TabIndex = 113;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // dgvSeanslar
            // 
            this.dgvSeanslar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeanslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSeanslar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSeanslar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeanslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeanslar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSeanslar.Location = new System.Drawing.Point(30, 12);
            this.dgvSeanslar.Name = "dgvSeanslar";
            this.dgvSeanslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeanslar.Size = new System.Drawing.Size(539, 276);
            this.dgvSeanslar.TabIndex = 112;
            this.dgvSeanslar.DoubleClick += new System.EventHandler(this.dgvSalonlar_DoubleClick);
            // 
            // frmSeansSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(594, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.dgvSeanslar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeansSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Seç";
            this.Load += new System.EventHandler(this.frmSeansSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeanslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.DataGridView dgvSeanslar;
    }
}