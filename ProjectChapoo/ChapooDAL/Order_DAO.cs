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
        public void WriteOrder(int orderId, int tafelId, int prijs, string dateTime, string BTW)
        {
            string query = $"Insert into[order] (orderId, TableId, prijs, Date, BTWt) Values('{orderId}','{tafelId}','{prijs}', '{dateTime}','{BTW}')";
            ExecuteEditQuery(query);
        }
        ////Get order -> finished
        //public bool GetRunningOrder(int tableid, int status)
        //{
        //    string query = $"select OrderId from [SelectedItems] where status ='{status}' and tableId ='{tableid}'";
        //    return RunningOrder(ExecuteSelectQuery(query));
        //}
        //Get order -> finished
        public bool CheckOrderStatus(int tableid, SelectedItemStatus status)
        {
            string query = $"select SelectedItemsStatus.StatusNaam from [SelectedItems] inner " +
                           $"join SelectedItemsStatus on SelectedItems.[status] = SelectedItemsStatus.[Status] " +
                           $"where SelectedItemsStatus.statusnaam = '{status}' and [SelectedItems].tableid = '{tableid}'";
            return RunningOrder(ExecuteSelectQuery(query));
        }
        //Check if there is a running order
        private bool RunningOrder(DataTable dataTable)
        {
            bool runningOrder = false;

            if (dataTable.Rows.Count >= 1)
                runningOrder = true;

            return runningOrder;
        }

        //Get finished order

        public List<Order> GetSelectedItemKeuken()
        {
            string query = "select * from [SelectedItems], [order] where [SelectedItems].[status] = 2 And [SelectedItems].OrderId = [order].OrderId and itemcategorie = 'Lunch' or itemcategorie= 'Diner'";
            return GetItemss(ExecuteSelectQuery(query));
        }
        public List<Order> selectedItemsBarman()
        {
            string query = "select * from [SelectedItems], [order] where [SelectedItems].[status] = 2 And [SelectedItems].OrderId = [order].OrderId and itemcategorie = 'Drank' ";
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
            DateTime tijd = Convert.ToDateTime("12:00".ToString());
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
                    tijd = Convert.ToDateTime(item["Date"].ToString());
                    Order selectedItem = new Order(orderId,tableId, menuItem, Prijs, aantal, Btw, tijd);
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
