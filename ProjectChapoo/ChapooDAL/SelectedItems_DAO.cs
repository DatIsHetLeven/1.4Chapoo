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
        public void SendItemsToKitchen(int tableid, int orderid)
        {
            string query = $"update SelectedItems set status = 2 , orderid = '{orderid}' where tableId = '{tableid}' and [status] = 1";
            ExecuteEditQuery(query);
        }


        //Insert
        public void InsertNewSelectedItem(int tableid, string item, int prijs, int itemid, string itemCategorie, int invoer, decimal BTW, int menuiD, int orderid)
        {
            string query = $"Insert into[selecteditems] (tableId, menuItem, Prijs, status, itemid, itemCategorie, Aantal, [BTWTot], menuid, orderid) Values('{tableid}', '{item}', '{prijs}', 1, '{itemid}', '{itemCategorie}', '{invoer}', '{BTW.ToString()}', '{menuiD}', '{orderid}')";
            ExecuteEditQuery(query);
        }

        //Insert
        public void InsertNewSelectedItem2(SelectedItem selectedItem, int itemid, MenuItem menuItem,int orderid)
        {
            string query = $"Insert into[selecteditems] (tableId, menuItem, Prijs, status, itemid, itemCategorie, Aantal, [BTWTot], menuid, orderid) Values('{selectedItem.tableid}', '{selectedItem.menuItem}', '{selectedItem.prijs}', 1, '{itemid}', '{menuItem.menuItemCategorie}', '{selectedItem.aantal}', '{selectedItem.BTW}', '{menuItem.menuitemId}', '{orderid}')";
            ExecuteEditQuery(query);
        }

        //Select for bar
        public List<SelectedItem> GetSelectedItemsBar()
        {
            string query = "select tableId, menuItem, Prijs, aantal,BTWTot from [SelectedItems] where status = 2 and itemcategorie = 'Drinks' ";
            return GetItemss(ExecuteSelectQuery(query));
        }
        //Return
        private List<SelectedItem> GetItems(DataTable dataTable)
        {
            int tableId = 0;
            string menuItem = "";
            int Prijs = 0;
            int aantal = 0;
            string BTWTot = "";

            List<SelectedItem> selectedItems = new List<SelectedItem>();
            foreach (DataRow item in dataTable.Rows)
            {

                tableId = (int)item["tableId"];
                menuItem = (string)item["menuItem"].ToString();
                aantal = (int)item["aantal"];
                Prijs = (int)item["Prijs"];
                BTWTot = (string)item["BTWTot"].ToString();

                SelectedItem selectedItem = new SelectedItem(tableId, menuItem, Prijs, aantal, BTWTot);
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
        public void UpdateStatus2(int tableId, int status, int currentstatus)
        {
            string query = $"update SelectedItems set status = '{status}' where status = '{currentstatus}' and tableId = '{tableId}'";
            ExecuteEditQuery(query);
        }
        //Select order
        public List<SelectedItem> GetMakingOrder(int tableid, int status)
        {
            string query = $"select tableId, menuItem, aantal,Prijs,BTWTot from [SelectedItems] where tableId = '{tableid}' and status ='{status}'";
            return GetItems(ExecuteSelectQuery(query));
        }

        //Return
        private List<SelectedItem> GetItemss(DataTable dataTable)
        {
            int tableId = 0;
            string menuItem = "";
            int Prijs = 0;
            int status = 0;
            string BTWTot = "";
            int aantal = 0;
            List<SelectedItem> selectedItems = new List<SelectedItem>();
            foreach (DataRow item in dataTable.Rows)
            {
                tableId = (int)item["tableId"];
                menuItem = (string)item["menuItem"].ToString();
                Prijs = (int)item["Prijs"];
                aantal = (int)item["aantal"];
                BTWTot = (string)item["BTWTot"].ToString();
                SelectedItem selectedItem = new SelectedItem(tableId, menuItem, Prijs,aantal, BTWTot);
                {
                    selectedItems.Add(selectedItem);
                }
            }
            return selectedItems;
        }

    }
}
