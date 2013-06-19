namespace Skladiste_PI
{
    partial class frmUnosZaposlenika
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.lblTrazi = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panelZaposlenici = new System.Windows.Forms.Panel();
            this.panelUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.panelZaposlenici.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panelUnos
            // 
            this.panelUnos.Controls.Add(this.btnObrisi);
            this.panelUnos.Controls.Add(this.txtAdresa);
            this.panelUnos.Controls.Add(this.txtEmail);
            this.panelUnos.Controls.Add(this.txtBrojTelefona);
            this.panelUnos.Controls.Add(this.lblAdresa);
            this.panelUnos.Controls.Add(this.txtPrezime);
            this.panelUnos.Controls.Add(this.lblEmail);
            this.panelUnos.Controls.Add(this.lblBrojTelefona);
            this.panelUnos.Controls.Add(this.txtIme);
            this.panelUnos.Controls.Add(this.lblPrezime);
            this.panelUnos.Controls.Add(this.lblIme);
            this.panelUnos.Controls.Add(this.btnSpremi);
            this.panelUnos.Location = new System.Drawing.Point(248, 19);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(306, 229);
            this.panelUnos.TabIndex = 12;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Location = new System.Drawing.Point(138, 180);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(106, 23);
            this.btnObrisi.TabIndex = 23;
            this.btnObrisi.Text = "&Obriši promjene";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(152, 123);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 21);
            this.txtAdresa.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 17;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(152, 94);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(100, 21);
            this.txtBrojTelefona.TabIndex = 20;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(55, 126);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(41, 13);
            this.lblAdresa.TabIndex = 18;
            this.lblAdresa.Text = "Adresa";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(151, 40);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 21);
            this.txtPrezime.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(55, 97);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(69, 13);
            this.lblBrojTelefona.TabIndex = 15;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(151, 11);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 21);
            this.txtIme.TabIndex = 12;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(54, 43);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 16;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(54, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(25, 13);
            this.lblIme.TabIndex = 13;
            this.lblIme.Text = "Ime";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(57, 180);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "&Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodaj.Location = new System.Drawing.Point(216, 304);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "&Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisi.Location = new System.Drawing.Point(216, 333);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 9;
            this.btnBrisi.Text = "O&briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.AllowUserToResizeColumns = false;
            this.dgvPodaci.AllowUserToResizeRows = false;
            this.dgvPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPodaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPodaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(0, 44);
            this.dgvPodaci.MultiSelect = false;
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.RowHeadersVisible = false;
            this.dgvPodaci.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPodaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPodaci.ShowCellToolTips = false;
            this.dgvPodaci.ShowEditingIcon = false;
            this.dgvPodaci.Size = new System.Drawing.Size(210, 315);
            this.dgvPodaci.TabIndex = 6;
            this.dgvPodaci.SelectionChanged += new System.EventHandler(this.dgvPodaci_SelectionChanged);
            // 
            // lblTrazi
            // 
            this.lblTrazi.AutoSize = true;
            this.lblTrazi.Location = new System.Drawing.Point(3, 3);
            this.lblTrazi.Name = "lblTrazi";
            this.lblTrazi.Size = new System.Drawing.Size(70, 13);
            this.lblTrazi.TabIndex = 3;
            this.lblTrazi.Text = "Ime i prezime";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(3, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ShortcutsEnabled = false;
            this.txtFilter.Size = new System.Drawing.Size(186, 21);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panelZaposlenici
            // 
            this.panelZaposlenici.Controls.Add(this.txtFilter);
            this.panelZaposlenici.Controls.Add(this.lblTrazi);
            this.panelZaposlenici.Controls.Add(this.dgvPodaci);
            this.panelZaposlenici.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelZaposlenici.Location = new System.Drawing.Point(0, 0);
            this.panelZaposlenici.Name = "panelZaposlenici";
            this.panelZaposlenici.Size = new System.Drawing.Size(210, 362);
            this.panelZaposlenici.TabIndex = 8;
            // 
            // frmUnosZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.panelZaposlenici);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmUnosZaposlenika";
            this.ShowInTaskbar = false;
            this.Text = "Unos novog zaposlenika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnosZaposlenika_FormClosing);
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.panelZaposlenici.ResumeLayout(false);
            this.panelZaposlenici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Panel panelUnos;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnBrisi;
        internal System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Label lblTrazi;
        private System.Windows.Forms.TextBox txtFilter;
        internal System.Windows.Forms.Panel panelZaposlenici;
    }
}