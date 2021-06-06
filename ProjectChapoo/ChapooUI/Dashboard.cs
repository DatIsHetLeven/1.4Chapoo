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
        private User User;
        public Dashboard(User user)
        {
            InitializeComponent();
            this.User = user;
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
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
        private void goToTableChoiche(int tableId)
        {
            this.Hide();
            TableChoice tableChoice = new TableChoice(tableId);
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

        //Go to TableChoice.cs, method for table buttons
        private void goToTableChoiche(string tableId)
        {
            int tableNumber = int.Parse(tableId);
            this.Hide();
            TableChoice tableChoice = new TableChoice(tableNumber);
            tableChoice.ShowDialog();
            this.Close();
        }

    }
}
