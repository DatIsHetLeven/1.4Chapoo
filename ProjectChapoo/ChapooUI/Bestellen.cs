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
    public partial class Bestellen : Form
    {
        int TableId;
        Table_Service table_Service = new Table_Service();
        MenuItem_Service menuItem_Service = new MenuItem_Service();
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        Order_Service order_Service = new Order_Service();

        List<SelectedItem> selectedItemsMaking = new List<SelectedItem>();
        List<ChapoModel.MenuItem> menuItemList = new List<ChapoModel.MenuItem>();
        List<int> invoerAantal = new List<int>();

        public Bestellen(int tableid)
        {
            InitializeComponent();
            this.TableId = tableid;
            Lbl_Table_Lunch.Text = ("Tafelnummer : " + TableId.ToString());

            invoerAantal.Add(1);
            invoerAantal.Add(2);
            invoerAantal.Add(3);
            invoerAantal.Add(4);
            invoerAantal.Add(5);
            invoerAantal.Add(6);
            invoerAantal.Add(7);
            invoerAantal.Add(8);
            invoerAantal.Add(9);
            invoerAantal.Add(10);

            drop_InvoerAantal.DataSource = invoerAantal;
            //Haal alle lunch items op
            menuItemList = menuItem_Service.GetLunchItems();

            foreach (var item in menuItemList)
            {
                ListViewItem LunchItem = new ListViewItem(item.menuitemId.ToString());
                LunchItem.SubItems.Add(item.MenuItemNaam);
                LunchItem.SubItems.Add(item.Prijs.ToString());
                LunchItem.SubItems.Add(item.menuItemCategorie);

                listView_Lunch.Items.Add(LunchItem);
            }
        }
        //Button bestellen
        private void btn_bestellen_Click(object sender, EventArgs e)
        {

            int number = order_Service.GetMaxId();
            int newOrderId = (number + 1);

            int invoer = drop_InvoerAantal.SelectedIndex + 1;
            decimal BTW = 0.21m;

            foreach (var menuItem in menuItemList)
            {
                //zoekt gekozen menuid met de menuid in de list van alle menuitems
                if (menuItem.menuitemId == int.Parse(listView_Lunch.SelectedItems[0].SubItems[0].Text))
                {
                    //Select object from list
                    ChapoModel.MenuItem gekozenItem = menuItem;

                    int totaalprijs = int.Parse(gekozenItem.Prijs.ToString()) * invoer;
                    BTW = BTW * totaalprijs;
                    //Create selecteditem ('orderitem')
                    SelectedItem selectedItem = new SelectedItem(TableId, gekozenItem.MenuItemNaam, totaalprijs, invoer, BTW.ToString());
                    //Insert selecteditem naar database
                    selectedItems_Service.selectedItem2(selectedItem, 1, gekozenItem, newOrderId);
                }
            }
            //refresh list
            ShowSelectedItems();
        }

        private void ShowSelectedItems()
        {
            selectedItemsMaking = selectedItems_Service.GetMakingOrder(TableId, 1);
            datagrid_Making.DataSource = selectedItemsMaking;
        }

        private void Bestellen_Load(object sender, EventArgs e)
        {
            ShowSelectedItems();
        }
        //Gekozen items bestellen -> sturen naar keuken
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string tijd = DateTime.Now.ToString("HH:mm");

            int number = order_Service.GetMaxId();
            int newOrderId = (number + 1);

            int TotaalPrijs = 0;
            double totaalBtw = 0;
            if (selectedItemsMaking.Count >= 1)
            {
                foreach (var item in selectedItemsMaking)
                {
                    TotaalPrijs = item.prijs + TotaalPrijs;
                    totaalBtw = double.Parse(item.BTW) + totaalBtw;
                }
                //Write order 
                order_Service.WriteOrder(newOrderId, TableId, TotaalPrijs, tijd, totaalBtw.ToString());
                selectedItems_Service.SendItemsToKitchen(TableId, newOrderId);
                MessageBox.Show("Verzonden naar de keuken");
            }
            else
            {
                MessageBox.Show("Geen Items om te bestellen");
            }
            ShowSelectedItems();
        }























        //Go Drinks
        private void Btn_Go_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDranken bestellenDiner = new BestellenDranken(TableId);
            bestellenDiner.ShowDialog();
            this.Close();
        }
        //Go Diner
        private void Btn_Go_Diner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId);
            bestellenDiner.ShowDialog();
            this.Close();
        }
        //Back to Dashboard
        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableChoice tableChoiceView = new TableChoice(TableId);
            tableChoiceView.ShowDialog();
            this.Close();
        }

        // delete item van actuele bestelling 
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int item = datagrid_Making.CurrentCell.RowIndex;
            string menuitem = datagrid_Making.Rows[item].Cells["menuItem"].FormattedValue.ToString();
            selectedItems_Service.updateStatus(menuitem, TableId, 0);
            ShowSelectedItems();
        }
    }
}
