namespace lab_18.Tasks;

public class AvgNumbers
{
	private int[] Numbers { get; set; }

	public AvgNumbers() => Numbers = new int[10];
	
	public void FillFromConsole()
	{
		for (var i = 0; i < Numbers.Length; i++)
		{
			Console.WriteLine($"Write {i} number: ");
			var num = int.Parse(Console.ReadLine()!);
			Numbers.SetValue(num, i);
		}
	}
	

	public void WriteToFile()
	{
		var path = "C:\\folder\\numbers.txt";
		var avg = Numbers.Average();
		using var file = new StreamWriter(path, true);
		file.Write(string.Join(", ", Numbers));
		file.WriteLine($" | {avg}");
	}
}