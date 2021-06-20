using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapoModel;

namespace ChapooDAL
{
    public class Order_DAO : Base
    {
        //Insert order
        public void WriteOrder(int orderId, int tafelId, int prijs, DateTime dateTime, string BTW)
        {
            string query = $"Insert into[order] (orderId, TableId, prijs, Date, BTWt) Values('{orderId}','{tafelId}','{prijs}', '{dateTime}','{BTW}')";
            ExecuteEditQuery(query);
        }
        //Get Running order
        public bool GetRunningOrder(int tableid)
        {
            string query = $" select tableId, menuItem, Prijs, aantal from [SelectedItems] where status = 4 and tableId ='{tableid}'";
            return RunningOrder(ExecuteSelectQuery(query));
        }
        //Check if there is a running order
        private bool RunningOrder(DataTable dataTable)
        {
            bool runningOrder = false;

            if (dataTable.Rows.Count >= 1)
            {
                runningOrder = true;
            }
            return runningOrder;
        }
        //Get finished order


        //Select for kitchen
        public List<Order> GetSelectedItemKeuken()
        {
            string query = "select OrderId, tableId, menuItem, Prijs, aantal,[status],[BTWTot] from [SelectedItems] where status = 2 and itemcategorie = 'Lunch' or itemcategorie= 'Diner'";
            return GetItemss(ExecuteSelectQuery(query));
        }
        private List<Order> GetItemss(DataTable dataTable)
        {
            int orderId = 0;
            int tableId = 0;
            string menuItem = "";
            int Prijs = 0;
            int aantal = 0;
            string Btw = "";
            List<Order> selectedItems = new List<Order>();
            if (dataTable.Rows.Count >= 1)
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    orderId = (int)item["OrderId"];
                    tableId = (int)item["tableId"];
                    menuItem = (string)item["menuItem"].ToString();
                    Prijs = (int)item["Prijs"];
                    aantal = (int)item["aantal"];
                    Btw = (string)item["BTWTot"].ToString();
                    Order selectedItem = new Order(orderId,tableId, menuItem, Prijs, aantal, Btw);
                    {
                        selectedItems.Add(selectedItem);
                    }
                }
            }
            return selectedItems;
        }

        private int MaxId(DataTable datatable)
        {
            int MaxId = 0;

            foreach (DataRow item in datatable.Rows)
            {
                MaxId = (int)item["id"];
            }
            return MaxId;
        }
        //Get Max
        public int GetMaxId()
        {
            string query = $"select max([OrderId]) AS [id] from[order]";
            return MaxId(ExecuteSelectQuery(query));
        }
    }
}
