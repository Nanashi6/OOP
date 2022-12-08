using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForLab7
{
    public class Kitchen : Room
    {
        TypeOfCooker cooker;
        public Kitchen(string name, double area, double height, double amountOfWindow, bool furniture, TypeOfCooker cooker ) : base(name, area, height, amountOfWindow, furniture)
        {
            this.Name = name;
            this.area = area;
            this.height = height;
            this.amountOfWindow = amountOfWindow;
            this.furniture = furniture;
            this.cooker = cooker;
        }
    }
}
