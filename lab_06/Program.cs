using System;
using static System.Console;

namespace lab_06
{
	internal static class Program
	{
		public static void Main(string[] args)
		{
			WriteLine("Task №1");
			Task_1();
			WriteLine("Task №2");
			Task_2();
			WriteLine("Task №3");
			Task_3();
			WriteLine("Task №4");
			Task_4();
			
		}

		private static void Task_1()
		{
			Write("Write line: ");
			foreach (var ch in ReadLine())
				WriteLine($"Symbol {ch}: {(int)ch}");
		}

		private static void Task_2()
		{
			Write("Write line: ");
			int i = 0;
			foreach (var ch in ReadLine())
				if (ch > 64 && ch < 91)
					i++;
			WriteLine($"Count latin capitals symbols: {i}");
		}

		private static void Task_3()
		{
			Write("Write string: ");
			string input = ReadLine();
			string output = string.Empty;
			foreach (var ch in input)
			{
				if (ch.ToString() == ch.ToString().ToUpper())
					output += ch.ToString().ToLower();
				if (ch.ToString() == ch.ToString().ToLower())
					output += ch.ToString().ToUpper();
			}
			
			WriteLine($"Result: {output}");
		}

		private static void Task_4()
		{
			Write("Please, write string: ");
			string input = ReadLine();
			while (input.Contains("  "))
				input = input.Replace("  ", " ");
			Console.WriteLine($"Removed spaces: {input}");
		}
	}
}