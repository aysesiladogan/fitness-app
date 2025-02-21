using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualproject
{
    public partial class Weight : Form
    {
        int userId = Form1.LoggedInUserID;
        public Weight()
        { 
            InitializeComponent();
        }

        private void btnHome5_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(userId);
            frm.Show();
            this.Hide();
        }

        private void btn_nutri_Click(object sender, EventArgs e)
        {
            Nutrition nutrition = new Nutrition();
            nutrition.Show();
            this.Hide();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();
            this.Hide();
        }

        private void Weight_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=projectDb.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT week1, week4 FROM weight WHERE user_id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", Form1.LoggedInUserID);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var week1Value = reader["week1"];
                            var week4Value = reader["week4"];

                            textBox2.Text = week1Value != DBNull.Value ? week1Value.ToString() : string.Empty;
                            textBox4.Text = week4Value != DBNull.Value ? week4Value.ToString() : string.Empty;
                        }
                    }
                }
            }
        }

        private void btnProg5_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }

        private void btnFood5_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.Show();
            this.Hide();
        }

        private void goalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goals goal = new Goals();
            goal.Show();
            this.Hide();
        }


        private void editYourProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(Form1.LoggedInUserID);
            frm5.Show();
            this.Hide();
        }

        private void btnMenu5_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenu5, new Point(0, btnMenu5.Height));

        }
    }
}
