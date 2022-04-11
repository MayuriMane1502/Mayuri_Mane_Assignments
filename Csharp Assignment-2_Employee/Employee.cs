using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_2_Employee
{
    internal class Employee
    {
		private int EmpNo;
		private string EmpName;
		private double salary, HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

		public Employee(int ENum, string EName, double sal)
		{
			EmpNo = ENum;
			EmpName = EName;
			salary = sal;

			if (salary < 5000)
			{
				HRA = salary * 10 / 100;
				TA = salary * 5 / 100;
				DA = salary * 15 / 100;
				GrossSalary = salary * HRA + TA + DA;
			}
			else if (salary < 10000)
			{
				HRA = salary * 15 / 100;
				TA = salary * 10 / 100;
				DA = salary * 20 / 100;
				GrossSalary = salary;
			}
			else if (salary < 15000)
			{
				HRA = salary * 20 / 100;
				TA = salary * 15 / 100;
				DA = salary * 25 / 100;
				GrossSalary = salary + HRA + TA + DA;
			}
			else if (salary >= 20000)
			{
				HRA = salary * 30 / 100;
				TA = salary * 25 / 100;
				DA = salary * 35 / 100;
				GrossSalary = salary + HRA + TA + DA;
			}


		}
		public void CalculateSalary()
		{
			PF = GrossSalary * 10 / 100;
			TDS = GrossSalary * 18 / 100;
			NetSalary = GrossSalary - (PF + TDS);
		}
		static void Main(string[] args)
        {
			Employee Emp = new Employee(1, "Mayuri", 30000);
			Emp.CalculateSalary();
			Console.WriteLine("Name Of the Employee: " + Emp.EmpName);
			Console.WriteLine("Employee Salary: " + Emp.salary);
			Console.WriteLine("Gross Salary of Employee: " + Emp.GrossSalary);
			Console.WriteLine("Net Salary of Employee: " + Emp.NetSalary);
			Console.ReadKey();
		}
    }
}
