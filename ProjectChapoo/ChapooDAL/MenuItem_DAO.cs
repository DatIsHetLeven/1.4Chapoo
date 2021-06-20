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
        //Get all lunch Items
        public List<MenuItem> GetMenuItems()
        {
            string query = "Select [prijs], [menuItemNaam], [menuItemCategorie],[menuitemid] from[MenuitemTable] where menuItemCategorie = 'Lunch'";
            return MenuItems(ExecuteSelectQuery(query));
        }
        //get all Diner Items
        public List<MenuItem> GetDinerItems()
        {
            string query = "Select [prijs], [menuItemNaam], [menuItemCategorie],[menuitemid] from[MenuitemTable] where menuItemCategorie = 'Diner'";
            return MenuItems(ExecuteSelectQuery(query));
        }
        //Get all Drink items
        public List<MenuItem> GetDrinktems()
        {
            string query = "Select [prijs], [menuItemNaam], [menuItemCategorie],[menuitemid] from[MenuitemTable] where menuItemCategorie = 'Drank'";
            return MenuItems(ExecuteSelectQuery(query));
        }


        //Return MenuItems
        private List<MenuItem> MenuItems(DataTable datatable)
        {
            int Prijs = 0;
            string MenuItemNaam = "";
            string MenuItemCategorie = "";
            int MenuitemId = 0; 

            List<MenuItem> ListMenuItem = new List<MenuItem>();

            foreach (DataRow item in datatable.Rows)
            {
                MenuItem menuItem = new MenuItem(Prijs, MenuItemNaam, MenuItemCategorie, MenuitemId);
                {
                    Prijs = (int)item["prijs"];
                    MenuItemNaam = (string)item["menuItemNaam"].ToString();
                    MenuItemCategorie = (string)item["menuItemCategorie"].ToString();
                    MenuitemId = (int)item["menuitemid"];
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