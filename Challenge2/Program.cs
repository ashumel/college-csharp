using System.Text.RegularExpressions;
using static System.Console;

namespace Challenge2;

internal static class Program
{
	private static void Task_3()
	{
		string line = ReadLine();
		Regex findSpaces = new Regex(@"\s{2,}");
		MatchCollection matchSpaces = findSpaces.Matches(line ?? string.Empty);
		foreach (Match x in matchSpaces)
			line = line?.Remove(x.Index, x.Value.Length - 1);
		WriteLine(line);
			
	}
	public static void Main(string[] args)
	{
		Task_3();
	}
}