using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibForLab2;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test1()
        {
            double[] x = { 1, 2, 3 };
            double[] y = { 1, 2, 3 };
            double[] z = new double[3];

            double[] Z = { 0, 0, 0 };
            double TrueSclrPrdct = 14;
            double TrueMxdPrdct = 0;
            double[] X = { 2, 4, 6};
            Vector vec = new Vector();

            int k = 2;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test2()
        {
            double[] x = { 1, 7, 3 };
            double[] y = { 2, 2, 8 };
            double[] z = new double[3];

            double[] Z = { 50, -2, -12 };
            double TrueSclrPrdct = 40;
            double TrueMxdPrdct = 2648;
            double[] X = { 5, 35, 15 };
            Vector vec = new Vector();

            int k = 5;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test3()
        {
            double[] x = { 6, 2, 4 };
            double[] y = { 3, 5, 2 };
            double[] z = new double[3];

            double[] Z = { -16, 0, 24 };
            double TrueSclrPrdct = 36;
            double TrueMxdPrdct = 832;
            double[] X = { 6, 2, 4 };
            Vector vec = new Vector();

            int k = 1;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test4()
        {
            double[] x = { 0, 2, 3 };
            double[] y = { 1, 0, 0 };
            double[] z = new double[3];

            double[] Z = { 0, 3, -2 };
            double TrueSclrPrdct = 0;
            double TrueMxdPrdct = 13;
            double[] X = { 0, 0, 0 };
            Vector vec = new Vector();

            int k = 0;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test5()
        {
            double[] x = { -5, -2, 3 };
            double[] y = { -1, 2, -3 };
            double[] z = new double[3];

            double[] Z = { 0, -18, -12 };
            double TrueSclrPrdct = -8;
            double TrueMxdPrdct = 468;
            double[] X = { -10, -4, 6 };
            Vector vec = new Vector();

            int k = 2;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test6()
        {
            double[] x = { 1, 0, 0 };
            double[] y = { 0, 2, 0 };
            double[] z = new double[3];

            double[] Z = { 0, 0, 2 };
            double TrueSclrPrdct = 0;
            double TrueMxdPrdct = 4;
            double[] X = { 3, 0, 0 };
            Vector vec = new Vector();

            int k = 3;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test7()
        {
            double[] x = { 4, 5, 6 };
            double[] y = { 5, 2, 5 };
            double[] z = new double[3];

            double[] Z = { 13, 10, -17 };
            double TrueSclrPrdct = 60;
            double TrueMxdPrdct = 558;
            double[] X = { 16, 20, 24 };
            Vector vec = new Vector();

            int k = 4;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test8()
        {
            double[] x = { 9, 3, 2 };
            double[] y = { 2, 0, 3 };
            double[] z = new double[3];

            double[] Z = { 9, -23, -6 };
            double TrueSclrPrdct = 24;
            double TrueMxdPrdct = 646;
            double[] X = { 54, 18, 12 };
            Vector vec = new Vector();

            int k = 6;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test9()
        {
            double[] x = { 1, 7, 1 };
            double[] y = { 6, 2, 4 };
            double[] z = new double[3];

            double[] Z = { 26, 2, -40 };
            double TrueSclrPrdct = 24;
            double TrueMxdPrdct = 2280;
            double[] X = { 7, 49, 7 };
            Vector vec = new Vector();

            int k = 7;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test10()
        {
            double[] x = { 8, 6, 5 };
            double[] y = { 9, 1, 3 };
            double[] z = new double[3];

            double[] Z = { 13, 21, -46 };
            double TrueSclrPrdct = 93;
            double TrueMxdPrdct = 2726;
            double[] X = { 64, 48, 40 };
            Vector vec = new Vector();

            int k = 8;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test11()
        {
            double[] x = { 1, 3, 3 };
            double[] y = { 4, 4, 3 };
            double[] z = new double[3];

            double[] Z = { -3, 9, -8 };
            double TrueSclrPrdct = 25;
            double TrueMxdPrdct = 154;
            double[] X = { 9, 27, 27 };
            Vector vec = new Vector();

            int k = 9;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test12()
        {
            double[] x = { 1, 6, 3 };
            double[] y = { 2, 8, 3 };
            double[] z = new double[3];

            double[] Z = { -6, 3, -4 };
            double TrueSclrPrdct = 59;
            double TrueMxdPrdct = 61;
            double[] X = { 10, 60, 30 };
            Vector vec = new Vector();

            int k = 10;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test13()
        {
            double[] x = { 8, 3, 12 };
            double[] y = { 11, 29, 3 };
            double[] z = new double[3];

            double[] Z = { -339, 108, 199 };
            double TrueSclrPrdct = 211;
            double TrueMxdPrdct = 166186;
            double[] X = { 88, 33, 132 };
            Vector vec = new Vector();

            int k = 11;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test14()
        {
            double[] x = { 0, 0, 0 };
            double[] y = { 0, 0, 0 };
            double[] z = new double[3];

            double[] Z = { 0, 0, 0 };
            double TrueSclrPrdct = 0;
            double TrueMxdPrdct = 0;
            double[] X = { 0, 0, 0 };
            Vector vec = new Vector();

            int k = -2;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }
        [TestMethod]
        public void Test15()
        {
            double[] x = { 0, 1, 0 };
            double[] y = { 1, 0, -1 };
            double[] z = new double[3];

            double[] Z = { -1, 0, -1 };
            double TrueSclrPrdct = 0;
            double TrueMxdPrdct = 2;
            double[] X = { 0, 2.5, 0 };
            Vector vec = new Vector();

            double k = 2.5;

            z = vec.GetVectorProduct(x, y);
            double sclrPrdct = vec.GetScalarProduct(x, y);
            double mxdPrdct = vec.GetMixedProduct(x, y, z);
            x = vec.GetValue(x, k);

            Assert.AreEqual(z[0], Z[0]);
            Assert.AreEqual(z[1], Z[1]);
            Assert.AreEqual(z[2], Z[2]);
            Assert.AreEqual(sclrPrdct, TrueSclrPrdct);
            Assert.AreEqual(mxdPrdct, TrueMxdPrdct);
            Assert.AreEqual(x[0], X[0]);
            Assert.AreEqual(x[1], X[1]);
            Assert.AreEqual(x[2], X[2]);
        }        
    }
}
