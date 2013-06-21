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
    public partial class frmUnosKupaca : Form
    {
        private PoslovniPartner kupac = null;

        public frmUnosKupaca()
        {
            InitializeComponent();
        }
        public frmUnosKupaca(PoslovniPartner odabraniKupac)
        {
            InitializeComponent();
            kupac = odabraniKupac;
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnosKupaca_Load(object sender, EventArgs e)
        {

        }
    }
}
