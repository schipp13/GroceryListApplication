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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace GroceryListApplication
{
  
    public partial class SelectMealMessage : Form
    {
        // Global Variables
        Event @event = new Event();
        public static string selectedMeal;
        public static string meals;

        public int AppID = 0;
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDatabase.mdb");
        OleDbCommand cmd;
        public SelectMealMessage()
        {
            InitializeComponent();

            // Grabs meal names and adds them to the combo box
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
            cn.Close();

            

        }

        // Get the ingredients for grocerylist array
        public void  getIngredients()
        {
            List<string> Ingredients = new List<string>();
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT MealIngredients FROM MealInformation Where MealName = @meal";
            cmd.Parameters.AddWithValue("@meal", mealNameComboBox.Text);
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();

            OleDbDataReader drd = cmd.ExecuteReader();
            for(int i = 0; i <= mealNameComboBox.Items.Count; i++)
            {
                while (drd.Read())
                {
                    GroceryList.MealIngredients.Items.Add(drd["MealIngredients"].ToString());
                }
            }

            cn.Close();
            
        }


        //SETTERS AND GETTERS

        public DateTime DatePicker
        {
            set { mealDateDateTimePicker.Value = value; }
            get { return mealDateDateTimePicker.Value; }
        }

        public int ID
        {
            set { AppID = value; }
            get { return AppID; }
        }
     
        private void SelectMealMessage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mealDatabaseDataSet.MealInformation' table. You can move, or remove it, as needed.
            this.mealInformationTableAdapter.Fill(this.mealDatabaseDataSet.MealInformation);
        }

        private void mealInformationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mealInformationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mealDatabaseDataSet);
        }

        public void BtnSubmitMeal_Click(object sender, EventArgs e)
        {
            getIngredients();
            selectedMeal = mealNameComboBox.SelectedItem.ToString();
            // Update the Date where MealName = SelectedMeal 
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "Update MealInformation SET MealDate = @SelectedDate Where MealName = @SelectedMeal";
            cmd.Parameters.AddWithValue("@SelectedDate", mealDateDateTimePicker.Value);
            cmd.Parameters.AddWithValue("@SelectedMeal", mealNameComboBox.Text);
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
       
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Closes the popup
            Close();
        }
    }
}
