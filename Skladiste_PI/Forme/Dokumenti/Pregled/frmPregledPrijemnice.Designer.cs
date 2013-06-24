namespace Skladiste_PI
{
    partial class frmPregledPrijamnice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledPrijamnice));
            this.DGVPrijamnice = new System.Windows.Forms.DataGridView();
            this.DGVStavke2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrijamnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPrijamnice
            // 
            this.DGVPrijamnice.AllowUserToAddRows = false;
            this.DGVPrijamnice.AllowUserToDeleteRows = false;
            this.DGVPrijamnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPrijamnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPrijamnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPrijamnice.Location = new System.Drawing.Point(0, 0);
            this.DGVPrijamnice.Name = "DGVPrijamnice";
            this.DGVPrijamnice.Size = new System.Drawing.Size(717, 434);
            this.DGVPrijamnice.TabIndex = 1;
            this.DGVPrijamnice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPrijamnice_CellClick);
            // 
            // DGVStavke2
            // 
            this.DGVStavke2.AllowUserToAddRows = false;
            this.DGVStavke2.AllowUserToDeleteRows = false;
            this.DGVStavke2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVStavke2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStavke2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVStavke2.Location = new System.Drawing.Point(0, 206);
            this.DGVStavke2.Name = "DGVStavke2";
            this.DGVStavke2.Size = new System.Drawing.Size(717, 228);
            this.DGVStavke2.TabIndex = 2;
            // 
            // frmPregledPrijamnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 434);
            this.Controls.Add(this.DGVStavke2);
            this.Controls.Add(this.DGVPrijamnice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPregledPrijamnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled prijemnice";
            this.Load += new System.EventHandler(this.frmPregledPrijamnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrijamnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPrijamnice;
        private System.Windows.Forms.DataGridView DGVStavke2;
    }
}