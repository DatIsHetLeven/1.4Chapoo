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

        //Get all table status
        public DataTable GetTableStatus(int TableId, int TableStatus)
        {
            string query = "select * from [Table] where TableId = '" + TableId + "' and   TableStatus =  '" + TableStatus + "' ";
            DataTable dt = ExecuteSelectQuery(query);

            return dt;
        }
        //Set table to status : reservated
        public void SetTableReservated(int table)
        {
            string query = "Update [table] set TableStatus=2 where TableId=@tafelid";
            query = query.Replace("@tafelid", table.ToString());
            ExecuteEditQuery(query);
        }

        //Set table to status : Free
        public void SetTableFree(int table)
        {
            string query = "Update [table] set TableStatus=1 where TableId=@tafelid";
            query = query.Replace("@tafelid", table.ToString());
            ExecuteEditQuery(query);
        }
        //Set table In use
        public void SetTableInUse(int tableId)
        {
            string query = "Update [table] set TableStatus=3 where TableId=@tafelid";
            query = query.Replace("@tafelid", tableId.ToString());
            ExecuteEditQuery(query);
        }

        //Get all table info 
        public List<Table> TableInfo()
        {
            string query = "select [TableId], [TableStatus] from[table]";
            return TableInfo(ExecuteSelectQuery(query));
        }
        //Return all tables
        private List<Table> TableInfo(DataTable datatable)
        {
            int TableId = 0;
            int TableStatus = 0;

            List<Table> TableList = new List<Table>();

            foreach (DataRow item in datatable.Rows)
            {
                Table table = new Table(TableId, TableStatus);
                {
                    TableId = (int)item["TableId"];
                    TableStatus = (int)item["TableStatus"];
                    if (table.TableId != 0)
                    {
                        TableList.Add(table);
                    }
                };
            }
            return TableList;
        }
    }
}
