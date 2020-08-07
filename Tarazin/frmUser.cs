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
    public partial class frmUser : Form
    {
        public string strAction;
        public long ID;

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            if (strAction == "NEWUSER")
            {
                this.btnAction.Text = "ایجاد";
            }else
            {
                this.btnAction.Text = "بروزرسانی";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string strUsername;
            string strSQL;

            if(strAction=="NEWUSER")
            {
                strUsername = this.txtUsername.Text.ToString();
                strSQL = "SELECt * FROM Users WHERE uname='{0}'";
                strSQL = string.Format(strSQL, strUsername);
                DataTable result = new DataTable();
                result = G.SelectData(strSQL);
                if (result.Rows.Count > 0)
                {
                    this.lblRepeatitive.Visible = true;
                }else
                {
                    this.lblRepeatitive.Visible = false;
                }

            }
        }

        private bool ValidateFields()
        {
            if (this.txtfirstname.Text == "")
            {
                MessageBox.Show("فیلد نام خالی است");
                return false;
            }

            if (this.txtLastname.Text == "")
            {
                MessageBox.Show("فیلد نام خانوادگی خالی است");
                return false;
            }
            if (this.txtUsername.Text == "")
            {
                MessageBox.Show("فیلد نام کاربری خالی است");
                return false;
            }
            if (this.txtPassword.Text == "")
            {
                MessageBox.Show("فیلد کلمه عبور خالی است");
                return false;
            }

            if (this.lblRepeatitive.Visible == true)
            {
                MessageBox.Show("نام کاربری تکراری است");
                return false;
            }

            return true;

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string strSQL;

            string strFirstname;
            string strLastname;
            string strUsername;
            string strPassword;
            string strAccessLevel;
            string strActive;


            if (ValidateFields() == false)
            {
                return;
            }

            if (strAction == "NEWUSER")
            {

                strFirstname = this.txtfirstname.Text.ToString();
                strLastname = this.txtLastname.Text.ToString();
                strUsername = this.txtUsername.Text.ToString();
                strPassword = this.txtPassword.Text.ToString();
                strAccessLevel = this.cmbAccessLevel.Text.ToString();
                strActive = this.cmbUserActive.Text.ToString();

                strSQL = "INSERT INTO Users (fname, lname, uname, pass, role, active) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                strSQL = string.Format(strSQL, strFirstname, strLastname, strUsername, strPassword, strAccessLevel, strActive);
                G.DoCommand(strSQL);
                Close();

            }
            else
            {
                strFirstname = this.txtfirstname.Text.ToString();
                strLastname = this.txtLastname.Text.ToString();
                strPassword = this.txtPassword.Text.ToString();
                strAccessLevel = this.cmbAccessLevel.Text.ToString();
                strActive = this.cmbUserActive.Text.ToString();

                strSQL = "UPDATE Users SET fname='{0}', lname='{1}', pass='{2}', role='{3}', active='{4}' WHERE id={5}";
                strSQL = string.Format(strSQL, strFirstname, strLastname, strPassword, strAccessLevel, strActive, ID);
                G.DoCommand(strSQL);
                Close();
            }
        }
    }
}
