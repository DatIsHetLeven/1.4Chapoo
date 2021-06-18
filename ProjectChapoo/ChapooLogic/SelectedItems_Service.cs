﻿using System;
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
    public class SelectedItems_Service
    {
        SelectedItems_DAO selectedItems_DAO = new SelectedItems_DAO();
        //Create new  -> insert db
        public void selectedItem(int tableId, string item, int prijs, int itemid, string itemCategorie, int invoer, decimal BTW)
        {
            selectedItems_DAO.InsertNewSelectedItem(tableId, item, prijs, itemid, itemCategorie, invoer, BTW);
        }
        public void selectedItemToKitchen(int tableId, string item, int prijs)
        {
            selectedItems_DAO.InsertNewSelectedItemToKitchen(tableId, item, prijs);
        }
        //Get
        public List<SelectedItem> GetSelectedItemsKeuken()
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetSelectedItemKeuken();
            return selectedItemsList;
        }
        //Get
        public List<SelectedItem> GetSelectedItemsBar()
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetSelectedItemsBar();
            return selectedItemsList;
        }


        //Update
        public void updateStatus(string menuItem, int tableId, int status)
        {
            selectedItems_DAO.UpdateStatus(menuItem, tableId, status);
        }
        //
        public List<SelectedItem> GetCurrentItems(int tableid)
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetSelectedOrder(tableid);
            return selectedItemsList;
        }
        //delete
        public void removeItems(int tableId)
        {
            selectedItems_DAO.ClearItems(tableId);
        }
        //Get Order in making
        public List<SelectedItem> GetMakingOrder(int tableid, int status)
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetMakingOrder(tableid, status);
            return selectedItemsList;
        }

        public void SendItemsToKitchen(int tableid)
        {
            selectedItems_DAO.SendItemsToKitchen(tableid);
        }
    }
}