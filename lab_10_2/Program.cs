using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_10_2
{
	internal static class Program
	{
		public static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>()
			{
				new Employee(
					fullName: "Wilson C. Hudson",
					position: "Employer relations representative",
					salary: 1230),
				new Employee(
					fullName: "Jennifer D. Fournier",
					position: "Typist",
					salary: 1405),
				new Employee(
					fullName: "Josephine F. Durham",
					position: "Instructional materials director",
					salary: 1200),
				new Employee(
					fullName: "Terrie C. Brown",
					position: "Computer manager",
					salary: 1200)
			};
			var sortEmployees = from employee in employees
				orderby employee.FullName
				select employee;
			foreach (Employee employee in sortEmployees)
				employee.Show();
			Console.WriteLine("Write min salary: ");
			double minSalary = double.Parse(Console.ReadLine() ?? string.Empty);
			foreach (Employee employee in sortEmployees)
				if (minSalary <= employee.GetSalary())
					employee.Show();
		}
	}
}