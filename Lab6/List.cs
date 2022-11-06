using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibForLab6;

namespace Lab6
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            List<LibForLab6.Ticket> tickets = Performance.GetList();

            textBox.Items.Clear();

            int i = 1;
            foreach (Ticket ticket in tickets)
            {
                textBox.Items.Add("Билет " + i + ": дата - " + ticket.date + ", место - " + ticket.place + "."); 

                i++;
            }
        }

        private void dateTicketListButton_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());

            textBox.Items.Clear();

            textBox.Items.Add("Билетов на " + date + " - " + Program.performance.SalesTickets(date));
        }

        private void AverageTicketButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            DateTime lastDate = Convert.ToDateTime(dateTimePicker3.Value.ToShortDateString());

            double colParterre, colBalcony, colLoggia;

            textBox.Items.Clear();

            Program.performance.GetAverageSales(firstDate, lastDate, out colParterre, out colLoggia, out colBalcony);

            textBox.Items.Add("Среднее число билетов в партер - " + colParterre + ", лоджию - " + colLoggia + ", балкон - " + colBalcony);
        }

        private void MinColTicketButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = Convert.ToDateTime(dateTimePicker2.Value.ToShortDateString());
            DateTime lastDate = Convert.ToDateTime(dateTimePicker3.Value.ToShortDateString());

            textBox.Items.Clear();

            DateTime date = Program.performance.GetMinSales(firstDate, lastDate);

            textBox.Items.Add("Минимальное кол-во билетов продано на дату - " + date.ToString());
        }

        private void List_Load(object sender, EventArgs e)
        {

        }
    }
}
