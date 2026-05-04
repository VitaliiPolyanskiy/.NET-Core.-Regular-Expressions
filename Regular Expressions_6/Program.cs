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

            Console.WriteLine("Введіть число: ");
            string Input = Console.ReadLine();
            string pattern = @"^(-|\+)?\d+(\.\d+)?$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(Input))
                Console.WriteLine("Некоректне введення!");
            else
                Console.WriteLine("Число введене правильно!");
        }
    }
}
