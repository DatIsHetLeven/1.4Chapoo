using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapoModel;


namespace ChapooDAL
{
    public class Table_DAO : Base
    {
        DataTable dataTable = new DataTable();

        //Change Table Status
        public void ChangeTableStatus(int tableId, int status)
        {
            string query = $"Update [table] set TableStatus='{status}'where TableId='{tableId}'";
            ExecuteEditQuery(query);
        }
        //Get all table info 
        public List<Table> TableInfo()
        {
            string query = "select [TableId], [TafelStatus] from[table],[TafelStatus] where [Table].TableStatus = [TafelStatus].TafelStatusId Order By TableId";
            return TableInfo(ExecuteSelectQuery(query));
        }
        //Return all tables
        private List<Table> TableInfo(DataTable datatable)
        {
            int TableId = 0;
            TableStatus TableStatus;

            List<Table> TableList = new List<Table>();
            foreach (DataRow item in datatable.Rows)
            {
                TableId = (int)item["TableId"];
                TableStatus = (TableStatus)Enum.Parse(typeof(TableStatus), (string)item["TafelStatus"].ToString()); 
                Table table = new Table(TableId, TableStatus);
                TableList.Add(table);
            }
            return TableList;
        }
    }
}
