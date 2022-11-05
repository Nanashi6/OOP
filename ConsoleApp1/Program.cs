using LibForLab6;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performance performance = new Performance();

            DateTime firstDate = DateTime.Now;
            DateTime lastDate = firstDate.AddDays(1);

            Performance.CreateTicket(firstDate, 2, Place.Loggia);
            Performance.CreateTicket(lastDate, 1, Place.Parterre);

            Console.WriteLine(Performance.GetMinSales(firstDate, lastDate.AddDays(1)));
        }
    }
}
