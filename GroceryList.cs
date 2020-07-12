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
    public partial class GroceryList : Form
    {
        // Creates a connection to the database
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDatabase.mdb");
        
        public GroceryList()
        {
            InitializeComponent();
            cn.Open();
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
         // Goes back to the calendar

            Close();
            cn.Close();
        }
    }
}
