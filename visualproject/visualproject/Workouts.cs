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
    public partial class Workouts : Form
    {
        int userId = Form1.LoggedInUserID;
        public Workouts()
        {
            InitializeComponent();
            btnWork5.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }

        private void btnHome4_Click(object sender, EventArgs e)
        {
            Form4 home = new Form4(userId);
            home.Show();
            this.Hide();
        }

        private void btnFood4_Click(object sender, EventArgs e)
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

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenu4, new Point(0, btnMenu4.Height));

        }
    }
}
