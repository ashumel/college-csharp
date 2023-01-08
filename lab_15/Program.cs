namespace lab_15;

internal static class Program
{
	public static void Main()
	{
		Console.Write("\t-- Task 1 --");
		Task1();
		Task2();
	}

	private static void Task1()
	{
		var person = new People();
		while (true)
		{
			Console.Write("\n-- Select action --\n" +
			              "z - create person\n" +
			              "x - show person\n" +
			              "c - delete person\n" +
			              "v - exit\n");
			switch (Console.ReadKey().Key)
			{
				case ConsoleKey.Z:
					person.Operation = person.Set;
					break;
				case ConsoleKey.X:
					person.Operation = person.Show;
					break;
				case ConsoleKey.C:
					Console.Write("\nClear person\n" +
					              "Please, press any button...");
					person = new People();
					Console.ReadKey();
					break;
				case ConsoleKey.V:
					Console.Write("\nPress any button for exit...");
					Console.ReadKey();
					return;
				default:
					Console.Write("\nIncorrect button!");
					person.Operation = null;
					break;
			}
			person.Operation?.Invoke();
		}
	}

	private static void Task2()
	{
		var numbers = new NumArray(new[] { 3.45, 2.55, 6.66 });
		Console.Clear();
		while (true)
		{
			Console.Write("\nAppend action\n" +
			              "1 - max; 2 - min; 3 - sum; 4 - avg\n");
			switch (Console.ReadKey().Key)
			{
				case ConsoleKey.D1:
					numbers.OperationConsole += numbers.ShowMax;
					break;
				case ConsoleKey.D2:
					numbers.OperationConsole += numbers.ShowMin;
					break;
				case ConsoleKey.D3:
					numbers.OperationConsole += numbers.ShowSum;
					break;
				case ConsoleKey.D4:
					numbers.OperationConsole += numbers.ShowAvg;
					break;
				case ConsoleKey.D0:
					numbers.OperationConsole?.Invoke();
					Console.Write("\nPress any button for exit...");
					Console.ReadKey();
					return;
				default:
					Console.Write("\nIncorrect button!");
					numbers.OperationConsole = null;
					break;
			}
				
		}
			
	}
}