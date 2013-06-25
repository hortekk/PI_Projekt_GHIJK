using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skladiste_PI;
using Funkcije;
using Baza;

namespace Skladiste_PI
{
    public partial class frmMail : Form
    {
        private string nazmaila;
        public string sifra;
        private string nasmaila;
        private string mailprim;
        private string tekst;
        private string logZaposlenik;

        public frmMail(string logZap)
        {
            InitializeComponent();
            logZaposlenik = logZap;
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            List<PoslovniPartner> listapp = PoslovniPartner.DohvatiPoslovnePartnere(TipoviPP.Dobavljac);
            comboBox1.DataSource = listapp;
            comboBox1.DisplayMember = "Email";

            	
            List<Artikli> listaArtikla = Artikli.DohvatiSveArtikleAlarm();
            //textBox3.Text = textBox3.Text + "<table>";
            foreach (Artikli art in listaArtikla)
            {
                textBox3.Text = textBox3.Text + Environment.NewLine.ToString() + art.idArtikla.ToString() + "   \t\t\t" + art.Naziv + "   \t\t\t" + (art.AlarmnaKolicina + (art.AlarmnaKolicina - art.KolicinaNaSkladistu)).ToString();
            }
            textBox3.Text=textBox3.Text.Replace("*FUNKCIJA DATE/TIME*", DateTime.Now.ToShortDateString());
            textBox3.Text = textBox3.Text + Environment.NewLine.ToString() + Environment.NewLine.ToString() + Environment.NewLine.ToString() + logZaposlenik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Metoda metoda = new Metoda();
                nazmaila = label1.Text;
                sifra = textBox1.Text;
                mailprim = comboBox1.Text;
                nasmaila = label3.Text;
                tekst = textBox3.Text;
                int p = 0, p1 = 0;
                if (metoda.ProvjeriLozinku(textBox1.Text))
                {
                    p = 1;
                }
                if (metoda.ProvjeriMail(comboBox1.Text))
                {
                    p1 = 1;
                }
                if (p1 == 1 && p == 1)
                {
                    metoda.SaljiMail(nazmaila, sifra, mailprim, nasmaila, tekst);
                }
                else
                {
                    MessageBox.Show("Nemogu poslati mail, provjerite lozinku i e-mail !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nemogu poslati mail, provjerite lozinku i e-mail !");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Metoda metoda1 = new Metoda();
            if (metoda1.ProvjeriLozinku(textBox1.Text))
            {
                picLozYes.Visible = true;
                picLozNo.Visible = false;
            }
            else
            { 
                picLozNo.Visible = true;
                picLozYes.Visible = false;            
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            Metoda metoda2 = new Metoda();
            if (metoda2.ProvjeriMail(comboBox1.Text))
            {
                picMailYes.Visible = true;
                picMailNo.Visible = false;
            }
            else
            {
                picMailNo.Visible = true;
                picMailYes.Visible = false;
            }
        }

       
    }
}
