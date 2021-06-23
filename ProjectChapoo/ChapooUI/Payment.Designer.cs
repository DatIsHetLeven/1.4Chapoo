namespace ChapooUI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_PayIdeal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TotaalPrijsMetFooi = new System.Windows.Forms.Label();
            this.lbl_TotaalBtw = new System.Windows.Forms.Label();
            this.lbl_TotaalPrijsZonderFooi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TipAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listview_AlleItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(675, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 163);
            this.panel3.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(32, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(43, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "CASH";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btn_PayIdeal);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(422, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 163);
            this.panel2.TabIndex = 20;
            // 
            // btn_PayIdeal
            // 
            this.btn_PayIdeal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PayIdeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PayIdeal.Location = new System.Drawing.Point(33, 122);
            this.btn_PayIdeal.Name = "btn_PayIdeal";
            this.btn_PayIdeal.Size = new System.Drawing.Size(114, 34);
            this.btn_PayIdeal.TabIndex = 17;
            this.btn_PayIdeal.Text = "Pay";
            this.btn_PayIdeal.UseVisualStyleBackColor = false;
            this.btn_PayIdeal.Click += new System.EventHandler(this.btn_PayIdeal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(68, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "PIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(820, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bon";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbl_TotaalPrijsMetFooi);
            this.panel1.Controls.Add(this.lbl_TotaalBtw);
            this.panel1.Controls.Add(this.lbl_TotaalPrijsZonderFooi);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Btn_Refresh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_TipAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(675, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 246);
            this.panel1.TabIndex = 18;
            // 
            // lbl_TotaalPrijsMetFooi
            // 
            this.lbl_TotaalPrijsMetFooi.AutoSize = true;
            this.lbl_TotaalPrijsMetFooi.Location = new System.Drawing.Point(160, 197);
            this.lbl_TotaalPrijsMetFooi.Name = "lbl_TotaalPrijsMetFooi";
            this.lbl_TotaalPrijsMetFooi.Size = new System.Drawing.Size(41, 13);
            this.lbl_TotaalPrijsMetFooi.TabIndex = 53;
            this.lbl_TotaalPrijsMetFooi.Text = "label10";
            // 
            // lbl_TotaalBtw
            // 
            this.lbl_TotaalBtw.AutoSize = true;
            this.lbl_TotaalBtw.Location = new System.Drawing.Point(160, 82);
            this.lbl_TotaalBtw.Name = "lbl_TotaalBtw";
            this.lbl_TotaalBtw.Size = new System.Drawing.Size(41, 13);
            this.lbl_TotaalBtw.TabIndex = 52;
            this.lbl_TotaalBtw.Text = "label10";
            // 
            // lbl_TotaalPrijsZonderFooi
            // 
            this.lbl_TotaalPrijsZonderFooi.AutoSize = true;
            this.lbl_TotaalPrijsZonderFooi.Location = new System.Drawing.Point(160, 44);
            this.lbl_TotaalPrijsZonderFooi.Name = "lbl_TotaalPrijsZonderFooi";
            this.lbl_TotaalPrijsZonderFooi.Size = new System.Drawing.Size(41, 13);
            this.lbl_TotaalPrijsZonderFooi.TabIndex = 51;
            this.lbl_TotaalPrijsZonderFooi.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(29, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "BTW";
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Refresh.Location = new System.Drawing.Point(163, 144);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(139, 36);
            this.Btn_Refresh.TabIndex = 48;
            this.Btn_Refresh.Text = "Add Tip";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(28, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Amount ";
            // 
            // txt_TipAmount
            // 
            this.txt_TipAmount.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_TipAmount.Location = new System.Drawing.Point(163, 118);
            this.txt_TipAmount.Name = "txt_TipAmount";
            this.txt_TipAmount.Size = new System.Drawing.Size(140, 20);
            this.txt_TipAmount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tip ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Price ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(578, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chose Payment";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Red;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LogOut.Location = new System.Drawing.Point(41, 32);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(101, 35);
            this.btn_LogOut.TabIndex = 49;
            this.btn_LogOut.Text = "Back";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(522, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 123);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // listview_AlleItems
            // 
            this.listview_AlleItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listview_AlleItems.HideSelection = false;
            this.listview_AlleItems.Location = new System.Drawing.Point(162, 153);
            this.listview_AlleItems.Name = "listview_AlleItems";
            this.listview_AlleItems.Size = new System.Drawing.Size(420, 212);
            this.listview_AlleItems.TabIndex = 51;
            this.listview_AlleItems.UseCompatibleStateImageBehavior = false;
            this.listview_AlleItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MenuItem";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prijs";
            this.columnHeader2.Width = 56;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aantal";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BTW";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(308, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Alle items";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listview_AlleItems);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_PayIdeal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TipAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_TotaalBtw;
        private System.Windows.Forms.Label lbl_TotaalPrijsZonderFooi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listview_AlleItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbl_TotaalPrijsMetFooi;
    }
}