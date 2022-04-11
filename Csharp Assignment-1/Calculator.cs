using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Enter the First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Add");
            Console.WriteLine("\t2 - Subtract");
            Console.WriteLine("\t3 - Multiply");
            Console.WriteLine("\t4 - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            //  Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
