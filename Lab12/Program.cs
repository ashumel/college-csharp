using static System.Console;

namespace Lab12;

internal static class Program
{
	private static void ConsoleClear()
	{
		WriteLine("\nPlease, press Enter to continue...");
		if (ReadKey().Key != ConsoleKey.Enter)
			Environment.Exit(0);
		Clear();
	}
		
		
	public static void Main(string[] args)
	{
		Task1();
		ConsoleClear();
	}

	private static void Task1()
	{
		WriteLine("\t-- Task 1 --\t");
		int x1, y1, x2, y2;
		WriteLine("-- Length between x and y --");
		Write("X: ");
		x1 = int.Parse(ReadLine() ?? string.Empty);
		Write("Y: ");
		y1 = int.Parse(ReadLine() ?? string.Empty);
		WriteLine($"Result: {Distance.Length(x1, y1)}");
		WriteLine("\n\n-- Length between x1, y1 and x1, y2 --");
		Write("X1: ");
		x1 = int.Parse(ReadLine() ?? string.Empty);
		Write("Y1: ");
		y1 = int.Parse(ReadLine() ?? string.Empty);
		Write("X2: ");
		x2 = int.Parse(ReadLine() ?? string.Empty);
		Write("Y2: ");
		y2 = int.Parse(ReadLine() ?? string.Empty);
		WriteLine($"Result: {Distance.Length(x1, y1, x2, y2)}");
	}
}