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
        Table_Service table_Service = new Table_Service();
        List<Table> tableId = new List<Table>();
        private int UserId;
        public void DashboardUser(User user)
        {
            UserId = user.userId;
            lbl_UserName.Tag = user;
            lbl_UserName.Text = $"Geberuiker:{user.userName}";
        }
        public Dashboard()
        {
            InitializeComponent();
            tableId = table_Service.GetTables();

            List<Button> TableButtonList = new List<Button>();
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


            // Check status
            foreach (Button btn in TableButtonList)
            {
                foreach (var i in tableId)
                {
                    //Give tag Prop
                    btn.Tag = i.TableId;
                    //Check status of table
                    if (i.TableStatus == 1)//Status = free
                        btn.BackColor = Color.Lime;
                    else if (i.TableStatus == 3)//status = current order
                        btn.BackColor = Color.Blue;
                    else//status = reservated
                        btn.BackColor = Color.Red;
                    tableId.Remove(i);
                    break;
                }
            }
        }
        //Go to TableChoice.cs, method for table buttons
        private void goToTableChoiche(string tableId)
        {
            int tableNumber = int.Parse(tableId);
            this.Hide();
            TableChoice tableChoice = new TableChoice(tableNumber);
            tableChoice.ShowDialog();
            this.Close();
        }

        //Table1
        private void btn_Tafel_1_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_1.Tag.ToString());
        }
        //Table 2
        private void btn_Tafel_2_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_2.Tag.ToString());
        }
        //Table3
        private void btn_Tafel_3_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_3.Tag.ToString());
        } 
        //Table 4
        private void btn_Tafel_4_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_4.Tag.ToString());
        }
        //Table 5
        private void btn_Tafel_5_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_5.Tag.ToString());
        }
        //Tble 6
        private void btn_Tafel_6_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_6.Tag.ToString());
        }
        //Table 7
        private void btn_Tafel_7_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_7.Tag.ToString());
        }
        //Table 8
        private void btn_Tafel_8_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_8.Tag.ToString());
        }
        //Table 9
        private void btn_Tafel_9_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_9.Tag.ToString());
        }
        //Table 10
        private void btn_Tafel_10_Click(object sender, EventArgs e)
        {
            goToTableChoiche(btn_Tafel_10.Tag.ToString());
        }
        //Log out -> login page
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }
    }
}
