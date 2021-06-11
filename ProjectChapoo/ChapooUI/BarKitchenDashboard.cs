using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapoModel;
namespace ChapooUI
{
    public partial class BarKitchenDashboard : Form
    {
        User User;
        List<SelectedItem> selectedItems;
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();  
        public BarKitchenDashboard(User user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            selectedItems = new List<SelectedItem>();
            selectedItems = selectedItems_Service.GetSelectedItems();
            datgrid_OpenOrder.DataSource = selectedItems;
        }

        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int item = datgrid_OpenOrder.CurrentCell.RowIndex;

                string menuitem = datgrid_OpenOrder.Rows[item].Cells["menuItem"].FormattedValue.ToString();
                string tableId = datgrid_OpenOrder.Rows[item].Cells["tableid"].FormattedValue.ToString();
                selectedItems_Service.updateStatus(menuitem, int.Parse(tableId), 3);

                // refresh total orders when hit ready button for an item
                selectedItems = selectedItems_Service.GetSelectedItems();
                datgrid_OpenOrder.DataSource = selectedItems;
            }
            catch (Exception)
            {
                MessageBox.Show("Er zijn geen orders om gereed te stellen aan de bediening!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }
    }
}
