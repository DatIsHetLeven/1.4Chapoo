using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class Table
    {
        public int TableId { get; set; }
        public int TableStatus { get; set; }

        public Table(int tableId, int tableStatus)
        {
            this.TableId = tableId;
            this.TableStatus = tableStatus;
        }
    }
}
