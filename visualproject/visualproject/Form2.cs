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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=projectDb.db;Version=3;";
        
        string profile_photoPath;
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkReg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReg.Checked)
            {
                txtPassReg.UseSystemPasswordChar = false;
                txtPass2Reg.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassReg.UseSystemPasswordChar = true;
                txtPass2Reg.UseSystemPasswordChar = true;
            }
        }

        private void btnClearReg_Click(object sender, EventArgs e)
        {
            txtUsrReg.Text = "";
            txtPassReg.Text = "";
            txtPass2Reg.Text = "";
        }

        private void btnLoginReg_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();

            SQLiteCommand comm = new SQLiteCommand("insert into Tbl_users (username, password, profile_photo) values (@p1, @p2, @p3)", conn);
            comm.Parameters.AddWithValue("@p1", txtUsrReg.Text);
            if (txtPassReg.Text == txtPass2Reg.Text) {
                comm.Parameters.AddWithValue("@p2", txtPassReg.Text);
            }
            else
            {
                MessageBox.Show("Confirm password must be same with password !");
                txtUsrReg.Text = "";
                txtPassReg.Text = "";
                txtPass2Reg.Text = "";
                conn.Close();
                return;
            }
            profile_photoPath = "C:\\Users\\Huawei\\Downloads\\profile.png";
            comm.Parameters.AddWithValue("@p3", profile_photoPath);
            comm.ExecuteNonQuery();
            MessageBox.Show("Registration Successful !");
            conn.Close();
        }

    }

    }
