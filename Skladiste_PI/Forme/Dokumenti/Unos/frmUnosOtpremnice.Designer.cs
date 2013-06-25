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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosOtpremnice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMBZaposlenik = new System.Windows.Forms.ComboBox();
            this.CMKupac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBArtikl2 = new System.Windows.Forms.ComboBox();
            this.Artikl = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DGVStavke2 = new System.Windows.Forms.DataGridView();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnUnesiStavku = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnUnesiOtpremincu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.btnUnesiStavku);
            this.panel1.Controls.Add(this.btnZatvori);
            this.panel1.Controls.Add(this.btnUnesiOtpremincu);
            this.panel1.Controls.Add(this.CMBZaposlenik);
            this.panel1.Controls.Add(this.CMKupac);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKolicina2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBArtikl2);
            this.panel1.Controls.Add(this.Artikl);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.DGVStavke2);
            this.panel1.Controls.Add(this.lblZaposlenik);
            this.panel1.Controls.Add(this.lblDobavljac);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 500);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CMBZaposlenik
            // 
            this.CMBZaposlenik.FormattingEnabled = true;
            this.CMBZaposlenik.Location = new System.Drawing.Point(192, 120);
            this.CMBZaposlenik.Margin = new System.Windows.Forms.Padding(4);
            this.CMBZaposlenik.Name = "CMBZaposlenik";
            this.CMBZaposlenik.Size = new System.Drawing.Size(265, 26);
            this.CMBZaposlenik.TabIndex = 36;
            // 
            // CMKupac
            // 
            this.CMKupac.FormattingEnabled = true;
            this.CMKupac.Location = new System.Drawing.Point(192, 85);
            this.CMKupac.Margin = new System.Windows.Forms.Padding(4);
            this.CMKupac.Name = "CMKupac";
            this.CMKupac.Size = new System.Drawing.Size(265, 26);
            this.CMKupac.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(528, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "UNOS STAVKI DOKUMENTA";
            // 
            // txtKolicina2
            // 
            this.txtKolicina2.Location = new System.Drawing.Point(571, 121);
            this.txtKolicina2.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina2.Name = "txtKolicina2";
            this.txtKolicina2.Size = new System.Drawing.Size(200, 25);
            this.txtKolicina2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(467, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Kolicina";
            // 
            // CBArtikl2
            // 
            this.CBArtikl2.FormattingEnabled = true;
            this.CBArtikl2.Location = new System.Drawing.Point(571, 83);
            this.CBArtikl2.Margin = new System.Windows.Forms.Padding(4);
            this.CBArtikl2.Name = "CBArtikl2";
            this.CBArtikl2.Size = new System.Drawing.Size(200, 26);
            this.CBArtikl2.TabIndex = 31;
            // 
            // Artikl
            // 
            this.Artikl.AutoSize = true;
            this.Artikl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Artikl.Location = new System.Drawing.Point(467, 87);
            this.Artikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Artikl.Name = "Artikl";
            this.Artikl.Size = new System.Drawing.Size(96, 18);
            this.Artikl.TabIndex = 30;
            this.Artikl.Text = "Odabir Artikla";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(192, 47);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 25);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // DGVStavke2
            // 
            this.DGVStavke2.AllowUserToAddRows = false;
            this.DGVStavke2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStavke2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStavke2.Location = new System.Drawing.Point(4, 196);
            this.DGVStavke2.Margin = new System.Windows.Forms.Padding(4);
            this.DGVStavke2.Name = "DGVStavke2";
            this.DGVStavke2.Size = new System.Drawing.Size(776, 209);
            this.DGVStavke2.TabIndex = 28;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblZaposlenik.Location = new System.Drawing.Point(68, 121);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(77, 18);
            this.lblZaposlenik.TabIndex = 27;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDobavljac.Location = new System.Drawing.Point(71, 89);
            this.lblDobavljac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(47, 18);
            this.lblDobavljac.TabIndex = 26;
            this.lblDobavljac.Text = "Kupac";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDatum.Location = new System.Drawing.Point(68, 47);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(50, 18);
            this.lblDatum.TabIndex = 25;
            this.lblDatum.Text = "Datum";
            // 
            // btnUnesiStavku
            // 
            this.btnUnesiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnesiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesiStavku.Location = new System.Drawing.Point(390, 454);
            this.btnUnesiStavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnesiStavku.Name = "btnUnesiStavku";
            this.btnUnesiStavku.Size = new System.Drawing.Size(115, 32);
            this.btnUnesiStavku.TabIndex = 48;
            this.btnUnesiStavku.Text = "Unesi Stavku";
            this.btnUnesiStavku.UseVisualStyleBackColor = true;
            this.btnUnesiStavku.Click += new System.EventHandler(this.btnUnesiStavku_Click_2);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(679, 454);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(100, 32);
            this.btnZatvori.TabIndex = 47;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click_2);
            // 
            // btnUnesiOtpremincu
            // 
            this.btnUnesiOtpremincu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnesiOtpremincu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesiOtpremincu.Location = new System.Drawing.Point(536, 454);
            this.btnUnesiOtpremincu.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnesiOtpremincu.Name = "btnUnesiOtpremincu";
            this.btnUnesiOtpremincu.Size = new System.Drawing.Size(100, 32);
            this.btnUnesiOtpremincu.TabIndex = 46;
            this.btnUnesiOtpremincu.Text = "Unesi";
            this.btnUnesiOtpremincu.UseVisualStyleBackColor = true;
            this.btnUnesiOtpremincu.Click += new System.EventHandler(this.btnUnesiOtpremincu_Click_2);
            // 
            // frmUnosOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 565);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(795, 539);
            this.Name = "frmUnosOtpremnice";
            this.Text = "Unos otpremnice";
            this.Load += new System.EventHandler(this.frmUnosOtpremnice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CMBZaposlenik;
        private System.Windows.Forms.ComboBox CMKupac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBArtikl2;
        private System.Windows.Forms.Label Artikl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView DGVStavke2;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnUnesiStavku;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnUnesiOtpremincu;

    }
}