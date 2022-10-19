using System;

namespace lab_10
{
	internal static class Program
	{
		private static void SearchModel(Phone[] phones, string search)
		{
			foreach (Phone phone in phones)
				if (search == phone.GetModel)
					phone.Show();
		}
		public static void Main(string[] args)
		{
			Task3();
		}

		private static void Task1()
		{
			Phone[] phones = new Phone[]
			{
				new Phone(),
				new Phone(
					imei: 982806143804278,
					vendor: Vendor.Samsung,
					model: "Galaxy S21"),
				new Phone(
					imei: 449029291206462,
					vendor: Vendor.Samsung,
					model: "Galaxy S21"),
				new Phone(
					imei: 453795133484854,
					vendor: Vendor.Xiaomi,
					model: "Note 11"),
				new Phone(
					imei: 524861956731311,
					vendor: Vendor.Apple,
					model: "iPhone 13"),
			};
			SearchModel(phones, Console.ReadLine());
		}

		private static void Task3()
		{
			Console.WriteLine(Number.Factorial(5));
			Console.WriteLine(Number.Fibonacci(7));
		}
	}
}