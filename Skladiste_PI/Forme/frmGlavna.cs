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

        private void novoLogiranje()
        {
            
            frmLogIn frmLogIn =  new frmLogIn();
            //frmLogIn.MdiParent = this;
            frmLogIn.ShowDialog();

        }
        public void UspjesnaPrijava()
        {
            mnuMeni.Enabled = true;
            
            //logiranKorisnik = false;

        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void primkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledPrijemnice frmPregledPrijemnice = new frmPregledPrijemnice();
            frmPregledPrijemnice.MdiParent = this;
            frmPregledPrijemnice.Show();
        }

        private void noviKupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosKupaca frmUnosKupaca = new frmUnosKupaca();
            frmUnosKupaca.MdiParent = this;
            frmUnosKupaca.Show();

        }

        private void otpremniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledOtpremince frmPregledOtpremnice = new frmPregledOtpremince();
            frmPregledOtpremnice.MdiParent = this;
            frmPregledOtpremnice.Show();
         
        }

        private void narudžbeniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneriraneNarudzbenice frmGeneriraneNarudzbenice = new frmGeneriraneNarudzbenice();
            frmGeneriraneNarudzbenice.MdiParent = this;
            frmGeneriraneNarudzbenice.Show();

        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosDobavljaca frmUnosDobavljaca = new frmUnosDobavljaca();
            frmUnosDobavljaca.MdiParent = this;
            frmUnosDobavljaca.Show();

        }

        private void unosNovogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosArtikla frmUnosArtikla = new frmUnosArtikla();
            frmUnosArtikla.MdiParent = this;
            frmUnosArtikla.Show();

        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPregledArtikla frmPregledArtikla = new frmPregledArtikla();
            frmPregledArtikla.MdiParent = this;
            frmPregledArtikla.Show();

        }

        private void pregledToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPregledKupaca frmPregledKupaca = new frmPregledKupaca();
            frmPregledKupaca.MdiParent = this;
            frmPregledKupaca.Show();

        }

        private void pregledToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPregledDobavljaca frmPregledDobavljaca = new frmPregledDobavljaca();
            frmPregledDobavljaca.MdiParent = this;
            frmPregledDobavljaca.Show();
        }

        private void noviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUnosZaposlenika frmUnosZaposlenika = new frmUnosZaposlenika();
            frmUnosZaposlenika.MdiParent = this;
            frmUnosZaposlenika.Show();

        }

        private void pregledToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPregledZaposlenika frmPregledZaposlenika = new frmPregledZaposlenika();
            frmPregledZaposlenika.MdiParent = this;
            frmPregledZaposlenika.Show();

        }

        private void primkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosPrijemnice frmUnosPrijemnice = new frmUnosPrijemnice();
            frmUnosPrijemnice.MdiParent = this;
            frmUnosPrijemnice.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Odjava
            novoLogiranje();
        }

        private void otpremniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnosOtpremnice frmUnosOtpremnice = new frmUnosOtpremnice();
            frmUnosOtpremnice.MdiParent = this;
            frmUnosOtpremnice.Show();

        }

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tim PI! GHIJK", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dokumentacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uskoro...", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
