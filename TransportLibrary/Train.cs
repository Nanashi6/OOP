using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class Train : ITransport
    {
        public int number;
        double[] prices;
        int vacancies;               
        public Train(TypeOfTransport transport, int number, string departure, string destination, params double[] prices)
        {
            this.number = number;
            this.prices = prices;
            Departure = departure;
            Destination = destination;
            Transport = transport;
            vacancies = 120;
        }

        double ITransport.this[string typeOfPlace]
        {
            get
            {
                switch (typeOfPlace)
                {
                    case "люкс":
                        return prices[0];
                    case "купейный":
                        return prices[1];
                    case "плацкартный":
                        return prices[2];
                    case "общий":
                        return prices[3];
                }
                return 0;
            }
        }

        public int Vacancies { get => vacancies; set => vacancies = value; }                // Как работать с массивом?  
        public string Departure { get; set; }
        public string Destination { get; set; }
        public TypeOfTransport Transport { get; set; }

        public string GetInformation()
        {
            return Transport.ToString() + " " + number + " По маршруту: " + Departure + " - " + Destination + " Имеет свободных мест: " + vacancies + "\n";
        }
    }
}
