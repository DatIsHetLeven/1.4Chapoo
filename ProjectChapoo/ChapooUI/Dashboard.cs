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
        public Dashboard()
        {
            InitializeComponent();
            Table_Service table_Service = new Table_Service();

            DataTable dataTable = new DataTable();

            List<Table> tableId = new List<Table>();
            tableId = table_Service.GetTables();


            List<Button> TableButtonList = new List<Button>();
            TableButtonList.Add(btn_Tafel_1);
            TableButtonList.Add(btn_Tafel_2);
            TableButtonList.Add(btn_Tafel_3);
            TableButtonList.Add(btn_Tafel_4);

            foreach (Button item in TableButtonList)
            {
                foreach (var i in tableId)
                {
                    if (i.TableStatus == 1)
                    {
                        item.BackColor = Color.Lime;
                        tableId.Remove(i);
                    }
                    else
                    {
                        item.BackColor = Color.Red;
                        tableId.Remove(i);
                    }
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

        //Table 1
        private void btn_Tafel_1_Click(object sender, EventArgs e)
        {
            goToTableChoiche(1);
        }

        private void btn_Tafel_2_Click(object sender, EventArgs e)
        {
            goToTableChoiche(2);
        }

        private void btn_Tafel_3_Click(object sender, EventArgs e)
        {
            goToTableChoiche(3);
        }

        private void btn_Tafel_4_Click(object sender, EventArgs e)
        {
            goToTableChoiche(4);
        }
    }
}
