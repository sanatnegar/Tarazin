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
            ShowLast100Invoices();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowLast100Invoices()
        {
            string strSQL= "SELECT * FROM Invoices ORDER BY id DESC";
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            if (dt.Rows.Count > 0)
            {
                this.dataGridView1.DataSource = dt;

                this.dataGridView1.Columns[0].Visible = false; // ID
                this.dataGridView1.Columns[1].HeaderText = "شماره فاکتور";
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].HeaderText = "کاربر";
                this.dataGridView1.Columns[4].Visible = false;
                this.dataGridView1.Columns[5].HeaderText = "نام مشتری";
                this.dataGridView1.Columns[6].HeaderText = "تاریخ";
                this.dataGridView1.Columns[7].HeaderText = "مالیات(ریال)";
                this.dataGridView1.Columns[8].HeaderText = "مبلغ";

            }else
            {
                MessageBox.Show("هیچ فاکتوری ثبت نشده است", "خطا");
            }
        }

        private void btnLast100Invoices_Click(object sender, EventArgs e)
        {
            ShowLast100Invoices();
        }

        private void btnShowEditInvoiceInfo_Click(object sender, EventArgs e)
        {
            int  intRow;
            intRow = dataGridView1.CurrentRow.Index;

            if(dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    frmInvoiceInfo fo = new frmInvoiceInfo();

                    fo.strAction = "EDITINVOICE";
                    fo.ID = long.Parse(dataGridView1[0, intRow].Value.ToString());
                    fo.txtInvoiceNumber.Text = dataGridView1[1, intRow].Value.ToString();
                    fo.txtCustomerCode.Text = GetCustomerCodeByID(long.Parse(dataGridView1[4, intRow].Value.ToString()));
                    fo.txtFDate.Text = dataGridView1[6, intRow].Value.ToString();

                    double dblTax = double.Parse(dataGridView1[7, intRow].Value.ToString());
                    fo.txtTax.Text = dblTax.ToString("#,##");

                    double dblPrice =double.Parse(dataGridView1[8, intRow].Value.ToString());
                    fo.txtPrice.Text = dblPrice.ToString("#,##");

                    fo.ShowDialog();
                    ShowLast100Invoices();
                }else
                {
                    MessageBox.Show("لطفا یک فاکتور را از جدول انتخاب کنید", "خطا");
                }
            }
        }

        private string GetCustomerCodeByID(long lngID)
        {
            string strCustomerCode;
            string strSQL = "SELECT * FROM Customers WHERE id = {0}";
            strSQL = string.Format(strSQL, lngID.ToString());
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            strCustomerCode = dt.Rows[0][1].ToString();
            return strCustomerCode;
        }

        private void btnShowEditInvoiceItems_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frmInvoiceItemsList fo = new frmInvoiceItemsList();
                int intRow = dataGridView1.CurrentRow.Index;
                fo.Invoice_ID = long.Parse(this.dataGridView1[0, intRow].Value.ToString());
                fo.txtInvoiceNo.Text = this.dataGridView1[1, intRow].Value.ToString();
                fo.txtInvoiceDate.Text = this.dataGridView1[6, intRow].Value.ToString();
                fo.txtCustomerFullName.Text = this.dataGridView1[5, intRow].Value.ToString();
                long lngCustomerID = long.Parse(this.dataGridView1[4, intRow].Value.ToString());
                string strCustomerCode = GetCustomerCodeByID(lngCustomerID);
                fo.txtCutomerCode.Text = strCustomerCode;
                fo.ShowDialog();
                
            }





        }
    }
}
