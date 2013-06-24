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

   
    public partial class frmUnosArtikla : Form
    {

        public frmUnosArtikla()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dohvatiArtikle()
        {
            List<KategorijaArtikla> listaArtikla = KategorijaArtikla.DohvatiKategorijuArtikla();
            cbKategorija.DataSource = listaArtikla;
            cbKategorija.DisplayMember = "NazivKategorije";
            cbKategorija.ValueMember = "idKategorijeArtikla";
            
        
        }

        private void frmUnosArtikla_Load(object sender, EventArgs e)
        {
            dohvatiArtikle();



        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

            if ((txtNaziv.TextLength > 0)&& (txtAlarmKol.TextLength >= 0) && (txtCijena.TextLength > 0))
            {
                Artikli artikli = new Artikli();
                try
                {
                    artikli.Naziv = txtNaziv.Text;
                    artikli.AlarmnaKolicina = int.Parse(txtAlarmKol.Text);
                    artikli.CijenaProdaje = int.Parse(txtCijena.Text);
                    artikli.idKategorijeArtikla = int.Parse(cbKategorija.SelectedValue.ToString());

                    artikli.Spremi();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Osim polja 'Naziv', u ostala polja se upisuju brojevi!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Morate unijeti sva polja!", "Upozorenje!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
