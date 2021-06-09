using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public string MenuItem { get; set; }
        public int Prijs { get; set; }
        public DateTime Date { get; set; }

        public Order(int orderId, int tableId, string menuItem, int prijs, DateTime date)
        {
            this.OrderId = orderId;
            this.TableId = tableId;
            this.MenuItem = menuItem;
            this.Prijs = prijs;
            this.Date = date;
        }
    }
}
