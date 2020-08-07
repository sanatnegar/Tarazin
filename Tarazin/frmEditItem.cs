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
    public partial class frmEditItem : Form
    {
        public long ID;
        public frmEditItem()
        {
            InitializeComponent();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strSQL;
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
                       

            strSQL = "UPDATE Items SET name='{0}', unit_price={1} WHERE id={2}";
            strSQL = string.Format(strSQL, strName, lngUnitPrice.ToString(), ID);

            G.DoCommand(strSQL);
            Close();
        }
               
    }
}
