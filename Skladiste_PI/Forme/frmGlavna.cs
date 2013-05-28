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



    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            novoLogiranje();
        }
        /// <summary>
        /// Poziv forme za login.
        /// </summary>
        private void novoLogiranje()
        {
            mnuProzoriZatvoriSve_Click(null, null);
            frmLogIn frmLogIn =  new frmLogIn(this);
            frmLogIn.ShowDialog();
        }
        /// <summary>
        /// Funkcija dozvoljava dodatne funkcionalnosti ako se logira admin.
        /// </summary>
        /// <param name="istina">True ako je admin logiran, false ako nije.</param>
        private void logiranAdmin(bool istina)
        {
            this.mnuAdministracijaPostavke.Visible = istina;
            this.mnuAdministracijaSep1.Visible = istina;
            //....

        }

        /// <summary>
        /// Postavlja status/tekst na glavnoj formi.
        /// </summary>
        /// <param name="tekst">Tekst za ispis.</param>
        /// <param name="slika">0-pricekaj,1-logiran,2-logiranAdmin</param>
        public void PostaviStatusTekst(string tekst, byte slika)
        {
            logiranAdmin(false);
            switch (slika){
                case 0: // pricekaj
                    this.stStripStatusLabel.Image = Skladiste_PI.Properties.Resources.refresh;
                    break;
                case 1: // logiran korisnik
                    this.stStripStatusLabel.Image = Skladiste_PI.Properties.Resources.korisnik;
                    break;
                case 2: // logiran admin
                    this.stStripStatusLabel.Image = Skladiste_PI.Properties.Resources.admin;
                    logiranAdmin(true);
                    break;

            }
            this.stStripStatusLabel.Text = tekst;

        }

        private void mnuDatotekaZatvoriApp_Click(object sender, EventArgs e)
        {
            try
            {
                mnuProzoriZatvoriSve_Click(null, null);
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Pokretanje child formi.
        /// </summary>
        /// <param name="forma">Naziv forme za pokrenuti.</param>
        private void pokreniFormu(Form forma){
            forma.MdiParent = this;
            forma.Show();
        }

        private void mnuDatotekaIspis_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmIspis());
        }

        private void mnuDokumentiPregledPrijemnica_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmPregledPrijemnice());
        }

        private void mnuAdministracijaKupciUnos_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmUnosKupaca());
        }

        private void mnuDokumentiPregledOtpremnica_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmPregledOtpremince());
        }

        private void mnuDokumentiGeneriranjeNarudzbenice_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmGeneriraneNarudzbenice());
        }

        private void mnuAdministracijaDobavljaciUnos_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmUnosDobavljaca());
        }

        private void mnuArtikliUnos_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmUnosArtikla());
        }

        private void mnuArtikliPregled_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmPregledArtikla());
        }

        private void mnuAdministracijaKupciPregled_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmPregledKupaca());
        }

        private void mnuAdministracijaDobavljaciPregled_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmPregledDobavljaca());
        }

        private void mnuAdministracijaZaposleniciUnos_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmUnosZaposlenika());
        }

        private void mnuAdministracijaZaposleniciPregled_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmPregledZaposlenika());
        }

        private void mnuDokumentiUnosPrijemnica_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmUnosPrijemnice());
        }

        private void mnuDatotekaOdjava_Click(object sender, EventArgs e)
        {
            // Odjava
            // LogOut - evidencija

            novoLogiranje();
        }
        private void mnuAdministracijaSkladiste_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmSkladiste());
        }

        private void mnuDokumentiUnosOtpremnica_Click(object sender, EventArgs e)
        {
            pokreniFormu(new frmUnosOtpremnice());
        }

        private void mnuPomocONama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tim PI! GHIJK", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuPomocDokumentacija_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uskoro...", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Slaganje prozora
        private void mnuProzoriPoslaziVodopadno_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuProzoriPrikaziVertikalno_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuProzoriPrikaziHorizontalno_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuProzoriZatvoriSve_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in this.MdiChildren){
	            ChildForm.Dispose();
	        }
        }

        private void postaviProzore(FormWindowState stanje)
        {
            foreach (Form ChildForm in this.MdiChildren)
            {
                ChildForm.WindowState = stanje;
            }
        }

        private void mnuProzoriMinimizirajSve_Click(object sender, EventArgs e)
        {
            postaviProzore(FormWindowState.Minimized);
        }

        private void mnuProzoriPovecajSve_Click(object sender, EventArgs e)
        {
            postaviProzore(FormWindowState.Maximized);
        }

        private void mnuProzoriVratiSve_Click(object sender, EventArgs e)
        {
            postaviProzore(FormWindowState.Normal);
        }

        private void mnuAdministracijaPostavke_Click(object sender, EventArgs e)
        {
            // Samo admin promjene vezane za aplikaciju
            pokreniFormu(new frmPostavke());
        }


        // 1-Zbog renderiranja pozadine
        private void frmGlavna_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }
        // 2-Zbog renderiranja pozadine
        FormWindowState LastWindowState = FormWindowState.Maximized;
        private void frmGlavna_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                this.Refresh();
            }
        }

        private void frmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            mnuProzoriZatvoriSve_Click(null,null);
        }

    }
}
