using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Channels;
using TransportLibrary;

namespace TransportTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void PlaneTest()
        {
            ITransport plane = new Plane(TypeOfTransport.plane, 1597, "Berlin", "Paris", 200, 150, 100);
            Assert.AreEqual(plane["первый"], 100);
            Assert.AreEqual(plane["бизнес"], 150);
            Assert.AreEqual(plane["эконом"], 200);
        }
        [TestMethod]
        public void BusTest()
        {
            ITransport bus = new Bus(TypeOfTransport.bus, 7843, "Gomel", "Brest", 50, 25);
            Assert.AreEqual(bus.Departure, "Gomel");
            Assert.AreEqual(bus.Destination, "Brest");
        }
        [TestMethod]
        public void TrainTest()
        {
            ITransport train = new Train(TypeOfTransport.train, 15946, "Grodno", "Nankin", 200, 150, 100, 50);
            Assert.AreEqual(train.GetInformation(),
                "train 15946 По маршруту: Grodno - Nankin Имеет свободных мест: 120\n");
        }
    }
}
