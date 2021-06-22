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
    public class SelectedItems_Service
    {
        SelectedItems_DAO selectedItems_DAO = new SelectedItems_DAO();
        //Create new  -> insert db
        public void selectedItem2(SelectedItem selectedItem, int itemid, MenuItem menuItem, int orderid)
        {
            selectedItems_DAO.InsertNewSelectedItem2(selectedItem, itemid, menuItem, orderid);
        }

        //Update
        public void updateStatus(string menuItem, int tableId, int status)
        {
            selectedItems_DAO.UpdateStatus(menuItem, tableId, status);
        }
        //
        //Update2
        public void updateStatus2(int tableId, int status, int currentstatus)
        {
            selectedItems_DAO.UpdateStatus2(tableId, status, currentstatus);
        }

        //Get Order in making
        public List<SelectedItem> GetMakingOrder(int tableid, int status)
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetMakingOrder(tableid, status);
            return selectedItemsList;
        }

        public void SendItemsToKitchen(int tableid, int orderid)
        {
            selectedItems_DAO.SendItemsToKitchen(tableid, orderid);
        }

    }
}