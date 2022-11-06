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
    public partial class deleteTicket : Form
    {
        public deleteTicket()
        {
            InitializeComponent();
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
            int ticketCount = Convert.ToInt32(TicketColBox.Text);

            Place place;
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

            Program.performance.RemoveTicket(date, ticketCount, place);

            Close();
        }

        private void deleteTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
