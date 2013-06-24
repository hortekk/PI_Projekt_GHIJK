namespace Skladiste_PI
{
    partial class frmPregledOtpremince
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledOtpremince));
            this.DGVOtpremnice = new System.Windows.Forms.DataGridView();
            this.DGVStavke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOtpremnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOtpremnice
            // 
            this.DGVOtpremnice.AllowUserToAddRows = false;
            this.DGVOtpremnice.AllowUserToDeleteRows = false;
            this.DGVOtpremnice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOtpremnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOtpremnice.Location = new System.Drawing.Point(0, 0);
            this.DGVOtpremnice.Name = "DGVOtpremnice";
            this.DGVOtpremnice.Size = new System.Drawing.Size(653, 405);
            this.DGVOtpremnice.TabIndex = 1;
            this.DGVOtpremnice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOtpremnice_CellClick);
            // 
            // DGVStavke
            // 
            this.DGVStavke.AllowUserToAddRows = false;
            this.DGVStavke.AllowUserToDeleteRows = false;
            this.DGVStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStavke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVStavke.Location = new System.Drawing.Point(0, 201);
            this.DGVStavke.Name = "DGVStavke";
            this.DGVStavke.Size = new System.Drawing.Size(653, 204);
            this.DGVStavke.TabIndex = 2;
            // 
            // frmPregledOtpremince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 405);
            this.Controls.Add(this.DGVStavke);
            this.Controls.Add(this.DGVOtpremnice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmPregledOtpremince";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled otpremince";
            this.Load += new System.EventHandler(this.frmPregledOtpremince_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOtpremnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStavke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVOtpremnice;
        private System.Windows.Forms.DataGridView DGVStavke;
    }
}