using System;
using System.Collections.Generic;
using VectorException;

namespace VectorLibrary
{
    public class Vector
    {
        /// <summary>
        /// Вычисление произведения скаляра k и вектора х.
        /// Возвращает вектор х.
        /// </summary>
        /// <param name="x">Вектор</param>
        /// <param name="k">Скаляр</param>
        /// <returns></returns>
        public static List<double> GetValue(List<double> x, double k)
        {
            for (int i = 0; i < x.Count; i++) x[i] *= k;
            return x;
        }
        /// <summary>
        /// Вычисляет скалярное произведение векторов х и у.
        /// Возвращает скаляр.
        /// </summary>
        /// <param name="x">Вектор</param>
        /// <param name="y">Вектор</param>
        /// <returns></returns>
        public static double GetScalarProduct(List<double> x, List<double> y)
        {
            if (x.Count != y.Count) throw new ScalarProductException();

            double sum = 0;
            for(int i = 0; i < x.Count; i++) sum += x[i] * y[i];
            return sum;
        }
        /// <summary>
        /// Вычисляет векторное произведение векторов х и у.
        /// Возвращает вектор z.
        /// </summary>
        /// <param name="x">Вектор</param>
        /// <param name="y">Вектор</param>
        /// <returns></returns>
        public static List<double> GetVectorProduct(List<double> x, List<double> y)
        {
            if (x.Count != y.Count) throw new VectorProductException();

            List<double> z = new List<double>(3) { 0, 0, 0 };
            z[0] = x[1] * y[2] - x[2] * y[1];
            z[1] = -1 * (x[0] * y[2] + x[2] * y[0]);
            z[2] = x[0] * y[1] - x[1] * y[0];
            return z;
        }
        /// <summary>
        /// Вычисляет смешанное произведение векторов x, y, z.
        /// Возвращает скаляр.
        /// </summary>
        /// <param name="x">Вектор</param>
        /// <param name="y">Вектор</param>
        /// <param name="z">Вектор</param>
        /// <returns></returns>
        public static double GetMixedProduct(List<double> x, List<double> y, List<double> z)
        {
            return GetScalarProduct(x, GetVectorProduct(y , z));
        }
    }
}
