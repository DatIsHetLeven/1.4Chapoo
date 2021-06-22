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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bestellen));
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.datagrid_Making = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.drop_InvoerAantal = new System.Windows.Forms.ComboBox();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Go_Drinks = new System.Windows.Forms.Button();
            this.Btn_Go_Diner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_Table_Lunch = new System.Windows.Forms.Label();
            this.listView_Lunch = new System.Windows.Forms.ListView();
            this.ItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete.Location = new System.Drawing.Point(273, 500);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(95, 26);
            this.Btn_Delete.TabIndex = 45;
            this.Btn_Delete.Text = "Verwijderen";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // datagrid_Making
            // 
            this.datagrid_Making.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Making.Location = new System.Drawing.Point(28, 136);
            this.datagrid_Making.Name = "datagrid_Making";
            this.datagrid_Making.ReadOnly = true;
            this.datagrid_Making.RowHeadersWidth = 62;
            this.datagrid_Making.Size = new System.Drawing.Size(563, 338);
            this.datagrid_Making.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(622, -22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 714);
            this.panel4.TabIndex = 42;
            // 
            // drop_InvoerAantal
            // 
            this.drop_InvoerAantal.FormattingEnabled = true;
            this.drop_InvoerAantal.Location = new System.Drawing.Point(1123, 157);
            this.drop_InvoerAantal.Name = "drop_InvoerAantal";
            this.drop_InvoerAantal.Size = new System.Drawing.Size(129, 21);
            this.drop_InvoerAantal.TabIndex = 41;
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.BackColor = System.Drawing.Color.Red;
            this.btn_Back_To_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Back_To_Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(28, 28);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(87, 34);
            this.btn_Back_To_Dashboard.TabIndex = 40;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_bestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_bestellen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bestellen.Location = new System.Drawing.Point(803, 500);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(200, 35);
            this.btn_bestellen.TabIndex = 39;
            this.btn_bestellen.Text = "Toevoegen";
            this.btn_bestellen.UseVisualStyleBackColor = false;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(1120, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Aantal:";
            // 
            // Btn_Go_Drinks
            // 
            this.Btn_Go_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.Btn_Go_Diner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Go_Diner.Location = new System.Drawing.Point(868, 28);
            this.Btn_Go_Diner.Name = "Btn_Go_Diner";
            this.Btn_Go_Diner.Size = new System.Drawing.Size(135, 49);
            this.Btn_Go_Diner.TabIndex = 35;
            this.Btn_Go_Diner.Text = "Diner";
            this.Btn_Go_Diner.UseVisualStyleBackColor = true;
            this.Btn_Go_Diner.Click += new System.EventHandler(this.Btn_Go_Diner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(685, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "Lunch";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(198, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 35);
            this.button2.TabIndex = 47;
            this.button2.Text = "Bestellen";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_Table_Lunch
            // 
            this.Lbl_Table_Lunch.AutoSize = true;
            this.Lbl_Table_Lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl_Table_Lunch.Location = new System.Drawing.Point(205, 39);
            this.Lbl_Table_Lunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Table_Lunch.Name = "Lbl_Table_Lunch";
            this.Lbl_Table_Lunch.Size = new System.Drawing.Size(0, 25);
            this.Lbl_Table_Lunch.TabIndex = 48;
            // 
            // listView_Lunch
            // 
            this.listView_Lunch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Lunch.HideSelection = false;
            this.listView_Lunch.Location = new System.Drawing.Point(670, 136);
            this.listView_Lunch.Name = "listView_Lunch";
            this.listView_Lunch.Size = new System.Drawing.Size(416, 338);
            this.listView_Lunch.TabIndex = 49;
            this.listView_Lunch.UseCompatibleStateImageBehavior = false;
            this.listView_Lunch.View = System.Windows.Forms.View.Details;
            // 
            // ItemId
            // 
            this.ItemId.Text = "ItemId";
            this.ItemId.Width = 69;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MenuItem";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Categorie";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prijs";
            this.columnHeader3.Width = 94;
            // 
            // Bestellen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listView_Lunch);
            this.Controls.Add(this.Lbl_Table_Lunch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.datagrid_Making);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.drop_InvoerAantal);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Go_Drinks);
            this.Controls.Add(this.Btn_Go_Diner);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bestellen";
            this.Text = "Bestellen";
            this.Load += new System.EventHandler(this.Bestellen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView datagrid_Making;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox drop_InvoerAantal;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Go_Drinks;
        private System.Windows.Forms.Button Btn_Go_Diner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_Table_Lunch;
        private System.Windows.Forms.ListView listView_Lunch;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}