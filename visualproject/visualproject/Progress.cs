using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualproject
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=projectDb.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT monday, tuesday, wednesday, thursday, friday, saturday, sunday FROM move WHERE user_id = @userId;";
            cmd.Parameters.AddWithValue("@userId", Form1.LoggedInUserID);

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                for (int i = 0; i < days.Length; i++)
                {
                    object value = reader.IsDBNull(i) ? 0 : reader.GetValue(i);
                    double calories = Convert.ToDouble(value);

                    chart1.Series["move/kcal"].Points.AddXY(days[i], calories);
                }
            }

            SQLiteConnection con = new SQLiteConnection(connectionString);
            con.Open();
            SQLiteCommand com = new SQLiteCommand();
            com.Connection = con;
            com.CommandText = "SELECT monday, tuesday, wednesday, thursday, friday, saturday, sunday FROM nutrition WHERE user_id = @userId;";
            com.Parameters.AddWithValue("@userId", Form1.LoggedInUserID);

            SQLiteDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                for (int i = 0; i < days.Length; i++)
                {
                    object valuee = rdr.IsDBNull(i) ? 0 : rdr.GetValue(i);
                    double nutri = Convert.ToDouble(valuee);

                    chart3.Series["nutrition/kcal"].Points.AddXY(days[i], nutri);
                }
            }

            SQLiteConnection connect = new SQLiteConnection(connectionString);
            connect.Open();
            SQLiteCommand cmnd = new SQLiteCommand();
            cmnd.Connection = connect;
            cmnd.CommandText = "SELECT week1, week2, week3, week4 FROM weight WHERE user_id = @userId;";
            cmnd.Parameters.AddWithValue("@userId", Form1.LoggedInUserID);

            SQLiteDataReader readerr = cmnd.ExecuteReader();
            while (readerr.Read())
            {
                string[] weeks = { "Week1", "Week2", "Week3", "Week4" };

                for (int i = 0; i < weeks.Length; i++)
                {
                    object value = readerr.IsDBNull(i) ? 0 : readerr.GetValue(i);
                    double calories = Convert.ToDouble(value);

                    chart2.Series["weight/kcal"].Points.AddXY(weeks[i], calories);
                }
            }

        }

        private void btnHome4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(Form1.LoggedInUserID);
            form4.Show();
            this.Hide();
        }

        private void btnWork5_Click(object sender, EventArgs e)
        {
            Workouts workouts = new Workouts();
            workouts.Show();
            this.Hide();
        }

        private void btnFood4_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.Show();
            this.Hide();
        }

        private void btnProg4_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goals goal = new Goals();
            goal.Show();
            this.Hide();
        }

        private void EditProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(Form1.LoggedInUserID);
            frm5.Show();
            this.Hide();
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenu4, new Point(0, btnMenu4.Height));

        }
    }
}
