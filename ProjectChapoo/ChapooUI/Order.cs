using System;
using System.Windows.Forms;
using ChapoModel;

namespace ChapooUI
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TableChoice tableChoiceView = new TableChoice();
            tableChoiceView.ShowDialog();
            this.Close();
        }

        private void Showpanel(string panel)
        {
            if (panel == "gerechtenorder")
            {
                Pnl_Orderdrink.Hide();
                Pnl_Orderitems.Show();

                // clears comboboxes when changing panel
                Cb_orderitems.Items.Clear();
                Cb_orderitemsamount.Items.Clear();
               
                // add items to combobox gerechten
                Cb_orderitems.Items.Add("Pizza Margerita");
                Cb_orderitems.Items.Add("Pasta Carbornara");
                Cb_orderitems.Items.Add("Buffel Burger");

                // add amount numbers to combobox order amount
                Cb_orderitemsamount.Items.Add("1");
                Cb_orderitemsamount.Items.Add("2");
                Cb_orderitemsamount.Items.Add("3");
                Cb_orderitemsamount.Items.Add("4");
                Cb_orderitemsamount.Items.Add("5");
            }
            else if (panel == "drankorder")
            {
                Pnl_Orderitems.Hide();
                Pnl_Orderdrink.Show();

                // clears comboboxes when changing panel
                Cb_Drinkadd.Items.Clear();
                Cb_Drinkamount.Items.Clear();

                // add items to combobox drinks
                Cb_Drinkadd.Items.Add("heiniken 33cl");
                Cb_Drinkadd.Items.Add("Belvedere Vodka");
                Cb_Drinkadd.Items.Add("Cola");
                Cb_Drinkadd.Items.Add("Fanta");

                // add amount numbers to combobox drinks amount
                Cb_Drinkamount.Items.Add("1");
                Cb_Drinkamount.Items.Add("2");
                Cb_Drinkamount.Items.Add("3");
                Cb_Drinkamount.Items.Add("4");
                Cb_Drinkamount.Items.Add("5");
            }
        }

        private void Btn_Addorder_Click_1(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem(Cb_orderitems.SelectedItem.ToString());
            items.SubItems.Add(Cb_orderitemsamount.SelectedItem.ToString());
            items.SubItems.Add(Rtb_extraorder.Text);
            Lv_Currentorder.Items.Add(items);
            
            // clear all comboboxes and extra info fields after add item to order
            Cb_orderitems.Text = "";
            Cb_orderitemsamount.Text = "";
            Rtb_extraorder.Text = "";
        }

        private void Btn_Backdrinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableChoice tableChoiceView = new TableChoice();
            tableChoiceView.ShowDialog();
            this.Close();
        }

        public int orderid = 0;
        private void Btn_Senddrink_Click(object sender, EventArgs e)
        {
            orderid++;

            string drinks = Lv_Currentdrink.SelectedItems.ToString();
            int amount = int.Parse(Lv_Currentdrink.Items.Count.ToString());

            ChapooLogic.Order_Service order_Service = new ChapooLogic.Order_Service();

            // give data to service layer
            order_Service.WriteOrder(orderid, drinks, amount);

            // message that the order has b
            MessageBox.Show("De items op de bestelling zijn verzonden!");
            Lv_Currentdrink.Items.Clear();
        }

        private void Btn_Senditems_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("De items op de bestelling zijn verzonden!");
                Lv_Currentdrink.Items.Clear();
            }
            catch
            {
                MessageBox.Show("Iets ging verkeerd.... check je verbinding en probeer het opnieuw!");
            }
        }

        private void Btn_Adddrink_Click(object sender, EventArgs e)
        {
            ListViewItem drinks = new ListViewItem(Cb_Drinkadd.SelectedItem.ToString());
            drinks.SubItems.Add(Cb_Drinkamount.SelectedItem.ToString());
            Lv_Currentdrink.Items.Add(drinks);

            // clear all comboboxes and extra info fields after add item to order
            Cb_Drinkadd.Text = "";
            Cb_Drinkamount.Text = "";
        }

        private void Btn_Editdrink_Click(object sender, EventArgs e)
        {
            //
        }

        private void Btn_Deletedrink_Click(object sender, EventArgs e)
        {
            //
        }

        private void gerechtenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Showpanel("gerechtenorder");
        }

        private void drankenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showpanel("drankorder");
        }
    }
}
