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
    public partial class Food : Form
    {
        int userId = Form1.LoggedInUserID;

        public Food()
        {
            InitializeComponent();
            btnFood4.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;

            AddDataToTable(tableLayoutPanel1, "FOOD", 0, 0);
            AddDataToTable(tableLayoutPanel1, "kcal/100g", 0, 1);

            AddDataToTable(tableLayoutPanel1, "Zeytinyağlı Taze Fasulye", 1, 0);
            AddDataToTable(tableLayoutPanel1, "56", 1, 1);

            AddDataToTable(tableLayoutPanel1, "Zeytinyağlı Kereviz", 2, 0);
            AddDataToTable(tableLayoutPanel1, "66", 2, 1);

            AddDataToTable(tableLayoutPanel1, "Bezelye Çorbası", 3, 0);
            AddDataToTable(tableLayoutPanel1, "75", 3, 1);

            AddDataToTable(tableLayoutPanel1, "Patates Püresi", 4, 0);
            AddDataToTable(tableLayoutPanel1, "83", 4, 1);

            AddDataToTable(tableLayoutPanel1, "Fırında Kurufasulye", 5, 0);
            AddDataToTable(tableLayoutPanel1, "94", 5, 1);

            AddDataToTable(tableLayoutPanel1, "Sığır Eti Güveci", 6, 0);
            AddDataToTable(tableLayoutPanel1, "95", 6, 1);

            AddDataToTable(tableLayoutPanel1, "Chili con Carne (Kıymalı Fasulye)", 7, 0);
            AddDataToTable(tableLayoutPanel1, "105", 7, 1);

            AddDataToTable(tableLayoutPanel1, "Rozbif", 8, 0);
            AddDataToTable(tableLayoutPanel1, "111", 8, 1);

            AddDataToTable(tableLayoutPanel1, "Kıymalı Dolma", 9, 0);
            AddDataToTable(tableLayoutPanel1, "114", 9, 1);

            AddDataToTable(tableLayoutPanel1, "Fajita", 10, 0);
            AddDataToTable(tableLayoutPanel1, "117", 10, 1);

            AddDataToTable(tableLayoutPanel1, "Tavuklu Sezar Salata", 11, 0);
            AddDataToTable(tableLayoutPanel1, "127", 11, 1);

            AddDataToTable(tableLayoutPanel1, "Lazanya", 12, 0);
            AddDataToTable(tableLayoutPanel1, "132", 12, 1);

            AddDataToTable(tableLayoutPanel1, "Spagetti Bolonez", 13, 0);
            AddDataToTable(tableLayoutPanel1, "132", 13, 1);

            AddDataToTable(tableLayoutPanel1, "Karnıyarık", 14, 0);
            AddDataToTable(tableLayoutPanel1, "134", 14, 1);

            AddDataToTable(tableLayoutPanel1, "Yaprak Sarması", 15, 0);
            AddDataToTable(tableLayoutPanel1, "141", 15, 1);

            AddDataToTable(tableLayoutPanel1, "Patates Salatası", 16, 0);
            AddDataToTable(tableLayoutPanel1, "143", 16, 1);

            AddDataToTable(tableLayoutPanel1, "Kuzu Tandır", 17, 0);
            AddDataToTable(tableLayoutPanel1, "150", 17, 1);

            AddDataToTable(tableLayoutPanel1, "Fırında Tavuk", 18, 0);
            AddDataToTable(tableLayoutPanel1, "164", 18, 1);

            AddDataToTable(tableLayoutPanel1, "Zeytinyağlı Enginar", 19, 0);
            AddDataToTable(tableLayoutPanel1, "166", 19, 1);

            AddDataToTable(tableLayoutPanel1, "Zeytinyağlı Dolma", 20, 0);
            AddDataToTable(tableLayoutPanel1, "173", 20, 1);

            AddDataToTable(tableLayoutPanel1, "Hünkar Beğendi", 21, 0);
            AddDataToTable(tableLayoutPanel1, "174", 21, 1);

            AddDataToTable(tableLayoutPanel1, "Humus", 22, 0);
            AddDataToTable(tableLayoutPanel1, "177", 22, 1);

            AddDataToTable(tableLayoutPanel1, "Bulgur Pilavı", 23, 0);
            AddDataToTable(tableLayoutPanel1, "215", 23, 1);

            AddDataToTable(tableLayoutPanel1, "Kebap", 24, 0);
            AddDataToTable(tableLayoutPanel1, "215", 24, 1);

            AddDataToTable(tableLayoutPanel1, "Rulo Köfte", 25, 0);
            AddDataToTable(tableLayoutPanel1, "254", 25, 1);

            AddDataToTable(tableLayoutPanel1, "Pizza", 26, 0);
            AddDataToTable(tableLayoutPanel1, "267", 26, 1);

            AddDataToTable(tableLayoutPanel1, "Peynirli Pide", 27, 0);
            AddDataToTable(tableLayoutPanel1, "275", 27, 1);

            AddDataToTable(tableLayoutPanel1, "Kıymalı/Etli Pide", 28, 0);
            AddDataToTable(tableLayoutPanel1, "297", 28, 1);

            AddDataToTable(tableLayoutPanel1, "Tandır Ekmeği", 29, 0);
            AddDataToTable(tableLayoutPanel1, "310", 29, 1);

            AddDataToTable(tableLayoutPanel1, "Pilav", 30, 0);
            AddDataToTable(tableLayoutPanel1, "352", 30, 1);

            AddDataToTable(tableLayoutPanel1, "Makarna ve Peynir", 31, 0);
            AddDataToTable(tableLayoutPanel1, "370", 31, 1);

            AddDataToTable(tableLayoutPanel1, "Esmer Pirinç", 32, 0);
            AddDataToTable(tableLayoutPanel1, "362", 32, 1);

            AddDataToTable(tableLayoutPanel2, "FRUITS & VEGETABLES", 0, 0);
            AddDataToTable(tableLayoutPanel2, "kcal/100g", 0, 1);

            AddDataToTable(tableLayoutPanel2, "Marul", 1, 0);
            AddDataToTable(tableLayoutPanel2, "14", 1, 1);

            AddDataToTable(tableLayoutPanel2, "Kereviz", 2, 0);
            AddDataToTable(tableLayoutPanel2, "16", 2, 1);

            AddDataToTable(tableLayoutPanel2, "Kırmızı Turp", 3, 0);
            AddDataToTable(tableLayoutPanel2, "16", 3, 1);

            AddDataToTable(tableLayoutPanel2, "Salatalık", 4, 0);
            AddDataToTable(tableLayoutPanel2, "16", 4, 1);

            AddDataToTable(tableLayoutPanel2, "Domates", 5, 0);
            AddDataToTable(tableLayoutPanel2, "18", 5, 1);

            AddDataToTable(tableLayoutPanel2, "Pazı", 6, 0);
            AddDataToTable(tableLayoutPanel2, "19", 6, 1);

            AddDataToTable(tableLayoutPanel2, "Kuşkonmaz", 7, 0);
            AddDataToTable(tableLayoutPanel2, "20", 7, 1);

            AddDataToTable(tableLayoutPanel2, "Mantar", 8, 0);
            AddDataToTable(tableLayoutPanel2, "22", 8, 1);

            AddDataToTable(tableLayoutPanel2, "Ispanak", 9, 0);
            AddDataToTable(tableLayoutPanel2, "23", 9, 1);

            AddDataToTable(tableLayoutPanel2, "Karnabahar", 10, 0);
            AddDataToTable(tableLayoutPanel2, "25", 10, 1);

            AddDataToTable(tableLayoutPanel2, "Patlıcan", 11, 0);
            AddDataToTable(tableLayoutPanel2, "25", 11, 1);

            AddDataToTable(tableLayoutPanel2, "Roka", 12, 0);
            AddDataToTable(tableLayoutPanel2, "25", 12, 1);

            AddDataToTable(tableLayoutPanel2, "Kabak", 13, 0);
            AddDataToTable(tableLayoutPanel2, "26", 13, 1);

            AddDataToTable(tableLayoutPanel2, "Biber", 14, 0);
            AddDataToTable(tableLayoutPanel2, "27", 14, 1);

            AddDataToTable(tableLayoutPanel2, "Brokoli", 15, 0);
            AddDataToTable(tableLayoutPanel2, "34", 15, 1);

            AddDataToTable(tableLayoutPanel2, "Enginar", 16, 0);
            AddDataToTable(tableLayoutPanel2, "47", 16, 1);

            AddDataToTable(tableLayoutPanel2, "Pırasa", 17, 0);
            AddDataToTable(tableLayoutPanel2, "61", 17, 1);

            AddDataToTable(tableLayoutPanel2, "Mısır", 18, 0);
            AddDataToTable(tableLayoutPanel2, "365", 18, 1);

            AddDataToTable(tableLayoutPanel2, "Siyah Zeytin", 19, 0);
            AddDataToTable(tableLayoutPanel2, "115", 19, 1);

            AddDataToTable(tableLayoutPanel2, "Yeşil Zeytin", 20, 0);
            AddDataToTable(tableLayoutPanel2, "115", 20, 1);

            AddDataToTable(tableLayoutPanel2, "Karpuz", 21, 0);
            AddDataToTable(tableLayoutPanel2, "30", 21, 1);

            AddDataToTable(tableLayoutPanel2, "Çilek", 22, 0);
            AddDataToTable(tableLayoutPanel2, "32", 22, 1);

            AddDataToTable(tableLayoutPanel2, "Şeftali", 23, 0);
            AddDataToTable(tableLayoutPanel2, "39", 23, 1);

            AddDataToTable(tableLayoutPanel2, "Yeşil Erik", 24, 0);
            AddDataToTable(tableLayoutPanel2, "41", 24, 1);

            AddDataToTable(tableLayoutPanel2, "Portakal", 25, 0);
            AddDataToTable(tableLayoutPanel2, "47", 25, 1);

            AddDataToTable(tableLayoutPanel2, "Kayısı", 26, 0);
            AddDataToTable(tableLayoutPanel2, "48", 26, 1);

            AddDataToTable(tableLayoutPanel2, "Ananas", 27, 0);
            AddDataToTable(tableLayoutPanel2, "50", 27, 1);

            AddDataToTable(tableLayoutPanel2, "Kiraz", 28, 0);
            AddDataToTable(tableLayoutPanel2, "50", 28, 1);

            AddDataToTable(tableLayoutPanel2, "Elma", 29, 0);
            AddDataToTable(tableLayoutPanel2, "52", 29, 1);

            AddDataToTable(tableLayoutPanel2, "Ayva", 30, 0);
            AddDataToTable(tableLayoutPanel2, "57", 30, 1);

            AddDataToTable(tableLayoutPanel2, "Üzüm", 31, 0);
            AddDataToTable(tableLayoutPanel2, "69", 31, 1);

            AddDataToTable(tableLayoutPanel2, "Muz", 32, 0);
            AddDataToTable(tableLayoutPanel2, "89", 32, 1);
        }

        private void Food_Load(object sender, EventArgs e)
        {

        }
        private void AddDataToTable(TableLayoutPanel tableLayoutPanel, string data, int row, int col)
        {
            Label label = new Label
            {
                Text = data,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            tableLayoutPanel.Controls.Add(label, col, row);
        }

        private void btnHome4_Click(object sender, EventArgs e)
        {
            Form4 home = new Form4(userId);
            home.Show();
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
