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
    public partial class frmCustomer : Form
    {
        public string strAction;
        public long ID;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if (strAction == "NEWCUSTOMER")
            {
                this.btnAction.Text = "ایجاد";
            }
            else
            {
                this.btnAction.Text = "بروزرسانی";
                this.txtCode.ReadOnly = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string strSQL = "";

            string strCode = "";
            
            string strFullName = "";
            string strTel1 = "";
            string strTel2 = "";
            string strCell1 = "";
            string strCell2 = "";
            string strEmail = "";
            string strWebsite = "";

            if (ValidateFields() == false)
            {
                return;
            }

            if (strAction == "NEWCUSTOMER")
            {
                strCode = this.txtCode.Text.ToString();
                strFullName = this.txtFullName.Text.ToString();
                strTel1 = this.txtTel1.Text.ToString();
                strTel2 = this.txtTel2.Text.ToString();
                strCell1 = this.txtCell1.Text.ToString();
                strCell2 = this.txtCell2.Text.ToString();
                strEmail = this.txtEmail.Text.ToString();
                strWebsite = this.txtWebsite.Text.ToString();

                strSQL = "INSERT INTO Customers (code, full_name, tel1, tel2, cell1, cell2, email, website) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                strSQL = string.Format(strSQL, strCode, strFullName, strTel1, strTel2, strCell1, strCell2, strEmail, strWebsite);
               
                G.DoCommand(strSQL);
                Close();
            }
            else
            {
               
                
                strFullName = this.txtFullName.Text.ToString();
                strTel1 = this.txtTel1.Text.ToString();
                strTel2 = this.txtTel2.Text.ToString();
                strCell1 = this.txtCell1.Text.ToString();
                strCell2 = this.txtCell2.Text.ToString();
                strEmail = this.txtEmail.Text.ToString();
                strWebsite = this.txtWebsite.Text.ToString();

                strSQL = "UPDATE Customers SET full_name='{0}', tel1='{1}', tel2='{2}', cell1='{3}', cell2='{4}', email='{5}', website='{6}' WHERE id={7}";
                strSQL = string.Format(strSQL, strFullName, strTel1, strTel2, strCell1, strCell2, strEmail, strWebsite, ID);
                G.DoCommand(strSQL);
                Close();
            }

        }

        private bool ValidateFields()
        {
            if (this.txtCode.Text == "")
            {
                MessageBox.Show("فیلد کد مشتری خالی است", "خطا", MessageBoxButtons.OK);
                return false;
            }

            if (this.txtFullName.Text == "")
            {
                MessageBox.Show("فیلد نام خانوادگی خالی است", "خطا", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
