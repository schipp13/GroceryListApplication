using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GroceryListApplication
{
    class Event
    {
        public string Connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDataBase.mdb"; //GET DATABASE CONNECTION
        public OleDbConnection cn;

        //CHECK DATABASE CONNECTION STATUS
        public void Connected()
        {
            cn = new OleDbConnection(Connection); // GET SQL CONNECTION STATUS

            //CHECKS IF SQL CONNECTION IS CONNECTED
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }

        //INSERTING AND UPDATING EVENTS
        public bool InsertUpdateData(string sql)
        {
            Connected();
            OleDbCommand cmd = new OleDbCommand(sql, cn);

            return cmd.ExecuteNonQuery() > 0;
        }

        //Validate Date
        public bool dateValidation(DateTime start, DateTime end)
        {
            DateTime currentdate = DateTime.Now;

            string date = currentdate.ToShortDateString();
            if (start < Convert.ToDateTime(date))
            {
                MessageBox.Show("Can't add an event which start date passby the current date...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (end < start)
            {
                MessageBox.Show("Can't add an event which end date passby the start date...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (start >= Convert.ToDateTime(date) && end >= start)
            {
                return false;
            }
            return true;
        }

        public DataTable QueryAsDataTable(string sql)
        {
            Connected();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];
        }
    }
}
