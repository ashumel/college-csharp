using lab_18.Tasks;

namespace lab_18;

internal static class Program
{
	public static void Main()
	{
		Task1();
		//Task2();
		//Task3();
	}

	private static void Task1()
	{
		var numbers = new AvgNumbers();
		numbers.FillFromConsole();
		numbers.WriteToFile();
		TextFile.ReadToConsole("C:\\folder\\numbers.txt");
	}

	private static void Task2()
	{
		Console.WriteLine("Write index (a, b): ");
		var a = int.Parse(Console.ReadLine()!);
		var b = int.Parse(Console.ReadLine()!);
		TextFile.CopyNumbers(a, b);
	}

	private static void Task3()
	{
		TextFile.Uppercase("C:\\folder\\text3.txt");
	}
}