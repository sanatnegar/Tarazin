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
    public partial class frmInvoiceInfo : Form
    {
        public string strAction;
        public long ID;

        public frmInvoiceInfo()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

        }

        private void frmInvoiceInfo_Load(object sender, EventArgs e)
        {
            if(strAction == "NEWINVOICE")
            {
                this.btnAction.Text = "ایجاد";
            }else
            {
                this.btnAction.Text = "بروزرسانی";

            }
        }
    }
}
