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
using MenuItem = System.Windows.Forms.MenuItem;

namespace ChapooUI
{
    public partial class BestellenDranken : Form
    {
        List<SelectedItem> selectedItemsMaking = new List<SelectedItem>();
        List<ChapoModel.MenuItem> MenuItem = new List<ChapoModel.MenuItem>();
        Table_Service table_Service = new Table_Service();
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        List<ChapoModel.MenuItem> allMenuItems = new List<ChapoModel.MenuItem>();
        int TableId;
        public BestellenDranken(int tableId, List<ChapoModel.MenuItem> menuItem)
        {
            InitializeComponent();
            this.allMenuItems = menuItem;
            this.TableId = tableId;
            List<int> invoerAantal = new List<int>();
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
            foreach (var item in menuItem)
            {
                if (item.MenuId == 3)
                {
                    MenuItem.Add(item);
                    datagrid_Lunch.DataSource = MenuItem;

                }
            }
        }

        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            int invoer = drop_InvoerAantal.SelectedIndex + 1;
            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            int prijs1 = int.Parse(prijs);

            if (invoer > 0)
            {
                int verm = prijs1 * invoer;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + invoer + " , Prijs : " + verm.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), verm);
                table_Service.SetTableInUse(TableId);
            }
            ShowSelectedItems();
        }

        private void Btn_GoDiner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId, allMenuItems);
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
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
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
