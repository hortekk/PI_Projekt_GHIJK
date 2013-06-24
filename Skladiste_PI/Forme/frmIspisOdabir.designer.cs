namespace Skladiste_PI
{
    partial class frmIspisOdabir
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
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(12, 57);
            this.dgvPodaci.MultiSelect = false;
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.RowHeadersVisible = false;
            this.dgvPodaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPodaci.Size = new System.Drawing.Size(483, 240);
            this.dgvPodaci.TabIndex = 0;
            this.dgvPodaci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPodaci_CellClick);
            this.dgvPodaci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPodaci_CellDoubleClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(211, 303);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Učitaj";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(161, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(178, 13);
            this.label.TabIndex = 2;
            this.label.Text = "ODABERITE OTPREMNICU ZA ISPIS";
            // 
            // frmIspisOdabir
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(507, 338);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvPodaci);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIspisOdabir";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmIspisOtpremnice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIspisOdabir_FormClosing);
            this.Load += new System.EventHandler(this.frmIspisOtp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label;
    }
}