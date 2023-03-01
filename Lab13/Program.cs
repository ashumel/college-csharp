namespace Lab13;

internal static class Program
{
	public static void Main(string[] args)
	{
		var random = new Random();
		Console.Write("Count elements in array: ");
		var n = int.Parse(Console.ReadLine() ?? string.Empty);
		var array = new Figure[n];
		for (var i = 0; i < n; i++)
		{
			var r = random.Next(2);
			switch (r)
			{
				case 0:
					array[i] = new Circle(
						radius: random.Next(50));
					break;
				case 1:
					array[i] = new Foursquare(
						side: random.Next(230));
					break;
			}
		}

		double circleSumSquare = 0;
		double foursquareSumSquare = 0;
		foreach (var figure in array)
		{
			if (figure is Circle)
			{
				Console.WriteLine($"Square circle: {figure.Square()}");
				circleSumSquare += figure.Square();
			}

			if (figure is Foursquare)
			{
				Console.WriteLine($"Square foursquare: {figure.Square()}");
				foursquareSumSquare += figure.Square();
			}
		}
			
		Console.WriteLine($"\nSum circles square: {circleSumSquare}\n" +
		                  $"Sum foursquare square: {foursquareSumSquare}");
	}
}