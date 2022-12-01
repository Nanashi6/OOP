using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public abstract class GroundTransportation        // Не наследует интерфейс т.к. C# 7.3
    {
        public int this[string typeOfPlace] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int vacancies;
        public string departure;
        public string destination;
        public TypeOfTransport transport;
        public int number;
        public double[] prices;

        public GroundTransportation(TypeOfTransport transport, int number, string departure, string destination, params double[] prices)
        {
            this.destination = destination;
            this.departure = departure;
            this.prices = prices;
            this.number = number;
            this.transport = transport;
        }
    }
}
