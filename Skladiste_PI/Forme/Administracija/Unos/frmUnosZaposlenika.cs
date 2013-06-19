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
        

        public frmUnosZaposlenika()
        {
            InitializeComponent();
        }

        public frmUnosZaposlenika(Zaposlenik odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = odabraniZaposlenik;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zaposlenik == null) zaposlenik = new Zaposlenik();

            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime=txtPrezime.Text;
            zaposlenik.Email=txtEmail.Text;
            zaposlenik.BrojTelefona=txtBrojTelefona.Text;
            zaposlenik.Adresa = txtAdresa.Text;

            zaposlenik.Spremi();
            this.Close();
        }

        private void frmUnosZaposlenika_Load(object sender, EventArgs e)
        {
            if (zaposlenik != null)
            {
                this.Text = "Izmjena zaposlenika: " + zaposlenik.Ime + " " + zaposlenik.Prezime;
                txtIme.Text = zaposlenik.Ime;
                txtPrezime.Text = zaposlenik.Prezime;
                txtEmail.Text = zaposlenik.Email;
                txtBrojTelefona.Text = zaposlenik.BrojTelefona;
                txtAdresa.Text = zaposlenik.Adresa;

            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
