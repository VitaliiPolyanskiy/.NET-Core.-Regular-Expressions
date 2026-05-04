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

            string pattern = @"(\d+)\s?(рік)";
            Regex regex = new Regex(pattern);

            // Отримуємо співпадіння в екземплярі класу Match
            Match match = regex.Match(input);

            // Відображаємо всі співпадіння
            while (match.Success)
            {
                // Оскільки ми виділили в шаблоні дві групи (дві пари круглих дужок),
                // звертаємося до знайденого значення через властивість Groups класу Match
                Console.WriteLine(match.Groups[1].Value);
                Console.WriteLine(match.Groups[2].Value);
                Console.WriteLine(match.Value);

                // Переходимо до наступного співпадіння
                match = match.NextMatch();
            }
        }
    }
}