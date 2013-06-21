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
    public partial class frmPregledOtpremince : Form
    {
        Otpremnica otpremnica = null;




        public frmPregledOtpremince()
        {
            InitializeComponent();

        }

        private void DohvatiOtpremnice()
        {

            List<PregledOtpremnica> listaOtpremnice = PregledOtpremnica.DohvatiOtpremnicu();

            DGVOtpremnice.DataSource = listaOtpremnice;





        }

       



        private void frmPregledOtpremince_Load(object sender, EventArgs e)
        {

            DohvatiOtpremnice();
            
            DGVOtpremnice.Columns["idDokumenta"].HeaderText = "idDokumenta";
            DGVOtpremnice.Columns["idOvlasteneOsobe"].Visible = false;
            DGVOtpremnice.Columns["idPP"].Visible = false;
            DGVOtpremnice.Columns["TipDokumenta"].Visible = false;
            DGVOtpremnice.Columns["Ime"].HeaderText = "Ime zaposlenika";
            DGVOtpremnice.Columns["Prezime"].HeaderText = "Prezime Zaposlenia";
            DGVOtpremnice.Columns["ImeNaziv"].HeaderText = "Ime kupca";
            DGVOtpremnice.Columns["PrezimeVrsta"].HeaderText = "Prezime kupca";
            DGVOtpremnice.Columns["DatumIzdavanja"].HeaderText = "Datum Izdavanja";
            


        }

        private void DGVOtpremnice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = DGVOtpremnice.Rows[e.RowIndex].Cells["idDokumenta"].Value.ToString();
            int id2 = int.Parse(id.ToString());
            MessageBox.Show(id);
            List<PregledOtpremnicaStavke> listaStavki = PregledOtpremnicaStavke.DohvatiStavkeDokumenta(id2);
            DGVStavke.DataSource = listaStavki;
            DGVStavke.Columns["NazivArtikla"].HeaderText = "Naziv artikla";
        }

        

        
        



    }
}
