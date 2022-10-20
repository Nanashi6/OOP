using System;

namespace LibForLab3
{
    public class Matrix
    {
        public static int amountOfString;
        public int AmountOfString
        {
            get { return amountOfString; }
            private set
            {
                if (value < 1) Console.WriteLine("Кол-во строк должно быть больше нуля");
                else amountOfString = value;
            }
        }
        public static int amountOfCollumn;
        public int AmountOfCollumn
        {
            get { return amountOfCollumn; }
            private set
            {
                if (value < 1) Console.WriteLine("Кол-во столбцов должно быть больше нуля");
                else amountOfCollumn = value;
            }
        }
        public double[,] a { get; /*private*/ set; }
        public Matrix(int x, int y)
        {
            amountOfString = x;
            amountOfCollumn = y;
            a = new double[x, y];
        }
        public Matrix(double[,] x)
        {
            a = x;
        }
        //Индексатор
        public double this[int indexRow, int indexCol]
        {
            get => a[indexRow, indexCol];
            set => a[indexRow, indexCol] = value;
        }
        public void SetMatrix(double[,] x)
        {
            a = x;

        }
        public double[,] GetMatrix()
        {
            return a;
        }
        /// <summary>
        /// Находит сумму квадратов элеменнтов больших value
        /// </summary>
        /// <param name="value">некоторое число</param>
        /// <returns></returns>
        public double GetValue(double value)
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > value) sum += Math.Pow(a[i, j], 2);
                }
            }
            return sum;
        }
        /// <summary>
        /// Находит сумму квадратов элементов, стоящих после заданной позиции
        /// </summary>
        /// <param name="numberOfString">Строка</param>
        /// <param name="numberOfCollums">Столбец</param>
        /// <returns></returns>
        public double GetValue(int numberOfString, int numberOfCollums)
        {
            double sum = 0;
            int k = 0;
            for (int i = numberOfString; i < a.GetLength(0); i++)
            {
                if (k == 0)
                {
                    for (int j = numberOfCollums + 1; j < a.GetLength(1); j++)
                    {
                        sum += Math.Pow(a[i, j], 2);
                    }
                    k++;
                }
                else
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum += Math.Pow(a[i, j], 2);
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// Возвращает произведение двух матриц (если матрицы можно перемножить)
        /// </summary>
        /// <param name="x">Матрица</param>
        /// <param name="y">Матрица</param>
        /// <returns>Матрица</returns>
        /*Выбрасывать исключение*/
        public static double[,] GetScalarProduct(Matrix x, Matrix y)
        {
            double[,] z = new double[x.a.GetLength(0), y.a.GetLength(1)];
            
            if (x.a.GetLength(1) != y.a.GetLength(0)) throw new Exception("Матрицы не могут быть перемножены");
            else
            {
                for (int i = 0; i < x.a.GetLength(0); i++)
                {
                    for (int j = 0; j < y.a.GetLength(1); j++)
                    {
                        z[i, j] = 0;
                    }
                }

                for (int i = 0; i < x.a.GetLength(0); i++)
                {
                    for (int j = 0; j < y.a.GetLength(1); j++)
                    {
                        for (int k = 0; k < y.a.GetLength(0); k++)
                        {
                            z[i, j] += x[i, k] * y[k, j];
                        }
                    }
                }
            }
            return z;
        }

        // Перегрузка оператора ==
        public static bool operator == (Matrix a, Matrix b)
        {
            if (a.a.GetLength(0) != b.a.GetLength(0)) return false;
            if (a.a.GetLength(1) != b.a.GetLength(1)) return false;

            for (int i = 0; i < a.a.GetLength(0); i++)
            {
                for (int j = 0; j < b.a.GetLength(1); j++)
                {
                    if (a.a[i, j] != b.a[i, j]) return false;
                }
            }

            return true;
        }
        // Перегрузка оператора  !=
        public static bool operator != (Matrix a, Matrix b)
        {
            if (a.a.GetLength(0) != b.a.GetLength(0)) return true;
            if (a.a.GetLength(1) != b.a.GetLength(1)) return true;

            for (int i = 0; i < a.a.GetLength(0); i++)
            {
                for (int j = 0; j < a.a.GetLength(1); j++)
                {
                    if (a.a[i, j] != b.a[i, j]) return true;
                }
            }

            return false;
        }
        //Перегрузка метода Object.Equals
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Matrix)) throw new Exception("Получаемый объект не может быть приведён к типу Matrix");
            {
                Matrix b = (Matrix)obj;

                if (a.GetLength(0) != b.a.GetLength(0)) return false;
                if (a.GetLength(1) != b.a.GetLength(1)) return false;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < b.a.GetLength(1); j++)
                    {
                        if (a[i, j] != b.a[i, j]) return false;
                    }
                }
                return true;
            }

            return false;
        }
    }
}
