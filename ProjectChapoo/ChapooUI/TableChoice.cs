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

namespace ChapooUI
{
    public partial class TableChoice : Form
    {
        Table_Service table_Service = new Table_Service();
        private int TableId;
        public TableChoice()
        {
            InitializeComponent();
        }
        public TableChoice(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;
            lbl_Show_Table_Number.Text = ("Tablenumber : " + TableId.ToString());
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuView = new Menu();
            menuView.ShowDialog();
            this.Close();
        }

        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
            this.Close();
        }
        //Reservate Table
        private void btn_Reservate_Click(object sender, EventArgs e)
        {
            table_Service.SetTableReservate(TableId);
            MessageBox.Show("Table has been reservated");
        }
        // Free a table
        private void Btn_FreeTable_Click(object sender, EventArgs e)
        {
            table_Service.SetTableFree(TableId);
            MessageBox.Show("Table has been cleared");
        }
        // Form of Orders and option to add, remove and change an order
        private void Btn_Orders_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order orderView = new Order();
            orderView.ShowDialog();
            this.Close();
        }
    }
}
