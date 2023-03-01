using System.Text.RegularExpressions;

namespace Lab9;

internal static class Program
{
	enum OptionIgnoreCase
	{
		Yes, No
	}

	enum Country
	{
		Russia, Belarus,
		Ukraine, Poland
	}
	private static int GetCountSubstringInText(string substring, string text, OptionIgnoreCase mode)
	{
		switch (mode)
		{
			case OptionIgnoreCase.Yes:
				return Regex.Matches(text, substring, RegexOptions.IgnoreCase).Count;
			case OptionIgnoreCase.No:
				return Regex.Matches(text, substring).Count;
			default:
				throw new Exception("Invalid option ignore case!");
		}
	}

	private struct Chocolate
	{
		private string name;
		private Country country;
		private int weight;
		private double price;
		public Chocolate(string name, int weight, double price, Country country)
		{
			this.name = name;
			this.weight = weight;
			this.price = price;
			this.country = country;
		}
		public void PrintInformation()
		{
			Console.WriteLine("-- Chocolate information -- \n" +
			                  $"Name: {this.name}\n" +
			                  $"Country: {this.GetCountry()}\n" +
			                  $"Weight: {this.weight}\n" +
			                  $"Price: {this.price}");
		}
		public int GetWeight() => this.weight;

		private string GetCountry()
		{
			switch (this.country)
			{
				case Country.Belarus:
					return "Беларусь";
				case Country.Russia:
					return "Россия";
				case Country.Poland:
					return "Польша";
				case Country.Ukraine:
					return "Украина";
				default:
					throw new Exception("Invalid country");
			}
		}
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("-- Task 1 --");
		Task1();
		Console.WriteLine(" -- Task 2 --");
		Task2();
	}

	private static void Task1()
	{
		Console.Write("Please, write string: ");
		string text = Console.ReadLine();
		Console.Write("Write substring for get count comparison: ");
		string substring = Console.ReadLine();
		Console.Write("Mode: 0 - ignore case, 1 - sensitive case: ");
		switch (int.Parse(Console.ReadLine() ?? string.Empty))
		{
			case 0:
				Console.WriteLine($"Count substring in you string: " +
				                  $"{GetCountSubstringInText(substring, text, OptionIgnoreCase.Yes)}");
				break;
			case 1:
				Console.WriteLine($"Count substring in you string: " +
				                  $"{GetCountSubstringInText(substring, text, OptionIgnoreCase.No)}");
				break;
			default:
				throw new Exception("Invalid option");
		}
	}

	private static void Task2()
	{
		Chocolate[] chocolates = new Chocolate[]
		{
			new Chocolate(
				name: "Молочный шоколад «Nestle» Maxibon",
				weight: 80,
				country: Country.Poland,
				price: 3.19),
			new Chocolate(
				name: "Плитка кондитерская «Аленкина буренка»",
				weight: 90,
				country: Country.Russia,
				price: 1.55),
			new Chocolate(
				name: "Шоколад горький «O'Zera» с солёной карамелью",
				weight: 90,
				country: Country.Belarus,
				price: 4.50),
			new Chocolate(
				name: "Шоколад пористый «Победа»",
				weight: 65,
				country: Country.Ukraine,
				price: 2.79)
		};
		Console.Write("Enter weight chocolate: ");
		int weight = int.Parse(Console.ReadLine() ?? string.Empty);
		foreach (Chocolate chocolate in chocolates)
		{
			if (chocolate.GetWeight() == weight)
				chocolate.PrintInformation();
		}
	}
}