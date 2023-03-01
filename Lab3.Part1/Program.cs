namespace Lab3.Part1;

internal static class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Задача 1");
		Task_1();
		Console.WriteLine("Задача 2");
		Task_2();
		Console.WriteLine("Задача 3");
		Task_3();
		Console.WriteLine("Задача 4");
		Task_4(double.Parse(Console.ReadLine() ?? string.Empty));
		Console.WriteLine("Задача 5");
		Task_5(Int32.Parse(Console.ReadLine() ?? string.Empty));
	}

	private static void Task_1()
	{
		int number = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		if (number > 0) Console.WriteLine("Положительное");
		else if (number < 0) Console.WriteLine("Отрицательное");
		else Console.WriteLine("Число равно нулю");
	}

	private static void Task_2()
	{
		int number_1 = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		int number_2 = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		int number_3 = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		if ((number_1 < number_2) && (number_1 < number_3))
			Console.WriteLine("Первое число минимальное");
		else Console.WriteLine("Первое число не минимальное");
	}

	private static void Task_3()
	{
		int b = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		int d = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		int a = Int32.Parse(
			Console.ReadLine() ?? string.Empty);
		Console.WriteLine(
			((d < b ? b : d) * (a > b ? b : a)) *
			(a < b ? b : a));
	}

	private static void Task_4(double x)
	{
		double a = Math.Sin(x);
		double b = Math.Cos(x);
		double c = Math.Log(Math.Abs(x));
		Console.WriteLine($"{a}, {b}, {c}");
		Console.WriteLine(
			a > b ? (a > c ? a : c) : (b > c ? b : c));
	}

	private static void Task_5(int month)
	{
		switch (month)
		{
			case 9: case 10: case 11:
				Console.WriteLine("Осень");
				break;
			case 12: case 1: case 2:
				Console.WriteLine("Зима");
				break;
			case 3: case 4: case 5:
				Console.WriteLine("Весна");
				break;
			case 6: case 7: case 8:
				Console.WriteLine("Лето");
				break;
			default:
				Console.WriteLine("Некорректный ввод");
				break;
		}
	}
}