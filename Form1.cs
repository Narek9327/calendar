using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calendar
{
    public partial class Form1 : Form
    {
        public static int static_year;
        public static int static_month;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            displayDays();

        }
        int Year, Month;
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            Year = now.Year;
            Month = now.Month;
           



        DateTime startofthemonth = new DateTime(Year, Month, 1);
            // get
            int days = DateTime.DaysInMonth(Year, Month);
            // convert
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i =1; i< dayofweek; i++)
            {
                UserControlBlack ubl = new UserControlBlack();
                datcontainer.Controls.Add(ubl);
            }
            for (int i = 1;i <=days; i++)
            {
                UserControlDays ud = new UserControlDays();
                ud.days(i);
                datcontainer.Controls.Add(ud);
            }
            static_month = Month;
            static_year = Year;
        }

        private void btnpreviews_Click(object sender, EventArgs e)
        {
          
            datcontainer.Controls.Clear();
            Month--;
            static_month = Month;
            static_year = Year;
            DateTime startofthemonth = new DateTime(Year, Month, 1);
            // get
            int days = DateTime.DaysInMonth(Year, Month);
            // convert
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlack ubl = new UserControlBlack();
                datcontainer.Controls.Add(ubl);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ud = new UserControlDays();
                ud.days(i);
                datcontainer.Controls.Add(ud);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            datcontainer.Controls.Clear();
           

            Month++;
            static_month = Month;
            static_year = Year;

            DateTime startofthemonth = new DateTime(Year, Month, 1);
            // get
            int  days = DateTime.DaysInMonth(Year, Month);
            // convert
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlack ubl = new UserControlBlack();
                datcontainer.Controls.Add(ubl);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ud = new UserControlDays();
                ud.days(i);
                datcontainer.Controls.Add(ud);
            }

        }
    }
}
