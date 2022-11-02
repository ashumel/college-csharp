using System;

namespace lab_14
{
	public static class Division
	{
		private static int DivisionNumbers(int x, int y) => x / y;

		public static void Start()
		{
			try
			{
				Console.Write("Write X: ");
				var x = int.Parse(Console.ReadLine() ?? string.Empty);
				Console.Write("Write Y: ");
				var y = int.Parse(Console.ReadLine() ?? string.Empty);
				var result = DivisionNumbers(x, y);
				Console.Write($"Result: {result}");
			}
			catch (FormatException)
			{
				Console.WriteLine("It's not number");
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Divide by zero");
			}
		}
	}
}