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
    public partial class frmInvoiceItemsList : Form
    {
        public long Invoice_ID;

        public frmInvoiceItemsList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvoiceAddItem_Click(object sender, EventArgs e)
        {
            frmInvoiceItem fo = new frmInvoiceItem();
            fo.strAction = "NEWITEM";
            fo.Invoice_ID = long.Parse(this.txtInvoiceNo.Text.ToString());
            fo.ShowDialog();
            RefreshInvoiceList(Invoice_ID);
        }

        private void btnInvoiceEditItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount != 0)
            {
                if (this.dataGridView1.SelectedRows.Count != 0)
                {
                    frmInvoiceItem fo = new frmInvoiceItem();
                    fo.strAction = "EDITITEM";
                    fo.ShowDialog();
                    RefreshInvoiceList(Invoice_ID);
                }
            }
        }

        private void RefreshInvoiceList(long Invoice_ID)
        {
            string strSQL = "SELECT * FROM Invoice_Detailes WHERE invoice_id = {0}";
            strSQL = string.Format(strSQL, Invoice_ID.ToString());
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false; // ID
            this.dataGridView1.Columns[1].Visible = false; // Invoice ID
            this.dataGridView1.Columns[2].HeaderText = "کد کالا";
            this.dataGridView1.Columns[3].HeaderText = "نام کالا";
            this.dataGridView1.Columns[4].HeaderText = "قیمت واحد";
            this.dataGridView1.Columns[5].HeaderText = "ورن";
            this.dataGridView1.Columns[6].HeaderText = "قیمت";

        }

        private void frmInvoiceItemsList_Load(object sender, EventArgs e)
        {
            RefreshInvoiceList(Invoice_ID);
        }
    }
}
