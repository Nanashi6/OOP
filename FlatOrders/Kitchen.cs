using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatOrders
{
    public class Kitchen : Room
    {
        public TypeOfCooker cooker { get; private set; }
        public Kitchen(double area, int amountOfWindow, TypeOfCooker cooker, bool furniture = false) : base(area, amountOfWindow, furniture)
        {
            this.cooker = cooker;
        }
    }
}
