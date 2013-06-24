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
    public partial class frmPregledDobavljaca : Form
    {
        public frmPregledDobavljaca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcija onemogućuje određene opcije u slučaju da je lista prazna
        /// </summary>
        /// <param name="nemaPodataka">True ako je lista prazna, False ako nije</param>
        private void PostaviKontrole(bool nemaPodataka = false)
        {
            btnIzmjeni.Enabled = btnBrisi.Enabled = dgvDobavljaci.Enabled = !nemaPodataka;
        }

        /// <summary>
        /// Popunjava DataGrid s dobavljačima iz baze
        /// </summary>
        private void DohvatiDobavljace()
        {
            List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Dobavljac);
            dgvDobavljaci.DataSource = listaDobavljaca;

            if (dgvDobavljaci.RowCount <= 0) PostaviKontrole(true);
            else PostaviKontrole();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPregledDobavljaca_Load(object sender, EventArgs e)
        {
            DohvatiDobavljace();
            dgvDobavljaci.Columns["idPP"].Visible = false;
            dgvDobavljaci.Columns["TipPP"].Visible = false;
            dgvDobavljaci.Columns["ImeNaziv"].HeaderText = "Ime / Naziv";
            dgvDobavljaci.Columns["PrezimeVrsta"].HeaderText = "Prezime / Vrsta";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUnosDobavljaca frmUnosDobavljaca = new frmUnosDobavljaca(null);
            frmUnosDobavljaca.ShowDialog();
            DohvatiDobavljace();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvDobavljaci.SelectedRows.Count > 0)
            {
                switch (MessageBox.Show("Jeste li sigurni da želite obrisati " + (dgvDobavljaci.SelectedRows.Count == 1 ? "označenog dobavljača?" : "označene dobavljače?"), "Upit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.No:
                        return;
                }

                foreach (DataGridViewRow row in dgvDobavljaci.SelectedRows)
                {
                    PoslovniPartner odabraniDobavljaci = row.DataBoundItem as PoslovniPartner;
                    odabraniDobavljaci.Obrisi();
                }
                DohvatiDobavljace();
            }
        }

        private void frmPregledDobavljaca_Activated(object sender, EventArgs e)
        {
            DohvatiDobavljace();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (dgvDobavljaci.SelectedRows.Count == 1)
            {
                PoslovniPartner odabraniDobavljac = dgvDobavljaci.SelectedRows[0].DataBoundItem as PoslovniPartner;
                frmUnosDobavljaca frmUnosDobavljaca = new frmUnosDobavljaca(odabraniDobavljac);
                frmUnosDobavljaca.ShowDialog();
                DohvatiDobavljace();
            }
            else if (dgvDobavljaci.SelectedRows.Count > 1)
                MessageBox.Show("Označite samo jednog dobavljača za izmjenu!", "Informacija...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDobavljaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIzmjeni_Click(null,null);
        }

    }
}
