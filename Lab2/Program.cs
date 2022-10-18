using LibForLab2;
using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> x = new List<double>() { 0, 0, 0 };
            List<double> y = new List<double>() { 0, 0, 0 };
            List<double> z = new List<double>() { 0, 0, 0 };

            List<double> vct = new List<double>(3);
            double k = 0;

            Vector vec = new Vector();

            int key = 0;
            while (key != 9)
            {
                Console.Write("1. Ввести вектор Х. Текущее значение: ");
                foreach (double a in x)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
                Console.Write("2. Ввести вектор У. Текущее значение: ");
                foreach (double a in y)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
                Console.Write("3. Ввести вектор Z. Текущее значение: ");
                foreach (double a in z)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
                Console.WriteLine("4. Ввести скаляр k. Текущее значение: " + k);
                Console.WriteLine("5. Найти векторное произведение Х и У");
                Console.WriteLine("6. Найти скалярное произведение Х и У");
                Console.WriteLine("7. Найти смешанное произведение Х, У и Z");
                Console.WriteLine("8. Умножить вектор Х на k");
                Console.WriteLine("9. Выход");

                key = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (key)
                {
                    case 1:
                        for (int i = 0; i < x.Count; i++)
                        {
                            x[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.Clear();
                        break;
                    case 2:
                        for (int i = 0; i < y.Count; i++)
                        {
                            y[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.Clear();
                        break;
                    case 3:
                        for (int i = 0; i < z.Count; i++)
                        {
                            z[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.Clear();
                        break;
                    case 4:
                        k = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 5:
                        vct = vec.GetVectorProduct(y, z);
                        Console.Write("Результат векторного произведения векторов x и y: ");
                        for (int i = 0; i < vct.Count; i++)
                        {
                            Console.Write(vct[i] + " ");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Скалярное произведение:" + vec.GetScalarProduct(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Смешанное произведение: " + vec.GetMixedProduct(x, y, z));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Write("Результат умножения вектора х на скаляр k: ");
                        x = vec.GetValue(x, k);
                        for (int i = 0; i < x.Count; i++)
                        {
                            Console.Write(x[i] + " ");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        
                        break;
                    default: break;
                }
            }
        }
    }
}
