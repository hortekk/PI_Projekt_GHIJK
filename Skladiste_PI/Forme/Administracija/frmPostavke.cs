using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baza;
using Funkcije;

namespace Skladiste_PI
{
    public partial class frmPostavke : Form
    {
        private Administrator korisnik = null;
        List<Administrator> listaKorisnika = Administrator.DohvatiAdministratore();

        public frmPostavke()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Funkcija uspoređuje prethodne vrijednosti i nove vrijednosti polja kako bi dosla do zakljucka imali promjena u unosu
        /// </summary>
        /// <returns>True ako ima promjena, False ako nema</returns>
        private bool dosloDoPromjene()
        {
            try
            {
                if (txtLozinka.Tag != null && txtLozinka.Text != "") return true;
                if (txtKorIme.Tag != null)
                    if (!String.Equals(txtKorIme.Text.ToString(), txtKorIme.Tag.ToString())) return true;
            }
            catch (Exception)
            {
                //throw;
            }
            return false;
        }

        private bool provjeriPostojanostKorisnika()
        {
            // Provjeri jel postoji korisnicko ime u DataGridu - bazi
            foreach (Administrator adm in listaKorisnika)
                if (String.Equals(adm.KorisnickoIme, txtKorIme.Text) && !String.Equals(adm.idZaposlenika.ToString(), dgvPodaci.SelectedRows[0].Cells["id"].Value.ToString()))
                {
                    MessageBox.Show("Uneseno korisničko ime već postoji u bazi!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKorIme.Text = "";
                    txtKorIme.Focus();
                    return false;
                }
            return true;
        }

        /// <summary>
        /// Provjera unosa u polja
        /// </summary>
        /// <returns>True ako je unos ispravan, False ako nije</returns>
        private bool provjeriUnos()
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKorIme.Focus();
                return false;
            }
            if (txtLozinka.Tag==null && txtLozinka.Text == "")
            {
                MessageBox.Show("Unesite lozinku!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka.Text = "";
                txtLozinka.Focus();
                return false;
            }
            return provjeriPostojanostKorisnika();
        }

        /// <summary>
        /// Spremanje promjena u bazu podataka
        /// </summary>
        private bool spremiPromjene()
        {
            try
            {
                // Provjera ispravnog unosa podataka
                if (!provjeriUnos()) return false;

                if (lblStatus.Text == "Netočno" || (txtLozinka.Text!="" && lblStatus.Text == ""))
                {
                    MessageBox.Show("Lozinke nisu iste, molimo ponovite unos!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLozinka2.Text = "";
                    txtLozinka2.Focus();
                    return false;
                }
                // Nema promjene -> nema spremanja!
                if (txtKorIme.Tag != null && txtLozinka.Text=="" && cbAdmin.Checked==(bool)cbAdmin.Tag)
                    if (String.Equals(txtKorIme.Text.ToString(), txtKorIme.Tag.ToString())) return true;

                // Spremanje u bazu, ažuriranje DataGrida
                if (korisnik == null)
                {
                    korisnik = new Administrator();
                }

                txtKorIme.Tag = korisnik.KorisnickoIme = txtKorIme.Text;
                cbAdmin.Tag = korisnik.Admin = cbAdmin.Checked;
                if (txtLozinka.Text != "") txtLozinka.Tag = korisnik.Lozinka = Metoda.Kodiraj(txtLozinka.Text);
                korisnik.idZaposlenika = int.Parse(dgvPodaci.SelectedRows[0].Cells["id"].Value.ToString());

                korisnik.Spremi();

                listaKorisnika = Administrator.DohvatiAdministratore();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška pri spremanju!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Dohvaća podatke iz baze o pojedinom korisniku i puni textBoxe
        /// </summary>
        private void dohvatiKorisnika()
        {
            if (korisnik != null)
            {
                txtKorIme.Tag = txtKorIme.Text = korisnik.KorisnickoIme;
                txtLozinka.Tag = korisnik.Lozinka;
                txtLozinka.Text = txtLozinka2.Text = "";
                cbAdmin.Tag = cbAdmin.Checked = korisnik.Admin;
            }
        }

        /// <summary>
        /// Dohvaća podatke iz baze i puni DataGrid
        /// </summary>
        private void dohvatiPodatke()
        {
            dgvPodaci.Rows.Clear();
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            foreach (Zaposlenik z in listaZaposlenika)
            {
                dgvPodaci.Rows.Add(z.idZaposlenika, z.ToString());
            }
            if (dgvPodaci.RowCount <= 0)
            {
                MessageBox.Show("Nema unesenih zaposlenika!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.TextLength > 0)
                foreach (DataGridViewRow red in dgvPodaci.Rows)
                    if (red.Cells["colImePrezime"].Value.ToString().StartsWith(txtFilter.Text, StringComparison.CurrentCultureIgnoreCase))
                        red.Visible = true;
                    else red.Visible = false;
            else
                foreach (DataGridViewRow red in dgvPodaci.Rows) red.Visible = true;
        }

        private void dgvPodaci_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPodaci.Rows.Count > 0 && dgvPodaci.DisplayedRowCount(false) > 0)
                {
                    korisnik = Administrator.DohvatiPremaIDZaposlenika(dgvPodaci.SelectedRows[0].Cells["id"].Value.ToString());
                    dohvatiKorisnika();
                }
            }
            catch (Exception)
            {
                korisnik = null;
                txtLozinka.Text = txtLozinka2.Text = txtKorIme.Text = "";
                cbAdmin.Tag = txtKorIme.Tag = txtLozinka.Tag = null;
                cbAdmin.Checked = false;
            }
        }

        private void dgvPodaci_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dosloDoPromjene())
                switch (MessageBox.Show("Želite li pohraniti promjene?", "Informacija...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        spremiPromjene();
                        break;
                }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (korisnik == null)
            {
                dgvPodaci_SelectionChanged(null, null);
                return;
            }

            // Brisanje korisnika
            if (dgvPodaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite ukloniti prava pristupa označenom korisniku?", "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }
                korisnik.Obrisi();
                dgvPodaci.Rows[0].Selected = true;
                txtFilter.Text = "";
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (!spremiPromjene()) return;
            korisnik = null;
            txtLozinka.Text = txtLozinka2.Text = txtFilter.Text = "";
        }

        private void promjeniStatus()
        {
            if (txtLozinka2.Text != "" && txtLozinka.Text == txtLozinka2.Text)
            {
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Točno";
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                lblStatus.Text = txtLozinka2.Text == "" ? "" : "Netočno";
            }
        }
        private void frmPostavke_Load(object sender, EventArgs e)
        {
            dohvatiPodatke();
        }

        private void frmPostavke_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (dosloDoPromjene())
                    switch (MessageBox.Show("Želite li pohraniti promjene?", "Informacija...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            if (!spremiPromjene()) e.Cancel = true;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void txtKorIme_Validating(object sender, CancelEventArgs e)
        {
            provjeriPostojanostKorisnika();
        }

        private void txtLozinka2_TextChanged(object sender, EventArgs e)
        {
            promjeniStatus();
        }



    }
}
