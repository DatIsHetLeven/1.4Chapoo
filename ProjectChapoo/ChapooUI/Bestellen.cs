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
        DateTime date;

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
            datagrid_Lunch.DataSource = menuItemList;
        }
        //Button bestellen
        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            //Gekozen aantal
            int invoer = drop_InvoerAantal.SelectedIndex + 1;
            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            int prijs1 = int.Parse(prijs);
            decimal BTW = 0.21m;
            string menuid = (datagrid_Lunch.Rows[item].Cells[3].FormattedValue.ToString());

            int number = order_Service.GetMaxId();
            int newOrderId = (number + 1);




            if (invoer > 0)
            {
                //Daadwerklijke prijs berekenen. 
                int Menuid = int.Parse(menuid);
                int totaalprijs = prijs1 * invoer;
                BTW = BTW * totaalprijs;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + invoer + " , Prijs : " + totaalprijs.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), totaalprijs, 1, "Lunch", invoer, BTW, Menuid, newOrderId);
            }
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
            int number = order_Service.GetMaxId();
            int newOrderId = (number + 1);

            int TotaalPrijs = 0;
            double totaalBtw = 0;
            if (selectedItemsMaking.Count >=1)
            {
                foreach (var item in selectedItemsMaking)
                {
                    TotaalPrijs = item.prijs + TotaalPrijs;
                    totaalBtw = double.Parse(item.BTW) + totaalBtw;
                }
                //Write order 
                order_Service.WriteOrder(newOrderId, TableId, TotaalPrijs, date.Date, totaalBtw.ToString());
                selectedItems_Service.SendItemsToKitchen(TableId, newOrderId);
                table_Service.ChangeTableStatus(TableId, 3);
                MessageBox.Show("Verzonden naar de keuken");
            }
            else
            {
                MessageBox.Show("Geen Items om te bestellen");
            }
            ShowSelectedItems();
        }

        // delete item van actuele bestelling 
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int item = datagrid_Making.CurrentCell.RowIndex;
            string menuitem = datagrid_Making.Rows[item].Cells["menuItem"].FormattedValue.ToString();
            selectedItems_Service.updateStatus(menuitem, TableId, 0);
            ShowSelectedItems();
        }





















        //Go Drinks
        private void Btn_Go_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDranken bestellenDiner = new BestellenDranken(TableId, invoerAantal);
            bestellenDiner.ShowDialog();
            this.Close();
        }
        //Go Diner
        private void Btn_Go_Diner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId, invoerAantal);
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
    }
}
