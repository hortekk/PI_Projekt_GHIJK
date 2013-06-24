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
using System.Data.Common;
using System.Globalization;


namespace Skladiste_PI
{
    public partial class frmUnosPrijamnice : Form

        
    {
        private Prijamnice unosprijamnica = null;
        private StavkeDokumenta stavke= null;

        public frmUnosPrijamnice()
        {
            InitializeComponent();
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnosPrijamnice_Load (object sender, EventArgs e)
        {
            DohvatiDobavljace();
            DohvatiZaposlenike();
            DohvatiSveArtikle();
            DGVStavke.ColumnCount = 3;
            DGVStavke.Columns[0].HeaderText = "ID Artikla";
            DGVStavke.Columns[0].Visible = false;
            DGVStavke.Columns[1].HeaderText = "Artikli";
            DGVStavke.Columns[2].HeaderText = "Količina";

        }

        private void DohvatiDobavljace()
        {
            List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Dobavljac);
            CBDobavljac.DataSource = listaDobavljaca;
            CBDobavljac.DisplayMember = "ImeNaziv";
            CBDobavljac.ValueMember = "idPP";
            
          
        }

        private void DohvatiZaposlenike()
        {
             
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            CMZaposlenik.DataSource = listaZaposlenika;
            CMZaposlenik.DisplayMember = "Prezime";
            
            CMZaposlenik.ValueMember = "idZaposlenika";
            
        }

        private void DohvatiSveArtikle() {

            List<Artikli> listaArtikla = Artikli.DohvatiSveArtikle();
            CBArtikl.DataSource = listaArtikla;
            CBArtikl.DisplayMember = "Naziv";
            CBArtikl.ValueMember = "idArtikla";
            ;
        
        
        }

        private void DohvatiStavke() {
            List<StavkeDokumenta> listaStavki = StavkeDokumenta.DohvatiStavke();
            DGVStavke.DataSource = listaStavki;
        }




        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(txtKolicina.Text.Trim(), out number);
            if (result)
            {
                int kol =int.Parse(txtKolicina.Text);
                if ( kol> 0)
            {
                DGVStavke.Rows.Add(CBArtikl.SelectedValue, CBArtikl.Text, txtKolicina.Text);
            }
            else { 
            MessageBox.Show("Morate unijeti količinu veću od 0 ! ", "UPOZORENJE...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                }
        }   
            
            else
            {
                MessageBox.Show("Morate unijeti količinu ! ", "UPOZORENJE...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
        

        private void btnUnesiPrijamnicu_Click(object sender, EventArgs e)

        {

            if (DGVStavke.RowCount >0)
            {
                if (unosprijamnica == null) unosprijamnica = new Prijamnice();


                unosprijamnica.idOvlasteneOsobe = int.Parse(CMZaposlenik.SelectedValue.ToString());
                unosprijamnica.idPP = int.Parse(CBDobavljac.SelectedValue.ToString());
                unosprijamnica.DatumIzdavanja = dateTimePicker1.Value.ToShortDateString();
                unosprijamnica.Spremi();
                int ID = unosprijamnica.CurrentID();
                foreach (DataGridViewRow red in DGVStavke.Rows)
                {
                    stavke = new StavkeDokumenta();
                    stavke.idDokumenta = ID;
                    stavke.idArtikla = int.Parse(red.Cells[0].Value.ToString());
                    stavke.Kolicina = int.Parse(red.Cells[2].Value.ToString());
                    stavke.Spremi();
                }

                this.Close();
            }
            else {
                MessageBox.Show("Morate unijeti barem jednu stavku ! ", "UPOZORENJE...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        
        

        



    }
}
