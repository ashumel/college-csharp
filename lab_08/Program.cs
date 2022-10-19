using System;
using System.Text.RegularExpressions;

namespace lab_08
{
	internal static class Program
	{
		private static MatchCollection CustomMatch(string pattern, string line)
		{
			Regex whatFind = new Regex(pattern);
			return whatFind.Matches(line);
		}
		public static void Main(string[] args)
		{
			Console.Write("Write string: ");
			string line = Console.ReadLine();
			Task1(line);
			Task2(line);
			Console.Write("\nWrite words with numbers inside: ");
			line = Console.ReadLine();
			Task3(line);
		}

		private static void Task1(string line)
		{
			Console.Write("Only numbers:");
			foreach (Match xMatch in CustomMatch(@"[0-9]", line))
				Console.Write($"\t{xMatch.Value}");
		}

		private static void Task2(string line)
		{
			Console.Write("\nSum elements: ");
			int sum = 0;
			foreach (Match xMatch in CustomMatch(@"[0-9]{1,}", line))
				sum += int.Parse(xMatch.Value);
			Console.Write(sum);
		}

		private static void Task3(string line)
		{
			Console.Write("\nAll words with numbers: ");
			foreach (Match xMatch in CustomMatch(
				         @"\S*[A-Za-zА-Яа-я]\S*[0-9]\S*|\S*[0-9]\S*[A-Za-zА-Яа-я]\S*", line))
				Console.Write($"\t{xMatch.Value}");
		}
	}
}