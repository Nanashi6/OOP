using System;
using System.Text;

namespace LibForLab4
{
    public class GetRusText
    {
        /// <summary>
        /// Выделяет русские предложения из s в ss
        /// </summary>
        /// <param name="s">Начальнаястрока</param>
        /// <param name="ss">Конечная строка</param>
        public static StringBuilder FindRusText(string s, StringBuilder ss)
        {
            byte[] bytes = { };
            int len;
            int amount;
            string[] s1 = s.Split(' ');
            for (int i = 0; i < s1.Length; i++)
            {
                amount = 0;
                len = s1[i].Length;
                if (Char.IsPunctuation(s1[i][s1[i].Length - 1]))
                {
                    len -= 1;
                }

                bytes = Encoding.GetEncoding(1251).GetBytes(s1[i]);

                for (int j = 192; j < 256; j++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (j == bytes[k]) amount++;
                    }
                }

                if (amount == len)
                {
                    ss.AppendFormat(s1[i] + " ");
                }
            }
            /*
            Console.WriteLine("Конечный текст на русском");
            Console.WriteLine(ss.ToString());
            */
            return ss;
        }
    }
}
