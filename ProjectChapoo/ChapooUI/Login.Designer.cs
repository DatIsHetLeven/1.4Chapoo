namespace ChapooUI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_resetPsswrd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Inloggen = new System.Windows.Forms.Button();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.lbl_gebruikersnaam = new System.Windows.Forms.Label();
            this.txt_LoginPassword = new System.Windows.Forms.TextBox();
            this.txt_LoginUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_resetPsswrd
            // 
            this.btn_resetPsswrd.Location = new System.Drawing.Point(724, 374);
            this.btn_resetPsswrd.Name = "btn_resetPsswrd";
            this.btn_resetPsswrd.Size = new System.Drawing.Size(75, 23);
            this.btn_resetPsswrd.TabIndex = 21;
            this.btn_resetPsswrd.Text = "Forgot Password";
            this.btn_resetPsswrd.UseVisualStyleBackColor = true;
            this.btn_resetPsswrd.Click += new System.EventHandler(this.btn_resetPsswrd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1041, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Inloggen
            // 
            this.btn_Inloggen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Inloggen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Inloggen.Location = new System.Drawing.Point(453, 453);
            this.btn_Inloggen.Name = "btn_Inloggen";
            this.btn_Inloggen.Size = new System.Drawing.Size(182, 63);
            this.btn_Inloggen.TabIndex = 19;
            this.btn_Inloggen.Text = "Inloggen";
            this.btn_Inloggen.UseVisualStyleBackColor = false;
            this.btn_Inloggen.Click += new System.EventHandler(this.btn_Inloggen_Click_1);
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(450, 318);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lbl_wachtwoord.TabIndex = 18;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // lbl_gebruikersnaam
            // 
            this.lbl_gebruikersnaam.AutoSize = true;
            this.lbl_gebruikersnaam.Location = new System.Drawing.Point(450, 223);
            this.lbl_gebruikersnaam.Name = "lbl_gebruikersnaam";
            this.lbl_gebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.lbl_gebruikersnaam.TabIndex = 17;
            this.lbl_gebruikersnaam.Text = "Gebruikersnaam";
            // 
            // txt_LoginPassword
            // 
            this.txt_LoginPassword.Location = new System.Drawing.Point(453, 344);
            this.txt_LoginPassword.Name = "txt_LoginPassword";
            this.txt_LoginPassword.PasswordChar = '*';
            this.txt_LoginPassword.Size = new System.Drawing.Size(269, 20);
            this.txt_LoginPassword.TabIndex = 16;
            // 
            // txt_LoginUsername
            // 
            this.txt_LoginUsername.Location = new System.Drawing.Point(453, 248);
            this.txt_LoginUsername.Name = "txt_LoginUsername";
            this.txt_LoginUsername.Size = new System.Drawing.Size(269, 20);
            this.txt_LoginUsername.TabIndex = 15;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_resetPsswrd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Inloggen);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.lbl_gebruikersnaam);
            this.Controls.Add(this.txt_LoginPassword);
            this.Controls.Add(this.txt_LoginUsername);
            this.Name = "login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resetPsswrd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Inloggen;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Label lbl_gebruikersnaam;
        private System.Windows.Forms.TextBox txt_LoginPassword;
        private System.Windows.Forms.TextBox txt_LoginUsername;
    }
}