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

        List<Order> selectedItemsBarman;
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
            switch (User.userTitle)
            {
                case UserTitle.Keuken:
                    selectedItemsBarman = Order_Service.GetSelectedItemsBar();
                    datgrid_OpenOrder.DataSource = selectedItemsBarman;
                    foreach (var item in selectedItemsBarman)
                    {
                        tafelNummer.Add(item.TableId);
                        ShowOpenOrders.Add(item);
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
                listitem.SubItems.Add(item.startTijd.ToString());
                listView2.Items.Add(listitem);
            }
        }


        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            if (selectedItemsKeuken.Count > 0)
            {
                foreach (var item in selectedItemsKeuken)
                {
                    //Als gekozen tafelnummer gelijk staat met tafelnummer in lijt met alle items
                    if (item.TableId == int.Parse(listView2.SelectedItems[0].SubItems[0].Text))
                    {
                        //De hele order updaten 
                        Order order2 = item;
                        selectedItems_Service.updateStatus2(order2.TableId, 4, 2);
                        listView1.Items.Clear();
                        Refresh();
                    }
                }
            }
            else if (selectedItemsBarman.Count != 0)
            {
                foreach (var item in selectedItemsBarman)
                {
                    //Als gekozen tafelnummer gelijk staat met tafelnummer in lijt met alle items
                    if (item.TableId == int.Parse(listView2.SelectedItems[0].SubItems[0].Text))
                    {
                        //De hele order updaten 
                        Order order2 = item;
                        selectedItems_Service.updateStatus2(order2.TableId, 4, 2);
                        listView1.Items.Clear();
                        Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Niks om te refreshen");
            }

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
                case UserTitle.Keuken:
                    selectedItemsBarman = Order_Service.GetSelectedItemsBar();
                    foreach (var item in selectedItemsBarman)
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
