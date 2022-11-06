using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibForLab6;

namespace Lab6
{
    public partial class payTicket : Form
    {
        public payTicket()
        {
            InitializeComponent();
        }

        private void payTicket_Load(object sender, EventArgs e)
        {

        }

        private void payTicketButton_Click(object sender, EventArgs e)
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

            Program.performance.CreateTicket(date, ticketCount, place);

            Close();
        }
    }
}
