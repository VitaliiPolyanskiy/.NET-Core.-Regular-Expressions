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

            Console.WriteLine("Ваша ОС (Windows/Linux/Mac OS)?");
            string Input = Console.ReadLine();
            string pattern = @"^Windows$|^Linux$|^Mac OS$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(Input))
                Console.WriteLine("Така ОС є у списку");
            else
                Console.WriteLine("Такої ОС немає у списку");
        }
    }
}
