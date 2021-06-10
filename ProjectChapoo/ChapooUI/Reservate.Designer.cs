namespace ChapooUI
{
    partial class Reservate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservate));
            this.lbl_TableNumber = new System.Windows.Forms.Label();
            this.txt_NaamKlant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Gereed = new System.Windows.Forms.Button();
            this.btn_Terug = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.drop_TijdUren = new System.Windows.Forms.ComboBox();
            this.drop_TijdMinuten = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TableNumber
            // 
            this.lbl_TableNumber.AutoSize = true;
            this.lbl_TableNumber.Location = new System.Drawing.Point(202, 84);
            this.lbl_TableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TableNumber.Name = "lbl_TableNumber";
            this.lbl_TableNumber.Size = new System.Drawing.Size(0, 20);
            this.lbl_TableNumber.TabIndex = 0;
            // 
            // txt_NaamKlant
            // 
            this.txt_NaamKlant.Location = new System.Drawing.Point(195, 142);
            this.txt_NaamKlant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NaamKlant.Name = "txt_NaamKlant";
            this.txt_NaamKlant.Size = new System.Drawing.Size(233, 26);
            this.txt_NaamKlant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(75, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam:";
            // 
            // btn_Gereed
            // 
            this.btn_Gereed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Gereed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Gereed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Gereed.Location = new System.Drawing.Point(206, 323);
            this.btn_Gereed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Gereed.Name = "btn_Gereed";
            this.btn_Gereed.Size = new System.Drawing.Size(222, 60);
            this.btn_Gereed.TabIndex = 3;
            this.btn_Gereed.Text = "Reserveren";
            this.btn_Gereed.UseVisualStyleBackColor = false;
            this.btn_Gereed.Click += new System.EventHandler(this.btn_Gereed_Click);
            // 
            // btn_Terug
            // 
            this.btn_Terug.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Terug.Location = new System.Drawing.Point(18, 323);
            this.btn_Terug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(139, 60);
            this.btn_Terug.TabIndex = 4;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = false;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(75, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tijd:";
            // 
            // drop_TijdUren
            // 
            this.drop_TijdUren.FormattingEnabled = true;
            this.drop_TijdUren.Location = new System.Drawing.Point(195, 211);
            this.drop_TijdUren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drop_TijdUren.Name = "drop_TijdUren";
            this.drop_TijdUren.Size = new System.Drawing.Size(67, 28);
            this.drop_TijdUren.TabIndex = 46;
            // 
            // drop_TijdMinuten
            // 
            this.drop_TijdMinuten.FormattingEnabled = true;
            this.drop_TijdMinuten.Location = new System.Drawing.Point(297, 211);
            this.drop_TijdMinuten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drop_TijdMinuten.Name = "drop_TijdMinuten";
            this.drop_TijdMinuten.Size = new System.Drawing.Size(67, 28);
            this.drop_TijdMinuten.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(173, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 49;
            this.label4.Text = "Reserveren";
            // 
            // Reservate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drop_TijdMinuten);
            this.Controls.Add(this.drop_TijdUren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.btn_Gereed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NaamKlant);
            this.Controls.Add(this.lbl_TableNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reservate";
            this.Text = "Reservate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TableNumber;
        private System.Windows.Forms.TextBox txt_NaamKlant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Gereed;
        private System.Windows.Forms.Button btn_Terug;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drop_TijdUren;
        private System.Windows.Forms.ComboBox drop_TijdMinuten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}