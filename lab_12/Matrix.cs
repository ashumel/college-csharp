using System;

namespace lab_12
{
	public class Matrix
	{
		private int[,] _matrix;
		
		public Matrix(int n)
		{
			this._matrix = new int[n, n];
		}

		public Matrix(int n, int m)
		{
			this._matrix = new int[n, m];
		}

		public void Fill()
		{
			for (int i = 0; i < _matrix.Length; i++)
			for (int j = 0; j < _matrix.GetLength(i); j++)
			{
				Console.Write($"[{i}, {j}] array element: ");
				_matrix[i, j] = int.Parse(Console.ReadLine() ?? string.Empty);
			}
		}

		public void Fill(int x, int y)
		{
			Random random = new Random();
			for (int i = 0; i < _matrix.Length; i++)
			for (int j = 0; j < _matrix.GetLength(i); j++)
				_matrix[i, j] = random.Next(x, y);
		}

		public void Show()
		{
			Console.WriteLine("-- Matrix --");
			for (int i = 0; i < _matrix.Length; i++) {
				Console.WriteLine("\n");
				for (int j = 0; j < _matrix.GetLength(i); j++)
					Console.Write($"{_matrix[i, j]}\t");
			}
		}

		public static Matrix operator +(Matrix obj, int value)
		{
			for (int i = 0; i < obj._matrix.Length; i++)
			for (int j = 0; j < obj._matrix.GetLength(i); j++)
				obj._matrix[i, j] += value;
			return obj;
		}
	}
}