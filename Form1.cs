// Programmer: Saige Chipp
// Date  last modified: 7/12/2020


using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using System.Configuration;
using DateTime = System.DateTime;
using Microsoft.IdentityModel.Protocols;
using System.Data.OleDb;
using System.Threading;
using Google.Apis.Calendar.v3.Data;

namespace GroceryListApplication
{
    public partial class Form1 : Form
    {
        private List<FlowLayoutPanel> listFLDay = new List<FlowLayoutPanel>();
        private DateTime currentDate = DateTime.Today;
        Event @meal = new Event();

        // Creates a connection to the database
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\saich\Desktop\C# Practice\GroceryList\GroceryListApplication\GroceryListApplication\MealDataBase.mdb");

        public Form1()
        {
            InitializeComponent();
            cn.Open();
        }
    
    private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDayPanel(42); // Generates the number of panels to be displayed
            DisplayCurrentDate(); // Gets the current date
            currentDate = DateTime.Today;
            DisplayCurrentDate();
        }

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDayOfMonth.DayOfWeek + 1;
        }
        
        private int GetTotalDayCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDayOfMonth.AddMonths(1).AddDays(-1).Day;
        }

        private void DisplayCurrentDate()
        {
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDayCurrentDate();
            lblMonth.Text = currentDate.ToString("MMMM");
            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
        }

        private void GenerateDayPanel(int totalDays)
        {
            // Creates the panels for the calendar
            FlDays.Controls.Clear();
            listFLDay.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                var fl = new FlowLayoutPanel();
                fl.Name = $"flday{i}";
                fl.Size = new Size(99, 69);
                fl.BackColor = System.Drawing.Color.White;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fl.Cursor = Cursors.Hand;
                fl.Click += AddMeal;
                FlDays.Controls.Add(fl);
                listFLDay.Add(fl);
            }
        }

        // Adds a new meal to the list of meals
        private void AddMeal(object sender, EventArgs e)
        {
            int day = (int)((FlowLayoutPanel)sender).Tag;
            if (day != 0)
            {
                // Popup to select a meal
                var SelectMealMesssage = new SelectMealMessage();
                SelectMealMesssage.Show();
            }   
        }
        private void AddLabelDayToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            foreach (FlowLayoutPanel fl in listFLDay)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
                fl.BackColor = System.Drawing.Color.White;
            }
            // Creates the labels for each day in the month
            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                var lbl = new Label();
                lbl.Name = $"lblDay{i}";
                lbl.AutoSize = false;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lbl.Size = new Size(96, 23);
                lbl.Text = i.ToString();
                listFLDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFLDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listFLDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = System.Drawing.Color.LightBlue;
                }
            }
        }
        private void btnNextMonth_Click(object sender, EventArgs e)
        { 
            // Loads Next Month
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        { 
            // Loads previous month
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void btnGroceryList_Click(object sender, EventArgs e)
        {
            // Loads Grocery List Form
            var GroceryList = new GroceryList();
            GroceryList.Show();
            cn.Close();
        }

        private void BtnCreateMeal_Click(object sender, EventArgs e)
        {
            // Allows the user to create a new meal which will then be displayed in the Meal drop down.
            var NewMeal = new NewMeal();
            NewMeal.Show();
            cn.Close();
        }
    }
}

