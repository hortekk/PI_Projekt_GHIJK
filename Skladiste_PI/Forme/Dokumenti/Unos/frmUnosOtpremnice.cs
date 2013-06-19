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
    public partial class frmUnosOtpremnice : Form{
    
        private Otpremnica otpremnica = null;
        private StavkeDokumenta stavke= null;

        public frmUnosOtpremnice()
        {
            InitializeComponent();
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnosOtpremnice_Load (object sender, EventArgs e)
        {
            DohvatiDobavljace();
            DohvatiZaposlenike();
            DohvatiArtikle();
            DGVStavke2.ColumnCount = 3;
            DGVStavke2.Columns[0].Name = "ID Artikla";
            DGVStavke2.Columns[0].Visible = false;
            DGVStavke2.Columns[1].Name = "Artikli";
            DGVStavke2.Columns[2].Name = "Kolicina";
            
        }

        private void DohvatiDobavljace()
        {
            List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(0); // 0 - Dobavljaci
            CMKupac.DataSource = listaDobavljaca;
            CMKupac.DisplayMember = "ImeNaziv";
            CMKupac.ValueMember = "idPP";
            
          
        }

        private void DohvatiZaposlenike()
        {
             
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            CMBZaposlenik.DataSource = listaZaposlenika;
            CMBZaposlenik.DisplayMember = "Prezime";
            
            CMBZaposlenik.ValueMember = "idZaposlenika";
            
        }

        private void DohvatiArtikle() {

            List<Artikli> listaArtikla = Artikli.DohvatiArtikle();
            CBArtikl2.DataSource = listaArtikla;
            CBArtikl2.DisplayMember = "Naziv";
            CBArtikl2.ValueMember = "idArtikla";
            ;
        
        
        }

        private void DohvatiStavke() {
            List<StavkeDokumenta> listaStavki = StavkeDokumenta.DohvatiStavke();
            DGVStavke2.DataSource = listaStavki;
        }





        private void btnUnesiStavku_Click_1(object sender, EventArgs e)
        {
            int number;
            bool result = Int32.TryParse(txtKolicina2.Text.Trim(), out number);
            if (result)
            {
                int kol = int.Parse(txtKolicina2.Text);
                if (kol > 0)
                {
                    DGVStavke2.Rows.Add(CBArtikl2.SelectedValue, CBArtikl2.Text, txtKolicina2.Text);
                }
                else
                {
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


        private void btnUnesiOtpremincu_Click_1(object sender, EventArgs e)
        {


            if (DGVStavke2.RowCount > 0)
            {
                if (otpremnica == null) otpremnica = new Otpremnica();


                otpremnica.idOvlasteneOsobe = int.Parse(CMBZaposlenik.SelectedValue.ToString());
                otpremnica.idPP = int.Parse(CMKupac.SelectedValue.ToString());
                otpremnica.DatumIzdavanja = dateTimePicker2.Value.ToShortDateString();
                otpremnica.Spremi();
                int ID = otpremnica.CurrentID();
                foreach (DataGridViewRow red in DGVStavke2.Rows)
                {
                    stavke = new StavkeDokumenta();
                    stavke.idDokumenta = ID;
                    stavke.idArtikla = int.Parse(red.Cells["ID Artikla"].Value.ToString());
                    stavke.Kolicina = int.Parse(red.Cells["Kolicina"].Value.ToString());
                    stavke.Spremi();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Morate unijeti barem jednu stavku ! ", "UPOZORENJE...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        
        

        



    }
}
