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

        List<SelectedItem> selectedItemsBarman;
        List<SelectedItem> selectedItemsKeuken;
        public BarKitchenDashboard(User user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            selectedItems = new List<SelectedItem>();
            selectedItems = selectedItems_Service.GetSelectedItems();
            selectedItemsBarman = new List<SelectedItem>();
            selectedItemsKeuken = new List<SelectedItem>();

            if (User.userId == 2)
            {
                foreach (var item in selectedItems)
                {
                    if (item.menuId == 3)
                    {
                        selectedItemsBarman.Add(item);
                    }
                }
                datgrid_OpenOrder.DataSource = selectedItemsBarman;
            }
            else
            {
                foreach (var item in selectedItems)
                {
                    if (item.menuId != 3)
                    {
                        selectedItemsKeuken.Add(item);
                    }
                }
                datgrid_OpenOrder.DataSource = selectedItemsKeuken;
            }

        }

       

        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int item = datgrid_OpenOrder.CurrentCell.RowIndex;

                string menuitem = datgrid_OpenOrder.Rows[item].Cells["menuItem"].FormattedValue.ToString();
                string tableId = datgrid_OpenOrder.Rows[item].Cells["tableid"].FormattedValue.ToString();
                selectedItems_Service.updateStatus(menuitem, int.Parse(tableId), 3);
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
