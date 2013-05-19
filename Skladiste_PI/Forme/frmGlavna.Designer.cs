namespace Skladiste_PI
{
    partial class frmGlavna
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
            this.mnuMeni = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generiraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKupacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMeni
            // 
            this.mnuMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dokumentiToolStripMenuItem,
            this.artikliToolStripMenuItem,
            this.upravljanjeToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.mnuMeni.Location = new System.Drawing.Point(0, 0);
            this.mnuMeni.Name = "mnuMeni";
            this.mnuMeni.Size = new System.Drawing.Size(891, 24);
            this.mnuMeni.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjaviSeToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileToolStripMenuItem.Text = "&Datoteka";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.odjaviSeToolStripMenuItem.Text = "&Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zatvoriToolStripMenuItem.Text = "&Zatvori aplikaciju";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // dokumentiToolStripMenuItem
            // 
            this.dokumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.generiraniToolStripMenuItem});
            this.dokumentiToolStripMenuItem.Name = "dokumentiToolStripMenuItem";
            this.dokumentiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.dokumentiToolStripMenuItem.Text = "D&okumenti";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primkeToolStripMenuItem,
            this.otpremniceToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosToolStripMenuItem.Text = "&Unos";
            // 
            // primkeToolStripMenuItem
            // 
            this.primkeToolStripMenuItem.Name = "primkeToolStripMenuItem";
            this.primkeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.primkeToolStripMenuItem.Text = "&Prijemnica";
            this.primkeToolStripMenuItem.Click += new System.EventHandler(this.primkeToolStripMenuItem_Click);
            // 
            // otpremniceToolStripMenuItem
            // 
            this.otpremniceToolStripMenuItem.Name = "otpremniceToolStripMenuItem";
            this.otpremniceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otpremniceToolStripMenuItem.Text = "&Otpremnica";
            this.otpremniceToolStripMenuItem.Click += new System.EventHandler(this.otpremniceToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primkToolStripMenuItem,
            this.otpremniciToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem.Text = "&Pregled";
            // 
            // primkToolStripMenuItem
            // 
            this.primkToolStripMenuItem.Name = "primkToolStripMenuItem";
            this.primkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.primkToolStripMenuItem.Text = "&Prijemnica";
            this.primkToolStripMenuItem.Click += new System.EventHandler(this.primkToolStripMenuItem_Click);
            // 
            // otpremniciToolStripMenuItem
            // 
            this.otpremniciToolStripMenuItem.Name = "otpremniciToolStripMenuItem";
            this.otpremniciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otpremniciToolStripMenuItem.Text = "&Otpremnica";
            this.otpremniciToolStripMenuItem.Click += new System.EventHandler(this.otpremniciToolStripMenuItem_Click);
            // 
            // generiraniToolStripMenuItem
            // 
            this.generiraniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudžbeniceToolStripMenuItem});
            this.generiraniToolStripMenuItem.Name = "generiraniToolStripMenuItem";
            this.generiraniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generiraniToolStripMenuItem.Text = "&Generiranje";
            // 
            // narudžbeniceToolStripMenuItem
            // 
            this.narudžbeniceToolStripMenuItem.Name = "narudžbeniceToolStripMenuItem";
            this.narudžbeniceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.narudžbeniceToolStripMenuItem.Text = "&Narudžbenice";
            this.narudžbeniceToolStripMenuItem.Click += new System.EventHandler(this.narudžbeniceToolStripMenuItem_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogToolStripMenuItem,
            this.pregledToolStripMenuItem1});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.artikliToolStripMenuItem.Text = "&Artikli";
            // 
            // unosNovogToolStripMenuItem
            // 
            this.unosNovogToolStripMenuItem.Name = "unosNovogToolStripMenuItem";
            this.unosNovogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosNovogToolStripMenuItem.Text = "&Unos";
            this.unosNovogToolStripMenuItem.Click += new System.EventHandler(this.unosNovogToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem1.Text = "&Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.pregledToolStripMenuItem1_Click);
            // 
            // upravljanjeToolStripMenuItem
            // 
            this.upravljanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kupciToolStripMenuItem,
            this.dobavljačiToolStripMenuItem,
            this.zaposleniciToolStripMenuItem});
            this.upravljanjeToolStripMenuItem.Name = "upravljanjeToolStripMenuItem";
            this.upravljanjeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.upravljanjeToolStripMenuItem.Text = "&Upravljanje";
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviKupacToolStripMenuItem,
            this.pregledToolStripMenuItem2});
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kupciToolStripMenuItem.Text = "&Kupci";
            // 
            // noviKupacToolStripMenuItem
            // 
            this.noviKupacToolStripMenuItem.Name = "noviKupacToolStripMenuItem";
            this.noviKupacToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noviKupacToolStripMenuItem.Text = "&Novi";
            this.noviKupacToolStripMenuItem.Click += new System.EventHandler(this.noviKupacToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem2
            // 
            this.pregledToolStripMenuItem2.Name = "pregledToolStripMenuItem2";
            this.pregledToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem2.Text = "&Pregled";
            this.pregledToolStripMenuItem2.Click += new System.EventHandler(this.pregledToolStripMenuItem2_Click);
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem,
            this.pregledToolStripMenuItem3});
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dobavljačiToolStripMenuItem.Text = "&Dobavljači";
            // 
            // noviToolStripMenuItem
            // 
            this.noviToolStripMenuItem.Name = "noviToolStripMenuItem";
            this.noviToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noviToolStripMenuItem.Text = "&Novi";
            this.noviToolStripMenuItem.Click += new System.EventHandler(this.noviToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem3
            // 
            this.pregledToolStripMenuItem3.Name = "pregledToolStripMenuItem3";
            this.pregledToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem3.Text = "&Pregled";
            this.pregledToolStripMenuItem3.Click += new System.EventHandler(this.pregledToolStripMenuItem3_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviToolStripMenuItem1,
            this.pregledToolStripMenuItem4});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zaposleniciToolStripMenuItem.Text = "&Zaposlenici";
            // 
            // noviToolStripMenuItem1
            // 
            this.noviToolStripMenuItem1.Name = "noviToolStripMenuItem1";
            this.noviToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.noviToolStripMenuItem1.Text = "&Novi";
            this.noviToolStripMenuItem1.Click += new System.EventHandler(this.noviToolStripMenuItem1_Click);
            // 
            // pregledToolStripMenuItem4
            // 
            this.pregledToolStripMenuItem4.Name = "pregledToolStripMenuItem4";
            this.pregledToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem4.Text = "&Pregled";
            this.pregledToolStripMenuItem4.Click += new System.EventHandler(this.pregledToolStripMenuItem4_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dokumentacijaToolStripMenuItem,
            this.toolStripSeparator1,
            this.oNamaToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "&Pomoć";
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.oNamaToolStripMenuItem.Text = "&O nama...";
            this.oNamaToolStripMenuItem.Click += new System.EventHandler(this.oNamaToolStripMenuItem_Click);
            // 
            // dokumentacijaToolStripMenuItem
            // 
            this.dokumentacijaToolStripMenuItem.Name = "dokumentacijaToolStripMenuItem";
            this.dokumentacijaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dokumentacijaToolStripMenuItem.Text = "&Dokumentacija";
            this.dokumentacijaToolStripMenuItem.Click += new System.EventHandler(this.dokumentacijaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 515);
            this.Controls.Add(this.mnuMeni);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMeni;
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI Aplikacija za Skladište";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.mnuMeni.ResumeLayout(false);
            this.mnuMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMeni;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otpremniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otpremniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generiraniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKupacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;

    }
}

