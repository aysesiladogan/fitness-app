using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;


namespace visualproject
{
    public partial class Form1 : Form
    {
        string dbFİleName = "projectDb.db";
        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public static int LoggedInUserID;
        public static string LoggedInUsername { get; set; }
        public static string LoggedInProfile_photoPath { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(150, 255, 255, 255);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=projectDb.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            
            
            cmd.CommandText = " Select*From Tbl_users where username='"+txtUsername.Text+"'And password='"+txtPassword.Text+"'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                LoggedInUserID = Convert.ToInt32(dr["id"]);
                Form1.LoggedInUsername = dr["username"].ToString();
                Form1.LoggedInProfile_photoPath = dr["profile_photo"].ToString();
                MessageBox.Show("Login Successfull!");
                Form4 frm4 = new Form4(LoggedInUserID);
                frm4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password! Try again..");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();    
            }
            conn.Close();


            
        }
    }
}
