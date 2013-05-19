using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_PI
{
    public partial class frmLogIn : Form
    {
        public Boolean logiranKorisnik = false;

        public frmLogIn()
        {
            InitializeComponent();

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {

            logiranKorisnik = ProvjeriKorisnika(txtKorIme.Text, txtLozinka.Text);

            if (logiranKorisnik){
                // Provjera uspjesna
                MessageBox.Show("Uspješno ste se prijavili!", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // frmGlavna.UspjesnaPrijava();
                this.Close();
            }
            else
            {
                // Provjera neuspjesna
                MessageBox.Show("Unijeli ste pogrešno korisničko ime ili lozinku!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka.Text = txtKorIme.Text = "";
                txtKorIme.Focus();
            }
        }

        private Boolean ProvjeriKorisnika(string kIme, string lozinka)
        {
            Boolean logiran = false;

            // Proba
            if (kIme == "ž" && lozinka == "ž")
            {
                logiran = true;
            }

            return logiran;
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            // Izlaz iz aplikacije
            frmLogIn_FormClosing(sender, null);
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logiranKorisnik)
            {
                Application.Exit();
            }

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            logiranKorisnik = false;


            // Proba
            txtKorIme.Text = "ž";
            txtLozinka.Text = "ž";

        }
    }
}
