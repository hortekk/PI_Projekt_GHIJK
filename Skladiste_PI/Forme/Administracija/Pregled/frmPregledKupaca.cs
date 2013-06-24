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
    public partial class frmPregledKupaca : Form
    {
        public frmPregledKupaca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcija onemogućuje određene opcije u slučaju da je lista prazna
        /// </summary>
        /// <param name="nemaPodataka">True ako je lista prazna, False ako nije</param>
        private void PostaviKontrole(bool nemaPodataka = false)
        {
            btnIzmjeni.Enabled = btnBrisi.Enabled = dgvKupci.Enabled = !nemaPodataka;
        }

        /// <summary>
        /// Popunjava DataGrid s kupcima iz baze
        /// </summary>
        private void DohvatiKupce()
        {
            List<PoslovniPartner> listaKupaca = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Kupac);
            dgvKupci.DataSource = listaKupaca;

            if (dgvKupci.RowCount <= 0) PostaviKontrole(true);
            else PostaviKontrole();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPregledKupaca_Load(object sender, EventArgs e)
        {
            DohvatiKupce();
            dgvKupci.Columns["idPP"].Visible = false;
            dgvKupci.Columns["TipPP"].Visible = false;
            dgvKupci.Columns["ImeNaziv"].HeaderText = "Ime / Naziv";
            dgvKupci.Columns["PrezimeVrsta"].HeaderText = "Prezime / Vrsta";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUnosKupaca frmUnosKupaca = new frmUnosKupaca(null);
            frmUnosKupaca.ShowDialog();
            DohvatiKupce();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati " + (dgvKupci.SelectedRows.Count == 1 ? "označenog kupca?" : "označene kupce?"), "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }

                foreach (DataGridViewRow row in dgvKupci.SelectedRows)
                {
                    PoslovniPartner odabraniKupci = row.DataBoundItem as PoslovniPartner;
                    odabraniKupci.Obrisi();
                }
                DohvatiKupce();
            }
        }

        private void frmPregledKupaca_Activated(object sender, EventArgs e)
        {
            DohvatiKupce();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count == 1)
            {
                PoslovniPartner odabraniKupac = dgvKupci.SelectedRows[0].DataBoundItem as PoslovniPartner;
                frmUnosKupaca frmUnosKupaca = new frmUnosKupaca(odabraniKupac);
                frmUnosKupaca.ShowDialog();
                DohvatiKupce();
            }
            else if (dgvKupci.SelectedRows.Count > 1)
                MessageBox.Show("Označite samo jednog kupca za izmjenu!", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvKupci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIzmjeni_Click(null, null);
        }

    }
}
