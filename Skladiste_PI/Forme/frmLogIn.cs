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
        private byte logiranKorisnik = 0;
        private frmGlavna mainForm = null;


        public frmLogIn(frmGlavna callingForm)
        {
            mainForm = callingForm as frmGlavna; 
            InitializeComponent();

        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {

            logiranKorisnik = ProvjeriKorisnika(txtKorIme.Text, txtLozinka.Text);

            if (logiranKorisnik==1){
                // Provjera uspjesna - logiran korisnik
                this.mainForm.PostaviStatusTekst("Korisnik: " + txtKorIme.Text + ", prijavljen " + DateTime.Now.ToString(), 1);
                this.Close();
            }
            else if (logiranKorisnik==2)
            {
                // Provjera uspjesna - logiran admin
                this.mainForm.PostaviStatusTekst("Administrator: " + txtKorIme.Text + ", prijavljen " + DateTime.Now.ToString(), 2);
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

        /// <summary>
        /// Provjera unesenih podataka za logiranje.
        /// </summary>
        /// <param name="kIme">Korisnicko ime</param>
        /// <param name="lozinka">Lozinka</param>
        /// <returns>0-nije logiran,1-logiran korisnik,2-logiran admin</returns>
        private byte ProvjeriKorisnika(string kIme, string lozinka)
        {
            byte logiran = 0;


            // Dohvati podatke
            
            // Proba
            if (lozinka == "ž")  //kIme == "ž" && 
            {
                logiran = 1;
            }
            else if (lozinka == "admin")
            {
                logiran = 2;
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
            if (logiranKorisnik == 0)
            {
                Application.Exit();
            }

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            logiranKorisnik = 0;
            this.mainForm.PostaviStatusTekst("Inicijalizacija...",0);


            // Proba
            txtKorIme.Text = "ž";
            txtLozinka.Text = "admin";

        }
    }
}
