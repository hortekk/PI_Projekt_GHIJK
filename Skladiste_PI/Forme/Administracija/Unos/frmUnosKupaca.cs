﻿using System;
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
    public partial class frmUnosKupaca : Form
    {
        private PoslovniPartner kupac = null;
        private bool samoUnosIzmjena = false;
        private bool novi = false;
        private bool ZaustaviDretvu = false;
        

        public frmUnosKupaca()
        {
            InitializeComponent();
        }

        public frmUnosKupaca(PoslovniPartner odabraniKupac)
        {
            InitializeComponent();
            kupac = odabraniKupac;
            samoUnosIzmjena = true;
            postaviSamoUnos();
            dohvatiKupca();
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
            kupac = null;
            brisiPolja();
            this.Text = "Unos novog kupca";
            novi = true;
            promjenaUnosIzmjena();

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (kupac == null && novi)
            {
                novi = false;
                promjenaUnosIzmjena();
                dgvPodaci_SelectionChanged(null,null);
                return;
            }

            // Brisanje kupca
            if (dgvPodaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati označenog kupca?", "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }
                btnObrisi_Click(null,null);
                kupac.Obrisi();
                dgvPodaci.Rows[0].Selected = true;
                txtFilter.Text = "";
                dohvatiPodatke();
            }
        }

        /// <summary>
        /// Oblikuje formu za unos/izmjenu odabranog kupca (iz pregleda)
        /// </summary>
        private void postaviSamoUnos()
        {
            panelKupci.Visible = btnBrisi.Visible = btnDodaj.Visible = false;
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
            btnDodaj.Enabled = panelKupci.Enabled = !novi;
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
                if ((novi || samoUnosIzmjena) && kupac == null && (txtIme.Text != "" || txtPrezime.Text != "")) return true;
                if (!novi && txtIme.Tag != null && txtPrezime.Tag != null && txtKontakt.Tag != null && txtAdresa.Tag != null)
                {
                    if (!String.Equals(txtIme.Text.ToString(), txtIme.Tag.ToString())) return true;
                    if (!String.Equals(txtPrezime.Text.ToString(), txtPrezime.Tag.ToString())) return true;
                    if (!String.Equals(txtKontakt.Text.ToString(), txtKontakt.Tag.ToString())) return true;
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
                MessageBox.Show("Unesite ime/naziv kupca!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIme.Focus();
                return false;
            }
            if (txtPrezime.Text == "")
            {
                MessageBox.Show("Unesite prezime/vrstu kupca!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (kupac == null) kupac = new PoslovniPartner();

                txtIme.Tag = kupac.ImeNaziv = txtIme.Text;
                txtPrezime.Tag = kupac.PrezimeVrsta = txtPrezime.Text;
                txtKontakt.Tag = kupac.Kontakt = txtKontakt.Text;
                txtAdresa.Tag = kupac.Adresa = txtAdresa.Text;
                kupac.TipPP = (int)TipoviPP.Kupac;

                kupac.Spremi();

                // Ažuriranje DataGrida
                if (novi) dohvatiPodatke();
                else if (!samoUnosIzmjena) dgvPodaci.SelectedRows[0].Cells["colImePrezime"].Value = kupac.ToString();
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
        /// Dohvaća podatke iz baze o pojedinom kupcu i puni textBoxe
        /// </summary>
        private void dohvatiKupca()
        {
            if (kupac != null)
            {
                this.Text = "Izmjena kupca: " + kupac.ToString();
                txtIme.Tag = txtIme.Text = kupac.ImeNaziv;
                txtPrezime.Tag = txtPrezime.Text = kupac.PrezimeVrsta;
                txtKontakt.Tag = txtKontakt.Text = kupac.Kontakt;
                txtAdresa.Tag = txtAdresa.Text = kupac.Adresa;
            }
        }

        /// <summary>
        /// Dohvaća podatke iz baze i puni DataGrid
        /// </summary>
        private void dohvatiPodatke()
        {
            dgvPodaci.Rows.Clear();
            List<PoslovniPartner> listaKupaca = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Kupac);
            foreach (PoslovniPartner k in listaKupaca)
            {
                dgvPodaci.Rows.Add(k.idPP,k.ToString());
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
                    kupac = PoslovniPartner.DohvatiPoslovnogPartneraPremaID(dgvPodaci.SelectedRows[0].Cells["id"].Value.ToString(),TipoviPP.Kupac);
                    dohvatiKupca();
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
            txtIme.Text = txtPrezime.Text = txtKontakt.Text = txtAdresa.Text = "";
            txtIme.Focus();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Unos podataka
            if (kupac == null)
            {
                brisiPolja();
                return;
            }
            // Izmjena podataka
            try
            {
                txtIme.Text = txtIme.Tag.ToString();
                txtPrezime.Text = txtPrezime.Tag.ToString();
                txtKontakt.Text = txtKontakt.Tag.ToString();
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

        private void frmUnosKupaca_Leave(object sender, EventArgs e)
        {
            ZaustaviDretvuProvjeraUnosa();
        }

        private void frmUnosKupaca_Activated(object sender, EventArgs e)
        {
            ZaustaviDretvu = false;
            if (dosloDoPromjene()) bwPromjenaUnosa.RunWorkerAsync(1);
            else PokreniDretvuProvjeraUnosa();
        }

        private void frmUnosKupaca_Load(object sender, EventArgs e)
        {
            if (!samoUnosIzmjena) dohvatiPodatke();
        }

        private void frmUnosKupaca_FormClosing(object sender, FormClosingEventArgs e)
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
