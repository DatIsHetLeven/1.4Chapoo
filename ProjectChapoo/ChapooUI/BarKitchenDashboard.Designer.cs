namespace ChapooUI
{
    partial class BarKitchenDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarKitchenDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_UpdateStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datgrid_OpenOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_OpenOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Refresh.Image")));
            this.Btn_Refresh.Location = new System.Drawing.Point(1519, 372);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(126, 117);
            this.Btn_Refresh.TabIndex = 19;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(53, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 64);
            this.button1.TabIndex = 18;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_UpdateStatus
            // 
            this.btn_UpdateStatus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_UpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_UpdateStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UpdateStatus.Location = new System.Drawing.Point(845, 922);
            this.btn_UpdateStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UpdateStatus.Name = "btn_UpdateStatus";
            this.btn_UpdateStatus.Size = new System.Drawing.Size(214, 71);
            this.btn_UpdateStatus.TabIndex = 17;
            this.btn_UpdateStatus.Text = "Ready";
            this.btn_UpdateStatus.UseVisualStyleBackColor = false;
            this.btn_UpdateStatus.Click += new System.EventHandler(this.btn_UpdateStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(872, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Totaal orders ";
            // 
            // datgrid_OpenOrder
            // 
            this.datgrid_OpenOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrid_OpenOrder.Location = new System.Drawing.Point(408, 372);
            this.datgrid_OpenOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datgrid_OpenOrder.Name = "datgrid_OpenOrder";
            this.datgrid_OpenOrder.ReadOnly = true;
            this.datgrid_OpenOrder.RowHeadersWidth = 62;
            this.datgrid_OpenOrder.Size = new System.Drawing.Size(1071, 503);
            this.datgrid_OpenOrder.TabIndex = 15;
            // 
            // BarKitchenDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_UpdateStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datgrid_OpenOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BarKitchenDashboard";
            this.Text = "BarKitchenDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_OpenOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_UpdateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datgrid_OpenOrder;
    }
}