namespace Skladiste_PI
{
    partial class frmIspis
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelPozadina = new System.Windows.Forms.Panel();
            this.btnIspis = new System.Windows.Forms.Button();
            this.panelPozadina.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "&Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report.Location = new System.Drawing.Point(10, 10);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(564, 302);
            this.report.TabIndex = 1;
            // 
            // panelPozadina
            // 
            this.panelPozadina.Controls.Add(this.btnIspis);
            this.panelPozadina.Controls.Add(this.report);
            this.panelPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPozadina.Location = new System.Drawing.Point(0, 0);
            this.panelPozadina.Name = "panelPozadina";
            this.panelPozadina.Padding = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.panelPozadina.Size = new System.Drawing.Size(584, 362);
            this.panelPozadina.TabIndex = 7;
            // 
            // btnIspis
            // 
            this.btnIspis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIspis.Location = new System.Drawing.Point(416, 327);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 2;
            this.btnIspis.Text = "&Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.panelPozadina);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmIspis";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.frmIspis_Load);
            this.panelPozadina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.Panel panelPozadina;
        private System.Windows.Forms.Button btnIspis;
    }
}