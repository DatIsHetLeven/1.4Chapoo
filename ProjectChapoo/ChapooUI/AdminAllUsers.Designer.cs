namespace ChapooUI
{
    partial class AdminAllUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAllUsers));
            this.Btn_ChangePassword = new System.Windows.Forms.Button();
            this.Btn_CreateUser = new System.Windows.Forms.Button();
            this.btn_BackAdminDasboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ChangePassword
            // 
            this.Btn_ChangePassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_ChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_ChangePassword.Location = new System.Drawing.Point(897, 128);
            this.Btn_ChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ChangePassword.Name = "Btn_ChangePassword";
            this.Btn_ChangePassword.Size = new System.Drawing.Size(243, 68);
            this.Btn_ChangePassword.TabIndex = 30;
            this.Btn_ChangePassword.Text = "Change password user";
            this.Btn_ChangePassword.UseVisualStyleBackColor = false;
            this.Btn_ChangePassword.Click += new System.EventHandler(this.Btn_ChangePassword_Click);
            // 
            // Btn_CreateUser
            // 
            this.Btn_CreateUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_CreateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_CreateUser.Location = new System.Drawing.Point(110, 128);
            this.Btn_CreateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_CreateUser.Name = "Btn_CreateUser";
            this.Btn_CreateUser.Size = new System.Drawing.Size(188, 68);
            this.Btn_CreateUser.TabIndex = 29;
            this.Btn_CreateUser.Text = "Create user";
            this.Btn_CreateUser.UseVisualStyleBackColor = false;
            this.Btn_CreateUser.Click += new System.EventHandler(this.Btn_CreateUser_Click);
            // 
            // btn_BackAdminDasboard
            // 
            this.btn_BackAdminDasboard.BackColor = System.Drawing.Color.Red;
            this.btn_BackAdminDasboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackAdminDasboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BackAdminDasboard.Location = new System.Drawing.Point(52, 39);
            this.btn_BackAdminDasboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BackAdminDasboard.Name = "btn_BackAdminDasboard";
            this.btn_BackAdminDasboard.Size = new System.Drawing.Size(172, 73);
            this.btn_BackAdminDasboard.TabIndex = 28;
            this.btn_BackAdminDasboard.Text = "Logout";
            this.btn_BackAdminDasboard.UseVisualStyleBackColor = false;
            this.btn_BackAdminDasboard.Click += new System.EventHandler(this.btn_BackAdminDasboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(801, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 326);
            this.panel3.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(723, 621);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 326);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_CreateUser);
            this.panel1.Controls.Add(this.Btn_ChangePassword);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(321, 621);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 326);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(463, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(958, 334);
            this.dataGridView1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(744, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // AdminAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_BackAdminDasboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminAllUsers";
            this.Text = "AdminAllUsers";
            this.Load += new System.EventHandler(this.AdminAllUsers_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_ChangePassword;
        private System.Windows.Forms.Button Btn_CreateUser;
        private System.Windows.Forms.Button btn_BackAdminDasboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}