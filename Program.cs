using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_Assignment_3_OOP
{
	public class Employee
	{
		public int empid;
		public string empname;
		public double basic_salary = 30000;
		public double km;
	}
	public void getdetails()
	{
		Console.WriteLine("Enter Employee Id: ");
		int empid = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Employee Name: ");
		string empname = Console.ReadLine();
	}
	public void getkmdetails()
	{
		Console.WriteLine("Enter No of Kilometers Employee Traveled: ");
		double km = Convert.ToDouble(Console.ReadLine());
	}
	public void Display()
	{
		Console.WriteLine("\n\n\n");
		string empid = null;
		Console.WriteLine("Employee Id is: " + empid);
		string empname = null;
		Console.WriteLine("Employee Name is: " + empname);
	}
	public void CalculateSalary()
	{
		string basic_salary = null;
		Console.WriteLine("Your Basic Salary is: " + basic_salary);
	}
}

class Manager : Employee
{
	public void getempdetails()
	{
		getdetails();
		base.Display();
		base.CalculateSalary();
	}
	public void CalculateSalary()
	{
		double netsal;
		double gross_sal;

		gross_sal = base.basic_salary + (base.basic_salary * 0.08) + (base.basic_salary * 0.13) + (base.basic_salary * 0.03);
		Console.WriteLine("Your Gross Salary is: " + gross_sal);
		netsal = gross_sal - 500; //pf reduce
		Console.WriteLine("Your Net Salary is: " + netsal);
		Console.WriteLine("\n\n");
	}
}
class MarketingExecutive : Employee
{
	public void getempdetails()
	{
		base.Getdetails();
		base.Getkmdetails();
		base.Display();
		base.CalculateSalary();
	}
	public void CalculateSalary()
	{
		double netsal;
		double gross_sal;
		gross_sal = base.basic_salary + (base.km / 5) + 1000;
		Console.WriteLine("Your Gross Salary is: " + gross_sal);
		netsal = gross_sal - 500;
		Console.WriteLine("Your Net Salary is: " + netsal);
		Console.WriteLine("\n\n");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Manager mgr = new Manager();
		mgr.getempdetails();
		mgr.CalculateSalary();

		MarketingExecutive mkex = new MarketingExecutive();
		mkex.getempdetails();
		mkex.CalculateSalary();

		Console.ReadKey();
	}
}
