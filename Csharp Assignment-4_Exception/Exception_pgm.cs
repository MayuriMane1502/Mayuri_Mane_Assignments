using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_4_Exception
{
    class Stack
    {
        private int[] elet;
        private int top;
        private int max;
        public Stack(int size)
        {
            elet = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            if (top == max - 1)
            {
                throw new Exception("Stack Overflow can't perform push ");

            }
            else
            {
                elet[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is Empty");

            }

            else
            {
                Console.WriteLine("popped Element is: " + elet[top]);
                return elet[top--];
            }
        }
        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + elet[i]);
                }
            }
        }
    }
    class Exception_pgm
    {
        static void Main()
        {
            Stack S = new Stack(5);
            S.push(10);
            S.push(20);
            S.push(30);
            S.push(40);
            S.push(50);


            Console.WriteLine("Items are: ");
            S.printStack();
            


            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
            Console.ReadKey();
        }
    }
}

