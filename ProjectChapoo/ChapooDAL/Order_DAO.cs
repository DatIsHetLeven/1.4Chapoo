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
        //Get Max
        public List<int> GetMaxId()
        {
            string query = $"select max([OrderId]) AS [id] from[order]";
            return MaxId(ExecuteSelectQuery(query));
        }

        private List<int> MaxId(DataTable datatable)
        {
            List<int> MaxId = new List<int>();

            foreach (DataRow item in datatable.Rows)
            {
                int Id = (int)item["id"];
                MaxId.Add(Id);
            }
            return MaxId;
        }
        //place order, and send to database table [order]
        public void InsertOrder(int orderId, int tableId, string menuItem, int prijs)
        {
            DateTime thisDay = DateTime.Today;
            string query = $"insert into [order] values('{orderId}', '{tableId}', '{menuItem}', '{prijs}', '{thisDay}')";
            ExecuteEditQuery(query);
        }

        //Get Running order
        public bool GetRunningOrder(int tableid)
        {
            string query = $" select tableId, menuItem, Prijs, aantal from [SelectedItems] where status = 2 and tableId ='{tableid}'";
            return RunningOrder(ExecuteSelectQuery(query));
        }

        private bool RunningOrder(DataTable dataTable)
        {
            bool runningOrder = false;


            foreach (DataRow item in dataTable.Rows)
            {
                runningOrder = true;
            }
            return runningOrder;
        }
        

        //Get finished order
    }
}
