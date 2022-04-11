using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1_SwapValue
{
    internal class SwapValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ...Before Swapping....");

            Console.WriteLine("\n First Number is: {0}", num1);
            Console.WriteLine(" Second Number is: {0}", num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("\n ...After Swapping....");

            Console.WriteLine("\n First number is : {0}", num1);
            Console.WriteLine("Second number is : {0}", num2);
            Console.ReadKey();
        }
    }
}
