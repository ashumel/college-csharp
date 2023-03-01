namespace Lab4;

internal static class Program
{
	private static int CountRootQuadraticEquation(double a, double b, double c, out double d)
	{
		d = (b * b) - (4 * a * c);
		if (d > 0) return 2;
		if (d == 0) return 1;
		return 0;
	}

	private static void ReturnRootPlus1(double D, double a, 
		double b, int countRoot, out double root1, out double root2)
	{
		root1 = 0;
		root2 = 0;
		if (countRoot >= 1)
			root1 = (-b + Math.Sqrt(D)) / (2 * a);
		if (countRoot == 2)
			root2 = (-b - Math.Sqrt(D)) / (2 * a);
		if (countRoot == 0)
			Console.WriteLine("Корней нет");
	}

	private static void RDigit(int d, ref int k) => k = k * 10 + d;

	private static void TriangleP(double a, double h, out double P, out double S)
	{
		P = (2 * Math.Sqrt(a * a - h * h) + 2 * a);
		S = 1.0 / 2.0 * a * h;
	}

	private static bool IsPalindrom(int k)
	{
		return k == Convert.ToInt16(k.ToString().ToCharArray().Reverse());
	}
	public static void Main(string[] args)
	{
		Task2();
		Task3();
		Task4();
	}

	private static void Task2()
	{
		Console.WriteLine("Задание 1\n" +
		                  "Введите A, B, C: ");
		double a = double.Parse(Console.ReadLine() ?? string.Empty);
		double b = double.Parse(Console.ReadLine() ?? string.Empty);
		double c = double.Parse(Console.ReadLine() ?? string.Empty);
		double D;
		int countRoot = CountRootQuadraticEquation(a, b, c, out D);
		Console.WriteLine($"Количество корней кв. уравнения: {countRoot}");
		double root1, root2;
		ReturnRootPlus1(D, a, b, countRoot, out root1, out root2);
		Console.WriteLine($"{root1} и {root2}");

	}

	private static void Task3()
	{
		Console.WriteLine("Задание 3");
		int k = int.Parse(Console.ReadLine() ?? string.Empty);
		int d = int.Parse(Console.ReadLine() ?? string.Empty);
		RDigit(d, ref k);
		Console.WriteLine($"Ответ: {k}");
	}

	private static void Task4()
	{
		Console.WriteLine("Задание 4");
		double a = double.Parse(Console.ReadLine() ?? string.Empty);
		double h = double.Parse(Console.ReadLine() ?? string.Empty);
		double P, S;
		TriangleP(a, h, out P, out S);
		Console.WriteLine($"Периметр: {P}\nПлощадь: {S}");
	}
}