// Programmer: Saige Chipp
// Date last modified: 7/12/2020

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;

namespace GroceryListApplication
{
    public partial class NewMeal : Form
    {
        // Creates a connection to the database
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDataBase.mdb");
        OleDbCommand cmd;
        public NewMeal()
        {
            InitializeComponent(); 
            cn.Open();
        }

       private void BtnBack_Click(object sender, EventArgs e)
        {
            // Goes back to the main form
             Close();
            cn.Close();

            // Clears the form
            ClearForm();
        }

     
        private void BtnAddMeal_Click(object sender, EventArgs e)
        {
            // Inserts meal into the database
            cmd = cn.CreateCommand();
            cmd.CommandText = "INSERT INTO MealInformation(MealName,MealIngredients,MealInstructions,MealPicture)Values('" + mealNameTextBox.Text + "','" + mealIngredientsTextBox.Text + "','" + mealInstructionsTextBox.Text + "','" + mealPicturePictureBox + "')";
            cmd.Connection = cn;
            conv_photo();
            cmd.ExecuteNonQuery();

            // Clears the form
            ClearForm();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Search for an image to be included into the meal
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
               mealPicturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        void conv_photo()
        {
            //converting photo to binary data
            if (mealPicturePictureBox.Image != null)
            {
                //using MemoryStream:
               MemoryStream ms = new MemoryStream();
                mealPicturePictureBox.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("MealPicture", photo_aray);
            }
        }
        void ClearForm()
        {
            // Clears the form
            mealNameTextBox.Clear();
            mealIngredientsTextBox.Clear();
            mealInstructionsTextBox.Clear();
        }
        void CheckFields()
        {
            if(mealNameTextBox.Text != null & mealIngredientsTextBox.Text != null & mealInstructionsTextBox.Text != null)
            {
                BtnAddMeal.Enabled = true;
            }
        }

        private void mealInstructionsTextBox_TextChanged(object sender, EventArgs e)
        {
            // Allows the Add meal button to be enabled
            CheckFields();
        }

        private void mealNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Enables the Ingredients Text Box
            mealIngredientsTextBox.Enabled = true;
        }

        private void mealIngredientsTextBox_TextChanged(object sender, EventArgs e)
        {
            // Enables the Instructions Text Box
            mealInstructionsTextBox.Enabled = true;
        }
    }
}
