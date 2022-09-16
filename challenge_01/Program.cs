using System;

namespace challenge_01
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Задача 1");
			Task_1();
			Console.WriteLine("Задача 2");
			Task_2();
		}

		private static void Task_1()
		{
			int x;
			while (true)
			{
				x = Int32.Parse(Console.ReadLine() ?? string.Empty);
				if (x >= 0 && x < 10) break;
				Console.WriteLine("Введите цифру, а не число!");
			}
			int y = Int32.Parse(Console.ReadLine() ?? string.Empty);
			int k = 0, y_ch = y;
			while (y_ch > 0)
			{
				if (y_ch % 10 == x) k++;
				y_ch /= 10;
			}
			Console.WriteLine($"Количество {x} в {y}: {k}");
		}

		private static void Task_2()
		{
			int num, sum = 0, k = 0, min = 0;
			do
			{
				num = int.Parse(Console.ReadLine() ?? string.Empty);
				if (num is 0) continue;
				sum += num;
				k++;
				if (k == 1 || num < min) min = num;
			} while (num != 0);
			Console.WriteLine($"Среднее арифметическое: {sum / k}\n" +
			                  $"Минимальное введенное число: {min}");
		}
	}
}