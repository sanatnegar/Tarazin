using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tarazin
{
    public partial class frmLogin : Form
    {
        //public bool UserAuthenticated { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (G.HasSerialPort()!=true)
            {
                DialogResult dialogResult = MessageBox.Show("هیح درگاه سریالبی پیدا نشد. می خواهید ادامه دهید؟", "خطا", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    Close();
                }

            }

            // Check if database file exist in the path
            if (File.Exists(Application.StartupPath + "\\Tarazin.accdb"))
            {
                //MessageBox.Show("Database exists in the right path.");

            }
            else
            {
                G.CreateDB();
                MessageBox.Show("Database created.");
            }

            // Fill Users Combo Box

            DataTable dtUsers = new DataTable();
            string query = "SELECT * FROM Users";
            string strUsername;

            dtUsers = G.SelectData(query);
            int i;
            for(i=0; i<=dtUsers.Rows.Count -1; i++)
            {
                strUsername = Convert.ToString(dtUsers.Rows[i][3]);
                cmbUsernames.Items.Add(strUsername);
            }

            this.cmbUsernames.SelectedIndex = -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.cmbUsernames.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری را انتخاب کنید");
                return;
            }
            

            string Username;
            string Password;
            string dbPassword;
            string strSQL;
            Username = Convert.ToString(this.cmbUsernames.Text);
            Password = Convert.ToString(this.txtPassword.Text);
            //MessageBox.Show(Username + " - " + Password);

            DataTable dtUser = new DataTable();
            strSQL = "SELECT * FROM Users WHERE uname='" + Username + "'";
            dtUser = G.SelectData(strSQL);
            dbPassword = Convert.ToString(dtUser.Rows[0][4]);

            if (Password == dbPassword)
            {
                //UserAuthenticated = true;
                G.lngCurrentUserId = long.Parse(Convert.ToString(dtUser.Rows[0][0]));
                G.strCurrentUserFirstname = Convert.ToString(dtUser.Rows[0][1]);
                G.strCurremtUserLastname = Convert.ToString(dtUser.Rows[0][2]);
                G.strCurrentUsername = Convert.ToString(dtUser.Rows[0][3]);
                G.strCurrentUserLevel= Convert.ToString(dtUser.Rows[0][5]);

                frmMain fo = new frmMain();
                this.Hide();
                fo.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("کلمه عبور صحیح نیست");
            }
            

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null,null);

            }

        }
    }
}
