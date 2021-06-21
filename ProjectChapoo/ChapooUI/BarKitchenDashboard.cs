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
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        Order_Service Order_Service = new Order_Service();

        List<SelectedItem> selectedItemsBarman;
        List<Order> selectedItemsKeuken;
        public BarKitchenDashboard(User user)
        {
            InitializeComponent();
            this.User = user;

        }

        private void Refresh(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            List<Order> ShowOpenOrders = new List<Order>();

            List<int> tafelNummer = new List<int>();
            listBox1.Items.Clear();
            switch (User.userTitle)
            {
                case UserTitle.Keuken:
                    selectedItemsBarman = selectedItems_Service.GetSelectedItemsBar();
                    datgrid_OpenOrder.DataSource = selectedItemsBarman;
                    foreach (var item in selectedItemsBarman)
                    {
                        listView1.Items.Add(item.menuItem);
                    }
                    break;
                case UserTitle.Barman:
                    selectedItemsKeuken = Order_Service.GetSelectedItemsKeuken();
                    datgrid_OpenOrder.DataSource = selectedItemsKeuken;
                    foreach (var item in selectedItemsKeuken)
                    {
                        if (!tafelNummer.Contains(item.TableId))
                        {
                            tafelNummer.Add(item.TableId);
                            ShowOpenOrders.Add(item);
                        }
                    }
                    break;
            }

            foreach (var item in ShowOpenOrders)
            {
                ListViewItem listitem = new ListViewItem(item.TableId.ToString());
                //DateTime time = DateTime.Parse(item.startTijd);
                listitem.SubItems.Add(item.startTijd.ToString());
                //listBox1.Items.Add(item);
                listView2.Items.Add(listitem);

                //tafelNummer.Remove(itemm);
            }

            foreach (var item in tafelNummer)
            {
                listBox1.Items.Add(item);
            }
        }


        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView2.SelectedItems[0].SubItems[0].Text);

            foreach (var item in selectedItemsKeuken)
            {
                if (item.TableId == int.Parse(listView2.SelectedItems[0].SubItems[0].Text))
                {
                    Order order2 = item;
                    selectedItems_Service.updateStatus2(order2.TableId, 4, 2);
                    listView1.Items.Clear();
                }     
            } 


            //try
            //{
            //    int tafelReady = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            //    selectedItems_Service.updateStatus2(tafelReady, 4, 2);
            //    listView1.Items.Clear();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Niks om ready te melden");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int gekozenTafel = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
                ShowOrder(gekozenTafel);
                MessageBox.Show(listView2.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Geen order geselecteerd");
            }
            //try
            //{
            //    int gekozenTafel = int.Parse(listBox1.GetItemText(listBox1.SelectedItem));
            //    ShowOrder(gekozenTafel);
            //    MessageBox.Show(listBox1.GetItemText(listBox1.SelectedItem).ToString());
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Geen order geselecteerd");
            //}

        }

        private void ShowOrder(int tafelNummer)
        {
            listView1.Items.Clear();
            //De items tonen van gekozen tafel
            switch (User.userTitle)
            {
                case UserTitle.Barman:
                    selectedItemsKeuken = Order_Service.GetSelectedItemsKeuken();
                    foreach (var item in selectedItemsKeuken)
                    {
                        if (item.TableId == tafelNummer)
                        {
                            ListViewItem items = new ListViewItem(item.MenuItem);
                            items.SubItems.Add(item.aantal.ToString());
                            listView1.Items.Add(items);
                        }
                    }
                    break;
            }
        }
    }
}
