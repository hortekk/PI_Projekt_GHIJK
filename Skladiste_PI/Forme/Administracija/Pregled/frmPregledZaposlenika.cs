using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baza;

namespace Skladiste_PI
{
    public partial class frmPregledZaposlenika : Form
    {
        public frmPregledZaposlenika()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Popunjava DataGrid s zaposlenicima iz baze
        /// </summary>
        private void DohvatiZaposlenike()
        {
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            dgvZaposlenici.DataSource = listaZaposlenika;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPregledZaposlenika_Load(object sender, EventArgs e)
        {
            DohvatiZaposlenike();
            dgvZaposlenici.Columns["Ime"].HeaderText = "ImeZaposlenika";
            dgvZaposlenici.Columns["BrojTelefona"].HeaderText = "Broj telefona";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUnosZaposlenika frmUnosZaposlenika = new frmUnosZaposlenika();
            frmUnosZaposlenika.ShowDialog();
            DohvatiZaposlenike();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati " + (dgvZaposlenici.SelectedRows.Count == 1 ? "označenog zaposlenika?" : "označene zaposlenike?"), "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }

                foreach (DataGridViewRow row in dgvZaposlenici.SelectedRows)
                {
                    Zaposlenik odabraniZaposlenik = row.DataBoundItem as Zaposlenik;
                    odabraniZaposlenik.Obrisi();
                }
                DohvatiZaposlenike();
            }
        }

        private void frmPregledZaposlenika_Activated(object sender, EventArgs e)
        {
            DohvatiZaposlenike();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count == 1)
            {
                Zaposlenik odabraniZaposlenik = dgvZaposlenici.SelectedRows[0].DataBoundItem as Zaposlenik;
                frmUnosZaposlenika frmUnosZaposlenika = new frmUnosZaposlenika(odabraniZaposlenik);
                frmUnosZaposlenika.ShowDialog();
                DohvatiZaposlenike();
            }
            else if (dgvZaposlenici.SelectedRows.Count > 1)
                MessageBox.Show("Označite samo jednog zaposlenika za izmjenu!", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvZaposlenici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIzmjeni_Click(null,null);
        }

        private void dgvZaposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvZaposlenici_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
