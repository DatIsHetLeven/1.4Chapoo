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
        public string tafelStatus { get; set; }

        public Table(int tableId, /*int tableStatus,*/ string TafelSatus)
        {
            this.TableId = tableId;
            this.tafelStatus = TafelSatus;
        }
    }
}
