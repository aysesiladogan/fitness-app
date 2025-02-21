namespace visualproject
{
    partial class Progress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progress));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProg4 = new System.Windows.Forms.Button();
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFood4 = new System.Windows.Forms.Button();
            this.btnWork5 = new System.Windows.Forms.Button();
            this.btnHome4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 676);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Move";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "move/kcal";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(542, 268);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nutrition";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(0, 3);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "nutrition/kcal";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(542, 268);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(542, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Weight";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(0, 3);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "weight/kcal";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(542, 268);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnProg4);
            this.panel1.Controls.Add(this.btnMenu4);
            this.panel1.Controls.Add(this.btnFood4);
            this.panel1.Controls.Add(this.btnWork5);
            this.panel1.Controls.Add(this.btnHome4);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(1, 673);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 84);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(487, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(345, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Progress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(250, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(124, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Workouts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // btnProg4
            // 
            this.btnProg4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProg4.BackgroundImage")));
            this.btnProg4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProg4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProg4.Location = new System.Drawing.Point(348, 9);
            this.btnProg4.Name = "btnProg4";
            this.btnProg4.Size = new System.Drawing.Size(62, 43);
            this.btnProg4.TabIndex = 0;
            this.btnProg4.UseVisualStyleBackColor = true;
            this.btnProg4.Click += new System.EventHandler(this.btnProg4_Click);
            // 
            // btnMenu4
            // 
            this.btnMenu4.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenu4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu4.BackgroundImage")));
            this.btnMenu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu4.ContextMenuStrip = this.contextMenuStrip1;
            this.btnMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu4.Location = new System.Drawing.Point(475, 9);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(62, 43);
            this.btnMenu4.TabIndex = 0;
            this.btnMenu4.UseVisualStyleBackColor = false;
            this.btnMenu4.Click += new System.EventHandler(this.btnMenu4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goalsToolStripMenuItem,
            this.EditProfileToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 52);
            // 
            // goalsToolStripMenuItem
            // 
            this.goalsToolStripMenuItem.Name = "goalsToolStripMenuItem";
            this.goalsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.goalsToolStripMenuItem.Text = "Goals";
            this.goalsToolStripMenuItem.Click += new System.EventHandler(this.goalsToolStripMenuItem_Click);
            // 
            // EditProfileToolStripMenuItem1
            // 
            this.EditProfileToolStripMenuItem1.Name = "EditProfileToolStripMenuItem1";
            this.EditProfileToolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.EditProfileToolStripMenuItem1.Text = "Edit Your Profile";
            // 
            // btnFood4
            // 
            this.btnFood4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFood4.BackgroundImage")));
            this.btnFood4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFood4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood4.Location = new System.Drawing.Point(237, 9);
            this.btnFood4.Name = "btnFood4";
            this.btnFood4.Size = new System.Drawing.Size(62, 43);
            this.btnFood4.TabIndex = 0;
            this.btnFood4.UseVisualStyleBackColor = true;
            this.btnFood4.Click += new System.EventHandler(this.btnFood4_Click);
            // 
            // btnWork5
            // 
            this.btnWork5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWork5.BackgroundImage")));
            this.btnWork5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWork5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork5.Location = new System.Drawing.Point(118, 3);
            this.btnWork5.Name = "btnWork5";
            this.btnWork5.Size = new System.Drawing.Size(70, 58);
            this.btnWork5.TabIndex = 0;
            this.btnWork5.UseVisualStyleBackColor = true;
            this.btnWork5.Click += new System.EventHandler(this.btnWork5_Click);
            // 
            // btnHome4
            // 
            this.btnHome4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome4.BackgroundImage")));
            this.btnHome4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome4.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome4.Location = new System.Drawing.Point(11, 9);
            this.btnHome4.Name = "btnHome4";
            this.btnHome4.Size = new System.Drawing.Size(62, 43);
            this.btnHome4.TabIndex = 0;
            this.btnHome4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome4.UseVisualStyleBackColor = true;
            this.btnHome4.Click += new System.EventHandler(this.btnHome4_Click);
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 757);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.Progress_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProg4;
        private System.Windows.Forms.Button btnMenu4;
        private System.Windows.Forms.Button btnFood4;
        private System.Windows.Forms.Button btnWork5;
        private System.Windows.Forms.Button btnHome4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditProfileToolStripMenuItem1;
    }
}