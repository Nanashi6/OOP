using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForLab7
{
    public class Room
    {
        public string Name;
        public double area;
        public double height;
        public double amountOfWindow;
        public bool furniture;

        public Room(string name, double area, double height, double amountOfWindow, bool furniture)
        {
            Name = name;
            this.area = area;
            this.height = height;
            this.amountOfWindow = amountOfWindow;
            this.furniture = furniture;
        }
    }
}
