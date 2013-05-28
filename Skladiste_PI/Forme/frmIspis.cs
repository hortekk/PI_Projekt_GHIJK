using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_PI
{
    public partial class frmIspis : Form
    {
        public frmIspis()
        {
            InitializeComponent();
        }

        private void frmIspis_Load(object sender, EventArgs e)
        {

            this.report.RefreshReport();
        }
    }
}
