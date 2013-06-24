namespace Skladiste_PI
{
    partial class frmUnosPrijamnice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosPrijamnice));
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.DGVStavke = new System.Windows.Forms.DataGridView();
            this.btnUnesiPrijamnicu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.CBDobavljac = new System.Windows.Forms.ComboBox();
            this.CMZaposlenik = new System.Windows.Forms.ComboBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.Artikl = new System.Windows.Forms.Label();
            this.CBArtikl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke)).BeginInit();
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
            this.lblDobavljac.Location = new System.Drawing.Point(66, 61);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(54, 13);
            this.lblDobavljac.TabIndex = 1;
            this.lblDobavljac.Text = "Dobavljac";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(66, 89);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(57, 13);
            this.lblZaposlenik.TabIndex = 2;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // DGVStavke
            // 
            this.DGVStavke.AllowUserToAddRows = false;
            this.DGVStavke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStavke.Location = new System.Drawing.Point(0, 138);
            this.DGVStavke.Name = "DGVStavke";
            this.DGVStavke.Size = new System.Drawing.Size(606, 157);
            this.DGVStavke.TabIndex = 6;
            // 
            // btnUnesiPrijamnicu
            // 
            this.btnUnesiPrijamnicu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnesiPrijamnicu.Location = new System.Drawing.Point(438, 373);
            this.btnUnesiPrijamnicu.Name = "btnUnesiPrijamnicu";
            this.btnUnesiPrijamnicu.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiPrijamnicu.TabIndex = 7;
            this.btnUnesiPrijamnicu.Text = "Unesi";
            this.btnUnesiPrijamnicu.UseVisualStyleBackColor = true;
            this.btnUnesiPrijamnicu.Click += new System.EventHandler(this.btnUnesiPrijamnicu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2025, 7, 14, 0, 0, 0, 0);
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
            // CBDobavljac
            // 
            this.CBDobavljac.FormattingEnabled = true;
            this.CBDobavljac.Location = new System.Drawing.Point(159, 58);
            this.CBDobavljac.Name = "CBDobavljac";
            this.CBDobavljac.Size = new System.Drawing.Size(200, 21);
            this.CBDobavljac.TabIndex = 10;
            // 
            // CMZaposlenik
            // 
            this.CMZaposlenik.FormattingEnabled = true;
            this.CMZaposlenik.Location = new System.Drawing.Point(159, 86);
            this.CMZaposlenik.Name = "CMZaposlenik";
            this.CMZaposlenik.Size = new System.Drawing.Size(200, 21);
            this.CMZaposlenik.TabIndex = 11;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(349, 373);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(83, 23);
            this.btnDodajStavku.TabIndex = 12;
            this.btnDodajStavku.Text = "Dodaj Stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // Artikl
            // 
            this.Artikl.AutoSize = true;
            this.Artikl.Location = new System.Drawing.Point(365, 61);
            this.Artikl.Name = "Artikl";
            this.Artikl.Size = new System.Drawing.Size(72, 13);
            this.Artikl.TabIndex = 13;
            this.Artikl.Text = "Odabir Artikla";
            // 
            // CBArtikl
            // 
            this.CBArtikl.FormattingEnabled = true;
            this.CBArtikl.Location = new System.Drawing.Point(443, 58);
            this.CBArtikl.Name = "CBArtikl";
            this.CBArtikl.Size = new System.Drawing.Size(151, 21);
            this.CBArtikl.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kolicina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(443, 86);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(151, 21);
            this.txtKolicina.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "UNOS STAVKI DOKUMENTA";
            // 
            // frmUnosPrijamnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(606, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBArtikl);
            this.Controls.Add(this.Artikl);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.CMZaposlenik);
            this.Controls.Add(this.CBDobavljac);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUnesiPrijamnicu);
            this.Controls.Add(this.DGVStavke);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblDatum);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmUnosPrijamnice";
            this.Text = "Unos prijemnice";
            this.Load += new System.EventHandler(this.frmUnosPrijamnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.DataGridView DGVStavke;
        private System.Windows.Forms.Button btnUnesiPrijamnicu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox CBDobavljac;
        private System.Windows.Forms.ComboBox CMZaposlenik;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label Artikl;
        private System.Windows.Forms.ComboBox CBArtikl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label2;
    }
}