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
    public partial class frmUnosDobavljaca : Form
    {
        private PoslovniPartner dobavljac = null;

        public frmUnosDobavljaca()
        {
            InitializeComponent();
        }

        public frmUnosDobavljaca(PoslovniPartner odabraniDobavljac)
        {
            InitializeComponent();
            dobavljac = odabraniDobavljac;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
