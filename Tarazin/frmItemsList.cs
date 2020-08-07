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
    public partial class frmItemsList : Form
    {
        public frmItemsList()
        {
            InitializeComponent();
        }

        private void frmItemsList_Load(object sender, EventArgs e)
        {
            string strSQL;
            strSQL = "SELECT * FROM Items ORDER BY Code";
            this.dataGridView1.DataSource= G.SelectData(strSQL);
            FormatDataGrid();
        }

        private void FormatDataGrid()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].HeaderText = "کد کالا";
            this.dataGridView1.Columns[1].Width = 90;
            this.dataGridView1.Columns[2].HeaderText = "نام کالا";
            this.dataGridView1.Columns[2].Width = 220;
            this.dataGridView1.Columns[3].HeaderText = "قیمت واحد (ریال)";
            this.dataGridView1.Columns[3].Width = 130;
            this.dataGridView1.Columns[3].DefaultCellStyle.Format = "##,0";
            //this.dataGridView1.Columns[4].HeaderText = "ورن واحد (کیلوگرم)";
            //this.dataGridView1.Columns[4].Width = 130;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("", 10);

        }

        private void ShowAll()
        {
            string strSQL;
            strSQL = "SELECT * FROM Items ORDER BY Code";
            this.dataGridView1.DataSource = G.SelectData(strSQL);
            FormatDataGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strSQL;
            string strCode;
            string strName;

            strCode = this.txtCode.Text.ToString();
            strName = this.txtName.Text.ToString();

            strSQL = "SELECt * FROM Items Where code LIKE '%{0}%' AND name LIKE '%{1}%'";
            strSQL = string.Format(strSQL, strCode, strName);
            this.dataGridView1.DataSource=G.SelectData(strSQL);
            FormatDataGrid();
        }

        private void btnShowAllItems_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            long ID;
            string strSQL;

            if(this.dataGridView1.Rows.Count != 0)
            {
                if (MessageBox.Show("آیا از حذف کالا اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ID = long.Parse(this.dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                    strSQL = "DELETE FROM items WHERE id = {0}";
                    strSQL = string.Format(strSQL, ID);
                    G.DoCommand(strSQL);
                    ShowAll();
                }
                else
                {
                    MessageBox.Show("هیچ رکوردی وجود ندارد", "پیام", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem fo = new frmAddItem();
            fo.ShowDialog();
            ShowAll();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            
            if(this.dataGridView1.Rows.Count != 0)
            {
                frmEditItem fo = new frmEditItem();
                fo.ID = long.Parse(this.dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                fo.txtCode.Text= this.dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtName.Text= this.dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                fo.txtUnitPrice.Text = this.dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                
                fo.ShowDialog();
            }
            else
            {
                MessageBox.Show("هیج رکوردی وجود ندارد");
            }
            ShowAll();
        }
    }
}
