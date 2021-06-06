using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapoModel;

namespace ChapooUI
{
    public partial class TableChoice : Form
    {
        private Table_Service table_Service = new Table_Service();
        private int TableId;
        private Dashboard dashboard;
        private OrderDashboard orderDashboard;
        private Bestellen bestellen;

        public TableChoice(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;
            lbl_Show_Table_Number.Text = ("Tablenumber : " + TableId.ToString());
        }
        //Go to menu -> order
        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            this.Hide();
            bestellen = new Bestellen(TableId);
            bestellen.ShowDialog();
            this.Close();
        }
        //Go back to Dashboard.cs
        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }
        //Go to orders current table
        private void Btn_Go_Overzicht_Click(object sender, EventArgs e)
        {
            orderDashboard = new OrderDashboard(TableId);
            this.Hide();
            orderDashboard.ShowDialog();
            this.Close();
        }
        //Reservate table
        private void btn_Reservate_Click(object sender, EventArgs e)
        {
            table_Service.ChangeTableStatus(TableId,2);
            MessageBox.Show("Table has been reservated");
        }
        //Make table Free
        private void Btn_FreeTable_Click(object sender, EventArgs e)
        {
            table_Service.ChangeTableStatus(TableId,1);
            MessageBox.Show("Table has been cleared");
        }
    }
}
