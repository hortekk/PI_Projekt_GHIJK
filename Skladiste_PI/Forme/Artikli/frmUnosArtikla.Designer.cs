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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosArtikla));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTrazi = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panelArtikli = new System.Windows.Forms.Panel();
            this.bwPromjenaUnosa = new System.ComponentModel.BackgroundWorker();
            this.panelUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.panelArtikli.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panelUnos
            // 
            this.panelUnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelUnos.Controls.Add(this.lblKategorija);
            this.panelUnos.Controls.Add(this.cbKategorija);
            this.panelUnos.Controls.Add(this.btnObrisi);
            this.panelUnos.Controls.Add(this.txtCijena);
            this.panelUnos.Controls.Add(this.txtAlarm);
            this.panelUnos.Controls.Add(this.lblCijena);
            this.panelUnos.Controls.Add(this.txtIme);
            this.panelUnos.Controls.Add(this.lblAlarm);
            this.panelUnos.Controls.Add(this.lblIme);
            this.panelUnos.Controls.Add(this.btnSpremi);
            this.panelUnos.Location = new System.Drawing.Point(248, 19);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(306, 229);
            this.panelUnos.TabIndex = 4;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKategorija.Location = new System.Drawing.Point(36, 3);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(242, 18);
            this.lblKategorija.TabIndex = 19;
            this.lblKategorija.Text = "ODABERITE KATEGORIJU ARTIKLA";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(56, 35);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(188, 21);
            this.cbKategorija.TabIndex = 18;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(122, 190);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(106, 23);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "&Obriši promjene";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCijena.Location = new System.Drawing.Point(161, 134);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 21);
            this.txtCijena.TabIndex = 6;
            // 
            // txtAlarm
            // 
            this.txtAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAlarm.Location = new System.Drawing.Point(160, 107);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(100, 21);
            this.txtAlarm.TabIndex = 5;
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCijena.Location = new System.Drawing.Point(38, 137);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(97, 18);
            this.lblCijena.TabIndex = 6;
            this.lblCijena.Text = "Cijena prodaje";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIme.Location = new System.Drawing.Point(160, 78);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 21);
            this.txtIme.TabIndex = 4;
            // 
            // lblAlarm
            // 
            this.lblAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAlarm.Location = new System.Drawing.Point(38, 110);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(113, 18);
            this.lblAlarm.TabIndex = 5;
            this.lblAlarm.Text = "Alarmna količina";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIme.Location = new System.Drawing.Point(38, 81);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(44, 18);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Naziv";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpremi.Location = new System.Drawing.Point(41, 190);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
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
            this.btnDodaj.TabIndex = 2;
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
            this.btnBrisi.TabIndex = 3;
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
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colImePrezime});
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
            this.dgvPodaci.TabIndex = 1;
            this.dgvPodaci.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvPodaci_CellValidating);
            this.dgvPodaci.SelectionChanged += new System.EventHandler(this.dgvPodaci_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // colImePrezime
            // 
            this.colImePrezime.HeaderText = "Naziv artikla";
            this.colImePrezime.Name = "colImePrezime";
            this.colImePrezime.ReadOnly = true;
            // 
            // lblTrazi
            // 
            this.lblTrazi.AutoSize = true;
            this.lblTrazi.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTrazi.Location = new System.Drawing.Point(3, 3);
            this.lblTrazi.Name = "lblTrazi";
            this.lblTrazi.Size = new System.Drawing.Size(86, 18);
            this.lblTrazi.TabIndex = 0;
            this.lblTrazi.Text = "Naziv artikla";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(3, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.ShortcutsEnabled = false;
            this.txtFilter.Size = new System.Drawing.Size(186, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panelArtikli
            // 
            this.panelArtikli.Controls.Add(this.txtFilter);
            this.panelArtikli.Controls.Add(this.lblTrazi);
            this.panelArtikli.Controls.Add(this.dgvPodaci);
            this.panelArtikli.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelArtikli.Location = new System.Drawing.Point(0, 0);
            this.panelArtikli.Name = "panelArtikli";
            this.panelArtikli.Size = new System.Drawing.Size(210, 362);
            this.panelArtikli.TabIndex = 0;
            // 
            // bwPromjenaUnosa
            // 
            this.bwPromjenaUnosa.WorkerSupportsCancellation = true;
            this.bwPromjenaUnosa.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPromjenaUnosa_DoWork);
            this.bwPromjenaUnosa.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwPromjenaUnosa_RunWorkerCompleted);
            // 
            // frmUnosArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.panelArtikli);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmUnosArtikla";
            this.ShowInTaskbar = false;
            this.Text = "Unos novog artikla";
            this.Activated += new System.EventHandler(this.frmUnosArtikla_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnosArtikla_FormClosing);
            this.Load += new System.EventHandler(this.frmUnosArtikla_Load);
            this.Leave += new System.EventHandler(this.frmUnosArtikla_Leave);
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.panelArtikli.ResumeLayout(false);
            this.panelArtikli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Panel panelUnos;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtAlarm;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnBrisi;
        internal System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Label lblTrazi;
        private System.Windows.Forms.TextBox txtFilter;
        internal System.Windows.Forms.Panel panelArtikli;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImePrezime;
        private System.ComponentModel.BackgroundWorker bwPromjenaUnosa;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cbKategorija;
    }
}