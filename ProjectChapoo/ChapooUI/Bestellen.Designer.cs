namespace ChapooUI
{
    partial class Bestellen
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
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.datagrid_Making = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.drop_InvoerAantal = new System.Windows.Forms.ComboBox();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_Lunch = new System.Windows.Forms.DataGridView();
            this.Btn_Go_Drinks = new System.Windows.Forms.Button();
            this.Btn_Go_Diner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Lime;
            this.Btn_Refresh.Location = new System.Drawing.Point(545, 11);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(82, 66);
            this.Btn_Refresh.TabIndex = 46;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete.Location = new System.Drawing.Point(510, 120);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(91, 26);
            this.Btn_Delete.TabIndex = 45;
            this.Btn_Delete.Text = "Verwijderen X";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // datagrid_Making
            // 
            this.datagrid_Making.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Making.Location = new System.Drawing.Point(35, 120);
            this.datagrid_Making.Name = "datagrid_Making";
            this.datagrid_Making.ReadOnly = true;
            this.datagrid_Making.Size = new System.Drawing.Size(456, 120);
            this.datagrid_Making.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Bestelling";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(657, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 681);
            this.panel4.TabIndex = 42;
            // 
            // drop_InvoerAantal
            // 
            this.drop_InvoerAantal.FormattingEnabled = true;
            this.drop_InvoerAantal.Location = new System.Drawing.Point(1149, 136);
            this.drop_InvoerAantal.Name = "drop_InvoerAantal";
            this.drop_InvoerAantal.Size = new System.Drawing.Size(100, 21);
            this.drop_InvoerAantal.TabIndex = 41;
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(15, 11);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(87, 34);
            this.btn_Back_To_Dashboard.TabIndex = 40;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(685, 484);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(415, 35);
            this.btn_bestellen.TabIndex = 39;
            this.btn_bestellen.Text = "Toevoegen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1146, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Aantal:";
            // 
            // datagrid_Lunch
            // 
            this.datagrid_Lunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Lunch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_Lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Lunch.Location = new System.Drawing.Point(685, 120);
            this.datagrid_Lunch.Name = "datagrid_Lunch";
            this.datagrid_Lunch.ReadOnly = true;
            this.datagrid_Lunch.Size = new System.Drawing.Size(415, 338);
            this.datagrid_Lunch.TabIndex = 37;
            // 
            // Btn_Go_Drinks
            // 
            this.Btn_Go_Drinks.Location = new System.Drawing.Point(1051, 28);
            this.Btn_Go_Drinks.Name = "Btn_Go_Drinks";
            this.Btn_Go_Drinks.Size = new System.Drawing.Size(135, 49);
            this.Btn_Go_Drinks.TabIndex = 36;
            this.Btn_Go_Drinks.Text = "Dranken";
            this.Btn_Go_Drinks.UseVisualStyleBackColor = true;
            this.Btn_Go_Drinks.Click += new System.EventHandler(this.Btn_Go_Drinks_Click);
            // 
            // Btn_Go_Diner
            // 
            this.Btn_Go_Diner.Location = new System.Drawing.Point(873, 28);
            this.Btn_Go_Diner.Name = "Btn_Go_Diner";
            this.Btn_Go_Diner.Size = new System.Drawing.Size(135, 49);
            this.Btn_Go_Diner.TabIndex = 35;
            this.Btn_Go_Diner.Text = "Diner";
            this.Btn_Go_Diner.UseVisualStyleBackColor = true;
            this.Btn_Go_Diner.Click += new System.EventHandler(this.Btn_Go_Diner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(685, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "Lunch";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 35);
            this.button2.TabIndex = 47;
            this.button2.Text = "Bestellen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.datagrid_Making);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.drop_InvoerAantal);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_Lunch);
            this.Controls.Add(this.Btn_Go_Drinks);
            this.Controls.Add(this.Btn_Go_Diner);
            this.Controls.Add(this.button1);
            this.Name = "Bestellen";
            this.Text = "Bestellen";
            this.Load += new System.EventHandler(this.Bestellen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView datagrid_Making;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox drop_InvoerAantal;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_Lunch;
        private System.Windows.Forms.Button Btn_Go_Drinks;
        private System.Windows.Forms.Button Btn_Go_Diner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}