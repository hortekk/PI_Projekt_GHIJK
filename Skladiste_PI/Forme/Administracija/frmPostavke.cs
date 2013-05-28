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
    public partial class frmPostavke : Form
    {
        private bool noviKorisnik = false;

        public frmPostavke()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Funkcija uspoređuje prethodne vrijednosti i nove vrijednosti polja kako bi dosla do zakljucka imali promjena u unosu.
        /// </summary>
        /// <returns>true ako ima promjena, false ako nema.</returns>
        private bool dosloDoPromjene()
        {
            if (noviKorisnik) return true;
            if (txtKorIme.Tag != null && txtLozinka.Tag != null)
            {
                if (!String.Equals(txtKorIme.Text.ToString(), txtKorIme.Tag.ToString())) return true;
                if (!String.Equals(txtLozinka.Text.ToString(), txtLozinka.Tag.ToString())) return true;
            }
            // dodat za admina
            return false;
        }

        /// <summary>
        /// Provjera unosa u polja.
        /// </summary>
        /// <returns>True ako je unos ispravan, false ako nije.</returns>
        private bool provjeriUnos()
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKorIme.Focus();
                return false;
            }
            // Provjeri jel postoji korisnicko ime u DataGridu - bazi
            for (int index = 0; index < dgvPodaci.RowCount; index++)
                if (String.Equals(dgvPodaci.Rows[index].Cells[0].Value.ToString(), txtKorIme.Text.ToString()) && index != dgvPodaci.CurrentRow.Index)
                {
                    MessageBox.Show("Uneseno korisničko ime već postoji u bazi!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKorIme.Text = "";
                    txtKorIme.Focus();
                    return false;
                }
            if (txtLozinka.Text == "")
            {
                MessageBox.Show("Unesite lozinku!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLozinka.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Spremanje promjena u bazu podataka.
        /// </summary>
        private bool spremiPromjene()
        {
            // Provjera ispravnog unosa podataka
            if (!provjeriUnos()) return false;

            if (cbAdmin.Checked == true && lblStatus.Text != "Autoriziran" && !provjeriAdmina()) return false;
            
            // Nema promjene nema spremanja!
            if (!dosloDoPromjene()) return false;

            // Promjena u formi
            txtLozinka.Tag = txtLozinka.Text;
            txtKorIme.Tag = txtKorIme.Text;
            cbAdmin.Tag = cbAdmin.Checked.ToString();

            // Spremanje u bazu, ažuriranje DataGrida
            if (noviKorisnik)
            {
                //Dataset!!!.Rows.Add(def..., txtKorIme.Text)
                dgvPodaci.Rows.Add(txtKorIme.Text);
                dgvPodaci.Refresh();
            }
            else
            {
                // DataRow redak;??? 
                //redak = Dataset.!!!.Tables("xy....Korisnici").Rows.Find(....??txtKorIme.Text)
            //if (redak !=null) {
                //    redak("korisnicko_ime") = txtKorIme.Text
                dgvPodaci.CurrentRow.Cells[0].Value = txtKorIme.Text;
                ///}
            //else
             //  MessageBox.Show("Došlo je do greške prilikom pronalaženja reda u bazi!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

            return true;
        }

        /// <summary>
        /// Dohvaća podatke iz baze o pojedinom korisniku.
        /// </summary>
        private void dohvatiKorisnika()
        {

            // dohvati podatke iz baze prema korisničkom imenu i popunis textbox-ove

        }
       
        /// <summary>
        /// Dohvaća podatke iz baze.
        /// </summary>
        private void dohvatiPodatke()
        {

            // popuni DataGrid s podacima

            
            oznaciPrviRed();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.TextLength>0)
                for (int index=0;index<dgvPodaci.RowCount;index++){
                    if (dgvPodaci.Rows[index].Cells[0].Value.ToString().ToLower().StartsWith(txtFilter.Text.ToLower()))
                        dgvPodaci.Rows[index].Visible = true;
                    else
                        dgvPodaci.Rows[index].Visible = false;
                }
            else 
                for (int index=0;index<dgvPodaci.RowCount;index++)
                    dgvPodaci.Rows[index].Visible = true;
        }

        private void frmPostavke_Load(object sender, EventArgs e)
        {
            dohvatiPodatke();

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (!spremiPromjene()) return;
            noviKorisnik = false;
            promjenaUnosIzmjena();
        }

        private void dgvPodaci_SelectionChanged(object sender, EventArgs e)
        {
            if (!noviKorisnik && dgvPodaci.Rows.Count > 0 && dgvPodaci.DisplayedRowCount(false) > 0) dohvatiKorisnika();
        }

        private void brisiPolja()
        {
            txtAdmin.Text = txtKorIme.Text = txtLozinka.Text = "";
            cbAdmin.Checked = false;
            txtAdmin.Enabled = cbAdmin.Checked;
            txtKorIme.Focus();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            // Unos podataka
            if (noviKorisnik)
            {
                brisiPolja();
                return;
            }
            // Izmjena podataka
            try
            {
                txtKorIme.Text = txtKorIme.Tag.ToString();
                txtLozinka.Text = txtLozinka.Tag.ToString();
                cbAdmin.Checked = (cbAdmin.Tag.ToString()=="true"?true:false);
                txtAdmin.Text = (cbAdmin.Tag.ToString() == "true" ? "##########" : "");
                txtAdmin.Enabled = cbAdmin.Checked;
            }
            catch
            {
                brisiPolja();
            }
        }

        private void frmPostavke_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dosloDoPromjene())
            {
                e.Cancel = true;
                switch (MessageBox.Show("Želite li pohraniti promjene?", "Informacija...", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (!spremiPromjene()) return;
                        break;
                    case DialogResult.No:
                        e.Cancel=false;
                        break;
                }
            }
        }

        private void cbAadmin_CheckedChanged(object sender, EventArgs e)
        {
            btnProvjeriAdmina.Enabled = txtAdmin.Enabled = cbAdmin.Checked;
            if (cbAdmin.Checked == true) txtAdmin.Focus();
                else if (txtKorIme.Text == "") txtKorIme.Focus();
                    else if (txtLozinka.Text == "") txtLozinka.Focus();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (noviKorisnik)
            {
                noviKorisnik = false;
                promjenaUnosIzmjena();
                oznaciPrviRed();
                return;
            }

            // Brisanje korisnika
            switch (MessageBox.Show("Jeste li sigurni da želite obrisati označenog korisnika?", "Informacija...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        if (dgvPodaci.Rows.Count > 0)
                            if(dgvPodaci.DisplayedRowCount(false) > 0)
                            {
                                //DataRow redak = new object() as DataRow;
                                //    redak = Dataset!!!....Tables("xy...Korisni??").Rows.Find(Koriime??)
                                //if (redak != null)
                                    //        DS.Tables("xy...Korriid").Rows.Remove(redak)
                                    //for (int index = 0; index < dgvPodaci.RowCount; index++)
                                        dgvPodaci.Rows.Remove(dgvPodaci.CurrentRow);
                                        dgvPodaci.Refresh();
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
                            }
                            else
                            {
                                MessageBox.Show("Niste označili niti jedan red!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        oznaciPrviRed();
                    }
                    catch
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja podataka!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void oznaciPrviRed()
        {
            if (dgvPodaci.Rows.Count <= 0) // || u DataSetu>0----Or (DS.Tables("xy.....Kor").Rows.Count <= 0)
            {
                btnDodaj_Click(null,null);
            }
            else
            {
                txtFilter.Text = "";
                dgvPodaci.SelectedRows[0].Selected = true;
                //dgvPodaci_SelectionChanged(null, null);  testirat bez ovog!!!!!!!!!!!
            }
        }

        private void promjenaUnosIzmjena()
        {
            btnDodaj.Enabled = panelKorRacuni.Enabled = !noviKorisnik;
            if (noviKorisnik)
            {
                postaviAutorizaciju(false);
                btnBrisi.Text = "Odust&ani";
                return;
            }
            btnBrisi.Text = "O&briši";

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

            noviKorisnik = true;
            brisiPolja();
            promjenaUnosIzmjena();

        }

        private void postaviAutorizaciju(bool provjeren)
        {
            switch (provjeren)
            {
                case true:
                    cbAdmin.Tag = "true";
                    txtAdmin.Tag = txtAdmin.Text;
                    lblStatus.Location = new System.Drawing.Point(140, 92);
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    lblStatus.Text = "Autoriziran";
                    break;
                case false:
                    cbAdmin.Tag = "false";
                    txtAdmin.Tag = "";
                    lblStatus.Location = new System.Drawing.Point(135, 92);
                    lblStatus.ForeColor = System.Drawing.Color.DarkRed;
                    lblStatus.Text = "Ne autoriziran";
                    break;
            }
        }

        private bool provjeriAdmina()
        {
            // Autoriziran korisnik od prije
            if((cbAdmin.Tag.ToString()=="true"?true:false) && txtAdmin.Text=="##########") return false;

            // Provjera lozinke u bazi

            //!!!!!!!!!!!! petlja
            // prooba
            if (txtAdmin.Text == "foi")
            {
                postaviAutorizaciju(true);
                return true;
            }


            // Pogrešan unos
            switch (MessageBox.Show("Pogrešna lozinka u polju administratora, želite li ponoviti unos?", "Greška...", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
            {
                case DialogResult.Yes:
                    txtAdmin.Text = "";
                    txtAdmin.Focus();
                    break;
                case DialogResult.No:
                    pocistiPoljeAdmin();
                    break;
            }

            return false;
        }

        private void pocistiPoljeAdmin()
        {
            cbAdmin.Checked = false;
            txtAdmin.Text = "";
            //try
            //{
            //    if (cbAdmin.Tag.ToString() == "true")
            //    {
            //        cbAdmin.Checked = true;
            //        txtAdmin.Text = "##########";
            //        postaviAutorizaciju(true);
            //    }
            //}
            //catch
            //{
            //}
        }

        private void txtAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    btnProvjeriAdmin_Click(null,null);
                    break;
                case (char)Keys.Escape:
                    if (lblStatus.Text != "Autoriziran") 
                        pocistiPoljeAdmin();
                    break;
            }
        }

        private void btnProvjeriAdmin_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Autoriziran")
                MessageBox.Show("Autorizacija već provedena!", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else provjeriAdmina();
        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Autoriziran") postaviAutorizaciju(false);
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            // Ispis DataGrida (svih ili pojedinih korisnika korisnika)
        }




    }
}
