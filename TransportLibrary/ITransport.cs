using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public interface ITransport
    {
        int Vacancies { get; set; }
        string Departure { get; set; }
        string Destination { get; set; }
        TypeOfTransport Transport { get; set; }
        string GetInformation();
        double this[string typeOfPlace]
        {
            get;
        }
    }
}
