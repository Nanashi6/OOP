using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibForLab1;
using System;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] X = { 1, 1, 0, 0 };
            double[] Y = { 1, 0, 0, 1 };
            Square sqr = new Square(X, Y);

            double P = 4, S = 1;

            Assert.AreEqual(sqr.GetPerimeter(), P);
            Assert.AreEqual(sqr.GetArea(), S);
            Assert.AreEqual(sqr.DoesPointBelong(0.5, 0.5), Square.Belonging.In);
            Assert.AreEqual(sqr.DoesPointBelong(1, 0.5), Square.Belonging.OnBorder);
            Assert.AreEqual(sqr.DoesPointBelong(0, 5), Square.Belonging.Out);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[] X = { 1, 0, 1, 2 };
            double[] Y = { 1, 0, -1, 0 };
            Square sqr = new Square(X, Y);

            double P = Math.Sqrt(2) * 4, S = 2;

            Assert.AreEqual(sqr.GetPerimeter(), P);
            Assert.AreEqual(sqr.GetArea(), S);
            Assert.AreEqual(sqr.DoesPointBelong(1, 0), Square.Belonging.In);
            Assert.AreEqual(sqr.DoesPointBelong(0.5, 0.5), Square.Belonging.OnBorder);
            Assert.AreEqual(sqr.DoesPointBelong(2, -3), Square.Belonging.Out);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Cannot create the square with initial values")]
        public void TestMethod3()
        {
            double[] X = { 1, 0, 1, 0 };
            double[] Y = { 1, 0, 1, 0 };
            Square sqr = new Square(X, Y);
        }
    }
}
