using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using VectorException;
using VectorLibrary;

namespace VectorExceptionTest
{
    [TestClass]
    public class VectorExceptionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ScalarProductException))]
        public void ScalarProductException()
        {
            double[] a = { 1, 2 };
            double[] b = { 3, 4, 5 };
            Vector.GetScalarProduct(a.ToList(), b.ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(VectorProductException))]
        public void VectorProductException()
        {
            double[] a = { 1, 2 };
            double[] b = { 3, 4, 5 };
            Vector.GetVectorProduct(a.ToList(), b.ToList());
        }
    }
}
