namespace ChapooUI
{
    partial class AdminCreateUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.drop_UserRol = new System.Windows.Forms.ComboBox();
            this.btn_CreateNewUser = new System.Windows.Forms.Button();
            this.txt_UserPassword = new System.Windows.Forms.TextBox();
            this.txt_NewUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.drop_UserRol);
            this.panel1.Controls.Add(this.btn_CreateNewUser);
            this.panel1.Controls.Add(this.txt_UserPassword);
            this.panel1.Controls.Add(this.txt_NewUserName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(59, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 212);
            this.panel1.TabIndex = 23;
            // 
            // drop_UserRol
            // 
            this.drop_UserRol.FormattingEnabled = true;
            this.drop_UserRol.Location = new System.Drawing.Point(86, 123);
            this.drop_UserRol.Name = "drop_UserRol";
            this.drop_UserRol.Size = new System.Drawing.Size(100, 21);
            this.drop_UserRol.TabIndex = 28;
            // 
            // btn_CreateNewUser
            // 
            this.btn_CreateNewUser.BackColor = System.Drawing.SystemColors.Window;
            this.btn_CreateNewUser.Location = new System.Drawing.Point(61, 178);
            this.btn_CreateNewUser.Name = "btn_CreateNewUser";
            this.btn_CreateNewUser.Size = new System.Drawing.Size(137, 23);
            this.btn_CreateNewUser.TabIndex = 20;
            this.btn_CreateNewUser.Text = "Create user";
            this.btn_CreateNewUser.UseVisualStyleBackColor = false;
            this.btn_CreateNewUser.Click += new System.EventHandler(this.btn_CreateNewUser_Click);
            // 
            // txt_UserPassword
            // 
            this.txt_UserPassword.Location = new System.Drawing.Point(86, 91);
            this.txt_UserPassword.Name = "txt_UserPassword";
            this.txt_UserPassword.PasswordChar = '*';
            this.txt_UserPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_UserPassword.TabIndex = 21;
            // 
            // txt_NewUserName
            // 
            this.txt_NewUserName.Location = new System.Drawing.Point(86, 60);
            this.txt_NewUserName.Name = "txt_NewUserName";
            this.txt_NewUserName.Size = new System.Drawing.Size(100, 20);
            this.txt_NewUserName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "User rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Create new user";
            // 
            // AdminCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 299);
            this.Controls.Add(this.panel1);
            this.Name = "AdminCreateUser";
            this.Text = "AdminCreateUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox drop_UserRol;
        private System.Windows.Forms.Button btn_CreateNewUser;
        private System.Windows.Forms.TextBox txt_UserPassword;
        private System.Windows.Forms.TextBox txt_NewUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}