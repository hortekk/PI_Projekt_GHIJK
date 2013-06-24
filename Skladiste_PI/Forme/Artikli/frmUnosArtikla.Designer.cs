namespace Skladiste_PI
{
    partial class frmUnosArtikla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosArtikla));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblAlarmKol = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAlarmKol = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(154, 180);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "&Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(34, 37);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(34, 127);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(74, 13);
            this.lblCijena.TabIndex = 2;
            this.lblCijena.Text = "Cijena prodaje";
            // 
            // lblAlarmKol
            // 
            this.lblAlarmKol.AutoSize = true;
            this.lblAlarmKol.Location = new System.Drawing.Point(34, 95);
            this.lblAlarmKol.Name = "lblAlarmKol";
            this.lblAlarmKol.Size = new System.Drawing.Size(84, 13);
            this.lblAlarmKol.TabIndex = 4;
            this.lblAlarmKol.Text = "Alarmna količina";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(145, 34);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // txtAlarmKol
            // 
            this.txtAlarmKol.Location = new System.Drawing.Point(145, 92);
            this.txtAlarmKol.Name = "txtAlarmKol";
            this.txtAlarmKol.Size = new System.Drawing.Size(100, 20);
            this.txtAlarmKol.TabIndex = 6;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(145, 124);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 8;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(312, 65);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(188, 21);
            this.cbKategorija.TabIndex = 10;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(309, 37);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(191, 13);
            this.lblKategorija.TabIndex = 11;
            this.lblKategorija.Text = "ODABERITE KATEGORIJU ARTIKLA:";
            // 
            // frmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtAlarmKol);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblAlarmKol);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmUnosArtikla";
            this.Text = "Unos artikla";
            this.Load += new System.EventHandler(this.frmUnosArtikla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblAlarmKol;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAlarmKol;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label lblKategorija;
    }
}