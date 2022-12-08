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
    /// Логика взаимодействия для ChangeFlat.xaml
    /// </summary>
    public partial class ChangeFlat : Page
    {
        public ChangeFlat()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Order order in MainWindow.orders)
            {
                ChangeFlatComboBox.Items.Add(order.name);
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Order order in MainWindow.orders)
            {
                if (order.name == ChangeFlatComboBox.SelectedItem.ToString())
                {
                    OrderNameTextBox.Text = order.name;
                    FloorTextBox.Text = order.flat.floor.ToString();
                    if (order.flat.washMachine == false)
                    {
                        RadioFalse.IsChecked = true;
                    }
                    HeightTextBox.Text = order.flat.height.ToString();
                }
            }
        }

        private void ChangeFlatComboBox_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Order order in MainWindow.orders)
            {
                if (order.name == ChangeFlatComboBox.SelectedItem.ToString())
                {
                    order.SetName(OrderNameTextBox.Text);
                    order.flat.SetFlat(int.Parse(FloorTextBox.Text), (bool)RadioTrue.IsChecked, int.Parse(HeightTextBox.Text));
                }
            }
        }
    }
}
