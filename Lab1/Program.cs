namespace Lab1;

internal static class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Задание 1");
		Task1();
		Console.WriteLine("Задание 2");
		Task2();
		Console.WriteLine("Задание 3");
		Task3();
		Console.WriteLine("Задание 4");
		Console.WriteLine(Task4(Convert.ToInt16(Console.ReadLine()), 
			Convert.ToInt16(Console.ReadLine())));
	}

	private static void Task1()
	{
		const int x = 5;
		const int y = 6;
		Console.WriteLine("При x = " + x + ", y = " + y);
		Console.WriteLine("При x = {0}, y = {1}", x, y);
		Console.WriteLine($"При x = {x}, y = {y}");
	}

	private static void Task2()
	{
		int integer = Convert.ToInt16(Console.ReadLine());
		double extended = Convert.ToDouble(Console.ReadLine());
		char symbol = Convert.ToChar(Console.ReadLine() ?? string.Empty);
	}

	private static void Task3()
	{
		var number = Console.ReadLine();
		if (number == null) return;
		foreach (var i in number)
			Console.WriteLine(i);
	}

	private static double Task4(int x, int y)
	{
		// ReSharper disable once PossibleLossOfFraction
		return (x + y) / 2;
	}
}