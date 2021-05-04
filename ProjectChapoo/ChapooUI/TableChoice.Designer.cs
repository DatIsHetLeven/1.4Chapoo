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
            this.Btn_Orders_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_FreeTable
            // 
            this.Btn_FreeTable.Location = new System.Drawing.Point(858, 11);
            this.Btn_FreeTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_FreeTable.Name = "Btn_FreeTable";
            this.Btn_FreeTable.Size = new System.Drawing.Size(240, 94);
            this.Btn_FreeTable.TabIndex = 12;
            this.Btn_FreeTable.Text = "Free Table";
            this.Btn_FreeTable.UseVisualStyleBackColor = true;
            this.Btn_FreeTable.Click += new System.EventHandler(this.Btn_FreeTable_Click);
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(60, 18);
            this.btn_Back_To_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(219, 68);
            this.btn_Back_To_Dashboard.TabIndex = 11;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // lbl_Show_Table_Number
            // 
            this.lbl_Show_Table_Number.AutoSize = true;
            this.lbl_Show_Table_Number.Location = new System.Drawing.Point(402, 18);
            this.lbl_Show_Table_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Show_Table_Number.Name = "lbl_Show_Table_Number";
            this.lbl_Show_Table_Number.Size = new System.Drawing.Size(0, 20);
            this.lbl_Show_Table_Number.TabIndex = 10;
            // 
            // btn_Reservate
            // 
            this.btn_Reservate.Location = new System.Drawing.Point(406, 475);
            this.btn_Reservate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reservate.Name = "btn_Reservate";
            this.btn_Reservate.Size = new System.Drawing.Size(369, 149);
            this.btn_Reservate.TabIndex = 9;
            this.btn_Reservate.Text = "Reservate";
            this.btn_Reservate.UseVisualStyleBackColor = true;
            this.btn_Reservate.Click += new System.EventHandler(this.btn_Reservate_Click);
            // 
            // btn_Bon
            // 
            this.btn_Bon.Location = new System.Drawing.Point(406, 280);
            this.btn_Bon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Bon.Name = "btn_Bon";
            this.btn_Bon.Size = new System.Drawing.Size(369, 149);
            this.btn_Bon.TabIndex = 8;
            this.btn_Bon.Text = "Receipt";
            this.btn_Bon.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(406, 86);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(369, 149);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // Btn_Orders_Click
            // 
            this.Btn_Orders_Click.Location = new System.Drawing.Point(406, 649);
            this.Btn_Orders_Click.Name = "Btn_Orders_Click";
            this.Btn_Orders_Click.Size = new System.Drawing.Size(369, 91);
            this.Btn_Orders_Click.TabIndex = 13;
            this.Btn_Orders_Click.Text = "Order";
            this.Btn_Orders_Click.UseVisualStyleBackColor = true;
            this.Btn_Orders_Click.Click += new System.EventHandler(this.Btn_Orders_Click_Click);
            // 
            // TableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.Btn_Orders_Click);
            this.Controls.Add(this.Btn_FreeTable);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.lbl_Show_Table_Number);
            this.Controls.Add(this.btn_Reservate);
            this.Controls.Add(this.btn_Bon);
            this.Controls.Add(this.btn_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button Btn_Orders_Click;
    }
}