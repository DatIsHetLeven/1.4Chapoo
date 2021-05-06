using System;
using System.Data.SqlClient;


namespace ChapooDAL
{
    public class Order_DAO: Base
    {
        public void Db_Write_Order(int orderid, string itemname, int itemamount)
        {
            string query = $"INSERT INTO dbo.orders (order_id, item_name, item_amount) VALUES (@order_id, @item_name, @item_amount)";

            SqlParameter[] Writeorder =
            {
                new SqlParameter("@order_id", orderid),
                new SqlParameter("@item_name", itemname),
                new SqlParameter("@item_amount", itemamount)
            };
            ExecuteSelectQuery(query, Writeorder);
        }
    }
}
