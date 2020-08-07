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
using System.IO.Ports;

namespace Tarazin
{
    public partial class frmMain : Form
    {
        
        string strRXD;
        public bool SwitchUser { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen==false)
            {
                if(lblWeight.Text=="")
                {
                    lblWeight.Text = "DISC";
                }
                else
                {
                    lblWeight.Text = "";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            fillSerialPorts();
            fillBaudRate();
            btnDisconnect.Enabled = false;
            ApplyAccessLevel();
            lblCurrentUser.Text = G.strCurrentUserFirstname + " " + G.strCurremtUserLastname + "[" + G.strCurrentUserLevel + "]";

            
        }

        private void fillSerialPorts()
        {
            foreach(string strCOMM in SerialPort.GetPortNames())
            {
                this.cmbSerialPorts.Items.Add(strCOMM);
            }

            this.cmbSerialPorts.SelectedIndex = 0;

        }

        private void fillBaudRate()
        {
            cmbBaudRate.Items.Add("110");
            cmbBaudRate.Items.Add("300");
            cmbBaudRate.Items.Add("1200");
            cmbBaudRate.Items.Add("2400");
            cmbBaudRate.Items.Add("4800");
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
           
            cmbBaudRate.SelectedIndex = 5;

        }

        private void ApplyAccessLevel()
        {
            if(G.strCurrentUserLevel =="user")
            {
                this.btnUsers.Enabled = false;
                this.btnBackDb.Enabled = false;
                this.btnRestoreDatabase.Enabled = false;

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(this.cmbSerialPorts.Text != "")
            {
                try
                {
                    this.btnDisconnect.Enabled = true;
                    this.btnConnect.Enabled = false;
                    this.cmbBaudRate.Enabled = false;
                    this.cmbSerialPorts.Enabled = false;

                    this.serialPort1.BaudRate = Convert.ToInt32(this.cmbBaudRate.Text);
                    this.serialPort1.PortName = this.cmbSerialPorts.Text.ToString();
                    this.serialPort1.Open();
                    this.serialPort1.DiscardInBuffer();
                    this.serialPort1.DiscardOutBuffer();

                }
                catch
                {
                    MessageBox.Show("خطا در باز کردن پورت سریال", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.btnConnect.Enabled = true;
            this.btnDisconnect.Enabled = false;
            this.cmbBaudRate.Enabled = true;
            this.cmbSerialPorts.Enabled = true;
            this.serialPort1.Close();

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
            strRXD = serialPort1.ReadLine();
            this.Invoke(new EventHandler(DisplayData));

               
        }

        private void DisplayData(object sender, EventArgs e)
        {
            try
            {
                int start = strRXD.IndexOf("WN");
                string strWeight = strRXD.Substring(start + 2, 7);
                this.lblWeight.Text = strWeight;
                G.dblCurrentWeight = Convert.ToDouble(strWeight);

            }
            catch
            {
                G.dblCurrentWeight = 0;

            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddItem fo = new frmAddItem();
            fo.ShowDialog();
        }

        private void btnShowItemsList_Click(object sender, EventArgs e)
        {
            frmItemsList fo = new frmItemsList();
            fo.ShowDialog();
        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            frmLogin fo = new frmLogin();
            this.Hide();
            fo.ShowDialog();
            this.Close();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsersList fo = new frmUsersList();
            fo.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomersList fo = new frmCustomersList();
            fo.ShowDialog();

        }
    }
}
