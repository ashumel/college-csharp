namespace Lab2;

internal static class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Задание 1");
		Task_1();
		Console.WriteLine($"Задание 2\n{Task_2(5, 6)}");
		Console.WriteLine($"Задание 3\n{Task_3(6, 5)}");
		Console.WriteLine($"Задание 4\n{Task_4(15900)}");
	}

	private static void Task_1()
	{
		string line = Console.ReadLine();
		Console.WriteLine(line);
		Console.WriteLine($"Ваша строка: {line}. Все верно?");
	}

	private static double Task_2(double x, double z)
	{
		return 1.0 / 8 * Math.Pow(Math.E, x * z)
		       + (Math.Abs(x - z) / 
		          Math.Sqrt(Math.Pow(x + z, 4)));
	}

	private static string Task_3(double x, double y)
	{
		return $"Разность чисел: {x - y}, частное: {x / y}";
	}

	private static string Task_4(double weight_kg)
	{
		int weight_tons = (int)(weight_kg / 1000);
		double remainder_kg = ((weight_kg / 1000) - weight_tons) * 1000;
		return $"Полных тонн: {weight_tons} Остаток: {remainder_kg} кг.";
	}
}