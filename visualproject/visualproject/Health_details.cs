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
    public partial class Health_details : Form
    {
        public Health_details()
        {
            InitializeComponent();
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

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnMenu4, new Point(0, btnMenu4.Height));

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
    }
}
