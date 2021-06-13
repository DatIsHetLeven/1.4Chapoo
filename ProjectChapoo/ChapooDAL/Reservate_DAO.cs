using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapoModel;

namespace ChapooDAL
{
    public class Reservate_DAO : Base
    {
        //Insert Reservation
        public void InsertReservation(int tafelId, DateTime startTijd, string klantNaam)
        {
            string query = $"Insert into[Reservate] (tafelId, startTijd, klantNaam) Values('{tafelId}', '{startTijd}','{klantNaam}')";
            ExecuteEditQuery(query);
        }

        //Delete reservation
        public void RemoveReservation(int tafelId)
        {
            string query = $"delete from [reservate] where reservateId = '{tafelId}'";
            ExecuteEditQuery(query);
        }

        //Select Reservation
        public Reservate Getreservation(int tafelId)
        {
            string query = $"select tafelId, reservateId, starttijd, klantnaam from [reservate] where tafelid = '{tafelId}'";
            return GetReservates(ExecuteSelectQuery(query));
        }

        //Reservation details
        private Reservate GetReservates(DataTable dataTable)
        {
            int tafelId = 0;
            int reservateId = 0;
            DateTime starttijd = Convert.ToDateTime("12:00".ToString());
            string klantnaam = "";

            foreach (DataRow item in dataTable.Rows)
            {
                tafelId = (int)item["tafelId"];
                reservateId = (int)item["reservateId"];
                starttijd = Convert.ToDateTime(item["starttijd"].ToString());
                klantnaam = (string)item["klantnaam"].ToString();
            }
            return new Reservate(tafelId, reservateId, starttijd, klantnaam);
        }
    }
}
