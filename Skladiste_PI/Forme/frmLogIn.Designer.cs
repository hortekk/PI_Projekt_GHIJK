﻿namespace Skladiste_PI
{
    partial class frmLogIn
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(172, 156);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(100, 23);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "&Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(154, 69);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(73, 13);
            this.lblKorisnickoIme.TabIndex = 1;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(154, 98);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(42, 13);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(239, 66);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(100, 21);
            this.txtKorIme.TabIndex = 0;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(239, 98);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 21);
            this.txtLozinka.TabIndex = 1;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIzlaz.Location = new System.Drawing.Point(278, 156);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(100, 23);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "&Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Location = new System.Drawing.Point(72, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(189, 13);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Molimo unesite korisničko ime i lozinku!";
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIzlaz;
            this.ClientSize = new System.Drawing.Size(528, 255);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPrijava);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava korisnika";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label lblNaslov;
    }
}