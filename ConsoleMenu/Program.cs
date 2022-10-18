using LibForLab1;
using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] X = { 2, 2, -2, -2 };
            double[] Y = { 2, -2, -2, 2 };
            Console.WriteLine("Координаты углов квадрата (X, Y)");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(X[i] + " " + Y[i]);
            }
            Square sqr = new Square(X, Y);

            Console.WriteLine("P=" + sqr.GetPerimeter());
            Console.WriteLine("S=" + sqr.GetArea());
            Console.WriteLine("Point(0,0) is " + sqr.DoesPointBelong(0, 0));
            Console.WriteLine("Point(6, 2) is " + sqr.DoesPointBelong(6, 2));
            Console.WriteLine("Point(2, 0) is " + sqr.DoesPointBelong(2, 0));

            Console.WriteLine("Trying to create invalid square...");
            try
            {
                double[] A = { 1, 0, 1, 0 };
                double[] B = { 1, 0, 1, 0 };
                Console.WriteLine("Координаты углов квадрата (X, Y)");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(A[i] + " " + B[i]);
                }
                Square invalidSquare = new Square(A, B);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}