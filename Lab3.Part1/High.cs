namespace Lab3.Part1;

public class High
{
	public static void Task_1()
	{
		int a = Int32.Parse(Console.ReadLine() ?? string.Empty);
		int b = Int32.Parse(Console.ReadLine() ?? string.Empty);
		int c = Int32.Parse(Console.ReadLine() ?? string.Empty);
		int x = Int32.Parse(Console.ReadLine() ?? string.Empty);
		int y = Int32.Parse(Console.ReadLine() ?? string.Empty);
		Console.WriteLine((
			(((a <= x) && (b <= y)) || ((a <= y) && (b <= x))
			                        || ((a <= x) && (c <= y)) || ((a <= y) && (c <= x))
			                        || ((b <= x)) && (c <= y)) || ((b <= y)&& (c <= x))) 
			? "Просунется" : "Не просунется");
	}

	public static void Task_3()
	{
		int GetSumNumbers(int n)
		{
			int sum = 0;
			while (n != 0)
			{
				sum += n % 10;
				n /= 10;
			}
			return sum;
		}
		int number = Int32.Parse(Console.ReadLine() ?? string.Empty);
		Console.WriteLine((Math.Pow(number, 2) == Math.Pow(GetSumNumbers(number), 3)) 
			? true : false);
	}
}