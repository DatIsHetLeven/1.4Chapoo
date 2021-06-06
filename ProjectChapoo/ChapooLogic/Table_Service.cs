using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapooDAL;
using ChapoModel;

namespace ChapooLogic
{
    public class Table_Service
    {
        Table_DAO table_DAO = new Table_DAO();

        //Set table to status: Reservated
        public void SetTableReservate(int tableId)
        {
                table_DAO.SetTableReservated(tableId);
        }

        //Set table to status : Free
        public void SetTableFree(int tableId)
        {
            table_DAO.SetTableFree(tableId);
        }
        public void SetTableInUse(int tableId)
        {
            table_DAO.SetTableInUse(tableId);
        }

        //Get table Status
        public DataTable GetTableStatus(int TableId, int TableStatus)
        {
            return table_DAO.GetTableStatus(TableId, TableStatus);
        }

        //Get tableinfo
        public List<Table> GetTables()
        {
            List<Table> tableList;
            tableList = table_DAO.TableInfo();
            return tableList;
        }
    }
}


