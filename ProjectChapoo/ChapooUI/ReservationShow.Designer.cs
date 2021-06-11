namespace ChapooUI
{
    partial class ReservationShow
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Gereserveerd = new System.Windows.Forms.Label();
            this.lbl_Tijd = new System.Windows.Forms.Label();
            this.lbl_KlantNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(81, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Reservering tonen";
            // 
            // lbl_Gereserveerd
            // 
            this.lbl_Gereserveerd.AutoSize = true;
            this.lbl_Gereserveerd.Location = new System.Drawing.Point(32, 75);
            this.lbl_Gereserveerd.Name = "lbl_Gereserveerd";
            this.lbl_Gereserveerd.Size = new System.Drawing.Size(0, 13);
            this.lbl_Gereserveerd.TabIndex = 51;
            // 
            // lbl_Tijd
            // 
            this.lbl_Tijd.AutoSize = true;
            this.lbl_Tijd.Location = new System.Drawing.Point(32, 122);
            this.lbl_Tijd.Name = "lbl_Tijd";
            this.lbl_Tijd.Size = new System.Drawing.Size(0, 13);
            this.lbl_Tijd.TabIndex = 52;
            // 
            // lbl_KlantNaam
            // 
            this.lbl_KlantNaam.AutoSize = true;
            this.lbl_KlantNaam.Location = new System.Drawing.Point(32, 167);
            this.lbl_KlantNaam.Name = "lbl_KlantNaam";
            this.lbl_KlantNaam.Size = new System.Drawing.Size(0, 13);
            this.lbl_KlantNaam.TabIndex = 53;
            // 
            // ReservationShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 267);
            this.Controls.Add(this.lbl_KlantNaam);
            this.Controls.Add(this.lbl_Tijd);
            this.Controls.Add(this.lbl_Gereserveerd);
            this.Controls.Add(this.label4);
            this.Name = "ReservationShow";
            this.Text = "ReservationShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Gereserveerd;
        private System.Windows.Forms.Label lbl_Tijd;
        private System.Windows.Forms.Label lbl_KlantNaam;
    }
}