using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualproject
{
    public partial class Nutrition : Form
    {
        int userId = Form1.LoggedInUserID;
        public Nutrition()
        {
            InitializeComponent();
            maskedTextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btnHome5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(userId);
            form4.Show();
            this.Hide();
        }

        private void btn_weight_Click(object sender, EventArgs e)
        {
            Weight weight = new Weight();
            weight.Show();
            this.Hide();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();
            this.Hide();
        }

        private void Nutrition_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            string connectionString = "Data Source=projectDb.db;Version=3;";

            string dayName = DateTime.Now.ToString("dddd", new CultureInfo("en-US"));

            string columnName = dayName;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM nutrition WHERE user_id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", Form1.LoggedInUserID);

                    var result = command.ExecuteScalar();
                    if( Convert.ToInt64(result) > 2500)
                    {
                        label11.Visible = true;
                    }
                    txt_nutri.Text = result != null ? result.ToString() : "0";
                }
            }
        }

        private void btnWork5_Click(object sender, EventArgs e)
        {
            Workouts workouts = new Workouts();
            workouts.Show();
            this.Hide();
        }

        private void btnFood5_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.Show();
            this.Hide();
        }

        private void btnProg5_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
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
