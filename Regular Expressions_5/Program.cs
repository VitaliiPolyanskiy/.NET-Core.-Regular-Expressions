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

            Console.WriteLine("Введіть час у форматі години:хвилини[:секунди] або години.хвилини[.секунди]");
            string Input = Console.ReadLine();
            string pattern = @"^(([01][0-9])|(2[0-3]))(:|\.)[0-5][0-9]((:|\.)[0-5][0-9])?$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(Input))
                Console.WriteLine("Час введено правильно!");
            else
                Console.WriteLine("Час введено неправильно!");
        }
    }
}
