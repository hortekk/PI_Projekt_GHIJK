namespace Skladiste_PI
{
    partial class frmUnosOtpremnice
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.DGVStavke2 = new System.Windows.Forms.DataGridView();
            this.btnUnesiOtpremincu = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBArtikl2 = new System.Windows.Forms.ComboBox();
            this.Artikl = new System.Windows.Forms.Label();
            this.CMKupac = new System.Windows.Forms.ComboBox();
            this.CMBZaposlenik = new System.Windows.Forms.ComboBox();
            this.btnUnesiStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(66, 30);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum";
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(68, 61);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(36, 13);
            this.lblDobavljac.TabIndex = 1;
            this.lblDobavljac.Text = "Kupac";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(66, 84);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(57, 13);
            this.lblZaposlenik.TabIndex = 2;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // DGVStavke2
            // 
            this.DGVStavke2.AllowUserToAddRows = false;
            this.DGVStavke2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStavke2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStavke2.Location = new System.Drawing.Point(0, 138);
            this.DGVStavke2.Name = "DGVStavke2";
            this.DGVStavke2.Size = new System.Drawing.Size(606, 157);
            this.DGVStavke2.TabIndex = 6;
            // 
            // btnUnesiOtpremincu
            // 
            this.btnUnesiOtpremincu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnesiOtpremincu.Location = new System.Drawing.Point(438, 373);
            this.btnUnesiOtpremincu.Name = "btnUnesiOtpremincu";
            this.btnUnesiOtpremincu.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiOtpremincu.TabIndex = 7;
            this.btnUnesiOtpremincu.Text = "Unesi";
            this.btnUnesiOtpremincu.UseVisualStyleBackColor = true;
            this.btnUnesiOtpremincu.Click += new System.EventHandler(this.btnUnesiOtpremincu_Click_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(159, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(519, 373);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "UNOS STAVKI DOKUMENTA";
            // 
            // txtKolicina2
            // 
            this.txtKolicina2.Location = new System.Drawing.Point(443, 84);
            this.txtKolicina2.Name = "txtKolicina2";
            this.txtKolicina2.Size = new System.Drawing.Size(151, 21);
            this.txtKolicina2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kolicina";
            // 
            // CBArtikl2
            // 
            this.CBArtikl2.FormattingEnabled = true;
            this.CBArtikl2.Location = new System.Drawing.Point(443, 56);
            this.CBArtikl2.Name = "CBArtikl2";
            this.CBArtikl2.Size = new System.Drawing.Size(151, 21);
            this.CBArtikl2.TabIndex = 19;
            // 
            // Artikl
            // 
            this.Artikl.AutoSize = true;
            this.Artikl.Location = new System.Drawing.Point(365, 59);
            this.Artikl.Name = "Artikl";
            this.Artikl.Size = new System.Drawing.Size(72, 13);
            this.Artikl.TabIndex = 18;
            this.Artikl.Text = "Odabir Artikla";
            // 
            // CMKupac
            // 
            this.CMKupac.FormattingEnabled = true;
            this.CMKupac.Location = new System.Drawing.Point(159, 58);
            this.CMKupac.Name = "CMKupac";
            this.CMKupac.Size = new System.Drawing.Size(200, 21);
            this.CMKupac.TabIndex = 23;
            // 
            // CMBZaposlenik
            // 
            this.CMBZaposlenik.FormattingEnabled = true;
            this.CMBZaposlenik.Location = new System.Drawing.Point(159, 83);
            this.CMBZaposlenik.Name = "CMBZaposlenik";
            this.CMBZaposlenik.Size = new System.Drawing.Size(200, 21);
            this.CMBZaposlenik.TabIndex = 24;
            // 
            // btnUnesiStavku
            // 
            this.btnUnesiStavku.Location = new System.Drawing.Point(350, 372);
            this.btnUnesiStavku.Name = "btnUnesiStavku";
            this.btnUnesiStavku.Size = new System.Drawing.Size(86, 23);
            this.btnUnesiStavku.TabIndex = 25;
            this.btnUnesiStavku.Text = "Unesi Stavku";
            this.btnUnesiStavku.UseVisualStyleBackColor = true;
            this.btnUnesiStavku.Click += new System.EventHandler(this.btnUnesiStavku_Click_1);
            // 
            // frmUnosOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(606, 408);
            this.Controls.Add(this.btnUnesiStavku);
            this.Controls.Add(this.CMBZaposlenik);
            this.Controls.Add(this.CMKupac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKolicina2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBArtikl2);
            this.Controls.Add(this.Artikl);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnUnesiOtpremincu);
            this.Controls.Add(this.DGVStavke2);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblDatum);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmUnosOtpremnice";
            this.Text = "Unos Otpremnice";
            this.Load += new System.EventHandler(this.frmUnosOtpremnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.DataGridView DGVStavke2;
        private System.Windows.Forms.Button btnUnesiOtpremincu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBArtikl2;
        private System.Windows.Forms.Label Artikl;
        private System.Windows.Forms.ComboBox CMKupac;
        private System.Windows.Forms.ComboBox CMBZaposlenik;
        private System.Windows.Forms.Button btnUnesiStavku;
    }
}