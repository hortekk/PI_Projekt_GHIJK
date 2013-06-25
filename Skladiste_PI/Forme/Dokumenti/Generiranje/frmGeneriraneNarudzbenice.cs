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
using Skladiste_PI;

namespace Skladiste_PI
{
    public partial class frmGeneriraneNarudzbenice : Form
    {

        private frmGlavna mainForm = null;

        public frmGeneriraneNarudzbenice(frmGlavna callingForm)
        {
            mainForm = callingForm as frmGlavna;
            InitializeComponent();
        }

        private void DohvatiSveArtikleAlarm() {
            List<Artikli> listaArtikla = Artikli.DohvatiSveArtikleAlarm();
            dgvGenNar.DataSource = listaArtikla;
        }
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGeneriraneNarudzbenice_Load(object sender, EventArgs e)
        {
            DohvatiSveArtikleAlarm();
        }
        private void frmGeneriraneNarudzbenice_Activated(object sender, EventArgs e)
        {
            DohvatiSveArtikleAlarm();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            mainForm.pokreniFormu(new frmIspis(TipIspis.Narudžbenice));
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            frmMail mail = new frmMail(mainForm.logiranKorisnik);
            mail.ShowDialog();
                
        }

    }
}
