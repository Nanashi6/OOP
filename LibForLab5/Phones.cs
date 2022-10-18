using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LibForLab5
{
    public class Phones
    {
        public static List<string> phones = new List<string>();

        public static List<string> mobilePhones = new List<string>();
        public static List<string> cityPhones = new List<string>();
        public static List<string> uncknownPhones = new List<string>();

        static string cityPhone = @"\d{3}-\d{2}-\d{2}";
        static string mobilePhone = @"\+\d{12}$";
        /// <summary>
        /// Метод сортироет номера хранящиеся в объекте на момент начала работы программы 
        /// </summary>
        public static void SortPhones()
        {
            foreach (string phone in phones)
            {
                if (Regex.IsMatch(phone, cityPhone))
                {
                    cityPhones.Add(phone);
                }
                else
                {
                    if (Regex.IsMatch(phone, mobilePhone))
                    {
                        mobilePhones.Add(phone);
                    }
                    else
                    {
                        uncknownPhones.Add(phone);
                    }
                }
            }
        }
        /// <summary>
        /// Метод передает полученый номер phone в один из списков
        /// </summary>
        /// <param name="phone">Номер</param>
        public static void SortPhones(string phone)
        {
            Phones.phones.Add(phone);
            if (Regex.IsMatch(phone, cityPhone))
            {
                cityPhones.Add(phone);
            }
            else
            {
                if (Regex.IsMatch(phone, mobilePhone))
                {
                    mobilePhones.Add(phone);
                }
                else
                {
                    uncknownPhones.Add(phone);
                }
            }
        }
    }
}