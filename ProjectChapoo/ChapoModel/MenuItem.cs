using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapoModel
{
    public class MenuItem
    {
        public int Prijs { get; set; }
        public string MenuItemNaam { get; set; }
        public int MenuId { get; set; }

        public MenuItem(int prijs, string menuItemNaam, int menuId)
        {
            this.Prijs = prijs;
            this.MenuItemNaam = menuItemNaam;
            this.MenuId = menuId;
        }

    }

    public class Class1
    {
    }
}
