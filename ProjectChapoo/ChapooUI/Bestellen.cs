﻿using System;
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

        List<ChapoModel.MenuItem> menuItems = new List<ChapoModel.MenuItem>();
        List<SelectedItem> selectedItemsMaking = new List<SelectedItem>();
        Table_Service table_Service = new Table_Service();
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        List<ChapoModel.MenuItem> menuItemList = new List<ChapoModel.MenuItem>();
        List<int> invoerAantal = new List<int>();

        public Bestellen(int tableid)
        {
            InitializeComponent();
            this.TableId = tableid;
            Lbl_Table_Lunch.Text = ("Tafelnummer : " + TableId.ToString());

            MenuItem_Service menuItem_Service = new MenuItem_Service();

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

            menuItemList = menuItem_Service.GetMenuItems();
            foreach (var i in menuItemList)
            {
                if (i.MenuId == 1)
                {
                    menuItems.Add(i);
                    datagrid_Lunch.DataSource = menuItems;
                }
            }
        }
        //Button bestellen
        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            //Gekozen aantal
            int invoer = drop_InvoerAantal.SelectedIndex + 1;
            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            int prijs1 = int.Parse(prijs);

            if (invoer > 0)
            {
                //Daadwerklijke prijs berekenen. 
                int totaalprijs = prijs1 * invoer;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + invoer + " , Prijs : " + totaalprijs.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), totaalprijs,1);
                table_Service.ChangeTableStatus(TableId,3);
            }
            ShowSelectedItems();
        }

        //Go Drinks
        private void Btn_Go_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDranken bestellenDiner = new BestellenDranken(TableId, menuItemList, invoerAantal);
            bestellenDiner.ShowDialog();
            this.Close();
        }
        //Go Diner
        private void Btn_Go_Diner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId, menuItemList, invoerAantal);
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
            ShowSelectedItems();
            try  // met nul bestellingen verwijderen geeft een error....
            {
                int item = datagrid_Making.CurrentCell.RowIndex;
                string menuitem = datagrid_Making.Rows[item].Cells["menuItem"].FormattedValue.ToString();
                selectedItems_Service.updateStatus(menuitem, TableId, 2);
                ShowSelectedItems();
                MessageBox.Show("Item is verzonden!");  // kan alleen van de lijst per item het versturen naar de datbase
            }
            catch (Exception)
            {
                MessageBox.Show("Niks om te bestellen");
            }
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
