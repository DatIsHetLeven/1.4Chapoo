using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapoModel;

namespace ChapooDAL
{
    public class MenuItem_DAO : Base
    {
        public List<MenuItem> GetMenuItems()
        {
            string query = "Select [menuItemId], [menuId], [prijs], [menuItemNaam], [menuItemCategorie] from[MenuItem]";
            return MenuItems(ExecuteSelectQuery(query));
        }
        //Return MenuItems
        private List<MenuItem> MenuItems(DataTable datatable)
        {
            int MenuItemId = 0;
            int MenuId = 0;
            int Prijs = 0;
            string MenuItemNaam = "";
            string MenuItemCategorie = "";

            List<MenuItem> ListMenuItem = new List<MenuItem>();

            foreach (DataRow item in datatable.Rows)
            {
                MenuItem menuItem = new MenuItem(Prijs, MenuItemNaam, MenuId);
                {
                    //MenuItemId = (int)item["menuItemId"];
                    MenuId = (int)item["menuId"];
                    Prijs = (int)item["prijs"];
                    MenuItemNaam = (string)item["menuItemNaam"].ToString();
                    //MenuItemCategorie = (string)item["menuItemCategorie"].ToString();
                    //ListMenuItem.Add(menuItem);
                    if (menuItem.Prijs != 0)
                    {
                        ListMenuItem.Add(menuItem);
                    }
                };
            }
            return ListMenuItem;
        }

    }
}