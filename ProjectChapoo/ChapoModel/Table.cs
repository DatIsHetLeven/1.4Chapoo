using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class Table
    {
        private int tableid;

        public int TableId { get { return tableid; } }
        public TableStatus tafelStatus { get; set; }

        public Table(int tableId, TableStatus TafelSatus)
        {
            this.tableid = tableId;
            this.tafelStatus = TafelSatus;
        }
    }
}
