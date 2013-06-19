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

        public frmUnosZaposlenika()
        {
            InitializeComponent();
            dohvatiPodatke();
            dgvPodaci.Columns["idZaposlenika"].Visible = false;
            dgvPodaci.Columns["Email"].Visible = false;
            dgvPodaci.Columns["BrojTelefona"].Visible = false;
            dgvPodaci.Columns["Adresa"].Visible = false;

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
            MessageBox.Show(dgvPodaci.CurrentRow.Cells[1].Value.ToString());
            //this.Close();
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
            promjenaUnosIzmjena();

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (zaposlenik == null)
            {
                promjenaUnosIzmjena();
                oznaciPrviRed();
                return;
            }

            // Brisanje korisnika
            if (dgvPodaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati označenog zaposlenika?", "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }
                zaposlenik.Obrisi();
                dohvatiPodatke();
            }

            

                                //DataRow redak = new object() as DataRow;
                                //    redak = Dataset!!!....Tables("xy...Korisni??").Rows.Find(Koriime??)
                                //if (redak != null)
                                //        DS.Tables("xy...Korriid").Rows.Remove(redak)
                                //for (int index = 0; index < dgvPodaci.RowCount; index++)
                                //dgvPodaci.Rows.Remove(dgvPodaci.CurrentRow);
                                //dgvPodaci.Refresh();
                                //    if (int.Parse(dgvPodaci.Rows[index].Cells[0].Value.ToString()) == TrenutniID)
                                //    {
                                //        dgvPodaci.Rows.Remove(dgvPodaci.Rows[index]);
                                //        dgvPodaci.Refresh();
                                //    }
                                //    else
                                //    {
                                //        MessageBox.Show("Došlo je do greške prilikom pronalaženja reda u bazi!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //        return;
                                //    }
            //                else
            //                {
            //                    MessageBox.Show("Niste označili niti jedan red!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    return;
            //                }
            //            oznaciPrviRed();
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Došlo je do greške prilikom brisanja podataka!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        break;
            //}
        }

        private void oznaciPrviRed()
        {
            if (dgvPodaci.Rows.Count <= 0) // || u DataSetu>0----Or (DS.Tables("xy.....Kor").Rows.Count <= 0)
            {
                //btnDodaj_Click(null, null);
            }
            else
            {
                txtFilter.Text = "";
                //dgvPodaci.SelectedRows[0].Selected = true;
                //dgvPodaci_SelectionChanged(null, null);  testirat bez ovog!!!!!!!!!!!
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
        }

        private void promjenaUnosIzmjena()
        {
            btnDodaj.Enabled = panelZaposlenici.Enabled;
            if (zaposlenik == null)
            {
                btnBrisi.Text = "Odust&ani";
                return;
            }
            btnBrisi.Text = "O&briši";

        }

        private void frmUnosZaposlenika_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dosloDoPromjene())
            {
                e.Cancel = true;
                switch (MessageBox.Show("Želite li pohraniti promjene?", "Informacija...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (!spremiPromjene()) return;
                        else e.Cancel = false;
                        break;
                    case DialogResult.No:
                        e.Cancel = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Funkcija uspoređuje prethodne vrijednosti i nove vrijednosti polja kako bi dosla do zakljucka imali promjena u unosu.
        /// </summary>
        /// <returns>true ako ima promjena, false ako nema</returns>
        private bool dosloDoPromjene()
        {
            if (zaposlenik == null && (txtIme.Text != "" || txtPrezime.Text != "")) return true;
            if (txtIme.Tag != null && txtPrezime.Tag != null && txtEmail.Tag != null && txtBrojTelefona.Tag != null && txtAdresa.Tag != null)
            {
                if (!String.Equals(txtIme.Text.ToString(), txtIme.Tag.ToString())) return true;
                if (!String.Equals(txtPrezime.Text.ToString(), txtPrezime.Tag.ToString())) return true;
                if (!String.Equals(txtEmail.Text.ToString(), txtEmail.Tag.ToString())) return true;
                if (!String.Equals(txtBrojTelefona.Text.ToString(), txtBrojTelefona.Tag.ToString())) return true;
                if (!String.Equals(txtAdresa.Text.ToString(), txtAdresa.Tag.ToString())) return true;
            }
            return false;
        }

        /// <summary>
        /// Provjera unosa u polja
        /// </summary>
        /// <returns>True ako je unos ispravan, false ako nije.</returns>
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
            // Provjera ispravnog unosa podataka
            if (!provjeriUnos()) return false;

            // Nema promjene nema spremanja!
            if (!dosloDoPromjene())
            {
                if (samoUnosIzmjena) this.Close();
                return false;
            }


            // Spremanje u bazu, ažuriranje DataGrida
            if (zaposlenik == null)
            {
                zaposlenik = new Zaposlenik();
                //dgvPodaci.Rows.Add(45, txtIme.Text + " " + txtPrezime.Text);
            }
            //else dgvPodaci.CurrentRow.Cells[1].Value = txtIme.Text + " " + txtPrezime.Text;
            dgvPodaci.Refresh();

            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime = txtPrezime.Text;
            zaposlenik.Email = txtEmail.Text;
            zaposlenik.BrojTelefona = txtBrojTelefona.Text;
            zaposlenik.Adresa = txtAdresa.Text;

            zaposlenik.Spremi();

            // Promjena u formi
            txtIme.Tag = txtIme.Text;
            txtPrezime.Tag = txtPrezime.Text;
            txtEmail.Tag = txtEmail.Text;
            txtBrojTelefona.Tag = txtBrojTelefona.Text;
            txtAdresa.Tag = txtAdresa.Text;

            // Spremanje u bazu, ažuriranje DataGrida
            if (zaposlenik == null)
            {
                dgvPodaci.Rows.Add(45,txtIme.Text + " " + txtPrezime.Text);
                dgvPodaci.Refresh();
            }
            else
            {
                // DataRow redak;??? 
                //redak = Dataset.!!!.Tables("xy....Korisnici").Rows.Find(....??txtKorIme.Text)
                //if (redak !=null) {
                //    redak("korisnicko_ime") = txtKorIme.Text
              //  dgvPodaci.CurrentRow.Cells[1].Value = txtKorIme.Text;
                ///}
                //else
                //  MessageBox.Show("Došlo je do greške prilikom pronalaženja reda u bazi!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

            return true;
        }

        /// <summary>
        /// Dohvaća podatke iz baze o pojedinom korisniku.
        /// </summary>
        private void dohvatiZaposlenika()
        {
            if (zaposlenik != null)
            {
                this.Text = "Izmjena zaposlenika: " + zaposlenik.Ime + " " + zaposlenik.Prezime;
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
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            dgvPodaci.DataSource = listaZaposlenika;
            oznaciPrviRed();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.TextLength > 0)
                foreach (DataGridViewRow red in dgvPodaci.Rows)
                    if (red.Cells["Ime"].Value.ToString().StartsWith(txtFilter.Text, StringComparison.CurrentCultureIgnoreCase))
                        red.Visible = true;
                    else red.Visible = false;
            else
                foreach (DataGridViewRow red in dgvPodaci.Rows) red.Visible = true;
        }

        private void dgvPodaci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPodaci.Rows.Count > 0 && dgvPodaci.DisplayedRowCount(false) > 0)
            {
                zaposlenik = dgvPodaci.SelectedRows[0].DataBoundItem as Zaposlenik;
                dohvatiZaposlenika();
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
            promjenaUnosIzmjena();
        }



    }
}
