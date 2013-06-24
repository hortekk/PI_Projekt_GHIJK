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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostavke));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panelKoR = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.lblKor = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.panelZaposlenici = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblTrazi = new System.Windows.Forms.Label();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.panelKoR.SuspendLayout();
            this.panelZaposlenici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 10;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panelKoR
            // 
            this.panelKoR.Controls.Add(this.lblStatus);
            this.panelKoR.Controls.Add(this.cbAdmin);
            this.panelKoR.Controls.Add(this.txtLozinka2);
            this.panelKoR.Controls.Add(this.txtLozinka);
            this.panelKoR.Controls.Add(this.label1);
            this.panelKoR.Controls.Add(this.lblLozinka);
            this.panelKoR.Controls.Add(this.txtKorIme);
            this.panelKoR.Controls.Add(this.lblKor);
            this.panelKoR.Location = new System.Drawing.Point(248, 19);
            this.panelKoR.Name = "panelKoR";
            this.panelKoR.Size = new System.Drawing.Size(312, 144);
            this.panelKoR.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatus.Location = new System.Drawing.Point(226, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Tag = "";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(21, 106);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(90, 17);
            this.cbAdmin.TabIndex = 7;
            this.cbAdmin.Text = "Administrator";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(122, 68);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.ShortcutsEnabled = false;
            this.txtLozinka2.Size = new System.Drawing.Size(98, 21);
            this.txtLozinka2.TabIndex = 6;
            this.txtLozinka2.UseSystemPasswordChar = true;
            this.txtLozinka2.TextChanged += new System.EventHandler(this.txtLozinka2_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(122, 41);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.ShortcutsEnabled = false;
            this.txtLozinka.Size = new System.Drawing.Size(98, 21);
            this.txtLozinka.TabIndex = 5;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ponovi lozinku";
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
            this.txtKorIme.TabIndex = 4;
            this.txtKorIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorIme_Validating);
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
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpremi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSpremi.Location = new System.Drawing.Point(216, 304);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "&Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
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
            this.panelZaposlenici.TabIndex = 11;
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
            // lblTrazi
            // 
            this.lblTrazi.AutoSize = true;
            this.lblTrazi.Location = new System.Drawing.Point(3, 3);
            this.lblTrazi.Name = "lblTrazi";
            this.lblTrazi.Size = new System.Drawing.Size(70, 13);
            this.lblTrazi.TabIndex = 0;
            this.lblTrazi.Text = "Ime i prezime";
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
            this.colImePrezime.HeaderText = "Ime i prezime";
            this.colImePrezime.Name = "colImePrezime";
            this.colImePrezime.ReadOnly = true;
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
            this.btnBrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmPostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelZaposlenici);
            this.Controls.Add(this.panelKoR);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPostavke";
            this.ShowInTaskbar = false;
            this.Text = "Postavke autorizacije";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPostavke_FormClosing);
            this.Load += new System.EventHandler(this.frmPostavke_Load);
            this.panelKoR.ResumeLayout(false);
            this.panelKoR.PerformLayout();
            this.panelZaposlenici.ResumeLayout(false);
            this.panelZaposlenici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Panel panelKoR;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label lblKor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel panelZaposlenici;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblTrazi;
        internal System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImePrezime;
        private System.Windows.Forms.Button btnBrisi;
    }
}