using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class Item
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public int Tax { get; set; }
    }
}
