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
    public partial class frmUnosArtikla : Form
    {
        private Artikli artikl = null;
        private bool novi = false;
        private bool ZaustaviDretvu = false;

        public frmUnosArtikla()
        {
            InitializeComponent();
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
            artikl = null;
            brisiPolja();
            this.Text = "Unos novog artikla";
            novi = true;
            promjenaUnosIzmjena();

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (artikl == null && novi)
            {
                novi = false;
                promjenaUnosIzmjena();
                dgvPodaci_SelectionChanged(null,null);
                return;
            }

            // Brisanje artikla
            if (dgvPodaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati označeni artikl?", "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }
                btnObrisi_Click(null,null);
                artikl.Obrisi();
                dgvPodaci.Rows[0].Selected = true;
                txtFilter.Text = "";
                dohvatiPodatke();
            }
        }

        /// <summary>
        /// Postavlja pojedine kontrole (ne)dostupne prilikom unosa/izmjene
        /// </summary>
        private void promjenaUnosIzmjena()
        {
            btnDodaj.Enabled = panelArtikli.Enabled = !novi;
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
                if ((novi) && artikl == null && (txtIme.Text != "" || txtAlarm.Text != "" || txtCijena.Text != "")) return true;
                if (!novi && txtIme.Tag != null && txtAlarm.Tag != null && txtCijena.Tag != null)
                {
                    if (!String.Equals(txtIme.Text.ToString(), txtIme.Tag.ToString())) return true;
                    if (!String.Equals(txtAlarm.Text.ToString(), txtAlarm.Tag.ToString())) return true;
                    if (!String.Equals(txtCijena.Text.ToString(), txtCijena.Tag.ToString())) return true;
                    if (!String.Equals(cbKategorija.SelectedValue.ToString(), cbKategorija.Tag.ToString())) return true;
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
                MessageBox.Show("Unesite naziv artikla!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIme.Focus();
                return false;
            }
            if (txtAlarm.Text == "")
            {
                MessageBox.Show("Unesite alarmnu količinu artikla!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlarm.Focus();
                return false;
            }
            if (txtCijena.Text == "")
            {
                MessageBox.Show("Unesite cijenu prodaje artikla!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlarm.Focus();
                return false;
            }

            Provjera provjera = new Provjera();
            try
            {
                if (!provjera.provjeriNaziv(txtIme.Text)) return false;
                if (!provjera.provjeriCijenu(int.Parse(txtCijena.Text))) return false;
                if (!provjera.provjeriAlarmKol(int.Parse(txtAlarm.Text))) return false;
                if (!provjera.provjeriKat(int.Parse(cbKategorija.SelectedValue.ToString()))) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Provjerite unos!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!dosloDoPromjene()) return false;

                // Spremanje u bazu, ažuriranje DataGrida
                if (artikl == null) artikl = new Artikli();

                txtIme.Tag = artikl.Naziv = txtIme.Text;
                txtAlarm.Tag = artikl.AlarmnaKolicina = int.Parse(txtAlarm.Text);
                txtCijena.Tag = artikl.CijenaProdaje = int.Parse(txtCijena.Text);
                cbKategorija.Tag = artikl.idKategorijeArtikla = int.Parse(cbKategorija.SelectedValue.ToString());


                artikl.Spremi();

                // Ažuriranje DataGrida
                if (novi) dohvatiPodatke();
                else dgvPodaci.SelectedRows[0].Cells["colImePrezime"].Value = artikl.ToString();
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
        /// Dohvaća podatke iz baze o pojedinom artiklu i puni textBoxe
        /// </summary>
        private void dohvatiArtiklia()
        {
            if (artikl != null)
            {
                this.Text = "Izmjena artikla: " + artikl.ToString();
                txtIme.Tag = txtIme.Text = artikl.Naziv;
                txtAlarm.Tag = txtAlarm.Text = artikl.AlarmnaKolicina.ToString();
                txtCijena.Tag = txtCijena.Text = artikl.CijenaProdaje.ToString();
                cbKategorija.Tag = cbKategorija.SelectedValue = artikl.idKategorijeArtikla;
            }
        }

        /// <summary>
        /// Dohvaća podatke iz baze i puni DataGrid
        /// </summary>
        private void dohvatiPodatke()
        {
            List<KategorijaArtikla> listaArtikla = KategorijaArtikla.DohvatiKategorijuArtikla();
            cbKategorija.DataSource = listaArtikla;
            cbKategorija.DisplayMember = "NazivKategorije";
            cbKategorija.ValueMember = "idKategorijeArtikla";

            dgvPodaci.Rows.Clear();
            List<Artikli> lA = Artikli.DohvatiSveArtikle();
            foreach(Artikli a in lA){
                dgvPodaci.Rows.Add(a.idArtikla,a.ToString());
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
                    artikl = Artikli.DohvatiArtiklePremaID(dgvPodaci.SelectedRows[0].Cells["id"].Value.ToString());
                    dohvatiArtiklia();
                }
            }
            catch (Exception)
            {
                //
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
            txtIme.Text = txtAlarm.Text = txtCijena.Text = "";
            cbKategorija.Focus();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Unos podataka
            if (artikl == null)
            {
                brisiPolja();
                return;
            }
            // Izmjena podataka
            try
            {
                txtIme.Text = txtIme.Tag.ToString();
                txtAlarm.Text = txtAlarm.Tag.ToString();
                txtCijena.Text = txtCijena.Tag.ToString();
                cbKategorija.SelectedValue = artikl.idKategorijeArtikla;
            }
            catch
            {
                brisiPolja();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (!spremiPromjene()) return;
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

        private void frmUnosArtikla_Leave(object sender, EventArgs e)
        {
            ZaustaviDretvuProvjeraUnosa();
        }

        private void frmUnosArtikla_Activated(object sender, EventArgs e)
        {
            ZaustaviDretvu = false;
            if (dosloDoPromjene()) bwPromjenaUnosa.RunWorkerAsync(1);
            else PokreniDretvuProvjeraUnosa();
        }

        private void frmUnosArtikla_Load(object sender, EventArgs e)
        {
            dohvatiPodatke();
        }

        private void frmUnosArtikla_FormClosing(object sender, FormClosingEventArgs e)
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
