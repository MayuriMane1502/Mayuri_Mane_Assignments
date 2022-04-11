using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1_HighMark
{
    internal class HighMark
    {
        static void Main(string[] args)
        {
            Double highestmark = 0;
            int k = 0;
            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("Student {0}  please enter your average marks", i);
                Double j = Convert.ToDouble(Console.ReadLine());
                if (j > highestmark)
                {
                    highestmark = j;
                    k = i;
                }
            }
            Console.WriteLine("The average highest marks are {0} of student number {1}", highestmark, k);
            Console.ReadKey();
        }
    }
}
