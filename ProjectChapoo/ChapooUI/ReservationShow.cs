using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapoModel;

namespace ChapooUI
{
    public partial class ReservationShow : Form
    {
        private int Tableid;
        private Reservate_Service reservate_service = new Reservate_Service();
        public ReservationShow(int tableid)
        {
            InitializeComponent();
            this.Tableid = tableid;

            ChapoModel.Reservate reservate = reservate_service.GetReservates(Tableid);

            lbl_Gereserveerd.Text = $"Tafel met tafelnummer {Tableid} is gereserveerd";
            lbl_KlantNaam.Text = $"Gereserveerd voor klant : {reservate.klantNaam.ToString()}";
            lbl_Tijd.Text = $"Om tijdstip : {reservate.startTijd.ToString()}";
        }

    }
}
