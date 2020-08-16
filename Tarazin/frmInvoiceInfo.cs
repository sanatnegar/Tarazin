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
using System.Threading;

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
            long lngInvoiceNo;
            long lngUserId;
            string strCurrentUname;
            long lngCutomerId;
            string strCustomerFullName;
            string strInvoiceDate;
            double dblTotalTax;
            double dblTotalPrice;

            if (ValidateFields() == false)
            {
                return;
            }

            if (strAction == "NEWINVOICE")
            {
                lngInvoiceNo = long.Parse(this.txtInvoiceNumber.Text);
                lngUserId = G.lngCurrentUserId;
                strCurrentUname = G.strCurrentUsername;
                lngCutomerId = GetCustomerIdByCode(this.txtCustomerCode.Text);
                strCustomerFullName = txtCustomerFullName.Text.ToString();
                strInvoiceDate = txtFDate.Text.ToString();
                dblTotalPrice = 0;
                dblTotalTax = 0;
                                              //    0          1       2         3               4              5          6          7
                strSQL = "INSERT INTO Invoices (invoice_no, user_id, uname, customer_id, customer_full_name, invoice_date, total_tax, total_price) VALUES ({0}, {1}, '{2}', {3}, '{4}', '{5}', {6}, {7})";
                strSQL = string.Format(strSQL, lngInvoiceNo.ToString(), lngUserId.ToString(), strCurrentUname,  lngCutomerId.ToString(), strCustomerFullName, strInvoiceDate, dblTotalTax.ToString(), dblTotalPrice.ToString());
                //MessageBox.Show(strSQL);
                G.DoCommand(strSQL);
                Close();
            }
            else
            {
                lngCutomerId = GetCustomerIdByCode(this.txtCustomerCode.Text);
                strCustomerFullName = txtCustomerFullName.Text.ToString();
                strInvoiceDate = txtFDate.Text.ToString();

                strSQL = "UPDATE Invoices SET customer_full_name='{0}', invoice_date='{1}' WHERE id={2}";
                strSQL = string.Format(strSQL, strCustomerFullName, strInvoiceDate, ID);
                G.DoCommand(strSQL);
                Close();
            }
        }

        private void frmInvoiceInfo_Load(object sender, EventArgs e)
        {

            CultureInfo culture = new CultureInfo("en-US");

            if (strAction == "NEWINVOICE")
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
            if (txtFDate.Text == "")
            {
                MessageBox.Show("فیلد تاریخ خالی است", "خطا");
                return false;
            }
            if (txtCustomerCode.Text == "")
            {
                MessageBox.Show("کد مشتری را وارد کنید", "خطا");
                return false;
            }
            if (txtCustomerFullName.Text == "")
            {
                MessageBox.Show("کد مشتری صحیح نیست","خطا");
                return false;
            }

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

        private long GetCustomerIdByCode(string strCode)
        {
            long lngCustomerID;
            string strSQL = "SELECT * FROM Customers WHERE code = '{0}'";
            strSQL = string.Format(strSQL, strCode);
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            lngCustomerID = long.Parse(dt.Rows[0][0].ToString());
            return lngCustomerID;
        }

        private string GetCustomerFullNameByCode(string strCode)
        {
            string Firstname = "";
            string Lastname = "";
            string strSQL = "SELECT * FROM Customers WHERE code = '{0}'";
            strSQL = string.Format(strSQL, strCode);
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            if(dt.Rows.Count == 0)
            {
                return "";
            }else
            {
                Firstname = dt.Rows[0][2].ToString();
                Lastname = dt.Rows[0][3].ToString();
                return Firstname + " " + Lastname;
            }
        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            if(this.txtCustomerCode.Text != "")
            {
                this.txtCustomerFullName.Text = GetCustomerFullNameByCode(this.txtCustomerCode.Text);
            }else
            {
                this.txtCustomerFullName.Text = "";
            }
        }
    }
}
