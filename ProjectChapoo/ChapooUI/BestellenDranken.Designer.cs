namespace ChapooUI
{
    partial class BestellenDranken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestellenDranken));
            this.drop_InvoerAantal = new System.Windows.Forms.ComboBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.datagrid_Making = new System.Windows.Forms.DataGridView();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Go_Lunch = new System.Windows.Forms.Button();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_Lunch = new System.Windows.Forms.DataGridView();
            this.btn_Go_Drinks = new System.Windows.Forms.Button();
            this.Btn_GoDiner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_Table_Drank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).BeginInit();
            this.SuspendLayout();
            // 
            // drop_InvoerAantal
            // 
            this.drop_InvoerAantal.FormattingEnabled = true;
            this.drop_InvoerAantal.Location = new System.Drawing.Point(1700, 225);
            this.drop_InvoerAantal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drop_InvoerAantal.Name = "drop_InvoerAantal";
            this.drop_InvoerAantal.Size = new System.Drawing.Size(148, 28);
            this.drop_InvoerAantal.TabIndex = 52;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete.Location = new System.Drawing.Point(402, 760);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(141, 40);
            this.Btn_Delete.TabIndex = 50;
            this.Btn_Delete.Text = "Verwijderen";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // datagrid_Making
            // 
            this.datagrid_Making.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Making.Location = new System.Drawing.Point(97, 200);
            this.datagrid_Making.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagrid_Making.Name = "datagrid_Making";
            this.datagrid_Making.ReadOnly = true;
            this.datagrid_Making.RowHeadersWidth = 62;
            this.datagrid_Making.Size = new System.Drawing.Size(747, 520);
            this.datagrid_Making.TabIndex = 49;
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.BackColor = System.Drawing.Color.Red;
            this.btn_Back_To_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Back_To_Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(48, 38);
            this.btn_Back_To_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(130, 52);
            this.btn_Back_To_Dashboard.TabIndex = 47;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(925, -13);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 1065);
            this.panel4.TabIndex = 46;
            // 
            // btn_Go_Lunch
            // 
            this.btn_Go_Lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Go_Lunch.Location = new System.Drawing.Point(1030, 58);
            this.btn_Go_Lunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Go_Lunch.Name = "btn_Go_Lunch";
            this.btn_Go_Lunch.Size = new System.Drawing.Size(202, 75);
            this.btn_Go_Lunch.TabIndex = 45;
            this.btn_Go_Lunch.Text = "Lunch";
            this.btn_Go_Lunch.UseVisualStyleBackColor = true;
            this.btn_Go_Lunch.Click += new System.EventHandler(this.btn_Go_Lunch_Click);
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_bestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_bestellen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bestellen.Location = new System.Drawing.Point(1162, 760);
            this.btn_bestellen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(347, 54);
            this.btn_bestellen.TabIndex = 44;
            this.btn_bestellen.Text = "Toevoegen";
            this.btn_bestellen.UseVisualStyleBackColor = false;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1704, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Aantal:";
            // 
            // datagrid_Lunch
            // 
            this.datagrid_Lunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid_Lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Lunch.Location = new System.Drawing.Point(1030, 200);
            this.datagrid_Lunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagrid_Lunch.Name = "datagrid_Lunch";
            this.datagrid_Lunch.ReadOnly = true;
            this.datagrid_Lunch.RowHeadersWidth = 62;
            this.datagrid_Lunch.Size = new System.Drawing.Size(622, 520);
            this.datagrid_Lunch.TabIndex = 42;
            // 
            // btn_Go_Drinks
            // 
            this.btn_Go_Drinks.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Go_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Go_Drinks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Go_Drinks.Location = new System.Drawing.Point(1562, 58);
            this.btn_Go_Drinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Go_Drinks.Name = "btn_Go_Drinks";
            this.btn_Go_Drinks.Size = new System.Drawing.Size(202, 75);
            this.btn_Go_Drinks.TabIndex = 41;
            this.btn_Go_Drinks.Text = "Dranken";
            this.btn_Go_Drinks.UseVisualStyleBackColor = false;
            // 
            // Btn_GoDiner
            // 
            this.Btn_GoDiner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_GoDiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_GoDiner.Location = new System.Drawing.Point(1294, 58);
            this.Btn_GoDiner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_GoDiner.Name = "Btn_GoDiner";
            this.Btn_GoDiner.Size = new System.Drawing.Size(202, 75);
            this.Btn_GoDiner.TabIndex = 40;
            this.Btn_GoDiner.Text = "Diner";
            this.Btn_GoDiner.UseVisualStyleBackColor = false;
            this.Btn_GoDiner.Click += new System.EventHandler(this.Btn_GoDiner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(285, 829);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 54);
            this.button1.TabIndex = 53;
            this.button1.Text = "Bestellen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_Table_Drank
            // 
            this.Lbl_Table_Drank.AutoSize = true;
            this.Lbl_Table_Drank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl_Table_Drank.Location = new System.Drawing.Point(309, 75);
            this.Lbl_Table_Drank.Name = "Lbl_Table_Drank";
            this.Lbl_Table_Drank.Size = new System.Drawing.Size(0, 36);
            this.Lbl_Table_Drank.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(303, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 54;
            // 
            // BestellenDranken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 976);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Table_Drank);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drop_InvoerAantal);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.datagrid_Making);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Go_Lunch);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_Lunch);
            this.Controls.Add(this.btn_Go_Drinks);
            this.Controls.Add(this.Btn_GoDiner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BestellenDranken";
            this.Text = "BestellenDranken";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BestellenDranken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drop_InvoerAantal;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView datagrid_Making;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Go_Lunch;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_Lunch;
        private System.Windows.Forms.Button btn_Go_Drinks;
        private System.Windows.Forms.Button Btn_GoDiner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_Table_Drank;
        private System.Windows.Forms.Label label2;
    }
}