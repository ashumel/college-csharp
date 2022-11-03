using System;

namespace lab_14
{
	internal static class Program
	{
		public static void Main(string[] args)
		{
			Task1();
			Console.ReadKey();
			Console.Clear();
			Task2();
			Console.ReadKey();
			Console.Clear();
			Task3();
		}

		private static void Task1()
		{
			Division.Start();
		}
		
		private static void Task2()
		{
			try
			{
				var array = new Array();
				array.ShowArray();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		private static void Task3()
		{
			var random = new Random();
			var array = new int[random.Next(50)];
			Console.WriteLine($"Array length: {array.Length}");
			try
			{
				Console.Write("Write index A: ");
				var a = int.Parse(Console.ReadLine() ?? string.Empty);
				Console.Write("Write index B: ");
				var b = int.Parse(Console.ReadLine() ?? string.Empty);
				Console.WriteLine($"Result: {array[a] + array[b]}");
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine(e.Message);
			}
			
		}
	}
}