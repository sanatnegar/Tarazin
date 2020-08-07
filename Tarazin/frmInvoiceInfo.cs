using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
            string strSQL = "";

            if (strAction == "NEWINVOICE")
            {

            }
            else
            {

            }
        }

        private void frmInvoiceInfo_Load(object sender, EventArgs e)
        {
            if(strAction == "NEWINVOICE")
            {
                this.btnAction.Text = "ایجاد";
                this.txtInvoiceNumber.Text = GetInvoiceNumber().ToString();
                this.txtFDate.Text = G.TodayJalaliDate();
                this.lblTax.Visible = false;
                this.lblPrice.Visible = false;
                this.txtTax.Visible = false;
                this.txtPrice.Visible = false;
                
            }else
            {
                this.btnAction.Text = "بروزرسانی";
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateFields()
        {
            return true;
        }

        private long GetInvoiceNumber() {
            long lngInvoiceNo;
            string strSQL = "SELECT * from Invoices";
            DataTable dt = new DataTable();
            dt= G.SelectData(strSQL);
            if (dt.Rows.Count == 0)
            {
                return 1;
            }else
            {
                strSQL = "SELECT * FROM Invoices ORDER BY id DESC";
                dt = G.SelectData(strSQL);
                lngInvoiceNo = long.Parse(dt.Rows[0][1].ToString()) + 1;
                return lngInvoiceNo;

            }
            
        }

    }
}
