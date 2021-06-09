using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class Reservate : Form
    {
        public Reservate()
        {
            InitializeComponent();

            List<int> Uren = new List<int>();
            Uren.Add(12);
            Uren.Add(13);
            Uren.Add(14);
            Uren.Add(15);
            Uren.Add(16);
            Uren.Add(17);
            Uren.Add(18);
            Uren.Add(19);
            Uren.Add(20);

            List<int> Minuten = new List<int>();
            Minuten.Add(00);
            Minuten.Add(05);
            Minuten.Add(10);
            Minuten.Add(15);
            Minuten.Add(20);
            Minuten.Add(25);
            Minuten.Add(30);
            Minuten.Add(35);
            Minuten.Add(40);
            Minuten.Add(45);
            Minuten.Add(50);
            Minuten.Add(55);

            drop_TijdUren.DataSource = Uren;
            drop_TijdMinuten.DataSource = Minuten;
        }
    }
}
