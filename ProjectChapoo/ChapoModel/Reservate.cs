using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class Reservate
    {
        public int tafelId { get; set; }
        public DateTime startTijd { get; set; }
        public string klantNaam { get; set; }

        public Reservate(int Reservateid, int TafelId, DateTime StartTijd, string KlantNaam)
        {
            this.tafelId = TafelId;
            this.startTijd = StartTijd;
            this.klantNaam = KlantNaam;
        }
    }
}
