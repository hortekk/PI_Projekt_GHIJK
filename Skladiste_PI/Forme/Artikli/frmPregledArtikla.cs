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
    public partial class frmPregledArtikla : Form
    {
        public frmPregledArtikla()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dohvatiartikle() {

            List<Artikli> listaArtikli = Artikli.DohvatiArtikle();
            dataGridView1.DataSource = listaArtikli;
            
        }

        private void frmPregledArtikla_Load(object sender, EventArgs e)
        {
            dohvatiartikle();
            dataGridView1.Columns["idArtikla"].Visible = false;
            dataGridView1.Columns["idKategorijeArtikla"].Visible = false;
            dataGridView1.Columns["Naziv"].Name="Naziv artikla";
            dataGridView1.Columns["KolicinaNaSkladistu"].Name = "Kolicina na skladistu";
            dataGridView1.Columns["AlarmnaKolicina"].Name = "Alarmna kolicina";
            dataGridView1.Columns["CijenaProdaje"].Name = "Cijena prodaje";
        }



    }
}
