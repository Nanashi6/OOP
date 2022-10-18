using LibForLab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string String = Console.ReadLine();
            Console.WriteLine("Введите слово, которое нужно подсчитать встроке");
            string word = Console.ReadLine();

            WordFinder.FindWrd(String, word);
           
            StringBuilder stringBuilder = new StringBuilder();

            GetRusText.FindRusText(String, stringBuilder);
        }
    }
}
