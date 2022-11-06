using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibForLab6;

namespace TestPerformance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Performance performance = new Performance();

            performance.CreateTicket(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), 3, Place.Parterre);
            performance.CreateTicket(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), 2, Place.Balcony);
            performance.CreateTicket(Convert.ToDateTime(DateTime.Now.ToShortTimeString()).AddDays(1), 1, Place.Loggia);

            performance.RemoveTicket(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), 1, Place.Parterre);

            int trueValue = 4;
            int value = performance.SalesTickets(Convert.ToDateTime(DateTime.Now.ToShortTimeString()));

            Assert.AreEqual(value, trueValue);

            performance.ChangeTicket(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), 1, Place.Parterre, Convert.ToDateTime(DateTime.Now.ToShortTimeString()).AddDays(2), Place.Loggia);

            double trueLog = 2.0 / 3.0, trueBal = 2.0 / 3.0, truePar = 1.0 / 3.0;
            double bal, par, log;
            performance.GetAverageSales(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(DateTime.Now.ToShortTimeString()).AddDays(2), out par, out log, out bal);

            Assert.AreEqual(log, trueLog);
            Assert.AreEqual(bal, trueBal);
            Assert.AreEqual(par, truePar);

            DateTime trueDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString()).AddDays(1);
            DateTime date = performance.GetMinSales(Convert.ToDateTime(DateTime.Now.ToShortTimeString()), Convert.ToDateTime(DateTime.Now.ToShortTimeString()).AddDays(1));

            Assert.AreEqual(date, trueDate);
        }
    }
}
