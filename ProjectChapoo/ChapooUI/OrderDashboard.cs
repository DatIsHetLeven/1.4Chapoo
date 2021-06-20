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
    public partial class OrderDashboard : Form
    {
        private int TableId;
        private int TotalPrice;
        Order_Service order_Service = new Order_Service();

        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        List<SelectedItem> selectedItemsDelivered = new List<SelectedItem>();
        List<SelectedItem> IItemsReadyList;

        public OrderDashboard(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;
            RefreshMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IItemsReadyList.Count >= 1)
                MessageBox.Show("Kan niet betalen, Lever eerst de items af");
            else 
            {
                Payment payment = new Payment();
                this.Hide();
                payment.ShowDialog();
                this.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableChoice tableChoiceView = new TableChoice(TableId);
            tableChoiceView.ShowDialog();
            this.Close();
        }
        //Items van ready naar geleverd
        private void btn_AllesGeleverd_Click(object sender, EventArgs e)
        {
            //Status veranderen van ready naar geleverd
            selectedItems_Service.updateStatus2(TableId,3,4);
            RefreshMethod();
        }

        private void RefreshMethod()
        {
            listView_KlaarOmServeren.Items.Clear();
            IItemsReadyList = new List<SelectedItem>();

            IItemsReadyList = selectedItems_Service.GetMakingOrder(TableId, 4);

            foreach (var i in IItemsReadyList)
            {
                ListViewItem item = new ListViewItem(i.menuItem);
                item.SubItems.Add(i.aantal.ToString());
                item.SubItems.Add(i.prijs.ToString());
                listView_KlaarOmServeren.Items.Add(item);
            }
        }
    }
}
