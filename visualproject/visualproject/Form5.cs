using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visualproject.visualProjectDataSet1TableAdapters;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace visualproject
{
    public partial class Form5 : Form
    {
        int userID;
        public Form5(int userId)
        {
            userID = userId;
            InitializeComponent();


        }

        string connectionString = "Data Source=projectDb.db;Version=3;";
        string dbFileName = "projectDb.db";

        private void Form5_Load(object sender, EventArgs e)
        {
            getUserInfo(userID);
            // TODO: This line of code loads data into the 'visualProjectDataSet3.Tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.visualProjectDataSet3.Tbl_login);

            lblUsr5.Text = Form1.LoggedInUsername;
            pp5.Image = Image.FromFile(Form1.LoggedInProfile_photoPath);
            btnMenu5.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;

        }
        private void getUserInfo(int userID)
        {
            string connectionString = "Data Source=projectDb.db;Version=3;";
            string query = "SELECT username, password, profile_photo FROM Tbl_users WHERE id = '"+userID+"'";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            con.Open();

            SQLiteCommand comm = new SQLiteCommand(query, con);
            SQLiteDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                txtUsrUp.Text = reader["username"].ToString();
                txtPassUp.Text = reader["password"].ToString();
                string path = reader["profile_photo"].ToString();
                pp5.Image = Image.FromFile(path);
            }
            con.Close();
        }
        private void updateUserFromDatabase()
        {
            string connectionString = "Data Source=projectDb.db;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Tbl_users SET username = @p1, password = @p2, profile_photo = @p3 WHERE id = @id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", Form1.LoggedInUserID);
                    command.Parameters.AddWithValue("@p1", txtUsrUp.Text);
                    if(txtPassUp.Text == txtPassUp2.Text)
                    {
                        command.Parameters.AddWithValue("@p2", txtPassUp.Text);
                    }
                    else
                    {
                        MessageBox.Show("Your confirmation password must be the same as your password. Please try again!");
                    }
                    command.Parameters.AddWithValue("@p3", TxtPicUp.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update successful!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pp5.ImageLocation = openFileDialog1.FileName;
            TxtPicUp.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateUserFromDatabase();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form4 backMain = new Form4(userID);
            backMain.Show();
            this.Hide();
        }

        private void btnHome5_Click(object sender, EventArgs e)
        {
            Form4 main = new Form4(userID);
            main.Show();
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
