using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatOrders
{
    public class Order
    {
        public string name { get; set; }
        public double price { get; private set; }
        public Flat flat { get; private set; }

        public Order(string name, Flat flat)
        {
            this.name = name;
            this.flat = flat;
            price = GetPrice();
        }

        private double GetPrice()
        {
            return (flat.amountOfRoom + 1) * 20 + 10 * flat.floor; // Как считать?
        }

        public void SetFlat(Flat flat)
        {
            this.flat = flat;
            GetPrice();
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
