using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarazin
{
    public partial class frmInvoicesList : Form
    {
        public frmInvoicesList()
        {
            InitializeComponent();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            frmInvoiceInfo fo = new frmInvoiceInfo();
            fo.strAction = "NEWINVOICE";
            fo.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
