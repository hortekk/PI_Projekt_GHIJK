namespace Skladiste_PI
{
    partial class frmPostavke
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panelKorRacuni = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblTrazi = new System.Windows.Forms.Label();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.kor_ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelKoR = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnProvjeriAdmina = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.lblKor = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.panelKorRacuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.panelKoR.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panelKorRacuni
            // 
            this.panelKorRacuni.Controls.Add(this.txtFilter);
            this.panelKorRacuni.Controls.Add(this.lblTrazi);
            this.panelKorRacuni.Controls.Add(this.dgvPodaci);
            this.panelKorRacuni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKorRacuni.Location = new System.Drawing.Point(0, 0);
            this.panelKorRacuni.Name = "panelKorRacuni";
            this.panelKorRacuni.Size = new System.Drawing.Size(210, 362);
            this.panelKorRacuni.TabIndex = 6;
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
            // lblTrazi
            // 
            this.lblTrazi.AutoSize = true;
            this.lblTrazi.Location = new System.Drawing.Point(3, 3);
            this.lblTrazi.Name = "lblTrazi";
            this.lblTrazi.Size = new System.Drawing.Size(73, 13);
            this.lblTrazi.TabIndex = 3;
            this.lblTrazi.Text = "Korisničko ime";
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
            this.kor_ime});
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
            // kor_ime
            // 
            this.kor_ime.HeaderText = "Korisničko ime";
            this.kor_ime.Name = "kor_ime";
            this.kor_ime.ReadOnly = true;
            // 
            // panelKoR
            // 
            this.panelKoR.Controls.Add(this.lblStatus);
            this.panelKoR.Controls.Add(this.lblNapomena);
            this.panelKoR.Controls.Add(this.cbAdmin);
            this.panelKoR.Controls.Add(this.btnObrisi);
            this.panelKoR.Controls.Add(this.txtAdmin);
            this.panelKoR.Controls.Add(this.txtLozinka);
            this.panelKoR.Controls.Add(this.btnProvjeriAdmina);
            this.panelKoR.Controls.Add(this.btnSpremi);
            this.panelKoR.Controls.Add(this.lblLozinka);
            this.panelKoR.Controls.Add(this.txtKorIme);
            this.panelKoR.Controls.Add(this.lblKor);
            this.panelKoR.Location = new System.Drawing.Point(260, 29);
            this.panelKoR.Name = "panelKoR";
            this.panelKoR.Size = new System.Drawing.Size(312, 237);
            this.panelKoR.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatus.Location = new System.Drawing.Point(135, 92);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Tag = "";
            this.lblStatus.Text = "Ne autoriziran";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(18, 123);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(215, 39);
            this.lblNapomena.TabIndex = 8;
            this.lblNapomena.Text = "*  Kako bi ovom korisniku odobrili prava \n    administratora morate u polje upisa" +
    "ti \n    lozinku jednog postojećeg administatora!";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(19, 70);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(96, 17);
            this.cbAdmin.TabIndex = 6;
            this.cbAdmin.Text = "Administrator*";
            this.toolTip.SetToolTip(this.cbAdmin, "Kako bi ovom korisniku odobrili prava administratora morate u polje \ndesno upisat" +
        "i lozinku jednog već postojećeg administatora!");
            this.cbAdmin.UseVisualStyleBackColor = true;
            this.cbAdmin.CheckedChanged += new System.EventHandler(this.cbAadmin_CheckedChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnObrisi.Location = new System.Drawing.Point(147, 189);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(106, 23);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "&Obriši promjene";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtAdmin
            // 
            this.txtAdmin.Enabled = false;
            this.txtAdmin.Location = new System.Drawing.Point(122, 68);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.ShortcutsEnabled = false;
            this.txtAdmin.Size = new System.Drawing.Size(98, 21);
            this.txtAdmin.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtAdmin, "Ovdje upišite lozinku jednog već postojećeg administatora");
            this.txtAdmin.UseSystemPasswordChar = true;
            this.txtAdmin.TextChanged += new System.EventHandler(this.txtAdmin_TextChanged);
            this.txtAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmin_KeyPress);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(122, 41);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.ShortcutsEnabled = false;
            this.txtLozinka.Size = new System.Drawing.Size(98, 21);
            this.txtLozinka.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtLozinka, "U ovo polje unesite lozinku koju želite koristiti");
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // btnProvjeriAdmina
            // 
            this.btnProvjeriAdmina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProvjeriAdmina.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProvjeriAdmina.Location = new System.Drawing.Point(226, 68);
            this.btnProvjeriAdmina.Name = "btnProvjeriAdmina";
            this.btnProvjeriAdmina.Size = new System.Drawing.Size(75, 23);
            this.btnProvjeriAdmina.TabIndex = 0;
            this.btnProvjeriAdmina.Text = "Pro&vjeri";
            this.btnProvjeriAdmina.UseVisualStyleBackColor = true;
            this.btnProvjeriAdmina.Click += new System.EventHandler(this.btnProvjeriAdmin_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpremi.Location = new System.Drawing.Point(66, 189);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "&Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(18, 44);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(42, 13);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(122, 14);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.ShortcutsEnabled = false;
            this.txtKorIme.Size = new System.Drawing.Size(98, 21);
            this.txtKorIme.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtKorIme, "Ovdje unesite željeno korisničko ime");
            // 
            // lblKor
            // 
            this.lblKor.AutoSize = true;
            this.lblKor.Location = new System.Drawing.Point(18, 17);
            this.lblKor.Name = "lblKor";
            this.lblKor.Size = new System.Drawing.Size(73, 13);
            this.lblKor.TabIndex = 3;
            this.lblKor.Text = "Korisničko ime";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodaj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDodaj.Location = new System.Drawing.Point(216, 298);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "&Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipTitle = "Uputa...";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrisi.Location = new System.Drawing.Point(216, 327);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 0;
            this.btnBrisi.Text = "O&briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIspis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIspis.Location = new System.Drawing.Point(297, 327);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 0;
            this.btnIspis.Text = "Is&pis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmPostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelKoR);
            this.Controls.Add(this.panelKorRacuni);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnZatvori);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPostavke";
            this.Text = "frmPostavke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPostavke_FormClosing);
            this.Load += new System.EventHandler(this.frmPostavke_Load);
            this.panelKorRacuni.ResumeLayout(false);
            this.panelKorRacuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.panelKoR.ResumeLayout(false);
            this.panelKoR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        internal System.Windows.Forms.Panel panelKorRacuni;
        private System.Windows.Forms.TextBox txtFilter;
        internal System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Label lblTrazi;
        private System.Windows.Forms.Panel panelKoR;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label lblKor;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kor_ime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnProvjeriAdmina;
        private System.Windows.Forms.Button btnIspis;
    }
}