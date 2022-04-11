using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1_Circle
{
    internal class Circle
    {
        static void Main(string[] args)
        {
            Double pi = 3.14;
            Console.WriteLine("enter the radius of circle :");
            Double r = Convert.ToDouble(Console.ReadLine());
            Double Area = pi * r * r;
            Console.WriteLine("The Area of circle is {0}", Area);
            
            Double Circumference = 2 * pi * r;
            Console.WriteLine("The Circumference of circle is {0}", Circumference);
            Console.ReadKey();
        }
    }
}
