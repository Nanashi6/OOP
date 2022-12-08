using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatOrders
{
    public class Room
    {
        public double area { get; private set; }
        public int amountOfWindow { get; private set; }
        public bool furniture { get; private set; }
        public double price { get; private set; } 

        public Room(double area, int amountOfWindow, bool furniture)
        {
            this.area = area;
            this.amountOfWindow = amountOfWindow;
            this.furniture = furniture;
        }

        public void SetPrice(int heigth)
        {
            price = heigth * area * 2 / 100;
        }
    }
}
