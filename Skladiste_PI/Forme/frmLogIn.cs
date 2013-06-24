using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baza;

namespace Skladiste_PI
{
    public enum TipLogin { NijeLogiran = 0, Korisnik = 1, Admin = 2 }
    public partial class frmLogIn : Form
    {
        private TipLogin logiranKorisnik = TipLogin.NijeLogiran;
        private bool ucitaniPodaci = false;
        private frmGlavna mainForm = null;
        List<Administrator> listaAdm;


        public frmLogIn(frmGlavna callingForm)
        {
            mainForm = callingForm as frmGlavna;
            InitializeComponent();
        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                // Čekamo 2. dretvu da učita podatke u listu
                while (!ucitaniPodaci) { }
                // Prolaz kroz listu i provjera autorizacije
                foreach (Administrator adm in listaAdm)
                {
                    if (adm.KorisnickoIme == txtKorIme.Text && Administrator.Provjeri(txtLozinka.Text, adm.Lozinka))
                    {
                        if (adm.Admin) logiranKorisnik = TipLogin.Admin; // Provjera uspjesna - logiran admin
                        else logiranKorisnik = TipLogin.Korisnik; // Provjera uspjesna - logiran korisnik

                        Zaposlenik zap = Zaposlenik.DohvatiZaposlenikaPremaID(adm.idZaposlenika.ToString());

                        this.mainForm.PostaviStatusTekst((logiranKorisnik == TipLogin.Korisnik ? "Korisnik: " : "Administrator: ") + zap.ToString() + ", prijavljen " + DateTime.Now.ToString(), logiranKorisnik);
                        break;
                    }
                }
            }
            catch (Exception)
            {
                // trow;
            }
            txtLozinka.Text = txtKorIme.Text = "";
            txtKorIme.Focus();

            if (logiranKorisnik == TipLogin.NijeLogiran) MessageBox.Show("Unijeli ste pogrešno korisničko ime ili lozinku!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else this.Close();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logiranKorisnik == TipLogin.NijeLogiran) Application.Exit();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            bwPodaciLoad.RunWorkerAsync();

            logiranKorisnik = TipLogin.NijeLogiran;
            this.mainForm.PostaviStatusTekst("Inicijalizacija...", logiranKorisnik);

        }

        private void bwPodaciLoad_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (!ucitaniPodaci) listaAdm = Administrator.DohvatiAdministratore();
            }
            catch (Exception)
            {
               // throw;
            }
        }

        private void bwPodaciLoad_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ucitaniPodaci = true;
        }

    }
}
