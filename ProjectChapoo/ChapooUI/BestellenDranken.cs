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
using MenuItem = System.Windows.Forms.MenuItem;

namespace ChapooUI
{
    public partial class BestellenDranken : Form
    {
        List<SelectedItem> selectedItemsMaking = new List<SelectedItem>();
        List<ChapoModel.MenuItem> MenuItem = new List<ChapoModel.MenuItem>();
        Table_Service table_Service = new Table_Service();
        Order_Service order_Service = new Order_Service();
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        List<ChapoModel.MenuItem> allMenuItems = new List<ChapoModel.MenuItem>();
        List<ChapoModel.MenuItem> menuItemList = new List<ChapoModel.MenuItem>();
        List<int> invoerAantal = new List<int>();
        int TableId;
        public BestellenDranken(int tableId, List<int> invoeraantal)
        {
            InitializeComponent();
            this.TableId = tableId;
            this.invoerAantal = invoeraantal;
            Lbl_Table_Drank.Text = ("Tafelnummer : " + TableId.ToString());

            MenuItem_Service menuItem_Service = new MenuItem_Service();
            drop_InvoerAantal.DataSource = invoerAantal;
            menuItemList = menuItem_Service.GetDrinkItems();
            datagrid_Lunch.DataSource = menuItemList;

        }

        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            int invoer = drop_InvoerAantal.SelectedIndex + 1;
            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            int prijs1 = int.Parse(prijs);
            decimal BTW = 0.09m;
            string menuid = (datagrid_Lunch.Rows[item].Cells[3].FormattedValue.ToString());

            int number = order_Service.GetMaxId();
            int newOrderId = (number + 1);

            if (invoer > 0)
            {
                //Daadwerklijke prijs berekenen. 
                int Menuid = int.Parse(menuid);
                int verm = prijs1 * invoer;
                BTW = BTW * verm;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + invoer + " , Prijs : " + verm.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), verm,3,"Drinks",invoer, BTW, Menuid, newOrderId);
                table_Service.ChangeTableStatus(TableId,3);
            }
            ShowSelectedItems();
        }

        private void Btn_GoDiner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId,invoerAantal);
            bestellenDiner.ShowDialog();
            this.Close();
        }

        private void btn_Go_Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellen bestellen = new Bestellen(TableId);
            bestellen.ShowDialog();
            this.Close();
        }

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

        private void BestellenDranken_Load(object sender, EventArgs e)
        {
            ShowSelectedItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSelectedItems();
            try
            {
                int item = datagrid_Making.CurrentCell.RowIndex;
                string menuitem = datagrid_Making.Rows[item].Cells["menuItem"].FormattedValue.ToString();
                selectedItems_Service.updateStatus(menuitem, TableId, 2);
                ShowSelectedItems();
            }
            catch (Exception)
            {

                MessageBox.Show("Niks om te bestellen");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int item = datagrid_Making.CurrentCell.RowIndex;
            string menuitem = datagrid_Making.Rows[item].Cells["menuItem"].FormattedValue.ToString();
            selectedItems_Service.updateStatus(menuitem, TableId, 0);
            ShowSelectedItems();
        }
    }
}
