namespace Lab5.Part2;

internal static class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Task №1");
		Task_1();
		Console.WriteLine("Task №2");
		Task_2();
		Console.WriteLine("Task №3");
		Task_3();
	}

	private static int[,] CreateMatrix()
	{
		Random num = new Random();
		Console.Write("M: ");
		int m = int.Parse(Console.ReadLine() ?? string.Empty);
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine() ?? string.Empty);
		int[,] array2d = new int[m, n];
		for (int i = 0; i < m; i++) {
			for (int j = 0; j < n; j++)
			{
				array2d[i, j] = num.Next(100);
				Console.Write($"{array2d[i, j]}\t");
			}
			Console.WriteLine('\n');
		}
		return array2d;
	}
		
	private static void Task_1()
	{
		int countMinus = 0; 
		int[,] matrix = CreateMatrix();
		foreach (var number in matrix)
			if (number < 0)
				countMinus++;
		Console.WriteLine($"Count minus elements: {countMinus}");
	}
	private static void Task_2()
	{
		int[,] matrix = CreateMatrix();
		int maxElement = int.MinValue;
		int[] maxElementIndex = new int[2];
		int minElement = int.MaxValue;
		int[] minElementIndex = new int[2];
		for (int i = 0; i < matrix.GetLength(0); i++)
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] >= maxElement)
			{
				maxElement = matrix[i, j];
				maxElementIndex = new[] { i, j };
			}

			if (matrix[i, j] <= minElement)
			{
				minElement = matrix[i, j];
				minElementIndex = new[] { i, j };
			}
		}
		Console.WriteLine($"Min element: {minElement}\n" +
		                  $"Min element index: {minElementIndex[0]}; {minElementIndex[1]}\n" +
		                  $"Max element: {maxElement}\n" +
		                  $"Max element index: {maxElementIndex[0]}; {maxElementIndex[1]}\n");
	}

	private static void Task_3()
	{
		int[,] matrix = CreateMatrix();
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			int sumElements = 0;
			for (int j = 0; j < matrix.GetLength(1); j++)
				sumElements += matrix[i, j];
			Console.WriteLine($"Sum elements in row index {i}: {sumElements}");
		}
	}
}