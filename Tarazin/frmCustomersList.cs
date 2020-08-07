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
    public partial class frmCustomersList : Form
    {
        public frmCustomersList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
           
            frmCustomer fo = new frmCustomer();
            fo.strAction = "NEWCUSTOMER";
            fo.ShowDialog();

            ShowAllCustomers();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                frmCustomer fo = new frmCustomer();
                fo.strAction = "EDITCUSTOMER";

                //fo.cmbAccessLevel.SelectedIndex = 0;


                fo.txtCode.ReadOnly = true;

                fo.ID = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                fo.txtCode.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtFirstname.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtLastname.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtTel1.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtTel2.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtCell1.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtCell2.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtEmail.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtWebsite.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();

                fo.ShowDialog();
                ShowAllCustomers();
            }
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            ShowAllCustomers();
            ApplyAccessLevel(G.strCurrentUserLevel);
        }

        private void ApplyAccessLevel(string strUserLevel)
        {
            if (G.strCurrentUserLevel == "user")
            {
                this.btnAddCustomer.Enabled = false;
                this.btnEditCustomer.Enabled = false;
                this.btnDeleteCustomer.Enabled = false;
            }
        }

        private void ShowAllCustomers()
        {
            string strSQL = "";
            strSQL = "SELECT * FROM Customers";

            DataTable dt = new DataTable();
            dt = G.SelectData(strSQL);
            this.dataGridView1.DataSource = dt;

            FormatDataGrid();
            
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            long customer_id;
            string strSQL;

            if (dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("آیا از حذف این مشتری اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    customer_id = long.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    strSQL = "DELETE FROM Customers WHERE id={0}";
                    strSQL = string.Format(strSQL, customer_id);
                    G.DoCommand(strSQL);
                }

                ShowAllCustomers();
            }
            else
            {
                MessageBox.Show("هیچ رکوردی وجود ندارد");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSQL;
            string strFirstname;
            string strLastname;

            strFirstname = this.txtFirstname.Text.ToString();
            strLastname = this.txtLastname.Text.ToString();

            strSQL = "SELECt * FROM Customers Where fname LIKE '%{0}%' AND lname LIKE '%{1}%'";
            strSQL = string.Format(strSQL, strFirstname, strLastname);
            this.dataGridView1.DataSource = G.SelectData(strSQL);
            FormatDataGrid();
        }

        private void FormatDataGrid()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].HeaderText = "کد مشتری";
            this.dataGridView1.Columns[2].HeaderText = "نام";
            this.dataGridView1.Columns[3].HeaderText = "نام خانوادگی";
            this.dataGridView1.Columns[4].HeaderText = "تلفن 1";
            this.dataGridView1.Columns[5].HeaderText = "تلفن 2";
            this.dataGridView1.Columns[6].HeaderText = "همراه 1";
            this.dataGridView1.Columns[7].HeaderText = "همراه 2";
            this.dataGridView1.Columns[8].HeaderText = "ایمیل";
            this.dataGridView1.Columns[9].HeaderText = "آدرس سایت";
        }

        private void btnShowAllCustomer_Click(object sender, EventArgs e)
        {
            ShowAllCustomers();
        }
    }
}
