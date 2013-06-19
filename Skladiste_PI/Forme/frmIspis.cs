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
    public partial class frmIspis : Form
    {
        public frmIspis()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor za formu ispis
        /// </summary>
        /// <param name="tip">0-Prijemnice,1-Otpremnice,2-Artikl,3-Kupci,4-Dobavljaci,5-Zaposlenici</param>
        public frmIspis(byte tip)
        {
            InitializeComponent();
            Microsoft.Reporting.WinForms.ReportDataSource reportDS = new Microsoft.Reporting.WinForms.ReportDataSource();

            switch (tip)
            {
                case 0: // Prijemnice
                    this.Text = "Pregled ispisa prijemnica";
                    //reportDS.Name = "dsPP";
                    //List<PoslovniPartner> listaPrijemnica = PoslovniPartner.DohvatiPoslovnePartnere(1);
                    //reportDS.Value = listaPrijemnica;
                    //this.report.LocalReport.DataSources.Add(reportDS);
                    this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Prijemnice.rdlc";
                    break;
                case 1: // Otpremnice
                    this.Text = "Pregled ispisa otpremnica";
                    //reportDS.Name = "dsPP";
                    //List<PoslovniPartner> listaOtpremnica = PoslovniPartner.DohvatiPoslovnePartnere(1);
                   // reportDS.Value = listaOtpremnica;
                   // this.report.LocalReport.DataSources.Add(reportDS);
                    this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Otpremnice.rdlc";
                    break;
                case 2: // Artikl
                    this.Text = "Pregled ispisa arikala";
                    //reportDS.Name = "dsPP";
                   // List<PoslovniPartner> listaKupaca = PoslovniPartner.DohvatiPoslovnePartnere(1);
                   // reportDS.Value = listaKupaca;
                   // this.report.LocalReport.DataSources.Add(reportDS);
                    this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Artikli.rdlc";
                    break;
                case 3: // Kupci
                    this.Text = "Pregled ispisa kupaca";
                    reportDS.Name = "dsPP";
                    List<PoslovniPartner> listaKupaca = PoslovniPartner.DohvatiPoslovnePartnere(1); // 1 - Kupci
                    reportDS.Value = listaKupaca;
                    this.report.LocalReport.DataSources.Add(reportDS);
                    this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Kupci.rdlc";
                    break;
                case 4: // Dobavljaci
                    this.Text = "Pregled ispisa dobavljača";
                    reportDS.Name = "dsPP";
                    List<PoslovniPartner> listaDobavljaca = PoslovniPartner.DohvatiPoslovnePartnere(0); // 0 - Dobavljaci
                    reportDS.Value = listaDobavljaca;
                    this.report.LocalReport.DataSources.Add(reportDS);
                    this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Dobavljaci.rdlc";
                    break;
                case 5: // Zaposlenici
                    this.Text = "Pregled ispisa zaposlenika";
                    reportDS.Name = "dsZaposlenici";
                    List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
                    reportDS.Value = listaZaposlenika;
                    this.report.LocalReport.DataSources.Add(reportDS);
                    this.report.LocalReport.ReportEmbeddedResource = "Skladiste_PI.Izvjestaji.Zaposlenici.rdlc";
                    break;
            }
        }

        private void frmIspis_Load(object sender, EventArgs e)
        {
            this.report.RefreshReport();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            this.report.PrintDialog();
        }
    }
}
