namespace Lab25;

public static class Program
{
	public static void Main(string[] args)
	{
		var task = new Task(DisplayMessage);
		task.Start();
		task.Wait();
		Console.ReadLine();
		
		var task1 = new Task(PrintNumbers);
		var task2 = new Task(PrintText);
		
		task1.Start();
		task2.Start();
		Task.WaitAll(task1, task2);
		Task.WaitAny(task1, task2);


		Parallel.For(1, 10, Factorial);
		Parallel.ForEach(new List<int> { 1, 3, 5, 8}, Factorial);
		Parallel.ForEach(new List<int> { 1, 2, 6, 10, 18 }, number =>
		{ 
			if (number.IsPrime()) 
				Console.WriteLine("Number {0} is prime", number);
			Console.WriteLine("Number {0} is not prime", number);
		});
		
		Console.WriteLine("The end of the Main method");
	}

	private static void DisplayMessage() => 
		Console.WriteLine(
			"The beginning of working with the Display method\n" + 
			"The end of working with the Display method");

	private static void PrintNumbers()
	{
		for (var i = 1; i < 10; i++) 
			Console.WriteLine(i);
	}

	private static void PrintText()
	{
		for (var i = 0; i < 10; i++) 
			Console.WriteLine("Nikita Samoilov");
	}

	private static void Factorial(int x)
	{
		var result = 1;
		for (var i = 1; i <= x; i++)
			result *= i;
		Console.WriteLine(
			"Execution task {0}\n" + 
			"Factorial number {1}: {2}", 
			Task.CurrentId, x, result);
		Thread.Sleep(3000);
	}
	
	private static bool IsPrime(this int number)
	{
		if (number < 2)
			return false;
		
		if (number == 2)
			return true;
		
		if (number % 2 == 0) 
			return false;

		var boundary = (int)Math.Floor(Math.Sqrt(number));

		for (var i = 3; i <= boundary; i += 2)
			if (number % i == 0)
				return false;
		
		return true;
	}
}