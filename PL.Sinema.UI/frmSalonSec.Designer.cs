namespace PL.Sinema.UI
{
    partial class frmSalonSec
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
            this.dgvSalonlar = new System.Windows.Forms.DataGridView();
            this.btnYeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalonlar
            // 
            this.dgvSalonlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSalonlar.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSalonlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalonlar.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSalonlar.Location = new System.Drawing.Point(10, 12);
            this.dgvSalonlar.Name = "dgvSalonlar";
            this.dgvSalonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalonlar.Size = new System.Drawing.Size(349, 280);
            this.dgvSalonlar.TabIndex = 2;
            this.dgvSalonlar.DoubleClick += new System.EventHandler(this.dgvSalonlar_DoubleClick);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.LightGray;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeni.Location = new System.Drawing.Point(12, 306);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(98, 33);
            this.btnYeni.TabIndex = 107;
            this.btnYeni.Text = "Vazgeç";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(117, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 41);
            this.label1.TabIndex = 108;
            this.label1.Text = "Seçmek için salona çift tıklamanız yeterli.";
            // 
            // frmSalonSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(371, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.dgvSalonlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalonSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Seçimi";
            this.Load += new System.EventHandler(this.frmSalonSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalonlar;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label label1;
    }
}