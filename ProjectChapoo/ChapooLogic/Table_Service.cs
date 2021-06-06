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

        //Change TableStatus
        public void ChangeTableStatus(int tableId, int status)
        {
            table_DAO.ChangeTableStatus(tableId, status);
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


