using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baza;


namespace Skladiste_PI
{
    public partial class frmIspisOdabir : Form
    {
        frmIspis mainForm = null;
        private int id=-1;

        public frmIspisOdabir(TipIspis tip, frmIspis callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;

            if (tip == TipIspis.Otpremnice)
            {
                this.Text = "Odabir otpremnice";
                label.Text = "ODABERITE OTPREMNICU ZA ISPIS";
                DohvatiOtpremnice();
            }
            else
            {
                this.Text = "Odabir prijamnice";
                label.Text = "ODABERITE PRIJAMNICU ZA ISPIS";
                DohvatiPrijamnicu();

            }

        }

        private void DohvatiOtpremnice()
        {
            List<PregledOtpremnica> listaOtpremnice = PregledOtpremnica.DohvatiOtpremnicu();
            dgvPodaci.DataSource = listaOtpremnice;
        }
        public void DohvatiPrijamnicu()
        {
            List<PregledPrijamnice> listaOtpremnice = PregledPrijamnice.DohvatiOtpremnicu();
            dgvPodaci.DataSource = listaOtpremnice;
        }



        

        private void frmIspisOtp_Load(object sender, EventArgs e)
        {
            dgvPodaci.Columns["idDokumenta"].Visible = false;
            dgvPodaci.Columns["Ime"].HeaderText = "Ime zaposlenika";
            dgvPodaci.Columns["Prezime"].HeaderText = "Prezime zaposlenika";
            dgvPodaci.Columns["ImeNaziv"].HeaderText = "Ime kupca";
            dgvPodaci.Columns["PrezimeVrsta"].HeaderText = "Prezime kupca";
            dgvPodaci.Columns["DatumIzdavanja"].HeaderText = "Datum izdavanja";
        }

        private void dgvPodaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sID = dgvPodaci.Rows[e.RowIndex].Cells["idDokumenta"].Value.ToString();
                id = int.Parse(sID.ToString());
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           mainForm.postaviID(id);
           this.Close();
        }

        private void dgvPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sID = dgvPodaci.Rows[e.RowIndex].Cells["idDokumenta"].Value.ToString();
                id = int.Parse(sID.ToString());
                mainForm.postaviID(id);
                this.Close();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void frmIspisOdabir_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.postaviID(id);
        }
    }   
}
