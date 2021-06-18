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
    public partial class BestellenDiner : Form
    {
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        Table_Service table_Service = new Table_Service();
        List<SelectedItem> selectedItemsMaking = new List<SelectedItem>();


        List<ChapoModel.MenuItem> menuItemList = new List<ChapoModel.MenuItem>();
        List<int> invoerAantal = new List<int>();
        int TableId;
        public BestellenDiner(int tableid, List<int>invoeraantal)
        {
            InitializeComponent();

            MenuItem_Service menuItem_Service = new MenuItem_Service();
            this.TableId = tableid;
            this.invoerAantal = invoeraantal;
            Lbl_Table_Diner.Text = ("Tafelnummer : " + TableId.ToString());

            drop_InvoerAantal.DataSource = invoerAantal;


            menuItemList = menuItem_Service.GetDinerItems();
            datagrid_Lunch.DataSource = menuItemList;
        }
        //Bestellen
        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            int invoer = drop_InvoerAantal.SelectedIndex + 1;
            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            int prijs1 = int.Parse(prijs);
            decimal BTW = 0.21m;

            if (invoer > 0)
            {
                int verm = prijs1 * invoer;
                BTW = BTW * verm;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + invoer + " , Prijs : " + verm.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), verm,2,"Diner",invoer, BTW);
                table_Service.ChangeTableStatus(TableId,3);
            }
            ShowSelectedItems();
        }
        //Refresh
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            List<SelectedItem> selectedItemsMaking = new List<SelectedItem>();
            selectedItemsMaking = selectedItems_Service.GetMakingOrder(TableId,1);
            datagrid_Making.DataSource = selectedItemsMaking;
        }
        //Back Dashboard
        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableChoice tableChoiceView = new TableChoice(TableId);
            tableChoiceView.ShowDialog();
            this.Close();
        }
        //Go to lunch
        private void btn_Go_Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellen bestellen = new Bestellen(TableId);
            bestellen.ShowDialog();
            this.Close();
        }
        //Go to drinks
        private void btn_Go_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDranken bestellenDranken = new BestellenDranken(TableId, invoerAantal);
            bestellenDranken.ShowDialog();
            this.Close();
        }
        //Update List
        private void BestellenDiner_Load(object sender, EventArgs e)
        {
            ShowSelectedItems();
        }

        private void ShowSelectedItems()
        {
            selectedItemsMaking = selectedItems_Service.GetMakingOrder(TableId,1);
            datagrid_Making.DataSource = selectedItemsMaking;
        }
        //Bestellen
        private void button1_Click(object sender, EventArgs e)
        {
            ShowSelectedItems();
            try
            {
                int item = datagrid_Making.CurrentCell.RowIndex;
                string menuitem = datagrid_Making.Rows[item].Cells["menuItem"].FormattedValue.ToString();
                selectedItems_Service.updateStatus(menuitem, TableId,2);
                ShowSelectedItems();
                MessageBox.Show("Items zijn verzonden!"); // kan alleen van de lijst per item het versturen naar de datbase
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
