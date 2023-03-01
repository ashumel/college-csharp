namespace Lab16;

public static class Program
{
	public static void Main(string[] args)
	{
		var card1 = new Card(
			cardholder: "Vlad Anisimov",
			balance: 15.5,
			limit: 5.5);

		while (true)
		{
			Console.WriteLine("1. Show card\n" +
			                  "2. Make pay\n" +
			                  "3. Put to card\n" +
			                  "4. Exit"); 
			var key = Console.ReadKey().Key;
			switch (key)
			{
				case ConsoleKey.D1:
					card1.Show();
					break;
				case ConsoleKey.D2:
					Console.WriteLine("\nHow much do you want to withdraw?");
					card1.Pay(double.Parse(Console.ReadLine() ?? string.Empty));
					break;
				case ConsoleKey.D3:
					Console.WriteLine("\nHow much do you want to deposit?");
					card1.Put(double.Parse(Console.ReadLine() ?? string.Empty));
					break;
				case ConsoleKey.D4:
					return;
			}
		}
	}
}