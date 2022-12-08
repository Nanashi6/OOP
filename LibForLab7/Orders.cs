using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForLab7
{
    public class Orders
    {
        private List<string> ordersName;
        private List<Flat> flats = new List<Flat>();

        public void Add(Flat flat, string orderName)
        {
            this.ordersName.Add(orderName);
            this.flats.Add(flat);
        }

        public void Delete(string orderName)
        {
            int i = 0;
            foreach(string name in this.ordersName)
            {
                if(name == orderName)
                {
                    break;
                }
                i++;
            }

            this.ordersName.Remove(orderName);
            this.flats.Remove(this.flats[i]);
        }

        public List<string> GetOrdersNames()
        {
            return ordersName;
        }
    }
}
