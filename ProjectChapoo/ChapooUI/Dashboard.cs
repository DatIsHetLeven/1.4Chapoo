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
    public partial class Dashboard : Form
    {
        private int UserId;

        private Table_Service table_Service = new Table_Service();
        private Order_Service order_Service = new Order_Service();
        private List<Table> tables = new List<Table>();
        List<Button> TableButtonList;
        
       

        public void DashboardUser(User user)
        {
            UserId = user.userId;
            lbl_UserName.Tag = user;
            lbl_UserName.Text = $"Ingelogd als: {user.userName}";
        }
        public Dashboard()
        {
            InitializeComponent();

            TableButtonList = new List<Button>();
            TableButtonList.Add(btn_Tafel_1);
            TableButtonList.Add(btn_Tafel_2);
            TableButtonList.Add(btn_Tafel_3);
            TableButtonList.Add(btn_Tafel_4);
            TableButtonList.Add(btn_Tafel_5);
            TableButtonList.Add(btn_Tafel_6);
            TableButtonList.Add(btn_Tafel_7);
            TableButtonList.Add(btn_Tafel_8);
            TableButtonList.Add(btn_Tafel_9);
            TableButtonList.Add(btn_Tafel_10);

            //1E
            //// Check status
            //foreach (Button btn in TableButtonList)
            //{
            //    foreach (var i in tableId)
            //    {
            //        //Give tag Prop
            //        btn.Tag = i;
            //        //Check status of table
            //        if (i.tafelStatus == "Free")
            //            btn.BackColor = Color.Lime;
            //        else if (i.tafelStatus == "CurrentOrder")
            //            btn.BackColor = Color.Blue;
            //        else//status = reservated
            //            btn.BackColor = Color.Red;
            //        tableId.Remove(i);
            //        break;
            //    }
            //}

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000;
            timer.Tick += new System.EventHandler(RefreshForm);
            timer.Start();
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            tables = table_Service.GetTables();
            for (int i = 0; i < tables.Count; i++)
            {
                Button btn = TableButtonList[i];
                Table table = tables[i];

                bool orderReadyToBeServed = order_Service.CheckOrderStatus(table.TableId, SelectedItemStatus.ReadyToBeServed);
                bool OrderInKitchen = order_Service.CheckOrderStatus(table.TableId, SelectedItemStatus.OrderInKitchen);

                btn.Tag = tables[i];
                // Check if an order is in kitchen, ready to be served or reservated 
                if (orderReadyToBeServed == true)
                {
                    btn.BackColor = Color.Orange;
                }
                else if (OrderInKitchen == true)
                {
                    btn.BackColor = Color.Blue;
                }
                else if (table.tafelStatus == TableStatus.Reservated)
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Lime;
                }

                //Check status of table (Free or Reserved)
                //switch (table.tafelStatus)
                //{
                //    case TableStatus.Free:
                //        btn.BackColor = Color.Lime;
                //        break;
                //    case TableStatus.Reservated:
                //        btn.BackColor = Color.Red;
                //        break;
                //    default:
                //        break; 
                //}

                //if (tableId[i].tafelStatus == TableStatus.Free)
                //    btn.BackColor = Color.Lime;
                //else if (tableId[i].tafelStatus == TableStatus.CurrentOrder)
                //    btn.BackColor = Color.Blue;
                //else if (runningOrder == true)
                //    btn.BackColor = Color.Purple;
                //else
                //    btn.BackColor = Color.Red;
            }
        }

        void ButtonEvent(object sender, EventArgs e)
        {
            bool reservated = false;
            Button button = sender as Button;
            Table table = (Table)button.Tag;

            if (table.tafelStatus == TableStatus.Reservated)
                reservated = true;

            this.Hide();
            TableChoice tableChoice = new TableChoice(table.TableId);
            tableChoice.ValidateButons(reservated);
            tableChoice.ShowDialog();
            this.Close();
        }
        //Log out -> login page
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }

        










        ////Table1
        //private void btn_Tafel_1_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table 2
        //private void btn_Tafel_2_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table3
        //private void btn_Tafel_3_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table 4
        //private void btn_Tafel_4_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table 5
        //private void btn_Tafel_5_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}


        ////Tble 6
        //private void btn_Tafel_6_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}

        ////Table 7
        //private void btn_Tafel_7_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table 8
        //private void btn_Tafel_8_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table 9
        //private void btn_Tafel_9_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
        ////Table 10
        //private void btn_Tafel_10_Click(object sender, EventArgs e)
        //{
        //    table = (Table)btn_Tafel_1.Tag;
        //    goToTableChoiche(table);
        //}
    }
}
