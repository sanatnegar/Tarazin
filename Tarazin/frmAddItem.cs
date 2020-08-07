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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strCode;
            string strName;
            long lngUnitPrice;
            

            if (this.txtCode.Text == "")
            {
                MessageBox.Show("فیلد کد کالا خالی است", "خطا", MessageBoxButtons.OK);
                return;
            }

            if (this.txtName.Text == "")
            {
                MessageBox.Show("فیلد نام کالا خالی است", "خطا", MessageBoxButtons.OK);
                return;
            }

            //MessageBox.Show(G.SkipComma(this.txtUnitPrice.Text));

            if (this.txtUnitPrice.Text == "" || Convert.ToInt32(G.SkipComma(this.txtUnitPrice.Text)) == 0)
            {
                MessageBox.Show("فیلد قیمت  خالی یا مقدار آن صفر است", "خطا", MessageBoxButtons.OK);
                return;
            }

            strCode = this.txtCode.Text.ToString();
            strName = this.txtName.Text.ToString();
            lngUnitPrice = long.Parse(G.SkipComma(this.txtUnitPrice.Text));

           string strSQL = "INSERT INTO Items (code, name, unit_price) VALUES('{0}', '{1}', {2})";
            strSQL = string.Format(strSQL, strCode, strName, lngUnitPrice);
            G.DoCommand(strSQL);

            Close();
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            G.OnlyDigits(sender, e);
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            string strSQL = "";
            DataTable dt = new DataTable();

            if (this.txtCode.Text != "")
            {
                strSQL = "SELECT * FROM Items WHERE code = '{0}'";
                strSQL = string.Format(strSQL, this.txtCode.Text.ToString());
                dt = G.SelectData(strSQL);
                if (dt.Rows.Count > 0)
                {
                    this.lblRepeatitive.Visible = true;
                }else
                {
                    this.lblRepeatitive.Visible = false;
                }

            }
        }

       

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtUnitPrice.Text))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                int valueBefore = Int32.Parse(txtUnitPrice.Text, System.Globalization.NumberStyles.AllowThousands);
                txtUnitPrice.Text = String.Format(culture, "{0:N0}", valueBefore);
                txtUnitPrice.Select(txtUnitPrice.Text.Length, 0);
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
