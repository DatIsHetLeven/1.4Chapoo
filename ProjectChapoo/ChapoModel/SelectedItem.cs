using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class SelectedItem
    {
        public int tableid { get; set; }
        public string menuItem { get; set; }
        public int prijs { get; set; }
        public int aantal { get; set; }
        public string BTW { get; set; }

        public SelectedItem(int TableId, string MenuItem, int Prijs, int Aantal, string BTWT)
        {
            this.tableid = TableId;
            this.menuItem = MenuItem;
            this.prijs = Prijs;
            this.aantal = Aantal;
            this.BTW = BTWT;
        }

    }
}
