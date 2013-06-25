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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVStavke = new System.Windows.Forms.DataGridView();
            this.CMZaposlenik = new System.Windows.Forms.ComboBox();
            this.CBDobavljac = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBArtikl = new System.Windows.Forms.ComboBox();
            this.Artikl = new System.Windows.Forms.Label();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnUnesiPrijamnicu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.btnDodajStavku);
            this.panel1.Controls.Add(this.btnZatvori);
            this.panel1.Controls.Add(this.btnUnesiPrijamnicu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKolicina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBArtikl);
            this.panel1.Controls.Add(this.Artikl);
            this.panel1.Controls.Add(this.CMZaposlenik);
            this.panel1.Controls.Add(this.CBDobavljac);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblZaposlenik);
            this.panel1.Controls.Add(this.lblDobavljac);
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.DGVStavke);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 489);
            this.panel1.TabIndex = 18;
            // 
            // DGVStavke
            // 
            this.DGVStavke.AllowUserToAddRows = false;
            this.DGVStavke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStavke.Location = new System.Drawing.Point(4, 167);
            this.DGVStavke.Margin = new System.Windows.Forms.Padding(4);
            this.DGVStavke.Name = "DGVStavke";
            this.DGVStavke.Size = new System.Drawing.Size(762, 206);
            this.DGVStavke.TabIndex = 7;
            // 
            // CMZaposlenik
            // 
            this.CMZaposlenik.FormattingEnabled = true;
            this.CMZaposlenik.Location = new System.Drawing.Point(157, 99);
            this.CMZaposlenik.Margin = new System.Windows.Forms.Padding(4);
            this.CMZaposlenik.Name = "CMZaposlenik";
            this.CMZaposlenik.Size = new System.Drawing.Size(265, 26);
            this.CMZaposlenik.TabIndex = 17;
            // 
            // CBDobavljac
            // 
            this.CBDobavljac.FormattingEnabled = true;
            this.CBDobavljac.Location = new System.Drawing.Point(157, 60);
            this.CBDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.CBDobavljac.Name = "CBDobavljac";
            this.CBDobavljac.Size = new System.Drawing.Size(265, 26);
            this.CBDobavljac.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 25);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2025, 7, 14, 0, 0, 0, 0);
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblZaposlenik.Location = new System.Drawing.Point(33, 103);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(77, 18);
            this.lblZaposlenik.TabIndex = 14;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDobavljac.Location = new System.Drawing.Point(33, 64);
            this.lblDobavljac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(70, 18);
            this.lblDobavljac.TabIndex = 13;
            this.lblDobavljac.Text = "Dobavljac";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDatum.Location = new System.Drawing.Point(33, 22);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(50, 18);
            this.lblDatum.TabIndex = 12;
            this.lblDatum.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(503, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "UNOS STAVKI DOKUMENTA";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(546, 95);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(200, 25);
            this.txtKolicina.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(442, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kolicina";
            // 
            // CBArtikl
            // 
            this.CBArtikl.FormattingEnabled = true;
            this.CBArtikl.Location = new System.Drawing.Point(546, 56);
            this.CBArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.CBArtikl.Name = "CBArtikl";
            this.CBArtikl.Size = new System.Drawing.Size(200, 26);
            this.CBArtikl.TabIndex = 19;
            // 
            // Artikl
            // 
            this.Artikl.AutoSize = true;
            this.Artikl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Artikl.Location = new System.Drawing.Point(442, 60);
            this.Artikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Artikl.Name = "Artikl";
            this.Artikl.Size = new System.Drawing.Size(96, 18);
            this.Artikl.TabIndex = 18;
            this.Artikl.Text = "Odabir Artikla";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavku.Location = new System.Drawing.Point(364, 443);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(111, 32);
            this.btnDodajStavku.TabIndex = 25;
            this.btnDodajStavku.Text = "Dodaj Stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click_1);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(662, 443);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(100, 32);
            this.btnZatvori.TabIndex = 24;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click_1);
            // 
            // btnUnesiPrijamnicu
            // 
            this.btnUnesiPrijamnicu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnesiPrijamnicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnesiPrijamnicu.Location = new System.Drawing.Point(518, 443);
            this.btnUnesiPrijamnicu.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnesiPrijamnicu.Name = "btnUnesiPrijamnicu";
            this.btnUnesiPrijamnicu.Size = new System.Drawing.Size(100, 32);
            this.btnUnesiPrijamnicu.TabIndex = 23;
            this.btnUnesiPrijamnicu.Text = "Unesi";
            this.btnUnesiPrijamnicu.UseVisualStyleBackColor = true;
            this.btnUnesiPrijamnicu.Click += new System.EventHandler(this.btnUnesiPrijamnicu_Click_1);
            // 
            // frmUnosPrijamnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 565);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(795, 539);
            this.Name = "frmUnosPrijamnice";
            this.Text = "Unos prijemnice";
            this.Load += new System.EventHandler(this.frmUnosPrijamnice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnUnesiPrijamnicu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBArtikl;
        private System.Windows.Forms.Label Artikl;
        private System.Windows.Forms.ComboBox CMZaposlenik;
        private System.Windows.Forms.ComboBox CBDobavljac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DataGridView DGVStavke;

    }
}