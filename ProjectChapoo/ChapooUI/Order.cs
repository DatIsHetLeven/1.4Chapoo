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

        private void Btn_Addorder_Click_1(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem("Pizza");
            items.SubItems.Add("1");
            items.SubItems.Add("No peppers, extra crust");
            Lv_Currentorder.Items.Add(items);
        }

        private void Btn_Changeorder_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Removeorder_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sendorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been send!");
            Lv_Currentorder.Clear();
        }

        private void Btn_Drinkpanel_Click(object sender, EventArgs e)
        {
            Pnl_Orderitems.Hide();
            Pnl_Orderdrink.Show();
        }

        private void Btn_Backdrinks_Click(object sender, EventArgs e)
        {
            Pnl_Orderitems.Show();
        }

        private void Btn_Senddrink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De items op de bestelling zijn verzonden!");
            Lv_Currentdrink.Items.Clear();
        }

        private void Btn_Senditems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De items op de bestelling zijn verzonden!");
            Lv_Currentorder.Items.Clear();
        }
    }
}
