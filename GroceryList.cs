// Programmer: Saige Chipp
// Date last modified: 7/12/2020

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GroceryListApplication
{
    public partial class GroceryList : Form
    {
        string docPath = @"C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\";
        private string stringToPrint;

        public GroceryList()
        {
            InitializeComponent();
            // Assign ingredients from added meals from the calendar
            

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
         // Goes back to the calendar
            Close();
        }

        private void BtnAlreadyHave_Click(object sender, EventArgs e)
        {
            // Removes selected items from list
            for (int i = Grocery_List.Items.Count - 1; i >= 0; i--)
            {
                if (Grocery_List.GetItemChecked(i))
                {
                    Grocery_List.Items.Remove(Grocery_List.Items[i]);
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // Writes items into the GroceryList text file
            using (StreamWriter outputfile = new StreamWriter(Path.Combine(docPath, "GroceryList.txt")))
            {
                foreach (string Item in Grocery_List.Items)
                {
                    outputfile.WriteLine(Item);
                }
            }
            ReadFile();
            printDocument1.Print();
        }

        private void ReadFile()
        {
            string docName = "GroceryList.txt";
            printDocument1.DocumentName = docName;
            using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                stringToPrint = reader.ReadToEnd();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

        }
    }
}
