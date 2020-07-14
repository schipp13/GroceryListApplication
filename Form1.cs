// Programmer: Saige Chipp
// Date  last modified: 7/13/2020


using Google.Apis.Discovery;
using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GroceryListApplication
{ 
    public partial class Form1 : Form
    {
        private List<FlowLayoutPanel> listFLDay = new List<FlowLayoutPanel>();
        private System.DateTime currentDate = System.DateTime.Today;
        Event @event = new Event();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDayPanel(42); // Generates the number of panels to be displayed
            DisplayCurrentDate(); // Gets the current date
        }

        private int GetFirstDayOfWeekOfCurrentDate()
        {
            System.DateTime firstDayOfMonth = new System.DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDayOfMonth.DayOfWeek + 1;
        }

        private int GetTotalDayCurrentDate()
        {
            System.DateTime firstDayOfMonth = new System.DateTime(currentDate.Year, currentDate.Month, 1);
            return (int)firstDayOfMonth.AddMonths(1).AddDays(-1).Day;
        }

        private void DisplayCurrentDate()
        {
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDayCurrentDate();
            lblMonth.Text = currentDate.ToString("MMMM");
            AddLabelDayToFlDay(firstDayAtFlNumber, totalDay);
            AddAppointmentToFlDay(firstDayAtFlNumber);
        }
        private void GenerateDayPanel(int totalDays)
        {
            FlDays.Controls.Clear();
            listFLDay.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                var fl = new FlowLayoutPanel();
                fl.Name = $"flday{i}";
                fl.Size = new Size(104, 75);
                fl.BackColor = System.Drawing.Color.Red;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fl.Cursor = Cursors.Hand;
                fl.Click += AddNewEvent;
                FlDays.Controls.Add(fl);
                listFLDay.Add(fl);
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

            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                var lbl = new Label();
                lbl.Name = $"lblDay{i}";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(96, 23);
                lbl.Text = i.ToString();
                listFLDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFLDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                if (new System.DateTime(currentDate.Year, currentDate.Month, i) == System.DateTime.Today)
                {
                    listFLDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = System.Drawing.Color.LightBlue;
                }
            }
        }
        private void AddNewEvent(object sender, EventArgs e)
        {   
            int day = (int)((FlowLayoutPanel)sender).Tag;
            if (day != 0)
            {
                SelectMealMessage addEvent = new SelectMealMessage();

                //SETTERS FROM ADDEVENT FORM
                addEvent.AppID = 0;
                addEvent.DatePicker = new System.DateTime(currentDate.Year, currentDate.Month, day);
                // Popup to select a meal
               
                addEvent.ShowDialog();
                DisplayCurrentDate();
            }   
        }

        private void AddAppointmentToFlDay(int startDayAtFlNumber)
        {
            System.DateTime startDate = new System.DateTime(currentDate.Year, currentDate.Month, 1);
            System.DateTime endDate = startDate.AddMonths(1).AddDays(-1);


            string sql = $"select * from MealInformation where MealDate between #{startDate.ToShortDateString()}# and #{endDate.ToShortDateString()}#";
            DataTable dt = @event.QueryAsDataTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                System.DateTime appday = System.DateTime.Parse(dr["MealDate"].ToString());
                var link = new LinkLabel();
                link.Tag = dr["MealID"].ToString();
                link.Name = $"link{dr["MealID"]}";
                link.Text = dr["MealName"].ToString();
                link.BackColor = System.Drawing.Color.LightGray;
                link.LinkColor = System.Drawing.Color.Black;
                link.AutoSize = true;  
                link.Size = new Size(96, 23);
                listFLDay[(appday.Day - 1) + (startDayAtFlNumber - 1)].Controls.Add(link);
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
        }

        private void BtnCreateMeal_Click(object sender, EventArgs e)
        {
            // Allows the user to create a new meal which will then be displayed in the Meal drop down.
            var NewMeal = new NewMeal();
            NewMeal.Show();
        }
    }
}