// Programmer: Saige Chipp
// Date last modified: 7/11/2020

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

namespace GroceryListApplication
{
    public partial class NewMeal : Form
    {
        // Creates a connection to the database
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDatabase.mdb");

        public NewMeal()
        {
            InitializeComponent(); 
            cn.Open();
        }
        private void NewMeal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mealDatabaseDataSet.MealInformation' table. You can move, or remove it, as needed.
            this.mealInformationTableAdapter.Fill(this.mealDatabaseDataSet.MealInformation);


        }

       private void BtnBack_Click(object sender, EventArgs e)
        {
            // Goes back to the main form
             Close();
            cn.Close();
        }

     
        private void BtnAddMeal_Click(object sender, EventArgs e)
        {
            // Inserts meal into the database
            OleDbCommand cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO MealInformation(MealName,MealIngredients,MealInstructions)Values('" + mealNameTextBox.Text + "','" + mealIngredientsTextBox.Text + "','" + mealInstructionsTextBox.Text + "')";
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Search for an image to be included into the meal

        }

        

     
    }
}
