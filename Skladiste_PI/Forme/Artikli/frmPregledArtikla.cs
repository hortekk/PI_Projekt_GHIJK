using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Baza;

namespace Skladiste_PI
{
    public partial class frmPregledArtikla : Form
    {
        private bool alarm = false;
        public frmPregledArtikla()
        {
            InitializeComponent();
        }

        public frmPregledArtikla(bool sAlarmom = false)
        {
            InitializeComponent();
            alarm = sAlarmom;
            postaviPregledAlarm();
        }

        private void postaviPregledAlarm(){
            this.Text = "Stanje na skladištu";
            dgvArtikli.Enabled = false;
            dgvArtikli.RowHeadersVisible = false;
            System.Windows.Forms.DataGridViewCellStyle dgvArtikliCellStyleAlarm = new System.Windows.Forms.DataGridViewCellStyle();
            dgvArtikliCellStyleAlarm.SelectionBackColor = System.Drawing.Color.DarkRed;
            dgvArtikli.RowsDefaultCellStyle = dgvArtikliCellStyleAlarm;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dohvatiArtikle() {

            List<Artikli> listaArtikli = Artikli.DohvatiSveArtikle();
            dgvArtikli.DataSource = listaArtikli;
            

            if (alarm)
            {
                try
                {
                    foreach (DataGridViewRow red in dgvArtikli.SelectedRows) red.Selected = false;
                    List<Artikli> listaAlarm = Artikli.DohvatiSveArtikleAlarm();
                    foreach (DataGridViewRow red in dgvArtikli.Rows)
                    {
                        foreach (Artikli artikl in listaAlarm)
                            if (int.Parse(red.Cells["idArtikla"].Value.ToString()) == artikl.idArtikla)
                            {
                                red.Selected = true;
                            }
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
            }

        }

        private void frmPregledArtikla_Load(object sender, EventArgs e)
        {
            dohvatiArtikle();
            dgvArtikli.Columns["idArtikla"].Visible = false;
            dgvArtikli.Columns["idKategorijeArtikla"].Visible = false;
            dgvArtikli.Columns["Naziv"].HeaderText = "Naziv artikla";
            dgvArtikli.Columns["KolicinaNaSkladistu"].HeaderText = "Količina na skladištu";
            dgvArtikli.Columns["AlarmnaKolicina"].HeaderText = "Alarmna količina";
            dgvArtikli.Columns["CijenaProdaje"].HeaderText = "Cijena prodaje";

        }

        private void frmPregledArtikla_Activated(object sender, EventArgs e)
        {
            dohvatiArtikle();
        }



    }
}
