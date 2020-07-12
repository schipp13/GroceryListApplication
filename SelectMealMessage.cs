// Programmer: Saige Chipp
// Date last modified: 7/12/2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using DateTime = System.DateTime;
using System.Runtime.InteropServices;
using Google.Apis.Calendar.v3.Data;

namespace GroceryListApplication
{
    public partial class SelectMealMessage : Form
    {

        public List<FlowLayoutPanel> listFLDay = new List<FlowLayoutPanel>();
        private DateTime currentDate = DateTime.Today;
        Event @meal = new Event();
        public SelectMealMessage()
        {
            InitializeComponent();

            // Grabs meal names and adds them to the combo box
            OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDataBase.mdb");
            OleDbCommand cmd;
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT MealName FROM MealInformation";
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();

           OleDbDataReader drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                mealNameComboBox.Items.Add(drd["MealName"].ToString());

            }
        }

        private void mealInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mealInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mealDatabaseDataSet);

        }

        private void SelectMealMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mealDatabaseDataSet.MealInformation' table. You can move, or remove it, as needed.
            this.mealInformationTableAdapter.Fill(this.mealDatabaseDataSet.MealInformation);

        }

        private void BtnSubmitMeal_Click(object sender, EventArgs e)
        {
            AddAppointmentToFlDay();

        }
     

        private void AddAppointmentToFlDay(int startDayAtFlNumber)
        {

     
       // Creates the Meal for each day in the month
                DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                string sql = $"select * from calendar where startDate between '{startDate.ToShortDateString()}' and '{endDate.ToShortDateString()}'";
                DataTable dt = @meal.QueryAsDataTable(sql);

                foreach (DataRow dr in dt.Rows)
                {
                    DateTime appday = DateTime.Parse(dr["startDate"].ToString());
                    var link = new LinkLabel();
                    link.Tag = dr["id"].ToString();
                    link.Name = $"link{dr["id"]}";
                    link.Text = dr["Title"].ToString();
                    link.BackColor = Color.FromName(dr["color"].ToString());
                    link.LinkColor = Color.White;
                    link.AutoSize = true;
                    listFLDay[(appday.Day - 1) + (startDayAtFlNumber - 1)].Controls.Add(link);
                }

            }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Closes the popup
            Close();
        }
    }
}
