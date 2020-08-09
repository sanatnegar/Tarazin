using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace Tarazin
{
    public static class G
    {
        public static long lngCurrentUserId;
        public static string strCurrentUserFirstname;
        public static string strCurremtUserLastname;
        public static string strCurrentUsername;
        public static string strCurrentUserLevel;

        public static String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Tarazin.accdb;Jet OLEDB:Database Password=12345678;";

        public static double dblCurrentWeight;

        public static string TodayJalaliDate()
        {
            string strDay;
            string strMonth;
            string strYear;
            PersianCalendar pc = new PersianCalendar();
            DateTime todayDate = DateTime.Now;

            strYear = pc.GetYear(todayDate).ToString();
            strMonth = pc.GetMonth(todayDate).ToString();
            strDay = pc.GetDayOfMonth(todayDate).ToString();

            if (strMonth.Length < 2)
            {
                strMonth = "0" + strMonth;
            }

            if (strDay.Length < 2)
            {
                strDay = "0" + strDay;
            }


            string strToday = "{0}/{1}/{2}";
            strToday = string.Format(strToday,strYear,strMonth ,strDay );
            return strToday;
        }


        public static void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
        }

        public static string SkipComma(string str)
        {
            string[] ss = null;
            string strnew = "";
            if (str == "")
            {
                strnew = "0";
            }
            else
            {
                ss = str.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    strnew += ss[i];
                }
            }
            return strnew;
        }

        public static bool HasSerialPort()
        {
            string[] ports = SerialPort.GetPortNames();

            if (ports.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void CreateDB()
        {
            String password = "12345678";
            String connectionString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Tarazin.accdb;Jet OLEDB:Database Password=" + password + ";";

            ADOX.Catalog cat = new ADOX.Catalog();
            cat.Create(connectionString);

            //Now Close the database
            ADODB.Connection con = cat.ActiveConnection as ADODB.Connection;
            if (con != null)
            {
                con.Close();
            }

            MessageBox.Show("پایگاه داده ایجاد شد");

            //Create Tables
           
            String createItemsTable = "CREATE TABLE Items ("
              + "id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL,"
              + " code LONGTEXT,"
              + " name LONGTEXT,"
              + " unit_price DOUBLE"
              + ")";

            String createUsersTable = "CREATE TABLE Users ("
              + "id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL,"
              + " fname LONGTEXT,"
              + " lname LONGTEXT,"
              + " uname LONGTEXT,"
              + " pass LONGTEXT,"
              + " role LONGTEXT,"
              + " active LONGTEXT"
              + ")";

            String createCustomersTable = "CREATE TABLE Customers ("
              + "id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL,"
              + " code LONGTEXT,"
              + " fname LONGTEXT,"
              + " lname LONGTEXT,"
              + " tel1 LONGTEXT,"
              + " tel2 LONGTEXT,"
              + " cell1 LONGTEXT,"
              + " cell2 LONGTEXT,"
              + " email LONGTEXT,"
              + " website LONGTEXT"
              + ")";

            String createInvoicesTable = "CREATE TABLE Invoices ("
             + "id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL,"
             + " invoice_no INTEGER,"
             + " user_id INTEGER,"
             + " customer_id INTEGER,"
             + " invoice_date LONGTEXT,"
             + " invoice_time LONGTEXT,"
             + " total_tax DOUBLE,"
             + " total_price DOUBLE"
             + ")";

            String createInvoiceDetailsTable = "CREATE TABLE Invoice_Detailes ("
             + "id INTEGER IDENTITY(1,1) PRIMARY KEY NOT NULL,"
             + " invoice_id LONGTEXT,"
             + " code LONGTEXT,"
             + " name LONGTEXT,"
             + " unit_price DOUBLE,"
             + " weight DOUBLE,"
             + " price DOUBLE"
             + ")";




            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand dbCmd = new OleDbCommand();

            try
            {
                //Open Database Connection
                conn.Open();

                //MessageBox.Show(createSQL);
                dbCmd.Connection = conn;

                dbCmd.CommandText = createItemsTable;
                dbCmd.ExecuteNonQuery();

                dbCmd.CommandText = createCustomersTable;
                dbCmd.ExecuteNonQuery();

                dbCmd.CommandText = createUsersTable;
                dbCmd.ExecuteNonQuery();

                dbCmd.CommandText = createInvoicesTable;
                dbCmd.ExecuteNonQuery();

                dbCmd.CommandText = createInvoiceDetailsTable;
                dbCmd.ExecuteNonQuery();

                MessageBox.Show("جداول مربوطه در پایگاه داده ایجاد شد");          

                // Add Super Admin as the first user to the database
                String query = "SELECT * FROM Users";
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                OleDbCommandBuilder cmB = new OleDbCommandBuilder(da);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                da.Fill(ds, "Users");
                DataRow row = ds.Tables["Users"].NewRow();
                row["fname"] = "مدیر";
                row["lname"] = "کل";
                row["uname"] = "superadmin";
                row["pass"] = "12345678";
                row["role"] = "superadmin";
                row["active"] = "بله";
                ds.Tables["Users"].Rows.Add(row);
                da.Update(ds, "Users");

                // Add Passerby as the first customer in the database
                query = "SELECT * FROM Customers";
                ds = new DataSet();
                da = new OleDbDataAdapter(query, conn);
                cmB = new OleDbCommandBuilder(da);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                da.Fill(ds, "Customers");
                row = ds.Tables["Customers"].NewRow();
                row["code"] = "1";
                row["fname"] = "";
                row["lname"] = "رهگذر";
                row["tel1"] = "";
                row["tel2"] = "";
                row["cell1"] = "";
                row["cell2"] = "";
                row["email"] = "";
                row["website"] = "";
                ds.Tables["Customers"].Rows.Add(row);
                da.Update(ds, "Customers");
                
                conn.Close();

                //MessageBox.Show("Data inserted into the Database");
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static DataTable SelectData(string strSQL)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            DataTable dt = new DataTable();

            con.ConnectionString = constr;
            con.Open();
            cmd.Connection = con;
            da.SelectCommand = cmd;

            cmd.CommandText = strSQL;
            da.Fill(dt);
            con.Close();
            con.Dispose();

            return dt;
        }

        public static void DoCommand(string strSQL)
        {
            OleDbConnection con = new OleDbConnection();     
            OleDbCommand cmd = new OleDbCommand();
           
            con.ConnectionString = constr;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }

        public static double DoCommandScalar(string strSQL)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            double output;

            con.ConnectionString = constr;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = strSQL;
            output = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            con.Dispose();

            return output;

        }
    }
}
