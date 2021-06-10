namespace ChapooUI
{
    partial class AdminChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangePassword));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddPrivateKey = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PrivateKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.drop_UserId = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_AddPrivateKey);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_PrivateKey);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.drop_UserId);
            this.panel2.Location = new System.Drawing.Point(-5, -3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 431);
            this.panel2.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 36);
            this.label3.TabIndex = 28;
            this.label3.Text = "Change password user";
            // 
            // btn_AddPrivateKey
            // 
            this.btn_AddPrivateKey.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_AddPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_AddPrivateKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddPrivateKey.Location = new System.Drawing.Point(133, 297);
            this.btn_AddPrivateKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddPrivateKey.Name = "btn_AddPrivateKey";
            this.btn_AddPrivateKey.Size = new System.Drawing.Size(252, 61);
            this.btn_AddPrivateKey.TabIndex = 33;
            this.btn_AddPrivateKey.Text = "Add Private Key";
            this.btn_AddPrivateKey.UseVisualStyleBackColor = false;
            this.btn_AddPrivateKey.Click += new System.EventHandler(this.btn_AddPrivateKey_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "User Id";
            // 
            // txt_PrivateKey
            // 
            this.txt_PrivateKey.Location = new System.Drawing.Point(266, 201);
            this.txt_PrivateKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PrivateKey.Name = "txt_PrivateKey";
            this.txt_PrivateKey.Size = new System.Drawing.Size(180, 26);
            this.txt_PrivateKey.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Private Key:";
            // 
            // drop_UserId
            // 
            this.drop_UserId.FormattingEnabled = true;
            this.drop_UserId.Location = new System.Drawing.Point(266, 137);
            this.drop_UserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drop_UserId.Name = "drop_UserId";
            this.drop_UserId.Size = new System.Drawing.Size(180, 28);
            this.drop_UserId.TabIndex = 31;
            // 
            // AdminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 411);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminChangePassword";
            this.Text = "AdminChangePassword";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddPrivateKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PrivateKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox drop_UserId;
    }
}