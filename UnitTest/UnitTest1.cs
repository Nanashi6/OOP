using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibForLab3;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] x = { { 1, 1, 1}, { 1, 1, 1}, { 1, 1, 1} };
            double[,] y = { { 1, 1, 1}, { 1, 1, 1}, { 1, 1, 1} };

            double[,] trueZ = { { 3, 3, 3 }, { 3, 3, 3 }, { 3, 3, 3 } };

            Matrix a = new Matrix(3,3);
            Matrix b = new Matrix(3,3);

            a.a = x;
            b.a = y;

            double[,] z = Matrix.GetScalarProduct(a, a);

            Matrix c = new Matrix(3,3);

            c.a = z;

            double trueSum1 = 0;
            double sum1 = c.GetValue(4, 4);
            
            double trueSum2 = 81;
            double sum2 = c.GetValue(1);
            
            bool equalsMat = true;
            bool eqMat = (a == b)? true:false;
            
            for(int i = 0; i < z.GetLength(0); i++)
            {
                for(int j = 0; j < z.GetLength(1); j++)
                {

                    Assert.AreEqual(z[i,j], trueZ[i,j]);
                }
            }
            Assert.AreEqual(sum1, trueSum1);
            Assert.AreEqual(sum2, trueSum2);
            Assert.AreEqual(eqMat, equalsMat);
        }
    }
}
