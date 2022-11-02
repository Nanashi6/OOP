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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            payTicket eventIcon = new payTicket();
            eventIcon.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeTicket eventIcon = new changeTicket();
            eventIcon.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteTicket eventIcon = new deleteTicket();
            eventIcon.Show();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List eventIcon = new List();
            eventIcon.Show();
        }
    }
}
