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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Order> orders = new List<Order>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new AddFlat();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new ChangeFlat();
        }
        /*
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new DeleteFlat();
        }
        */
        private void GetOrdersListButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new OrdersList();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
