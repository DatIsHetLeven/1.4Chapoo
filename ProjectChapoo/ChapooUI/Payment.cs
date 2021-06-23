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
    public partial class Payment : Form
    {
        private int TableId;
        Order order;
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        Table_Service table_Service = new Table_Service();
        Order_Service order_Service = new Order_Service();

        List<SelectedItem> selectedItems = new List<SelectedItem>();
        public Payment(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;
            //Get all items which u want to pay for
            selectedItems = selectedItems_Service.GetMakingOrder(TableId, 3);
            //Show all items 
            foreach (var item in selectedItems)
            {
                ListViewItem listViewItem = new ListViewItem(item.menuItem);
                listViewItem.SubItems.Add(item.prijs.ToString());
                listViewItem.SubItems.Add(item.aantal.ToString());
                listViewItem.SubItems.Add(item.BTW);

                listview_AlleItems.Items.Add(listViewItem);
            }
            order = order_Service.GetOrderToPay(tableId);

            lbl_TotaalBtw.Text = order.BTW.ToString();
            lbl_TotaalPrijsZonderFooi.Text = order.Prijs.ToString();
            lbl_TotaalPrijsMetFooi.Text = lbl_TotaalPrijsZonderFooi.Text;
        }
        //Toevogen fooi
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                int fooi = int.Parse(txt_TipAmount.Text);
                //fooi kan niet negatief -> show messagebox
                if (fooi <0 )
                {
                    MessageBox.Show("Fooi kan niet onder de 0");
                }
                else
                {
                    //Berken nieuw bedrag (fooi + prijs incl btw)
                    int PrijsIncFooi = int.Parse(lbl_TotaalPrijsZonderFooi.Text) + fooi;
                    lbl_TotaalPrijsMetFooi.Text = PrijsIncFooi.ToString();
                }
            }
            //Als invoer fooi geen getal is (letter of leestekens) -> show messagebox
            catch (Exception)
            {
                MessageBox.Show("Het moet wel een getal zijn!");
            }
        }


        private void btn_PayIdeal_Click(object sender, EventArgs e)
        {
            FinishPayment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinishPayment();
        }
        private void FinishPayment()
        {
            //Change order to finished (Payed) in db
            order_Service.MarkOrderAsFinished(order);
            //Maak bon



            //Get back to dashboard form
            MessageBox.Show("Payment was successfully!");
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
