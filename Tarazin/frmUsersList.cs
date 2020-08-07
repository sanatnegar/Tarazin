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
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmUser fo = new frmUser();
            fo.strAction = "NEWUSER";
            fo.cmbAccessLevel.Items.Add("user");
            fo.cmbAccessLevel.Items.Add("admin");
            fo.cmbAccessLevel.SelectedIndex = 0;
            fo.cmbUserActive.Items.Add("بله");
            fo.cmbUserActive.Items.Add("خیر");
            fo.cmbUserActive.SelectedIndex = 0;
            fo.ShowDialog();
            ShowAllUsers(G.strCurrentUserLevel);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            bool blnSuperAdmin=false;

            if (dataGridView1.Rows.Count != 0)
            {
                frmUser fo = new frmUser();
                fo.strAction = "EDITUSER";
                fo.cmbAccessLevel.Items.Add("user");
                fo.cmbAccessLevel.Items.Add("admin");

                //fo.cmbAccessLevel.SelectedIndex = 0;

                fo.cmbUserActive.Items.Add("بله");
                fo.cmbUserActive.Items.Add("خیر");

                fo.txtUsername.ReadOnly = true;

                fo.ID = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                fo.txtfirstname.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtLastname.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtUsername.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtPassword.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();

                if (dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString() == "user")
                {
                    fo.cmbAccessLevel.SelectedIndex = 0;
                } else if (dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString() == "admin")
                {
                    fo.cmbAccessLevel.SelectedIndex = 1;
                } else
                {
                    fo.cmbAccessLevel.Items.Add("superadmin");
                    fo.cmbAccessLevel.SelectedIndex = 2;
                    fo.cmbAccessLevel.Enabled = false;
                    blnSuperAdmin = true;
                }

                if (dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString() == "بله")
                {
                    fo.cmbUserActive.SelectedIndex = 0;
                }
                else
                {
                    fo.cmbUserActive.SelectedIndex = 1;
                }

                if (blnSuperAdmin == true)
                {
                    fo.cmbUserActive.Enabled = false;
                }

                fo.ShowDialog();
                ShowAllUsers(G.strCurrentUserLevel);
            }
        }

        private void ApplyAccessLevel()
        {
           
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {

            ApplyAccessLevel();
            ShowAllUsers(G.strCurrentUserLevel);

        }

        private void ShowAllUsers(string strCurrentAccessLevel)
        {
            string strSQL="";

            
            if (strCurrentAccessLevel == "admin")
            {
                strSQL = "SELECT * FROM Users WHERE role = 'user'";

            }
            if (strCurrentAccessLevel == "superadmin")
            {
                strSQL = "SELECT * FROM Users";
            }

             
            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            this.dataGridView1.DataSource = dt;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            this.dataGridView1.Columns[0].Visible = false;

            this.dataGridView1.Columns[1].HeaderText = "نام";
            this.dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            this.dataGridView1.Columns[2].Width = 140;
            this.dataGridView1.Columns[3].HeaderText = "نام کاربری";
            this.dataGridView1.Columns[4].HeaderText = "کلمه عبور";
            this.dataGridView1.Columns[5].HeaderText = "دسترسی";
            this.dataGridView1.Columns[6].HeaderText = "فعال";

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            long user_id;
            string strSQL;

            if (dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("آیا از حذف این کاربر اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    user_id = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    strSQL = "DELETE FROM Users WHERE id={0}";
                    strSQL = string.Format(strSQL, user_id);
                    G.DoCommand(strSQL);

                }

                ShowAllUsers(G.strCurrentUserLevel);
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد");
            }



        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllUsers(G.strCurrentUserLevel);
        }
    }
}
