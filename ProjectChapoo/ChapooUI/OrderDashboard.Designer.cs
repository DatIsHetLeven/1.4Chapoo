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
            this.datagrid_Making = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Geleverd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.datagrid_CurrentOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CurrentOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_Making
            // 
            this.datagrid_Making.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Making.Location = new System.Drawing.Point(355, 74);
            this.datagrid_Making.Name = "datagrid_Making";
            this.datagrid_Making.ReadOnly = true;
            this.datagrid_Making.Size = new System.Drawing.Size(481, 120);
            this.datagrid_Making.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bereiden";
            // 
            // Geleverd
            // 
            this.Geleverd.AutoSize = true;
            this.Geleverd.Location = new System.Drawing.Point(352, 221);
            this.Geleverd.Name = "Geleverd";
            this.Geleverd.Size = new System.Drawing.Size(50, 13);
            this.Geleverd.TabIndex = 11;
            this.Geleverd.Text = "Geleverd";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(526, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DarkRed;
            this.btn_back.Location = new System.Drawing.Point(23, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(118, 40);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // datagrid_CurrentOrder
            // 
            this.datagrid_CurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_CurrentOrder.Location = new System.Drawing.Point(355, 237);
            this.datagrid_CurrentOrder.Name = "datagrid_CurrentOrder";
            this.datagrid_CurrentOrder.Size = new System.Drawing.Size(481, 120);
            this.datagrid_CurrentOrder.TabIndex = 8;
            // 
            // OrderDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.datagrid_Making);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Geleverd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.datagrid_CurrentOrder);
            this.Name = "OrderDashboard";
            this.Text = "OrderDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CurrentOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagrid_Making;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Geleverd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView datagrid_CurrentOrder;
    }
}