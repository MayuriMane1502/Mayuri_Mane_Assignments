using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_5_Collections
{
    class CollectionProgram
    {
        static void Main(string[] args)
        {
            int m;
            string s;
            Console.WriteLine("Enter The Number of students");
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            int[] temp = new int[m];
            Console.WriteLine("Enter The Marks of Student");
            for (int i = 0; i < m; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            System.Array.Reverse(a);
            Console.WriteLine("Reverse of array after Sorting is");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.ReadKey();
            }
            System.Array.Sort(a);
            Console.WriteLine("array after Sorting is");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.ReadKey();
            }
            System.Array.Sort(a);
            System.Array.Clear(a, 1, 2);
            Console.WriteLine("after Clear Operation the array is");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            System.Array.Copy(temp, a, a.Length);
            Console.WriteLine("The copied element are");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
            Console.WriteLine("Enter the value of String");
            s = Console.ReadLine();
            char[] array = s.ToCharArray();
            Console.WriteLine("\nString after Reverse operation: ");
            System.Array.Reverse(array);
            Console.WriteLine(new String(array));
            Console.WriteLine("\nString after Sort operation: ");
            System.Array.Sort(array);
            Console.WriteLine(new String(array));
            Console.WriteLine("\nString after clear operation: ");
            System.Array.Clear(array, 1, 2);
            Console.WriteLine(new String(array));
           
            Console.ReadKey();
        }
    }
}
