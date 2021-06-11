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
    public class Reservate_Service
    {
        Reservate_DAO Reservate_DAO = new Reservate_DAO();
        public void insertReservation(int tafelId, DateTime startTijd, string klantNaam)
        {
            Reservate_DAO.InsertReservation(tafelId, startTijd, klantNaam);
        }

        public Reservate GetReservates(int tableId)
        {
            return Reservate_DAO.Getreservation(tableId);
        }

        public void DeleteReservation(int tableId)
        {
            Reservate_DAO.RemoveReservation(tableId);
        }
    }
}
