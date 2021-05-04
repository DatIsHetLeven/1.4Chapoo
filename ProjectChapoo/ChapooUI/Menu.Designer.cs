namespace ChapooUI
{
    partial class Menu
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
            this.btn_Back_To_TableChoice = new System.Windows.Forms.Button();
            this.Btn_Order_Overview = new System.Windows.Forms.Button();
            this.btn_Drank = new System.Windows.Forms.Button();
            this.btn_Diner = new System.Windows.Forms.Button();
            this.btn_Lunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back_To_TableChoice
            // 
            this.btn_Back_To_TableChoice.Location = new System.Drawing.Point(48, 22);
            this.btn_Back_To_TableChoice.Name = "btn_Back_To_TableChoice";
            this.btn_Back_To_TableChoice.Size = new System.Drawing.Size(146, 44);
            this.btn_Back_To_TableChoice.TabIndex = 11;
            this.btn_Back_To_TableChoice.Text = "Back";
            this.btn_Back_To_TableChoice.UseVisualStyleBackColor = true;
            // 
            // Btn_Order_Overview
            // 
            this.Btn_Order_Overview.Location = new System.Drawing.Point(264, 338);
            this.Btn_Order_Overview.Name = "Btn_Order_Overview";
            this.Btn_Order_Overview.Size = new System.Drawing.Size(181, 64);
            this.Btn_Order_Overview.TabIndex = 10;
            this.Btn_Order_Overview.Text = "Bestelling Overzicht";
            this.Btn_Order_Overview.UseVisualStyleBackColor = true;
            // 
            // btn_Drank
            // 
            this.btn_Drank.Location = new System.Drawing.Point(264, 244);
            this.btn_Drank.Name = "btn_Drank";
            this.btn_Drank.Size = new System.Drawing.Size(181, 64);
            this.btn_Drank.TabIndex = 9;
            this.btn_Drank.Text = "Drank";
            this.btn_Drank.UseVisualStyleBackColor = true;
            // 
            // btn_Diner
            // 
            this.btn_Diner.Location = new System.Drawing.Point(264, 151);
            this.btn_Diner.Name = "btn_Diner";
            this.btn_Diner.Size = new System.Drawing.Size(181, 64);
            this.btn_Diner.TabIndex = 8;
            this.btn_Diner.Text = "Diner";
            this.btn_Diner.UseVisualStyleBackColor = true;
            // 
            // btn_Lunch
            // 
            this.btn_Lunch.Location = new System.Drawing.Point(264, 54);
            this.btn_Lunch.Name = "btn_Lunch";
            this.btn_Lunch.Size = new System.Drawing.Size(181, 64);
            this.btn_Lunch.TabIndex = 7;
            this.btn_Lunch.Text = "Lunch";
            this.btn_Lunch.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back_To_TableChoice);
            this.Controls.Add(this.Btn_Order_Overview);
            this.Controls.Add(this.btn_Drank);
            this.Controls.Add(this.btn_Diner);
            this.Controls.Add(this.btn_Lunch);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back_To_TableChoice;
        private System.Windows.Forms.Button Btn_Order_Overview;
        private System.Windows.Forms.Button btn_Drank;
        private System.Windows.Forms.Button btn_Diner;
        private System.Windows.Forms.Button btn_Lunch;
    }
}