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

            // Масив тестових рядків
            string[] test = [
                "This is .NET World", "Hello world", "My wonderful world"
            ];

            // Перевіримо, чи міститься у вихідних рядках слово World
            // при цьому ми не вкажемо параметри RegexOptions
            Regex regex = new Regex("World");

            Console.WriteLine("Пошук з урахуванням регістру: ");
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("У вихідному рядку: \"{0}\" є співпадіння!", str);
            }
            Console.WriteLine();

            // Тепер вкажемо пошук без урахування регістру
            regex = new Regex("World", RegexOptions.IgnoreCase);

            Console.WriteLine("Пошук без урахування регістру: ");
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("У вихідному рядку: \"{0}\" є співпадіння!", str);
            }
        }
    }
}