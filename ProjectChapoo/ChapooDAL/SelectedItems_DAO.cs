using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapoModel;

namespace ChapooDAL
{
    public class SelectedItems_DAO : Base
    {
        //Stuur naar keuken
        public void SendItemsToKitchen(int tableid)
        {
            string query = $"update SelectedItems set status = 2 where tableId = '{tableid}' and [status] = 1";
            ExecuteEditQuery(query);
        }


        //Insert
        public void InsertNewSelectedItem(int tableid, string item, int prijs, int itemid, string itemCategorie, int invoer, decimal BTW)
        {
            string query = $"Insert into[selecteditems] (tableId, menuItem, Prijs, status, itemid, itemCategorie, Aantal, [BTWTot]) Values('{tableid}', '{item}', '{prijs}', 1, '{itemid}', '{itemCategorie}', '{invoer}', '{BTW.ToString()}')";
            ExecuteEditQuery(query);
        }

        //Insert
        public void InsertNewSelectedItemToKitchen(int tableid, string item, int prijs)
        {
            string query = $"Insert into[selecteditems] (tableId, menuItem, Prijs, status) Values('{tableid}', '{item}', '{prijs}', 5)";
            ExecuteEditQuery(query);
        }
        //Select for bar
        public List<SelectedItem> GetSelectedItemsBar()
        {
            string query = "select tableId, menuItem, Prijs, aantal from [SelectedItems] where status = 2 and itemcategorie = 'Drinks' ";
            return GetItemss(ExecuteSelectQuery(query));
        }
        //Select for kitchen
        public List<SelectedItem> GetSelectedItemKeuken()
        {
            string query = " select tableId, menuItem, Prijs, aantal from [SelectedItems] where status = 2 and itemcategorie = 'Lunch' or itemcategorie= 'Diner'";
            return GetItemss(ExecuteSelectQuery(query));
        }
        //Select order
        public List<SelectedItem> GetSelectedOrder(int tableid)
        {
            string query = $"select tableId, menuItem, Prijs, status,itemCategorie, Aantal, [itemId] from [SelectedItems] where tableId = '{tableid}' and status =3";
            return GetItems(ExecuteSelectQuery(query));
        }
        //Return
        private List<SelectedItem> GetItems(DataTable dataTable)
        {
            int tableId = 0;
            string menuItem = "";
            int Prijs = 0;
            int aantal = 0;
            
            List<SelectedItem> selectedItems = new List<SelectedItem>();
            foreach (DataRow item in dataTable.Rows)
            {

                tableId = (int)item["tableId"];
                menuItem = (string)item["menuItem"].ToString();
                aantal = (int)item["aantal"];
                Prijs = (int)item["Prijs"];

                SelectedItem selectedItem = new SelectedItem(tableId, menuItem, Prijs, aantal);
                {
                    selectedItems.Add(selectedItem);
                }
            }
            return selectedItems;
        }
        //Update
        public void UpdateStatus(string menuItem, int tableId, int status)
        {
            string query = $"update SelectedItems set status = '{status}' where MenuItem = '{menuItem}' and tableId = '{tableId}'";
            ExecuteEditQuery(query);
        }
        //delete
        public void ClearItems(int tableid)
        {
            string query = $"delete from [SelectedItems] where tableId = '{tableid}'";
            ExecuteEditQuery(query);
        }
        //Select order
        public List<SelectedItem> GetMakingOrder(int tableid, int status)
        {
            string query = $"select tableId, menuItem, aantal,Prijs from [SelectedItems] where tableId = '{tableid}' and status ='{status}'";
            return GetItems(ExecuteSelectQuery(query));
        }

        //Return
        private List<SelectedItem> GetItemss(DataTable dataTable)
        {
            int tableId = 0;
            string menuItem = "";
            int Prijs = 0;
            int status = 0;
            string itemCategorie = "";
            int aantal = 0;
            List<SelectedItem> selectedItems = new List<SelectedItem>();
            foreach (DataRow item in dataTable.Rows)
            {
                tableId = (int)item["tableId"];
                menuItem = (string)item["menuItem"].ToString();
                Prijs = (int)item["Prijs"];
                aantal = (int)item["aantal"];
                SelectedItem selectedItem = new SelectedItem(tableId, menuItem, Prijs,aantal);
                {
                    selectedItems.Add(selectedItem);
                }
            }
            return selectedItems;
        }

    }
}
