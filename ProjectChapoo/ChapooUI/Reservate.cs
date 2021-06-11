using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapoModel;

namespace ChapooUI
{
    public partial class Reservate : Form
    {
        private Reservate_Service Reservate_Service;
        int TableId;
        private Table_Service table_Service = new Table_Service();

        public Reservate(int tableid)
        {
            InitializeComponent();
            this.TableId = tableid;
            lbl_TableNumber.Text = ("Tafelnummer : " + TableId.ToString());

            listboxTime.Items.Add("12:00");
            listboxTime.Items.Add("12:30");
            listboxTime.Items.Add("13:00");
            listboxTime.Items.Add("13:30");
            listboxTime.Items.Add("14:00");
            listboxTime.Items.Add("14:30");
            listboxTime.Items.Add("15:00");
            listboxTime.Items.Add("15:30");
            listboxTime.Items.Add("16:00");
            listboxTime.Items.Add("16:30");
            listboxTime.Items.Add("17:00");
            listboxTime.Items.Add("17:30");
            listboxTime.Items.Add("18:00");
            listboxTime.Items.Add("18:30");
            listboxTime.Items.Add("19:00");
            listboxTime.Items.Add("19:30");
            listboxTime.Items.Add("20:00");
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_Gereed_Click(object sender, EventArgs e)
        {
            Reservate_Service = new Reservate_Service();
            try
            {
                Reservate_Service.insertReservation(TableId, Convert.ToDateTime(listboxTime.SelectedItem.ToString()), txt_NaamKlant.Text);
                MessageBox.Show($"Tafel {TableId} is gereserveerd onder naam : {txt_NaamKlant.Text}\nTijd {listboxTime.SelectedItem.ToString()}");
                table_Service.ChangeTableStatus(TableId, 2);
            }
            catch (Exception)
            {
                MessageBox.Show("geen geldige invoer");
            }

            this.Hide();
            this.Close();
        }
    }
}
