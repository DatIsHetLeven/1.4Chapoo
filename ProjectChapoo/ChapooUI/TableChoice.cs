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
        Table_Service table_Service = new Table_Service();
        private int TableId;
        private User User;
        public TableChoice()
        {
            InitializeComponent();
        }
        public TableChoice(int tableId)
        {
            InitializeComponent();
            //this.User = user;
            this.TableId = tableId;
            lbl_Show_Table_Number.Text = ("Tablenumber : " + TableId.ToString());
        }
        //Go to menu -> order
        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellen bestellen = new Bestellen(TableId);
            bestellen.ShowDialog();
            this.Close();
        }
        //Reservate table
        private void btn_Reservate_Click(object sender, EventArgs e)
        {
            try
            {
                //table_Service.SetTableReservate(TableId);
                //MessageBox.Show("Table has been reservated");
                Reservate reservate = new Reservate();
                reservate.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured : Table could not be reservated");
            }
        }
        //Make table Free
        private void Btn_FreeTable_Click(object sender, EventArgs e)
        {
            table_Service.SetTableFree(TableId);
            MessageBox.Show("Table has been cleared");
        }
        //Go back to Dashboard.cs
        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
            this.Close();
        }
        //Go to orders current table
        private void Btn_Go_Overzicht_Click(object sender, EventArgs e)
        {
            OrderDashboard orderDashboard = new OrderDashboard(TableId);
            this.Hide();
            orderDashboard.ShowDialog();
            this.Close();
        }
    }
}
