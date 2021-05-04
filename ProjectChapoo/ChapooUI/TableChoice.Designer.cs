namespace ChapooUI
{
    partial class TableChoice
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
            this.Btn_FreeTable = new System.Windows.Forms.Button();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.lbl_Show_Table_Number = new System.Windows.Forms.Label();
            this.btn_Reservate = new System.Windows.Forms.Button();
            this.btn_Bon = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_FreeTable
            // 
            this.Btn_FreeTable.Location = new System.Drawing.Point(572, 7);
            this.Btn_FreeTable.Name = "Btn_FreeTable";
            this.Btn_FreeTable.Size = new System.Drawing.Size(160, 61);
            this.Btn_FreeTable.TabIndex = 12;
            this.Btn_FreeTable.Text = "Free Table";
            this.Btn_FreeTable.UseVisualStyleBackColor = true;
            this.Btn_FreeTable.Click += new System.EventHandler(this.Btn_FreeTable_Click);
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(40, 12);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(146, 44);
            this.btn_Back_To_Dashboard.TabIndex = 11;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // lbl_Show_Table_Number
            // 
            this.lbl_Show_Table_Number.AutoSize = true;
            this.lbl_Show_Table_Number.Location = new System.Drawing.Point(268, 12);
            this.lbl_Show_Table_Number.Name = "lbl_Show_Table_Number";
            this.lbl_Show_Table_Number.Size = new System.Drawing.Size(0, 13);
            this.lbl_Show_Table_Number.TabIndex = 10;
            // 
            // btn_Reservate
            // 
            this.btn_Reservate.Location = new System.Drawing.Point(271, 373);
            this.btn_Reservate.Name = "btn_Reservate";
            this.btn_Reservate.Size = new System.Drawing.Size(246, 97);
            this.btn_Reservate.TabIndex = 9;
            this.btn_Reservate.Text = "Reservate";
            this.btn_Reservate.UseVisualStyleBackColor = true;
            this.btn_Reservate.Click += new System.EventHandler(this.btn_Reservate_Click);
            // 
            // btn_Bon
            // 
            this.btn_Bon.Location = new System.Drawing.Point(271, 214);
            this.btn_Bon.Name = "btn_Bon";
            this.btn_Bon.Size = new System.Drawing.Size(246, 97);
            this.btn_Bon.TabIndex = 8;
            this.btn_Bon.Text = "Receipt";
            this.btn_Bon.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(271, 56);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(246, 97);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // TableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.Btn_FreeTable);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.lbl_Show_Table_Number);
            this.Controls.Add(this.btn_Reservate);
            this.Controls.Add(this.btn_Bon);
            this.Controls.Add(this.btn_Menu);
            this.Name = "TableChoice";
            this.Text = "TableChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_FreeTable;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.Label lbl_Show_Table_Number;
        private System.Windows.Forms.Button btn_Reservate;
        private System.Windows.Forms.Button btn_Bon;
        private System.Windows.Forms.Button btn_Menu;
    }
}