using FlatOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlatsOrders
{
    /// <summary>
    /// Логика взаимодействия для OrdersList.xaml
    /// </summary>
    public partial class OrdersList : Page
    {
        public OrdersList()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FiltersComboBox.Items.Add("1");
            FiltersComboBox.Items.Add("2");
            FiltersComboBox.Items.Add("3");
            FiltersComboBox.Items.Add("4");
            FiltersComboBox.Items.Add("5");
            FiltersComboBox.Items.Add("Электроплита");
        }

        private void FiltersComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            OrdersComboBox.Items.Clear();
            switch (FiltersComboBox.Text)
            {
                case "1":
                    foreach (Order order in MainWindow.orders)
                    {
                        if (1 == order.flat.amountOfRoom) OrdersComboBox.Items.Add(order.name);
                    }
                    break;
                case "2":
                    foreach (Order order in MainWindow.orders)
                    {
                        if (2 == order.flat.amountOfRoom) OrdersComboBox.Items.Add(order.name);
                    }
                    break;
                case "3":
                    foreach (Order order in MainWindow.orders)
                    {
                        if (3 == order.flat.amountOfRoom) OrdersComboBox.Items.Add(order.name);
                    }
                    break;
                case "4":
                    foreach (Order order in MainWindow.orders)
                    {
                        if (4 == order.flat.amountOfRoom) OrdersComboBox.Items.Add(order.name);
                    }
                    break;
                case "5":
                    foreach (Order order in MainWindow.orders)
                    {
                        if (5 == order.flat.amountOfRoom) OrdersComboBox.Items.Add(order.name);
                    }
                    break;
                case "Электроплита":
                    foreach (Order order in MainWindow.orders)
                    {
                        if (TypeOfCooker.electricity == order.flat.kitchen.cooker) OrdersComboBox.Items.Add(order.name);
                    }
                    break;
            }
        }

        private void OrdersComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            foreach(Order order in MainWindow.orders)
            {
                if(OrdersComboBox.Text == order.name)
                {
                    NameLabel.Content = order.name;
                    AmountOfRoomsLabel.Content = order.flat.amountOfRoom;
                    AveragePriceLabel.Content = order.price / order.flat.area;
                    CookerLabel.Content = order.flat.kitchen.cooker.ToString();
                    break;
                }
            }
        }
    }
}
