using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Calendar
{
    public partial class EventForm : Form
    {
        String conString = "server=localhost; user id = root; database=baza; sslmode = none";
       
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = UserControlDays.static_day + "/" + Form1.static_month + "/" + Form1.static_year;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            String cmdString = "INSERT INTO tbl_calendar(date, event) VALUES(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmdString;
            cmd.Parameters.AddWithValue("date", txtDate.Text);
            cmd.Parameters.AddWithValue("event", txtEvent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
         
        }
    }
}
