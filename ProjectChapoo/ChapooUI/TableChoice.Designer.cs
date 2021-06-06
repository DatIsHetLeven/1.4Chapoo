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
            this.Btn_Go_Overzicht = new System.Windows.Forms.Button();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.Btn_FreeTable = new System.Windows.Forms.Button();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.lbl_Show_Table_Number = new System.Windows.Forms.Label();
            this.btn_Reservate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Go_Overzicht
            // 
            this.Btn_Go_Overzicht.Location = new System.Drawing.Point(534, 274);
            this.Btn_Go_Overzicht.Name = "Btn_Go_Overzicht";
            this.Btn_Go_Overzicht.Size = new System.Drawing.Size(252, 84);
            this.Btn_Go_Overzicht.TabIndex = 17;
            this.Btn_Go_Overzicht.Text = "Bestelling Overzicht";
            this.Btn_Go_Overzicht.UseVisualStyleBackColor = true;
            this.Btn_Go_Overzicht.Click += new System.EventHandler(this.Btn_Go_Overzicht_Click);
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(534, 159);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(252, 84);
            this.btn_bestellen.TabIndex = 16;
            this.btn_bestellen.Text = "Bestellen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // Btn_FreeTable
            // 
            this.Btn_FreeTable.Location = new System.Drawing.Point(1096, 12);
            this.Btn_FreeTable.Name = "Btn_FreeTable";
            this.Btn_FreeTable.Size = new System.Drawing.Size(119, 51);
            this.Btn_FreeTable.TabIndex = 15;
            this.Btn_FreeTable.Text = "Free Table";
            this.Btn_FreeTable.UseVisualStyleBackColor = true;
            this.Btn_FreeTable.Click += new System.EventHandler(this.Btn_FreeTable_Click);
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(12, 12);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(121, 51);
            this.btn_Back_To_Dashboard.TabIndex = 14;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // lbl_Show_Table_Number
            // 
            this.lbl_Show_Table_Number.AutoSize = true;
            this.lbl_Show_Table_Number.Location = new System.Drawing.Point(258, 22);
            this.lbl_Show_Table_Number.Name = "lbl_Show_Table_Number";
            this.lbl_Show_Table_Number.Size = new System.Drawing.Size(0, 13);
            this.lbl_Show_Table_Number.TabIndex = 13;
            // 
            // btn_Reservate
            // 
            this.btn_Reservate.Location = new System.Drawing.Point(534, 394);
            this.btn_Reservate.Name = "btn_Reservate";
            this.btn_Reservate.Size = new System.Drawing.Size(252, 84);
            this.btn_Reservate.TabIndex = 12;
            this.btn_Reservate.Text = "Reservate";
            this.btn_Reservate.UseVisualStyleBackColor = true;
            this.btn_Reservate.Click += new System.EventHandler(this.btn_Reservate_Click);
            // 
            // TableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Btn_Go_Overzicht);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.Btn_FreeTable);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.lbl_Show_Table_Number);
            this.Controls.Add(this.btn_Reservate);
            this.Name = "TableChoice";
            this.Text = "TableChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Go_Overzicht;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Button Btn_FreeTable;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.Label lbl_Show_Table_Number;
        private System.Windows.Forms.Button btn_Reservate;
    }
}