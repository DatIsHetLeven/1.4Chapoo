using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class Order
    {
        public int Orderid { get; set; }
        public bool Orderstatus { get; set; }

        public Order(int orderid, bool orderstatus)
        {
            this.Orderid = orderid;
            this.Orderstatus = orderstatus;
        }
    }
}
