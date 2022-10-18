using System;

namespace LibForLab1
{
    public class Square
    {
        public enum Belonging
        {
            Out,
            In,
            OnBorder
        }
        public double[] X { get; private set; }
        public double[] Y { get; private set; }
        public Square(double[] x, double[] y)
        {
            X = x;
            Y = y;
            if (!DoesExist()) throw new ArgumentException("Cannot create the square with initial values");
        }
        /// <summary>
        /// Метод вычисляет и возвращает значение периметра квадрата.
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return 4 * Math.Sqrt(Math.Abs(X[0] - X[1]) * Math.Abs(X[0] - X[1]) + Math.Abs(Y[0] - Y[1]) * Math.Abs(Y[0] - Y[1]));
        }
        /// <summary>
        /// Метод вычисляет и возвращает значение площади квадратаю
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.Abs(X[0] - X[1]) * Math.Abs(X[0] - X[1]) + Math.Abs(Y[0] - Y[1]) * Math.Abs(Y[0] - Y[1]);
        }
        /// <summary>
        /// Метод принимает координаты точки и определяет является ли она частью квадрата. 
        /// Определение происходит с помощью определения площадей треугольников, которые точка
        /// образует с углами квадрата.
        /// Переменная Sum хранит значение площади.
        /// </summary>
        /// <param name="x"> Координата точки по оси абсцисс </param>
        /// <param name="y"> Координата точки по оси ординат </param>
        /// <returns></returns>
        public Belonging DoesPointBelong(double x, double y)
        {
            double Sum = 0;
            for (int i = 0; i < 4; i++)
            {
                if (x == X[i] && y == Y[i]) continue;
                if (i < 3)
                {
                    Sum += 0.5 * Math.Sqrt(Math.Pow((X[i] - X[i + 1]), 2) + Math.Pow((Y[i] - Y[i + 1]), 2)) *
                        Math.Sqrt(Math.Pow((X[i] - x), 2) + Math.Pow((Y[i] - y), 2)) *
                        Math.Sin(Math.Acos(((X[i] - X[i + 1]) * (X[i] - x) + (Y[i] - Y[i + 1]) * (Y[i] - y)) /
                        (Math.Sqrt(Math.Pow((X[i] - X[i + 1]), 2) + Math.Pow((Y[i] - Y[i + 1]), 2)) *
                        Math.Sqrt(Math.Pow((X[i] - x), 2) + Math.Pow((Y[i] - y), 2)))));
                }
                else
                {
                    Sum += 0.5 * Math.Sqrt(Math.Pow((X[i] - X[0]), 2) + Math.Pow((Y[i] - Y[0]), 2)) *
                        Math.Sqrt(Math.Pow((X[i] - x), 2) + Math.Pow((Y[i] - y), 2)) *
                        Math.Sin(Math.Acos(((X[i] - X[0]) * (X[i] - x) + (Y[i] - Y[0]) * (Y[i] - y)) /
                        (Math.Sqrt(Math.Pow((X[i] - X[0]), 2) + Math.Pow((Y[i] - Y[0]), 2)) *
                        Math.Sqrt(Math.Pow((X[i] - x), 2) + Math.Pow((Y[i] - y), 2)))));
                }
            }
            if (Math.Round(Sum) > Math.Round(GetArea()))
            {
                return Belonging.Out;
            }
            if ((x - X[0]) * (Y[1] - Y[0]) - (y - Y[0]) * (X[1] - X[0]) == 0 ||
                (x - X[1]) * (Y[2] - Y[1]) - (y - Y[1]) * (X[2] - X[1]) == 0 ||
                (x - X[2]) * (Y[3] - Y[2]) - (y - Y[2]) * (X[3] - X[2]) == 0 ||
                (x - X[3]) * (Y[0] - Y[3]) - (y - Y[3]) * (X[0] - X[3]) == 0) return Belonging.OnBorder;
            return Belonging.In;
        }
        /// <summary>
        /// Проверка получаемой фигуры.
        /// Возвращает истину если фигура квадрат.
        /// </summary>
        /// <returns></returns>
        private bool DoesExist()
        {
            if ((X[0] - X[3]) * (X[0] - X[1]) + (Y[0] - Y[3]) * (Y[0] - Y[1]) == 0 &&
                (X[2] - X[3]) * (X[2] - X[1]) + (Y[2] - Y[3]) * (Y[2] - Y[1]) == 0 &&
                Math.Sqrt(Math.Abs(X[0] - X[1]) * Math.Abs(X[0] - X[1]) + Math.Abs(Y[0] - Y[1]) * Math.Abs(Y[0] - Y[1])) ==
                Math.Sqrt(Math.Abs(X[1] - X[2]) * Math.Abs(X[1] - X[2]) + Math.Abs(Y[1] - Y[2]) * Math.Abs(Y[1] - Y[2])) &&
                Math.Sqrt(Math.Abs(X[0] - X[1]) * Math.Abs(X[0] - X[1]) + Math.Abs(Y[0] - Y[1]) * Math.Abs(Y[0] - Y[1])) ==
                Math.Sqrt(Math.Abs(X[2] - X[3]) * Math.Abs(X[2] - X[3]) + Math.Abs(Y[2] - Y[3]) * Math.Abs(Y[2] - Y[3])) &&
                Math.Sqrt(Math.Abs(X[0] - X[1]) * Math.Abs(X[0] - X[1]) + Math.Abs(Y[0] - Y[1]) * Math.Abs(Y[0] - Y[1])) ==
                Math.Sqrt(Math.Abs(X[3] - X[0]) * Math.Abs(X[3] - X[0]) + Math.Abs(Y[3] - Y[0]) * Math.Abs(Y[3] - Y[0]))) return true;
            return false;
        }
    }
}