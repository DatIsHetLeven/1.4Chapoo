using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class MenuItem
    {
        public double Prijs { get; set; }
        public string MenuItemNaam { get; set; }
        public string menuItemCategorie { get; set; }
        public int menuitemId { get; set; }


        public MenuItem(int prijs, string menuItemNaam, string MenuItemCategorie, int MenuitemId)
        {
            this.Prijs = prijs;
            this.MenuItemNaam = menuItemNaam;
            this.menuItemCategorie = MenuItemCategorie;
            this.menuitemId = MenuitemId;
        }

    }

    public class Class1
    {
    }
}
