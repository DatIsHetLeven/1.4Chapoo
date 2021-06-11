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
            this.label4 = new System.Windows.Forms.Label();
            this.listboxTime = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_TableNumber
            // 
            this.lbl_TableNumber.AutoSize = true;
            this.lbl_TableNumber.Location = new System.Drawing.Point(135, 55);
            this.lbl_TableNumber.Name = "lbl_TableNumber";
            this.lbl_TableNumber.Size = new System.Drawing.Size(0, 13);
            this.lbl_TableNumber.TabIndex = 0;
            // 
            // txt_NaamKlant
            // 
            this.txt_NaamKlant.Location = new System.Drawing.Point(130, 92);
            this.txt_NaamKlant.Name = "txt_NaamKlant";
            this.txt_NaamKlant.Size = new System.Drawing.Size(157, 20);
            this.txt_NaamKlant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam:";
            // 
            // btn_Gereed
            // 
            this.btn_Gereed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Gereed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Gereed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Gereed.Location = new System.Drawing.Point(137, 210);
            this.btn_Gereed.Name = "btn_Gereed";
            this.btn_Gereed.Size = new System.Drawing.Size(148, 39);
            this.btn_Gereed.TabIndex = 3;
            this.btn_Gereed.Text = "Reserveren";
            this.btn_Gereed.UseVisualStyleBackColor = false;
            this.btn_Gereed.Click += new System.EventHandler(this.btn_Gereed_Click);
            // 
            // btn_Terug
            // 
            this.btn_Terug.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Terug.Location = new System.Drawing.Point(12, 210);
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Size = new System.Drawing.Size(93, 39);
            this.btn_Terug.TabIndex = 4;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = false;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tijd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(115, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Reserveren";
            // 
            // listboxTime
            // 
            this.listboxTime.FormattingEnabled = true;
            this.listboxTime.Location = new System.Drawing.Point(130, 136);
            this.listboxTime.Name = "listboxTime";
            this.listboxTime.Size = new System.Drawing.Size(120, 17);
            this.listboxTime.TabIndex = 52;
            // 
            // Reservate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 267);
            this.Controls.Add(this.listboxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.btn_Gereed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NaamKlant);
            this.Controls.Add(this.lbl_TableNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listboxTime;
    }
}