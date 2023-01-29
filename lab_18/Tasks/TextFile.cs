using System.Net;

namespace lab_18.Tasks;

public static class TextFile
{
	public static void CopyNumbers(int a, int b)
	{
		var path = "C:\\folder\\numbers2.txt";
		var readFile = new StreamReader(path);
		var nums = readFile.ReadLine()!.Split(' ')
			.Select(int.Parse).ToArray();
		readFile.Close();
		using var file = new StreamWriter(path, true);
		for (var i = a; i <= b; i++)
			file.Write($"{nums[i].ToString()} ");
	}

	public static void Uppercase(string path)
	{
		var lines = File.ReadAllLines(path);
		File.WriteAllLines(path, lines.Select(line => line.ToUpper()));
	}

	public static void ReadToConsole(string path)
	{
		var lines = File.ReadAllLines(path);
		foreach (var line in lines)
			Console.WriteLine(line);
	}
}