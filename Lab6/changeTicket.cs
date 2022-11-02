using LibForLab6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class changeTicket : Form
    {
        public changeTicket()
        {
            InitializeComponent();
        }

        private void changeTicketButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            DateTime lastDate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            int ticketCount = Convert.ToInt32(TicketColBox.Text);

            LibForLab6.Place place;
            if (parerreRadioButton.Checked)
            {
                place = Place.Parterre;
            }
            else if (BalconyRadioButton.Checked)
            {
                place = Place.Balcony;
            }
            else
            {
                place = Place.Loggia;
            }

            LibForLab6.Place newPlace;
            if (newParerreRadioButton.Checked)
            {
                newPlace = Place.Parterre;
            }
            else if (newBalconyRadioButton.Checked)
            {
                newPlace = Place.Balcony;
            }
            else
            {
                newPlace = Place.Loggia;
            }

            Performance.ChangeTicket(firstDate, ticketCount, place, lastDate, newPlace);

            Close();
        }

        private void changeTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
