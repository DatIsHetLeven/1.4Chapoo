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

        public MenuItem(int prijs, string menuItemNaam, string MenuItemCategorie)
        {
            this.Prijs = prijs;
            this.MenuItemNaam = menuItemNaam;
            this.menuItemCategorie = MenuItemCategorie;
        }

    }

    public class Class1
    {
    }
}
