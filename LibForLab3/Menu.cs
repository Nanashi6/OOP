using System;
using System.Security.Cryptography.X509Certificates;

namespace LibForLab3
{
    public class Menu
    {
        Matrix a;
        Matrix b;
        Matrix c;

        private void GetMatrix()
        {
            int strings;
            int collums;
            int key = 1;
            while (key != 4)
            {
                Console.WriteLine("Введите кол-во строк");
                strings = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов");
                collums = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        a = new Matrix(strings, collums);
                        break;
                    case 2:
                        b = new Matrix(strings, collums);
                        break;
                    case 3:
                        c = new Matrix(strings, collums);
                        break;
                }
                key++;
            }

        }
        public void menu()
        {
            GetMatrix();
            int key = 0;
            while (key != 7)
            {
                Console.Clear();
                Console.WriteLine("1. Ввести матрицу");
                Console.WriteLine("2. Вывести матрицу");
                Console.WriteLine("3. Dывести сумму квадратов элементов матрицы, больших заданного числа");
                Console.WriteLine("4. Dывести сумму квадратов элементов матрицы, стоящих после заданного элемента");
                Console.WriteLine("5. Найти скалярное произведение двух матриц");
                Console.WriteLine("6. Сравнить две матрицы");


                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        double[,] x = SetMatrix();
                        switch (ChooseMatrix())
                        {
                            case 1:
                                a.SetMatrix(x);
                                break;
                            case 2:
                                b.SetMatrix(x);
                                break;
                            case 3:
                                c.SetMatrix(x);
                                break;
                        }
                        break;
                    case 2:
                        double[,] y = { { 1 },{ 1 } };
                        switch (ChooseMatrix())
                        {
                            case 1:
                                y = a.GetMatrix();
                                break;
                            case 2:
                                y = b.GetMatrix();
                                break;
                            case 3:
                                y = c.GetMatrix();
                                break;
                        }
                        GetMatrix(y);
                        break;
                    case 3:
                        Console.WriteLine("Введите число");
                        double value = Convert.ToDouble(Console.ReadLine());
                        double sum = 0;
                        switch (ChooseMatrix())
                        {
                            case 1:
                                sum = a.GetValue(value);
                                break;
                            case 2:
                                sum = b.GetValue(value);
                                break;
                            case 3:
                                sum = c.GetValue(value);
                                break;
                        }
                        Console.WriteLine("Сумма квадратов элементов матрицы, больших заданного числа " + value + " равна " + sum);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Введите число");
                        int i = Convert.ToInt32(Console.ReadLine());
                        int j = Convert.ToInt32(Console.ReadLine());
                        double sum1 = 0;
                        switch (ChooseMatrix())
                        {
                            case 1:
                                sum1 = a.GetValue(i - 1, j - 1);
                                break;
                            case 2:
                                sum1 = b.GetValue(i - 1, j - 1);
                                break;
                            case 3:
                                sum1 = c.GetValue(i - 1, j - 1);
                                break;
                        }
                        Console.WriteLine("Сумма квадратов элементов матрицы, стоящих после заданного элемента равна " + sum1);
                        Console.ReadLine();
                        break;
                    case 5:
                        double[,] z;
                        try
                        {
                            z = Matrix.GetScalarProduct(ChsMtrx(), ChsMtrx());
                            Console.WriteLine("Результат перемножения: ");
                            for (i = 0; i < z.GetLength(0); i++)
                            {
                                for (j = 0; j < z.GetLength(1); j++)
                                {
                                    Console.Write(z[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        if (ChsMtrx() == ChsMtrx())
                        {
                            Console.WriteLine("Матрицы равны");
                        }
                        else
                        {
                            Console.WriteLine("Матрицы не равны");
                        }
                        Console.ReadLine();
                        break;
                    default: Console.WriteLine("Нет такого варианта"); break;
                }
            }
        }

        public int ChooseMatrix()
        {
            int key = 0;
            while (key != 3 || key != 2 || key != 1)
            {
                Console.Clear();
                Console.WriteLine("1. Матрицу А");
                Console.WriteLine("2. Матрицу B");
                Console.WriteLine("3. Матрицу C");

                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    case 3:
                        return 3;
                    default: Console.WriteLine("Нет такого варианта"); break;
                }
            }
            return 0;
        }

        private Matrix ChsMtrx()
        {
            int key = 0;
            while (key != 3 || key != 2 || key != 1)
            {
                Console.Clear();
                Console.WriteLine("1. Матрицу А");
                Console.WriteLine("2. Матрицу B");
                Console.WriteLine("3. Матрицу C");

                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        return a;
                    case 2:
                        return b;
                    case 3:
                        return c;
                    default: Console.WriteLine("Нет такого варианта"); break;
                }
            }
            return a;
        }
        private double[,] SetMatrix()
        {
            Console.WriteLine("Кол-во строк: ");
            int amountOfString = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во столбцов: ");
            int amountOfCollumn = Convert.ToInt32(Console.ReadLine());
            double[,] x = new double[amountOfString, amountOfCollumn];

            Console.WriteLine("Ввод матрицы: ");
            for (int i = 0; i < amountOfString; i++)
            {
                for (int j = 0; j < amountOfCollumn; j++)
                {
                    x[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            return x;
        }
        private void GetMatrix(double[,] x)
        {
            Console.WriteLine("Вывод матрицы: ");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(" {0:F2}", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
