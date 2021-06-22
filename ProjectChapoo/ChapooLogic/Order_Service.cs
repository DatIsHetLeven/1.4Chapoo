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
    public class Order_Service
    {
        Order_DAO Order_DAO = new Order_DAO();
        public int GetMaxId()
        {
            int MaxId;
            MaxId = Order_DAO.GetMaxId();
            return MaxId;
        }
        //Write order
        public void WriteOrder(int orderId, int tafelId, int prijs, string dateTime, string BTW)
        {
            Order_DAO.WriteOrder(orderId, tafelId, prijs, dateTime, BTW);
        }

        //Get
        public List<Order> GetSelectedItemsKeuken()
        {
            List<Order> selectedItemsList;
            selectedItemsList = Order_DAO.GetSelectedItemKeuken();
            return selectedItemsList;
        }

        public List<Order> GetSelectedItemsBar()
        {
            List<Order> selectedItemsList;
            selectedItemsList = Order_DAO.selectedItemsBarman();
            return selectedItemsList;
        }

        
        //Getrunningorder
        public bool CheckOrderStatus(int tableid, SelectedItemStatus status)
        {
            bool runningorder;
            runningorder = Order_DAO.CheckOrderStatus(tableid, status);
            return runningorder;
        }

    }
}