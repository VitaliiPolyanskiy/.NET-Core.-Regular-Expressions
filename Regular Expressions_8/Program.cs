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

            string myText = @"Серіалізація — це процес збереження об'єкта на диску. 
В іншій частині застосунку або навіть у зовсім окремому застосунку може виконуватися
десеріалізація об'єкта, яка повертає його у стан, в якому він перебував до серіалізації.";

            string myReg = "Серіал";
            MatchCollection myMatch = Regex.Matches(myText, myReg, RegexOptions.IgnoreCase);

            Console.WriteLine("Усі входження рядка \"{0}\" у вихідному рядку: ", myReg);
            foreach (Match i in myMatch)
                Console.Write("\t" + i.Index);

            myReg = @"\b[с,д]\w*еріалізаці\w*";
            MatchCollection match = Regex.Matches(myText, myReg, RegexOptions.IgnoreCase);
            Console.WriteLine("\n");
            FindMyText(myText, match);

            Console.ReadLine();
        }

        static void FindMyText(string text, MatchCollection myMatch)
        {
            // Реалізуємо виділення ключових слів у консолі іншим кольором
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }
        }
    }
}