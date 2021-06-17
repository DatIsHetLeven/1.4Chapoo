using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapooDAL;
using ChapoModel;

namespace ChapooLogic
{
    public class MenuItem_Service
    {
        MenuItem_DAO menuItem_DAO = new MenuItem_DAO();

        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItemsList;
            menuItemsList = menuItem_DAO.GetMenuItems();
            return menuItemsList;
        }

        public List<MenuItem> GetDinerItems()
        {
            List<MenuItem> menuItemsList;
            menuItemsList = menuItem_DAO.GetDinerItems();
            return menuItemsList;
        }

        public List<MenuItem> GetDrinkItems()
        {
            List<MenuItem> menuItemsList;
            menuItemsList = menuItem_DAO.GetDrinktems();
            return menuItemsList;
        }
    }
}