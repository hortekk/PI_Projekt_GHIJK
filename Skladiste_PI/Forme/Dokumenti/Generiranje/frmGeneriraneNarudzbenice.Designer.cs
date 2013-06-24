namespace Skladiste_PI
{
    partial class frmGeneriraneNarudzbenice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneriraneNarudzbenice));
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvGenNar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenNar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPregled
            // 
            this.btnPregled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPregled.Location = new System.Drawing.Point(332, 327);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(159, 23);
            this.btnPregled.TabIndex = 2;
            this.btnPregled.Text = "&Pregled za ispis";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvGenNar
            // 
            this.dgvGenNar.AllowUserToAddRows = false;
            this.dgvGenNar.AllowUserToDeleteRows = false;
            this.dgvGenNar.AllowUserToOrderColumns = true;
            this.dgvGenNar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenNar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenNar.Location = new System.Drawing.Point(12, 12);
            this.dgvGenNar.Name = "dgvGenNar";
            this.dgvGenNar.ReadOnly = true;
            this.dgvGenNar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenNar.ShowEditingIcon = false;
            this.dgvGenNar.Size = new System.Drawing.Size(560, 309);
            this.dgvGenNar.TabIndex = 9;
            // 
            // frmGeneriraneNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.dgvGenNar);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnPregled);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmGeneriraneNarudzbenice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled narudžbenice";
            this.Activated += new System.EventHandler(this.frmGeneriraneNarudzbenice_Activated);
            this.Load += new System.EventHandler(this.frmGeneriraneNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenNar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvGenNar;
    }
}