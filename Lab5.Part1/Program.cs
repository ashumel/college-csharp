namespace Lab5.Part1;

internal static class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Task 1: ");
		Task_1();
		Console.WriteLine("\nTask 2: ");
		Task_2();
		Console.WriteLine("Task 3: ");
		Task_3();
		Console.WriteLine("Task 4: ");
		Task_4();
	}
		
	private static int[] CreateArray()
	{
		Random randElement = new Random();
		Console.Write("Write count elements in array: ");
		int n = int.Parse(Console.ReadLine() ?? string.Empty);
		int[] array = new int[n];
		Console.WriteLine("Output in a row: ");
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = randElement.Next(100);
			Console.Write($"{array[i]}\t");
		}
		return array;
	}
		
	private static void Task_1()
	{
		int[] array = CreateArray();
		Console.WriteLine($"\nOutput in a column:\n");
		foreach (var number in array)
			Console.WriteLine(number);
		int[] array2 = new int[array.Length];
		Array.Copy(array, array2, array.Length);
		Array.Sort(array2);
		Console.WriteLine($"Sorted array:");
		foreach (var number in array2)
			Console.Write($"{number}\t");
		Array.Reverse(array2);
		Console.WriteLine($"\nReverse array: ");
		foreach (var number in array2)
			Console.Write($"{number}\t");
	}
		
	private static void Task_2()
	{
		int[] array = CreateArray();
		int a = 0, b = 1;

		for (int i = 0; i < array.Length; i++)
		{
			var c = a + b;
			array[i] = c;
			a = b; b = c;
			if (i == 0 || i == 1)
				array[i] = 1;
		}
		Console.WriteLine($"\nArray with numbers Fibonacci: ");
		string outputArray = array.Aggregate(string.Empty, (current, number) 
			=> current + $"{number}\t");
		Console.WriteLine(outputArray);
	}

	private static void Task_3()
	{
		int n = int.Parse(Console.ReadLine() ?? string.Empty);
		double[] array = new double[n];
		for (int i = 0; i < array.Length; i++)
			array[i] = double.Parse(Console.ReadLine() ?? string.Empty);
		double valueMax = double.MinValue;
		foreach (double number in array)
			if (valueMax <= number) 
				valueMax = number;
		Console.WriteLine($"Max value in array: {valueMax}");
		Console.WriteLine($"Index: {Array.IndexOf(array, valueMax)}");
	}

	private static void Task_4()
	{
		int[] array1 = { 1, 5, 6, 8, 4 };
		int[] array2 = { 6, 7, 4, 10, 65 };
		int[] array3 = new int[array1.Length + array2.Length];
		for (int i = 0; i < array1.Length; i++)
			array3[i] = array1[i];
		for (int i = array1.Length, k = 0; i < array2.Length + array1.Length; i++, k++)
			array3[i] = array2[k];
		for (int i = 0; i < array3.Length; i++)
		for (int j = i + 1; j < array3.Length; j++)
			if (array3[i] > array3[j]) 
				(array3[i], array3[j]) = (array3[j], array3[i]);
		foreach (var number in array3)
			Console.Write($"{number}\t");
	}
}