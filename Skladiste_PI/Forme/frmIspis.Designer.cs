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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIspis));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelPozadina = new System.Windows.Forms.Panel();
            this.btnIspis = new System.Windows.Forms.Button();
            this.bwLoadReport = new System.ComponentModel.BackgroundWorker();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.lblLoad = new System.Windows.Forms.Label();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.panelOdabir = new System.Windows.Forms.Panel();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.panelPozadina.SuspendLayout();
            this.panelLoad.SuspendLayout();
            this.panelOdabir.SuspendLayout();
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
            this.panelPozadina.Visible = false;
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
            // bwLoadReport
            // 
            this.bwLoadReport.WorkerReportsProgress = true;
            this.bwLoadReport.WorkerSupportsCancellation = true;
            this.bwLoadReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadReport_DoWork);
            this.bwLoadReport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwLoadReport_ProgressChanged);
            this.bwLoadReport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadReport_RunWorkerCompleted);
            // 
            // panelLoad
            // 
            this.panelLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoad.Controls.Add(this.lblLoad);
            this.panelLoad.Controls.Add(this.pbLoad);
            this.panelLoad.Location = new System.Drawing.Point(162, 69);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(270, 163);
            this.panelLoad.TabIndex = 3;
            // 
            // lblLoad
            // 
            this.lblLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(12, 37);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(156, 13);
            this.lblLoad.TabIndex = 5;
            this.lblLoad.Text = "Učitavanje podataka u tijeku...";
            // 
            // pbLoad
            // 
            this.pbLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbLoad.Location = new System.Drawing.Point(15, 62);
            this.pbLoad.MaximumSize = new System.Drawing.Size(236, 35);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(236, 35);
            this.pbLoad.TabIndex = 4;
            // 
            // panelOdabir
            // 
            this.panelOdabir.Controls.Add(this.btnUcitaj);
            this.panelOdabir.Location = new System.Drawing.Point(200, 70);
            this.panelOdabir.Name = "panelOdabir";
            this.panelOdabir.Size = new System.Drawing.Size(323, 283);
            this.panelOdabir.TabIndex = 0;
            this.panelOdabir.Visible = false;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(0, 166);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 40;
            this.btnUcitaj.Text = "&Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // frmIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.panelPozadina);
            this.Controls.Add(this.panelOdabir);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmIspis";
            this.Text = "Ispis";
            this.panelPozadina.ResumeLayout(false);
            this.panelLoad.ResumeLayout(false);
            this.panelLoad.PerformLayout();
            this.panelOdabir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.Panel panelPozadina;
        private System.Windows.Forms.Button btnIspis;
        private System.ComponentModel.BackgroundWorker bwLoadReport;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.ProgressBar pbLoad;
        private System.Windows.Forms.Panel panelOdabir;
        private System.Windows.Forms.Button btnUcitaj;
    }
}