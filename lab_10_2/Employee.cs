using System;
using System.Text.RegularExpressions;

namespace lab_10_2
{
	public class Employee
	{
		public readonly string FullName;
		private readonly string _position;
		private double _salary;
		public Employee(string fullName, string position, double salary)
		{
			FullName = fullName;
			_position = position;
			Salary = salary;
		}
		

		private double Salary
		{
			set
			{
				if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
				_salary = value;
				if (IsManager())
				{
					_salary += (_salary / 100 * 30);
					return;
				}
				_salary += (_salary / 100 * 20);
			}
		}

		private bool IsManager() => Regex.IsMatch(_position, "manager", RegexOptions.IgnoreCase);

		public double GetSalary() => _salary;
		public void Show()
		{
			Console.WriteLine($"-- Identity --\n" +
			                  $"Full name: {FullName}\n" +
			                  $"Occupation: {_position}\n" +
			                  $"Salary: {_salary}");
		}
	}
}