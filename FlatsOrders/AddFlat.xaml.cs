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
    /// Логика взаимодействия для AddFlat.xaml
    /// </summary>
    public partial class AddFlat : Page
    {
        int AmountOfRoom;

        Flat newFlat;
        List<Room> rooms = new List<Room>();
        Kitchen Kitchen;

        public AddFlat()
        {
            InitializeComponent();
        }
        
        private void AmounOfRoomTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //Frame.Content = new AddRoom();
            RoomGrid.Visibility = Visibility.Visible;
            NextRoomButton.Visibility = Visibility.Visible;
            AmountOfRoom = Convert.ToInt32(AmounOfRoomTextBox.Text) - 1;
        }

        private void NextRoomButton_Click(object sender, RoutedEventArgs e)
        {
            if(AmountOfRoom >= 0)
            {
                double area = Convert.ToDouble(RoomAreaTextBox.Text);
                int amountOfWindow = Convert.ToInt32(AmountOfWindowTextBox.Text);
                bool furniture = false;
                if (FurnitureTrue.IsChecked == true) furniture = true;

                Room room = new Room(area, amountOfWindow, furniture);
                rooms.Add(room);

                RoomAreaTextBox.Text = null;
                AmountOfWindowTextBox.Text = null;
            }

            AmountOfRoom--;
            if(AmountOfRoom == -1)
            {
                RoomGrid.Visibility = Visibility.Hidden;
                KitchenGrid.Visibility = Visibility.Visible;
                //Frame.Content = new AddKitchen();
            }
            else if (AmountOfRoom == -2)
            {
                //Frame.Content = null;
                KitchenGrid.Visibility = Visibility.Hidden;

                double area = Convert.ToDouble(KitchenareaTextBox.Text);
                int amountOfWindow = Convert.ToInt32(AmountOfWindowKitchenTExtBox.Text);
                TypeOfCooker cooker = TypeOfCooker.electricity;
                if(RadioGas.IsChecked == true)
                {
                    cooker = TypeOfCooker.gas;
                }
                Kitchen = new Kitchen(area, amountOfWindow, cooker);
                NextRoomButton.Visibility = Visibility.Hidden;
            }
        }
        
        private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            string name = OrderNameTextBox.Text;
            int amountOfRoom = Convert.ToInt32(AmounOfRoomTextBox.Text);
            int floor = Convert.ToInt32(FloorTextBox.Text);
            int heigth = Convert.ToInt32(HeightTextBox.Text);
            bool washMashine = false;
            if (RadioTrue.IsChecked == true) washMashine = true;


            newFlat = new Flat(amountOfRoom, floor, washMashine, heigth);
            newFlat.SetKitchen(Kitchen);
            foreach(Room room in rooms)
            {
                newFlat.SetRoom(room);
            }
            Order order = new Order(name, newFlat);
            MainWindow.orders.Add(order);
        }
    }
}
