using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class Plane : ITransport
    {
        int vacancies;
        public int number;
        public double[] prices;
        public Plane( TypeOfTransport transport, int number, string departure, string destination,  params double[] prices)
        {
            this.number = number;
            this.prices = prices;
            Departure = departure;
            Destination = destination;
            Transport = transport;
            vacancies = 250;
        }

        public double this[string typeOfPlace] 
        {
            get
            {
                switch (typeOfPlace)
                {
                    case "эконом":
                        return prices[0];
                    case "бизнес":
                        return prices[1];
                    case "первый":
                        return prices[2];
                }
                return 0;
            } 
        }

        public int Vacancies { get => vacancies; set => vacancies = value; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public TypeOfTransport Transport { get; set; }

        public string GetInformation()
        {
            return Transport.ToString() + " " + number + " По маршруту: " + Departure + " - " + Destination + " Имеет свободных мест: " + vacancies + "\n";
        }
    }
}
