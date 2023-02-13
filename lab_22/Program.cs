using System.Collections;

namespace lab_22;

public static class Program
{
	public static void Main(string[] args)
	{
		Task1();
		Task2();
		Task3();
	}

	private static void Task1()
	{
		var arrayList = new ArrayList
		{
			"James", "Walker", "game_engineer"
		};

		foreach (var o in arrayList) 
			Console.WriteLine(o);

		arrayList[0] = "Alex";
		arrayList.Remove("game_engineer");
	}

	private static void Task2()
	{
		var numArray = new[] { 1, 3, 7, 10 }
			.ToList();
		var strArray = new[] { "Hello", "World" }
			.ToList();
		var numMax = numArray.Max();
		var strMax = strArray.OrderByDescending(s => s.Length).First();
		Console.WriteLine($"Max number: {numMax} | Max text length: {strMax}");
	}

	private static void Task3()
	{
		var students = new List<Student>
		{
			new("Jerry", "Tillmon", 17),
			new("Robert", "Donovan", 19),
			new("Victoria", "Simmons", 20),
			new("Jeffery", "Haynes", 16),
			new("Kelly", "Harper", 22),
		};
		students.Sort();
		Console.WriteLine(string.Join("\n", students));
	}
	
}