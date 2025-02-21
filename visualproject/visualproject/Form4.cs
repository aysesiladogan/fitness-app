using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualproject
{
    public partial class Form4 : Form
    {
        int usrId;
        public Form4(int userId)
        {
            usrId = userId;
            InitializeComponent();
            lblUsr4.Text = Form1.LoggedInUsername;
            pp4.Image = Image.FromFile(Form1.LoggedInProfile_photoPath);
            btnHome4.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form1 exit = new Form1();
                exit.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form5 frm5 = new Form5(usrId);
            frm5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Goals goals = new Goals();
            goals.Show();
            this.Hide(); 
        }

        private void btnFood4_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.Show();
            this.Hide();
        }

        private void btnWork5_Click(object sender, EventArgs e)
        {
            Workouts workouts = new Workouts();
            workouts.Show();
            this.Hide();
        }

        private void btnProg4_Click(object sender, EventArgs e)
        {
            Progress prog = new Progress();
            prog.Show();
            this.Hide();
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenu4, new Point(0, btnMenu4.Height));

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Goals goal = new Goals();
            goal.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(Form1.LoggedInUserID);
            frm5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Health_details health = new Health_details();
            health.Show();
            this.Hide();
        }

        private void btnHome4_Click(object sender, EventArgs e)
        {

        }
    }
}
