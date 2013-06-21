﻿using System;
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
    public partial class frmPregledPrijemnice : Form
    {
        public frmPregledPrijemnice()
        {
            InitializeComponent();
        }
        public void DohvatiPrijamnicu() {
            List<PregledPrijamnice> listaOtpremnice = PregledPrijamnice.DohvatiOtpremnicu();

            DGVPrijamnice.DataSource = listaOtpremnice;
        
        }
        private void frmPregledPrijemnice_Load(object sender, EventArgs e)
        {
            DohvatiPrijamnicu();

            DGVPrijamnice.Columns["idDokumenta"].HeaderText = "idDokumenta";
            DGVPrijamnice.Columns["idOvlasteneOsobe"].Visible = false;
            DGVPrijamnice.Columns["idPP"].Visible = false;
            DGVPrijamnice.Columns["TipDokumenta"].Visible = false;
            DGVPrijamnice.Columns["Ime"].HeaderText = "Ime zaposlenika";
            DGVPrijamnice.Columns["Prezime"].HeaderText = "Prezime Zaposlenia";
            DGVPrijamnice.Columns["ImeNaziv"].HeaderText = "Ime kupca";
            DGVPrijamnice.Columns["PrezimeVrsta"].HeaderText = "Prezime kupca";
            DGVPrijamnice.Columns["DatumIzdavanja"].HeaderText = "Datum Izdavanja";
            
        }

        private void DGVPrijamnice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            id = DGVPrijamnice.Rows[e.RowIndex].Cells["idDokumenta"].Value.ToString();
            int id2 = int.Parse(id.ToString());
            MessageBox.Show(id);
            List<PregledPrijamniceStavke> listaStavki = PregledPrijamniceStavke.DohvatiStavkeDokumenta(id2);
            DGVStavke2.DataSource = listaStavki;
            DGVStavke2.Columns["NazivArtikla"].HeaderText = "Naziv artikla";
        }
    }
}
