using System;

namespace lab_03_2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			/*Console.WriteLine("Задание 1");
			Task_1();
			Console.WriteLine("Задание 2");
			Task_2(); */
			Console.WriteLine("Задание 3");
			Task_3();
		}

		private static void Task_1()
		{
			int a = Int32.Parse(Console.ReadLine() ?? string.Empty);
			int b = Int32.Parse(Console.ReadLine() ?? string.Empty);
			if (a < b)
				while (a <= b)
				{
					Console.WriteLine(a);
					a++;
				}
			else if (b < a)
				while (b <= a)
				{
					Console.WriteLine(b);
					b++;
				}
			else Console.WriteLine("⚠️ Произошла ошибка ввода");
		}

		private static void Task_2()
		{
			int num, sum = 0, k = 0, min = Int32.MaxValue;
			int countMinus = 0, countPlus = 0;
			do
			{
				num = int.Parse(Console.ReadLine() ?? string.Empty);
				if (num is 0) continue;
				if (num < 0) countMinus++;
				else countPlus++;
				sum += num;
				k++;
				if (num < min) min = num;
			} while (num != 0);
			Console.WriteLine($"Среднее арифметическое: {sum / k}\n" +
			                  $"Минимальное введенное число: {min}\n" +
			                  $"Количество отрицательных чисел: {countMinus}\n" +
			                  $"Количество положительных чисел: {countPlus}");
		}

		private static void Task_3()
		{
			Console.WriteLine("Конечное, на n слагаемых: ");
			double RowSum(double sum, double rowX, int i) => sum + Math.Pow(rowX, i) / i;
			Console.WriteLine("Введите N: ");
			int n = int.Parse(Console.ReadLine() ?? string.Empty);
			Console.WriteLine("Введите X: ");
			double x = double.Parse(Console.ReadLine() ?? string.Empty);
			double result = 0;
			for (int i = 1; i <= n; i++)
				result += RowSum(result, x, i);
			Console.WriteLine(result);
			Console.WriteLine("Бесконечное, с точностью eps: ");
			Console.WriteLine("Введите eps: ");
			double eps = Double.Parse(Console.ReadLine() ?? string.Empty);
			result = 0.0;
			for (int i = 1; (Math.Pow(x, i) / i) > eps; i++) {
				result += RowSum(result, x, i);
				Console.WriteLine(result);
			}
			Console.WriteLine(result);
		}
	}
}