namespace ChapooUI
{
    partial class OrderDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView_KlaarOmServeren = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AllesGeleverd = new System.Windows.Forms.Button();
            this.Geleverd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(292, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Klaar om te serveren";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(837, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(32, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(118, 40);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // listView_KlaarOmServeren
            // 
            this.listView_KlaarOmServeren.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_KlaarOmServeren.HideSelection = false;
            this.listView_KlaarOmServeren.Location = new System.Drawing.Point(144, 222);
            this.listView_KlaarOmServeren.Name = "listView_KlaarOmServeren";
            this.listView_KlaarOmServeren.Size = new System.Drawing.Size(484, 270);
            this.listView_KlaarOmServeren.TabIndex = 24;
            this.listView_KlaarOmServeren.UseCompatibleStateImageBehavior = false;
            this.listView_KlaarOmServeren.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Prijs";
            this.columnHeader3.Width = 115;
            // 
            // btn_AllesGeleverd
            // 
            this.btn_AllesGeleverd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_AllesGeleverd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AllesGeleverd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AllesGeleverd.Location = new System.Drawing.Point(296, 582);
            this.btn_AllesGeleverd.Name = "btn_AllesGeleverd";
            this.btn_AllesGeleverd.Size = new System.Drawing.Size(209, 45);
            this.btn_AllesGeleverd.TabIndex = 25;
            this.btn_AllesGeleverd.Text = "Geleverd";
            this.btn_AllesGeleverd.UseVisualStyleBackColor = false;
            this.btn_AllesGeleverd.Click += new System.EventHandler(this.btn_AllesGeleverd_Click);
            // 
            // Geleverd
            // 
            this.Geleverd.AutoSize = true;
            this.Geleverd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Geleverd.Location = new System.Drawing.Point(911, 199);
            this.Geleverd.Name = "Geleverd";
            this.Geleverd.Size = new System.Drawing.Size(73, 20);
            this.Geleverd.TabIndex = 11;
            this.Geleverd.Text = "Geleverd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Items nog in de keuken :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(719, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 270);
            this.panel1.TabIndex = 26;
            // 
            // OrderDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_AllesGeleverd);
            this.Controls.Add(this.listView_KlaarOmServeren);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Geleverd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderDashboard";
            this.Text = "OrderDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView_KlaarOmServeren;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_AllesGeleverd;
        private System.Windows.Forms.Label Geleverd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}