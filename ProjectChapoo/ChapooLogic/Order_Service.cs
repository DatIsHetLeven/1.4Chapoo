using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;

namespace ChapooLogic
{
    public class Order_Service
    {
        Order_DAO Order_DAO = new Order_DAO();

        public void WriteOrder(int orderid, string itemname, int itemamount)
        {
            Order_DAO.Db_Write_Order(orderid, itemname, itemamount);
        }
    }
}
