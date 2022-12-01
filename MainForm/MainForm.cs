using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportLibrary;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITransport transport;
            StreamReader sr = new StreamReader(Program.path);
            string line = sr.ReadLine();
            List<string> strings;

            while (line != null)
            {
                strings = line.Split(' ').ToList();
                switch (strings[0])
                {
                    case "самолет": 
                        transport = new Plane(TypeOfTransport.plane, Convert.ToInt32(strings[1]), strings[2], strings[3], 
                                                            Convert.ToInt32(strings[4]), Convert.ToInt32(strings[5]), Convert.ToInt32(strings[5]));
                        Program.transports.Add(transport);
                        break;
                    case "автобус":
                        transport = new Bus(TypeOfTransport.bus, Convert.ToInt32(strings[1]), strings[2], strings[3],
                                                            Convert.ToInt32(strings[4]), Convert.ToInt32(strings[5]));
                        Program.transports.Add(transport);
                        break;
                    case "поезд": 
                        transport = new Train(TypeOfTransport.train, Convert.ToInt32(strings[1]), strings[2], strings[3],
                                                            Convert.ToInt32(strings[4]), Convert.ToInt32(strings[5]), Convert.ToInt32(strings[5]), Convert.ToInt32(strings[6]));
                        Program.transports.Add(transport);
                        break;
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void CheckTransportButton_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            BuyTicket.Visible = false;
            AdventureList.Visible = false;
            TicketTypeList.Visible = false;
            TransportList.Visible = false;
            TypeList.Visible = false;
            TransportTypeLabel.Visible = true;
            TypeOfTransportComboBox.Visible = true;
            ChooseTypeTicketComboBox.Visible = true;
            ChooseTypeTicketLabel.Visible = true;
            ChooseLabel.Visible = true;
            AdventureComboBox.Visible = true;
            FindTicketButton.Visible = true;
        }

        private void TypeOfTransportComboBox_Leave(object sender, EventArgs e)
        {
            ChooseTypeTicketComboBox.Items.Clear();
            AdventureComboBox.Items.Clear();
            foreach (ITransport transport in Program.transports)
            {
                if (TypeOfTransportComboBox.Text == transport.Transport.ToString()) AdventureComboBox.Items.Add(transport.Departure + " - " + transport.Destination);
            }

            switch (TypeOfTransportComboBox.Text)
            {
                case "train":
                    ChooseTypeTicketComboBox.Items.Add("люкс");
                    ChooseTypeTicketComboBox.Items.Add("купейный");
                    ChooseTypeTicketComboBox.Items.Add("плацкартный");
                    ChooseTypeTicketComboBox.Items.Add("общий");
                    break;
                case "plane":
                    ChooseTypeTicketComboBox.Items.Add("эконом");
                    ChooseTypeTicketComboBox.Items.Add("бизнес");
                    ChooseTypeTicketComboBox.Items.Add("первый");
                    break;
                case "bus":
                    ChooseTypeTicketComboBox.Items.Add("мягкий");
                    ChooseTypeTicketComboBox.Items.Add("жесткий");
                    break;
            }
        }

        private void FindTicketButton_Click(object sender, EventArgs e)
        {
            TextPriceLabel.Visible = true;
            PriceLabel.Visible = true;
            foreach (ITransport transport in Program.transports)
            {
                if (TypeOfTransportComboBox.Text == transport.Transport.ToString() && transport.Departure + " - " + transport.Destination == AdventureComboBox.Text)
                {
                    PriceLabel.Text = " " + transport[ChooseTypeTicketComboBox.Text] + " рублей";
                }
            }
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            AdventureList.Visible = true;
            TicketTypeList.Visible = true;
            TransportList.Visible = true;
            BuyTicket.Visible = true;
            TypeList.Visible = true;
            textBox1.Visible = true;
            TransportTypeLabel.Visible = false;
            TypeOfTransportComboBox.Visible = false;
            ChooseTypeTicketComboBox.Visible = false;
            ChooseTypeTicketLabel.Visible = false;
            ChooseLabel.Visible = false;
            AdventureComboBox.Visible = false;
            FindTicketButton.Visible = false;

            TransportList.Clear();
            foreach(ITransport transport in Program.transports)
            {
                TransportList.Text += transport.GetInformation();
            }

        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            int amountTicket = Convert.ToInt32(textBox1.Text);

            foreach(ITransport transport in Program.transports)
            {
                if(transport.Transport.ToString() == TypeList.Text && 
                    transport.Departure + " - " + transport.Destination == AdventureList.Text && 
                    transport.Vacancies >= amountTicket)
                {
                    transport.Vacancies -= amountTicket;
                }
            }

            TransportList.Clear();
            foreach (ITransport transport in Program.transports)
            {
                TransportList.Text += transport.GetInformation();
            }
        }

        private void TypeList_Leave(object sender, EventArgs e)
        {
            TicketTypeList.Items.Clear();
            AdventureList.Items.Clear();
            foreach (ITransport transport in Program.transports)
            {
                if (TypeList.Text == transport.Transport.ToString()) AdventureList.Items.Add(transport.Departure + " - " + transport.Destination);
            }

            switch (TypeList.Text)
            {
                case "train":
                    TicketTypeList.Items.Add("люкс");
                    TicketTypeList.Items.Add("купейный");
                    TicketTypeList.Items.Add("плацкартный");
                    TicketTypeList.Items.Add("общий");
                    break;
                case "plane":
                    TicketTypeList.Items.Add("эконом");
                    TicketTypeList.Items.Add("бизнес");
                    TicketTypeList.Items.Add("первый");
                    break;
                case "bus":
                    TicketTypeList.Items.Add("мягкий");
                    TicketTypeList.Items.Add("жесткий");
                    break;
            }


        }
    }
}
