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
    public partial class frmInvoiceItem : Form
    {
        public long ID;
        public long Invoice_ID;
        public string strAction = "";
        private double dblFinishedPrice;


        public frmInvoiceItem()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double dblUnitPrice=0;
            this.txtWeight.Text = G.dblCurrentWeight.ToString();

            if (txtItemUnitPrice.Text != "")
            {
                dblUnitPrice = Double.Parse(this.txtItemUnitPrice.Text.ToString());

            }
            else
            {
                dblFinishedPrice = 0;
            }

           
            dblFinishedPrice = dblUnitPrice * G.dblCurrentWeight;

            this.txtFinishedPrice.Text = dblFinishedPrice.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GetItemNameByCode(string strCode)
        {
            string strSQL = "SELECT name FROM Items WHERE code = '{0}'";
            strSQL = string.Format(strSQL, strCode);
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            if(dt.Rows.Count != 0)
            {
                return dt.Rows[0][0].ToString();

            }else
            {
                return "";
            }
        }

        private string GetItemUnitPriceByCode(string strCode)
        {
            string strSQL = "SELECT unit_price FROM Items WHERE code = '{0}'";
            strSQL = string.Format(strSQL, strCode);
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            if (dt.Rows.Count != 0)
            {
                return dt.Rows[0][0].ToString();

            }
            else
            {
                return "";
            }
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            if (txtItemCode.Text != "")
            {
                this.txtItemName.Text = GetItemNameByCode(txtItemCode.Text.ToString());
                this.txtItemUnitPrice.Text = GetItemUnitPriceByCode(txtItemCode.Text.ToString());
            }else
            {
                this.txtItemName.Text = "";
                this.txtItemUnitPrice.Text = "0";
            }
        }

        private void frmInvoiceItem_Load(object sender, EventArgs e)
        {
            if (strAction == "NEWITEM")
            {
                this.btnAction.Text = "اضافه";

            }else
            {
                this.btnAction.Text = "ویرایش";
            }
        }

        private void txtItemCode_TextChanged_1(object sender, EventArgs e)
        {
            this.txtItemName.Text = GetItemNameByCode(this.txtItemCode.Text);
            this.txtItemUnitPrice.Text = GetItemUnitPriceByCode(this.txtItemCode.Text);
        }
    }
}
