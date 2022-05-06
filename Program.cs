using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CALCULATOR");

            Console.ResetColor();
            Console.WriteLine("Enter the numbers");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What would You like to do: '+', '-', '*', '/', '.'");
            var operation = Console.ReadLine();
            Console.WriteLine("What's next number?");
            var number2 = int.Parse(Console.ReadLine());
            var result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("Use only '+', '-', '*', '/', '.'");
            }

            Console.WriteLine($"Your result: {result}");
            Console.ReadKey();
        }
    }
}