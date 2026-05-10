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

            string input = "AlexandrAlexey Alex Alexandra";
            Console.WriteLine("Вихідний рядок:\n{0}", input);
            string pattern = @"\bAlex\B";
            string replacement = "Саша";
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);

            input = "один два три чотири пять шість";
            Console.WriteLine("\nВихідний рядок:\n{0}", input);
            // У шаблоні використовується 5 груп
            pattern = @"\b(\w+)(\s)(\w+)(\s)(\w+)\b";
            replacement = "$5$4$3$2$1";
            // вихідний рядок замінюється на 5 груп
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);

            input = "1000000 USD";
            Console.WriteLine("\nВихідний рядок:\n{0}", input);
            pattern = @"\b(\d+)\s?USD";
            replacement = "$$$1";    // $$ - підставляє літерал "$"
            // вихідний рядок замінюється на 1 групу
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);

            input = "AABBCCDD";
            Console.WriteLine("\nВихідний рядок:\n{0}", input);
            pattern = "C+";
            replacement = "$`";
            // знайдений фрагмент тексту замінюється на підрядок
            // вхідного рядка до відповідності шаблону пошуку
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);

            input = "AABBCCDD";
            Console.WriteLine("\nВихідний рядок:\n{0}", input);
            pattern = "C+";
            replacement = "$'";
            // знайдений фрагмент тексту замінюється на підрядок
            // вхідного рядка після відповідності шаблону пошуку
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);

            input = "AABBCCDDEE";
            Console.WriteLine("\nВихідний рядок:\n{0}", input);
            pattern = "(A+)(B+)(C+)";
            replacement = "$+";
            // знайдений фрагмент тексту замінюється на останню захоплену групу
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);

            input = "AABBCC";
            Console.WriteLine("\nВихідний рядок:\n{0}", input);
            pattern = "B";
            replacement = "$_";
            // вхідний рядок замінює всі відповідності шаблону пошуку
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nЗмінений рядок: \n" + input);
        }
    }
}