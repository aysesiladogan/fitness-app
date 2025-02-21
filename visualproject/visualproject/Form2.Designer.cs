namespace visualproject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoginReg = new System.Windows.Forms.Button();
            this.btnClearReg = new System.Windows.Forms.Button();
            this.chkReg = new System.Windows.Forms.CheckBox();
            this.txtPass2Reg = new System.Windows.Forms.TextBox();
            this.txtPassReg = new System.Windows.Forms.TextBox();
            this.lblPass2Reg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtUsrReg = new System.Windows.Forms.TextBox();
            this.lblPassReg = new System.Windows.Forms.Label();
            this.lblUsrReg = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnLoginReg);
            this.panel2.Controls.Add(this.btnClearReg);
            this.panel2.Controls.Add(this.chkReg);
            this.panel2.Controls.Add(this.txtPass2Reg);
            this.panel2.Controls.Add(this.txtPassReg);
            this.panel2.Controls.Add(this.lblPass2Reg);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.txtUsrReg);
            this.panel2.Controls.Add(this.lblPassReg);
            this.panel2.Controls.Add(this.lblUsrReg);
            this.panel2.Location = new System.Drawing.Point(137, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 474);
            this.panel2.TabIndex = 0;
            // 
            // btnLoginReg
            // 
            this.btnLoginReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginReg.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLoginReg.Location = new System.Drawing.Point(17, 411);
            this.btnLoginReg.Name = "btnLoginReg";
            this.btnLoginReg.Size = new System.Drawing.Size(217, 41);
            this.btnLoginReg.TabIndex = 9;
            this.btnLoginReg.Text = "Back to LOGIN";
            this.btnLoginReg.UseVisualStyleBackColor = true;
            this.btnLoginReg.Click += new System.EventHandler(this.btnLoginReg_Click);
            // 
            // btnClearReg
            // 
            this.btnClearReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearReg.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClearReg.Location = new System.Drawing.Point(17, 326);
            this.btnClearReg.Name = "btnClearReg";
            this.btnClearReg.Size = new System.Drawing.Size(217, 41);
            this.btnClearReg.TabIndex = 8;
            this.btnClearReg.Text = "CLEAR";
            this.btnClearReg.UseVisualStyleBackColor = true;
            this.btnClearReg.Click += new System.EventHandler(this.btnClearReg_Click);
            // 
            // chkReg
            // 
            this.chkReg.AutoSize = true;
            this.chkReg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkReg.Location = new System.Drawing.Point(129, 246);
            this.chkReg.Name = "chkReg";
            this.chkReg.Size = new System.Drawing.Size(112, 18);
            this.chkReg.TabIndex = 7;
            this.chkReg.Text = "Show Password";
            this.chkReg.UseVisualStyleBackColor = true;
            this.chkReg.CheckedChanged += new System.EventHandler(this.chkReg_CheckedChanged);
            // 
            // txtPass2Reg
            // 
            this.txtPass2Reg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2Reg.Location = new System.Drawing.Point(17, 209);
            this.txtPass2Reg.Name = "txtPass2Reg";
            this.txtPass2Reg.Size = new System.Drawing.Size(217, 27);
            this.txtPass2Reg.TabIndex = 6;
            this.txtPass2Reg.UseSystemPasswordChar = true;
            // 
            // txtPassReg
            // 
            this.txtPassReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassReg.Location = new System.Drawing.Point(17, 138);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(217, 27);
            this.txtPassReg.TabIndex = 5;
            this.txtPassReg.UseSystemPasswordChar = true;
            // 
            // lblPass2Reg
            // 
            this.lblPass2Reg.AutoSize = true;
            this.lblPass2Reg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2Reg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPass2Reg.Location = new System.Drawing.Point(14, 176);
            this.lblPass2Reg.Name = "lblPass2Reg";
            this.lblPass2Reg.Size = new System.Drawing.Size(138, 18);
            this.lblPass2Reg.TabIndex = 4;
            this.lblPass2Reg.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(54, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Already have an account";
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.IndianRed;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(17, 279);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(217, 41);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "REGISTER";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtUsrReg
            // 
            this.txtUsrReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrReg.Location = new System.Drawing.Point(17, 70);
            this.txtUsrReg.Name = "txtUsrReg";
            this.txtUsrReg.Size = new System.Drawing.Size(217, 27);
            this.txtUsrReg.TabIndex = 1;
            // 
            // lblPassReg
            // 
            this.lblPassReg.AutoSize = true;
            this.lblPassReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassReg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassReg.Location = new System.Drawing.Point(14, 107);
            this.lblPassReg.Name = "lblPassReg";
            this.lblPassReg.Size = new System.Drawing.Size(75, 18);
            this.lblPassReg.TabIndex = 0;
            this.lblPassReg.Text = "Password";
            // 
            // lblUsrReg
            // 
            this.lblUsrReg.AutoSize = true;
            this.lblUsrReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrReg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsrReg.Location = new System.Drawing.Point(14, 43);
            this.lblUsrReg.Name = "lblUsrReg";
            this.lblUsrReg.Size = new System.Drawing.Size(79, 18);
            this.lblUsrReg.TabIndex = 0;
            this.lblUsrReg.Text = "Username";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(532, 703);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtUsrReg;
        private System.Windows.Forms.Label lblUsrReg;
        private System.Windows.Forms.TextBox txtPassReg;
        private System.Windows.Forms.Label lblPass2Reg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPassReg;
        private System.Windows.Forms.CheckBox chkReg;
        private System.Windows.Forms.TextBox txtPass2Reg;
        private System.Windows.Forms.Button btnClearReg;
        private System.Windows.Forms.Button btnLoginReg;
    }
}