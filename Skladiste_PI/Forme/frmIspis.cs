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
    public enum TipIspis { Prijamnice = 0, Otpremnice = 1, Narudžbenice = 2, Artikli = 3, Kupci = 4, Dobavljači = 5, Zaposlenici = 6 }
    public partial class frmIspis : Form
    {

        private TipIspis tip;
        private int pID = -1;
        public frmIspis()
        {
            InitializeComponent();
            postaviOdabir();
        }

        /// <summary>
        /// Konstruktor za formu ispis
        /// </summary>
        /// <param name="tip">Vrsta dokumenta za ispisa</param>
        public frmIspis(TipIspis odabraniTip, int idDok=-1)
        {
            InitializeComponent();
            tip = odabraniTip;
            pID = idDok;
            postaviNaslov();
            if (tip == TipIspis.Prijamnice || tip == TipIspis.Otpremnice && pID==-1)
            {
                frmIspisOdabir frmIspisOdabir = new frmIspisOdabir(tip, this);
                frmIspisOdabir.ShowDialog();
            }
            UcitajReport();
        }

        public void postaviID(int ID)
        {
            pID = ID;
        }

        private void UcitajReport()
        {
            if ((tip == TipIspis.Prijamnice || tip == TipIspis.Otpremnice) && pID == -1)
            {
                MessageBox.Show("Greška pri učitavanju podataka!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblLoad.Text = "Greška pri učitavanju podataka!";
                pbLoad.Visible = false;
            }
            // Druga dretva učitava report
            else bwLoadReport.RunWorkerAsync(tip);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            this.report.PrintDialog();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            foreach (var pControl in panelOdabir.Controls)
            {
                RadioButton rButton = pControl as RadioButton;
                if (rButton != null && rButton.Checked)
                {
                    tip = (TipIspis)rButton.Tag;
                    break;
                }
            }

            this.MaximizeBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.btnZatvori.Location = new System.Drawing.Point(497, 327);
            this.AcceptButton = null;
            panelOdabir.Visible = false;
            panelLoad.Visible = true;
            postaviNaslov();

            if (tip == TipIspis.Prijamnice || tip == TipIspis.Otpremnice)
            {
                frmIspisOdabir frmIspisOdabir = new frmIspisOdabir(tip, this);
                frmIspisOdabir.ShowDialog();
            }

            UcitajReport();
        }

        /// <summary>
        /// Postavlja formu za odabir ispisa
        /// </summary>
        private void postaviOdabir()
        {
            this.Text = "Odaberite stavku za ispis";
            this.AcceptButton = this.btnUcitaj;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.btnZatvori.Location = new System.Drawing.Point(280, 236);
            panelLoad.Visible = false;
            panelOdabir.Visible = true;
            foreach (TipIspis rTip in Enum.GetValues(typeof(TipIspis))){
                RadioButton radioTip = new RadioButton();
                radioTip.Text = rTip.ToString();
                radioTip.Tag = rTip;
                radioTip.Top = 20 * (int)rTip;
                if (rTip == TipIspis.Prijamnice) radioTip.Checked = true;
                panelOdabir.Controls.Add(radioTip);
            }
        }

        /// <summary>
        /// Postavlja odgovarajući naslov na formu
        /// </summary>
        private void postaviNaslov()
        {
            switch (tip)
            {
                case TipIspis.Prijamnice:
                    this.Text = "Pregled ispisa prijemnica";
                    break;
                case TipIspis.Otpremnice:
                    this.Text = "Pregled ispisa otpremnica";
                    break;
                case TipIspis.Narudžbenice:
                    this.Text = "Pregled ispisa narudžbenice";
                    break;
                case TipIspis.Artikli:
                    this.Text = "Pregled ispisa artikala";
                    break;
                case TipIspis.Kupci:
                    this.Text = "Pregled ispisa kupaca";
                    break;
                case TipIspis.Dobavljači:
                    this.Text = "Pregled ispisa dobavljača";
                    break;
                case TipIspis.Zaposlenici:
                    this.Text = "Pregled ispisa zaposlenika";
                    break;
            }
        }

        /// <summary>
        /// Dohvaća podatke o kupcima i popunjava report
        /// </summary>
        private void dohvatiKupce()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS.Name = "dsPP";
            List<PoslovniPartner> listaKupaca = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Kupac);
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS.Value = listaKupaca;
            this.report.LocalReport.DataSources.Add(reportDS);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Kupci.rdlc";
        }

        /// <summary>
        /// Dohvaća podatke o dobavljačima i popunjava report
        /// </summary>
        private void dohvatiDobavljace()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS.Name = "dsPP";
            List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Dobavljac);
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS.Value = listaDobavljaca;
            this.report.LocalReport.DataSources.Add(reportDS);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Dobavljaci.rdlc";
        }

        /// <summary>
        /// Dohvaća podatke o zaposlenicima i popunjava report
        /// </summary>
        private void dohvatiZaposlenike()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS.Name = "dsZaposlenici";
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS.Value = listaZaposlenika;
            this.report.LocalReport.DataSources.Add(reportDS);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Zaposlenici.rdlc";
        }

        /// <summary>
        /// Dohvaća podatke o artiklima i popunjava report
        /// </summary>
        private void dohvatiArtikle()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS.Name = "dsArtikl";
            List<Artikli> listaArtikla = Artikli.DohvatiSveArtikle();
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS.Value = listaArtikla;
            this.report.LocalReport.DataSources.Add(reportDS);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Artikli.rdlc";
        }

        /// <summary>
        /// Dohvaća podatke o artiklima za narudžbenicu i popunjava report
        /// </summary>
        private void dohvatiNarudzbenicu()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS.Name = "dsArtikl";
            List<Artikli> listaArtikla = Artikli.DohvatiSveArtikleAlarm();
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS.Value = listaArtikla;
            this.report.LocalReport.DataSources.Add(reportDS);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Narudzbenice.rdlc";
        }

        /// <summary>
        /// Dohvaća podatke o otpremnicama i popunjava report
        /// </summary>
        private void dohvatiOtpremnice()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDS2 = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS1.Name = "dsOtpremnica";
            reportDS2.Name = "dsOtpremnicaStavke";
            List<PregledOtpremnicaStavke> listaStavki = PregledOtpremnicaStavke.DohvatiStavkeDokumenta(pID);
            List<PregledOtpremnica> listaOtpremnica = PregledOtpremnica.DohvatiOtpremnicuPremaID(pID);
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS1.Value = listaOtpremnica;
            reportDS2.Value = listaStavki;
            this.report.LocalReport.DataSources.Add(reportDS1);
            this.report.LocalReport.DataSources.Add(reportDS2);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Otpremnice.rdlc";
        }

        /// <summary>
        /// Dohvaća podatke o prijemnicama i popunjava report
        /// </summary>
        private void dohvatiPrijamnice()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDS1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDS2 = new Microsoft.Reporting.WinForms.ReportDataSource();

            reportDS1.Name = "dsPrijamnica";
            reportDS2.Name = "dsPrijamnicaStavke";
            List<PregledPrijamniceStavke> listaStavki = PregledPrijamniceStavke.DohvatiStavkeDokumenta(pID);
            List<PregledPrijamnice> listaPrijamnica = PregledPrijamnice.DohvatiPrijamnicuPremaID(pID);
            bwLoadReport.ReportProgress(37);
            System.Threading.Thread.Sleep(500);
            reportDS1.Value = listaPrijamnica;
            reportDS2.Value = listaStavki;
            this.report.LocalReport.DataSources.Add(reportDS1);
            this.report.LocalReport.DataSources.Add(reportDS2);
            bwLoadReport.ReportProgress(80);
            System.Threading.Thread.Sleep(500);
            this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Prijamnice.rdlc";
        }
        
        private void bwLoadReport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(200);
                TipIspis tip = (TipIspis)e.Argument;

                switch (tip)
                {
                    case TipIspis.Prijamnice:
                        dohvatiPrijamnice();
                        break;
                    case TipIspis.Otpremnice:
                        dohvatiOtpremnice();
                        break;
                    case TipIspis.Narudžbenice:
                        dohvatiNarudzbenicu();
                        break;
                    case TipIspis.Artikli:
                        dohvatiArtikle();
                        break;
                    case TipIspis.Kupci:
                        dohvatiKupce();
                        break;
                    case TipIspis.Dobavljači:
                        dohvatiDobavljace();
                        break;
                    case TipIspis.Zaposlenici:
                        dohvatiZaposlenike();
                        break;
                }
                bwLoadReport.ReportProgress(100);
                System.Threading.Thread.Sleep(500);
                e.Result = true;
            }
            catch (Exception ex)
            {
                if (!(ex is ObjectDisposedException)) MessageBox.Show("Greška pri učitavanju podataka!", "Greška...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Result = false;
            }
        }

        private void bwLoadReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if ((bool)e.Result)
                {
                    this.report.RefreshReport();
                    this.report.RefreshReport();
                    panelLoad.Visible = false;
                    panelPozadina.Visible = true;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void bwLoadReport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbLoad.Value = e.ProgressPercentage;
        }

    }
}
