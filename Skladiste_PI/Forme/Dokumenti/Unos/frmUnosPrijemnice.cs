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
    public partial class frmUnosPrijemnice : Form

        
    {
        private Prijamnice unosprijamnica = null;
        private StavkeDokumenta stavke= null;

        public frmUnosPrijemnice()
        {
            InitializeComponent();
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnosPrijemnice_Load (object sender, EventArgs e)
        {
            DohvatiDobavljace();
            DohvatiZaposlenike();
            DohvatiArtikle();
            DGVStavke.ColumnCount = 3;
            DGVStavke.Columns[0].Name = "ID Artikla";
            DGVStavke.Columns[0].Visible = false;
            DGVStavke.Columns[1].Name = "Artikli";
            DGVStavke.Columns[2].Name = "Kolicina";
            
        }

        private void DohvatiDobavljace()
        {
            List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(0); // 0 - Dobavljaci
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

        private void DohvatiArtikle() {

            List<Artikli> listaArtikla = Artikli.DohvatiArtikle();
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
                    //Console.WriteLine("Morate unijeti kolicinu vecu od 0 ! ");
            MessageBox.Show("Morate unijeti kolicinu vecu od 0 ! ", "UPOZORENJE...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                }
        }   
            
            else
            {
                //Console.WriteLine("Niste unijeli nista u kolicinu! ");
                MessageBox.Show("Morate unijeti kolicinu ! ", "UPOZORENJE...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
        

        private void btnUnesiPrijemnicu_Click(object sender, EventArgs e)

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
                    stavke.idArtikla = int.Parse(red.Cells["ID Artikla"].Value.ToString());
                    stavke.Kolicina = int.Parse(red.Cells["Kolicina"].Value.ToString());
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
