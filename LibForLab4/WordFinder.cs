using System;

namespace LibForLab4
{
    public class WordFinder
    {
        /// <summary>
        /// Метод принимает строку s и считает кол-во повторений строки s1
        /// </summary>
        /// <param name="s">Строка</param>
        /// <param name="s1">Подстрока</param>
        public static int FindWrd(string s, string s1)
        {
            int c = 0;
            string[] ss = s.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                if (Char.IsPunctuation(ss[i][ss[i].Length - 1]))
                {
                    if (Char.IsPunctuation(ss[i][ss[i].Length - 1]))
                    {
                        ss[i] = ss[i].Substring(0, ss[i].Length - 1);
                    }
                }
            }

            foreach (var str in ss)
            {
                if (str.ToLower() == s1.ToLower())
                {
                    ++c;
                }
            }
            /*
            Console.WriteLine("Число повторений равно {0}", c);
            Console.ReadLine();
            */
            return c;
        }
    }
}
