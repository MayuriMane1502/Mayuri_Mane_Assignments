using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_6_Delegate
{
    class BankAccount
    {
        public delegate void delegatemethod(int a);

        public class Account
        {
            public int AccountNumber { get; set; }

            public string CustomerName { get; set; }

            public int Balance = 10000;

            public event delegatemethod UnderBalance;
            public event delegatemethod ZeroBalance;
        
            public void Insufficient(int a)
            {
                UnderBalance(a);
            }
            public void DepositMoney(int b)
            {
                ZeroBalance(b);
            }
            public void WithDraw(int a)
            {
                if (a < Balance && Balance != 0)
                {
                    Console.WriteLine("Transaction Successful....!");
                    Console.WriteLine("Remaining Balance is: " + (Balance - a));
                }
                else if (a > Balance && Balance != 0)
                {
                    Console.WriteLine("Sorry...Insufficient Amount...");
                    Console.WriteLine("Your Current Balance is " + Balance);
                }
                else
                {
                    Console.WriteLine("Zero Balance: " + Balance);
                }
            }

            public void Deposit(int a)
            {
                Console.WriteLine("Balance after Successful Deposit: " + (Balance + a));
            }
        }
        static void Main(string[] args)
        {
            
            Account obj = new Account();
                   
            Console.WriteLine("Enter Name of the depositor :");

            obj.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Account Number  :");

            obj.AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" \nPress 1 for WithDraw an Amount. \nPress 2 for Deposit an Amount.");
            string wd = Console.ReadLine();
           
           if(wd == "1")
            {
                Console.WriteLine("Enter balance to be withdraw: ");
                int wdbalance = Convert.ToInt32(Console.ReadLine());
                obj.UnderBalance += new delegatemethod(obj.WithDraw);
                obj.Insufficient(wdbalance);
            }
            else
            {
                Console.WriteLine("Enter Amount to be Deposit: ");
                int dpbalance = Convert.ToInt32(Console.ReadLine());
                obj.ZeroBalance += new delegatemethod(obj.Deposit);
                obj.DepositMoney(dpbalance);
            }
            Console.ReadKey();
        }
    }
}
