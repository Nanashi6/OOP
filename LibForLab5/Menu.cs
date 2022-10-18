using System;
using System.IO;

namespace LibForLab5
{
    public class Menu
    {
        public static void PhonesMenu()
        {
            StreamReader f = new StreamReader("E:\\2 Курс\\ООПиП\\phones.txt");
            while (!f.EndOfStream)
            {
                Phones.phones.Add(f.ReadLine());
            }
            f.Close();
            Phones.SortPhones();

            int key = 0;
            while (key != 6)
            {
                Console.WriteLine("1. Вывести исходный список номеров");
                Console.WriteLine("2. Вывести список мобильных номеров");
                Console.WriteLine("3. Вывести список городских номеров");
                Console.WriteLine("4. Вывести список неверных номеров");
                Console.WriteLine("5. Добавить номера к исходному списку");
                Console.WriteLine("6. Выход");

                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Исходный список номеров:");
                        foreach (string phone in Phones.phones)
                        {
                            Console.WriteLine(phone);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Список мобильных номеров:");
                        foreach (string phone in Phones.mobilePhones)
                        {
                            Console.WriteLine(phone);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Список городских номеров:");
                        foreach (string phone in Phones.cityPhones)
                        {
                            Console.WriteLine(phone);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Список неверных номеров:");
                        foreach (string phone in Phones.uncknownPhones)
                        {
                            Console.WriteLine(phone);
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        StreamWriter file = new StreamWriter("E:\\2 Курс\\ООПиП\\phones.txt", true);
                        string newPhones = Console.ReadLine();

                        string[] phones = newPhones.Split(' ');

                        foreach (string phone in phones)
                        {
                            file.WriteLine(phone);
                            Phones.SortPhones(phone);
                        }
                        file.Close();
                        break;
                    default: break;
                }
            }
        }
    }
}