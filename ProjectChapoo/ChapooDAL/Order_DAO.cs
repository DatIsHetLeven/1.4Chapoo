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
        //Get
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
        //order
        public void InsertOrder(int orderId, int tableId, string menuItem, int prijs)
        {
            DateTime thisDay = DateTime.Today;
            string query = $"insert into [order] values('{orderId}', '{tableId}', '{menuItem}', '{prijs}', '{thisDay}')";
            ExecuteEditQuery(query);
        }
    }
}
