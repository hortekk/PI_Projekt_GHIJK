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

namespace Skladiste_PI
{
    public partial class frmUnosZaposlenika : Form
    {
        private Zaposlenik zaposlenik = null;
        private bool samoUnosIzmjena = false;
        private bool novi = false;
        private bool ZaustaviDretvu = false;

        public frmUnosZaposlenika()
        {
            InitializeComponent();
        }

        public frmUnosZaposlenika(Zaposlenik odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = odabraniZaposlenik;
            samoUnosIzmjena = true;
            postaviSamoUnos();
            dohvatiZaposlenika();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (dosloDoPromjene())
            {
                switch (MessageBox.Show("Želite li pohraniti promjene?", "Informacija...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (!spremiPromjene()) return;
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            zaposlenik = null;
            brisiPolja();
            this.Text = "Unos novog zaposlenika";
            novi = true;
            promjenaUnosIzmjena();

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (zaposlenik == null && novi)
            {
                novi = false;
                promjenaUnosIzmjena();
                dgvPodaci_SelectionChanged(null,null);
                return;
            }

            // Brisanje zaposlenika
            if (dgvPodaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati označenog zaposlenika?", "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }
                btnObrisi_Click(null,null);
                zaposlenik.Obrisi();
                dgvPodaci.Rows[0].Selected = true;
                txtFilter.Text = "";
                dohvatiPodatke();
            }
        }

        /// <summary>
        /// Oblikuje formu za unos/izmjenu odabranog zaposlenika (iz pregleda)
        /// </summary>
        private void postaviSamoUnos()
        {
            panelZaposlenici.Visible = btnBrisi.Visible = btnDodaj.Visible = false;
            this.panelUnos.Location = new System.Drawing.Point(20, 20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = this.MinimizeBox = false;
            this.MinimumSize = this.ClientSize = new System.Drawing.Size(360, 305);
            panelUnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
        }

        /// <summary>
        /// Postavlja pojedine kontrole (ne)dostupne prilikom unosa/izmjene
        /// </summary>
        private void promjenaUnosIzmjena()
        {
            btnDodaj.Enabled = panelZaposlenici.Enabled = !novi;
            if (dgvPodaci.RowCount <= 0) btnBrisi.Enabled = false;
            else btnBrisi.Enabled = true;

            if (novi)
            {
                btnBrisi.Text = "Odust&ani";
                return;
            }
            btnBrisi.Text = "O&briši";

        }

        /// <summary>
        /// Funkcija uspoređuje prethodne vrijednosti i nove vrijednosti polja kako bi dosla do zakljucka imali promjena u unosu
        /// </summary>
        /// <returns>True ako ima promjena, False ako nema</returns>
        private bool dosloDoPromjene()
        {
            try
            {
                if ((novi || samoUnosIzmjena) && zaposlenik == null && (txtIme.Text != "" || txtPrezime.Text != "")) return true;
                if (!novi && txtIme.Tag != null && txtPrezime.Tag != null && txtEmail.Tag != null && txtBrojTelefona.Tag != null && txtAdresa.Tag != null)
                {
                    if (!String.Equals(txtIme.Text.ToString(), txtIme.Tag.ToString())) return true;
                    if (!String.Equals(txtPrezime.Text.ToString(), txtPrezime.Tag.ToString())) return true;
                    if (!String.Equals(txtEmail.Text.ToString(), txtEmail.Tag.ToString())) return true;
                    if (!String.Equals(txtBrojTelefona.Text.ToString(), txtBrojTelefona.Tag.ToString())) return true;
                    if (!String.Equals(txtAdresa.Text.ToString(), txtAdresa.Tag.ToString())) return true;
                }
            }
            catch (Exception)
            {
                //throw;
            }
            return false;
        }

        /// <summary>
        /// Provjera unosa u polja
        /// </summary>
        /// <returns>True ako je unos ispravan, False ako nije</returns>
        private bool provjeriUnos()
        {
            if (txtIme.Text == "")
            {
                MessageBox.Show("Unesite ime zaposlenika!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIme.Focus();
                return false;
            }
            if (txtPrezime.Text == "")
            {
                MessageBox.Show("Unesite prezime zaposlenika!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrezime.Focus();
                return false;
            }
            return true;
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

                // Nema promjene -> nema spremanja!
                if (!dosloDoPromjene())
                    if (samoUnosIzmjena) this.Close();
                    else return false;

                // Spremanje u bazu, ažuriranje DataGrida
                if (zaposlenik == null) zaposlenik = new Zaposlenik();

                txtIme.Tag = zaposlenik.Ime = txtIme.Text;
                txtPrezime.Tag = zaposlenik.Prezime = txtPrezime.Text;
                txtEmail.Tag = zaposlenik.Email = txtEmail.Text;
                txtBrojTelefona.Tag = zaposlenik.BrojTelefona = txtBrojTelefona.Text;
                txtAdresa.Tag = zaposlenik.Adresa = txtAdresa.Text;

                zaposlenik.Spremi();

                // Ažuriranje DataGrida
                if (novi) dohvatiPodatke();
                else if (!samoUnosIzmjena) dgvPodaci.SelectedRows[0].Cells["colImePrezime"].Value = zaposlenik.ToString();
                dgvPodaci.Refresh();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Greška pri spremanju!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Dohvaća podatke iz baze o pojedinom zaposleniku i puni textBoxe
        /// </summary>
        private void dohvatiZaposlenika()
        {
            if (zaposlenik != null)
            {
                this.Text = "Izmjena zaposlenika: " + zaposlenik.ToString();
                txtIme.Tag = txtIme.Text = zaposlenik.Ime;
                txtPrezime.Tag = txtPrezime.Text = zaposlenik.Prezime;
                txtEmail.Tag = txtEmail.Text = zaposlenik.Email;
                txtBrojTelefona.Tag = txtBrojTelefona.Text = zaposlenik.BrojTelefona;
                txtAdresa.Tag = txtAdresa.Text = zaposlenik.Adresa;
            }
        }

        /// <summary>
        /// Dohvaća podatke iz baze i puni DataGrid
        /// </summary>
        private void dohvatiPodatke()
        {
            dgvPodaci.Rows.Clear();
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            foreach(Zaposlenik z in listaZaposlenika){
                dgvPodaci.Rows.Add(z.idZaposlenika,z.ToString());
            }
            if (dgvPodaci.RowCount<=0) btnDodaj_Click(null,null);
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
                    zaposlenik = Zaposlenik.DohvatiZaposlenikaPremaID(dgvPodaci.SelectedRows[0].Cells["id"].Value.ToString());
                    dohvatiZaposlenika();
                }
            }
            catch (Exception)
            {
               // throw;
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

        /// <summary>
        /// Brise sve unose iz polja
        /// </summary>
        private void brisiPolja()
        {
            txtIme.Text = txtPrezime.Text = txtEmail.Text = txtBrojTelefona.Text = txtAdresa.Text = "";
            txtIme.Focus();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Unos podataka
            if (zaposlenik == null)
            {
                brisiPolja();
                return;
            }
            // Izmjena podataka
            try
            {
                txtIme.Text = txtIme.Tag.ToString();
                txtPrezime.Text = txtPrezime.Tag.ToString();
                txtEmail.Text = txtEmail.Tag.ToString();
                txtBrojTelefona.Text = txtBrojTelefona.Tag.ToString();
                txtAdresa.Text = txtAdresa.Tag.ToString();
            }
            catch
            {
                brisiPolja();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (!spremiPromjene()) return;
            if (samoUnosIzmjena) this.Close();
            novi = false;
            txtFilter.Text = "";
            promjenaUnosIzmjena();
        }

        /// <summary>
        /// Pokreće dretvu za provjeru unosa
        /// </summary>
        private void PokreniDretvuProvjeraUnosa()
        {
            btnObrisi.Enabled = false;
            bwPromjenaUnosa.RunWorkerAsync(0);
        }

        /// <summary>
        /// Zaustavlja dretvu za provjeru unosa
        /// </summary>
        private void ZaustaviDretvuProvjeraUnosa()
        {
            ZaustaviDretvu = true;
        }

        private void bwPromjenaUnosa_DoWork(object sender, DoWorkEventArgs e)
        {
            int tip = int.Parse(e.Argument.ToString());
            if (tip == 1)
                while (!ZaustaviDretvu)
                {
                    if (!dosloDoPromjene()) break;
                }
            else
                while (!ZaustaviDretvu)
                {
                    if (dosloDoPromjene()) break;
                }
        }

        private void bwPromjenaUnosa_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnObrisi.Enabled = true;
            if (!ZaustaviDretvu)
                if (dosloDoPromjene()) bwPromjenaUnosa.RunWorkerAsync(1);
                else PokreniDretvuProvjeraUnosa();
        }

        private void frmUnosZaposlenika_Leave(object sender, EventArgs e)
        {
            ZaustaviDretvuProvjeraUnosa();
        }

        private void frmUnosZaposlenika_Activated(object sender, EventArgs e)
        {
            ZaustaviDretvu = false;
            if (dosloDoPromjene()) bwPromjenaUnosa.RunWorkerAsync(1);
            else PokreniDretvuProvjeraUnosa();
        }

        private void frmUnosZaposlenika_Load(object sender, EventArgs e)
        {
            if (!samoUnosIzmjena) dohvatiPodatke();
        }

        private void frmUnosZaposlenika_FormClosing(object sender, FormClosingEventArgs e)
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
                if (!e.Cancel)
                {
                    // Triba zbog FixedSingla kod paljenja iz Pregleda; ne handla FormLeave
                    ZaustaviDretvuProvjeraUnosa();
                }
            }
            catch (Exception)
            {
                // U slučaju greške prilikom gašenja forme zaustavlja dretvu
                ZaustaviDretvuProvjeraUnosa();
            }
        }

    }
}
