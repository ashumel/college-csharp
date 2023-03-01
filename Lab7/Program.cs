using System.Text;

namespace Lab7;

internal static class Program
{
	private static void StringInformation(StringBuilder text)
	{
		Console.WriteLine($"String length: {text.Length}\n" +
		                  $"String capacity: {text.Capacity}");

	}
		
	public static void Main(string[] args)
	{
		Console.WriteLine("-- Task 1 --");
		Task1();
		Console.WriteLine("-- Task 2 --");
		Task2();
		Console.WriteLine("-- Task 3 --");
		Task3();
	}
		
	private static void Task1()
	{
		StringBuilder text = new StringBuilder("Hello, World!");
		Console.WriteLine($"Old string: {text}");
		StringInformation(text);
		text.Append(" Hello, everyone!");
		Console.WriteLine($"New string: {text}");
		StringInformation(text);
	}

	private static void Task2()
	{
		Console.Write("Write string: ");
		string text = Console.ReadLine();
		if (text == null) return;
		Console.WriteLine("Sort by alphabet: " +
		                  $"{string.Join(" ", text.Split().OrderBy(x => x))}");
		Console.WriteLine("Sort by length: " +
		                  $"{string.Join(" ", text.Split().OrderBy(x => x.Length))}");
	}

	private static void Task3()
	{
		Console.Write("Please, write line: ");
		StringBuilder text = new StringBuilder(Console.ReadLine());
		Console.Write("Start index for remove from line: ");
		int indexStart = int.Parse(Console.ReadLine() ?? string.Empty);
		Console.Write("The end of index: ");
		int indexEnd = int.Parse(Console.ReadLine() ?? string.Empty);
		text.Remove(indexStart, indexEnd - indexStart + 1);
		Console.WriteLine($"Result: {text}");
	}
		
}