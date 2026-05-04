using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            // У вихідному рядку потрібно знайти всі числа,
            // що відповідають рокам випуску мов програмування
            string input = "Випуск першої офіційної версії: " +
                "Мова програмування C++ - 1985 рік. " +
                "Мова програмування Java - 1995 рік. " +
                "Мова програмування C# - 2002 рік. ";

            string pattern = @"(\d+)\s?рік";
            Regex regex = new Regex(pattern);

            // Досягаємо того ж результату, що й у попередньому прикладі,
            // використовуючи метод Regex.Matches(), який повертає MatchCollection
            MatchCollection mc = regex.Matches(input);

            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[1].Value);
                Console.WriteLine(match.Value);
            }
        }
    }
}