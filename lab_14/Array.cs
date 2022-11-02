using System;

namespace lab_14
{
	public class Array
	{
		public Array()
		{
			_password = SetPassword();
			_array = SetArray();
		}

		private readonly string _password;
		private readonly int[] _array;
		
		private string SetPassword()
		{
			Console.Clear();
			Console.WriteLine("\t-- Set password --");
			Console.Write("New password of 5 characters: ");
			var password = Console.ReadLine();
			if (password != null && password.Length != 5)
				throw new ArgumentException("Password length is not 5");
			if (password == null)
				throw new ArgumentException("Password empty");
			return password;
		}

		private int[] SetArray()
		{
			Console.Clear();
			Console.WriteLine("\t-- Array --");
			Console.Write("Length: ");
			var n = int.Parse(Console.ReadLine() ?? string.Empty);
				var array = new int[n];
				for (var i = 0; i < array.Length; i++)
				{
					Console.Write($"Write {i + 1}-number: ");
					array[i] = int.Parse(Console.ReadLine() ?? string.Empty);
				}
				return array;
		}

		public void ShowArray()
		{
			if (IsValidPassword())
			{
				Console.Clear();
				Console.WriteLine("\t-- Your array --");
				foreach (var element in _array)
					Console.Write($"\t{element}");
			}
		}

		private bool IsValidPassword()
		{
			Console.Clear();
			Console.WriteLine("Please, write your password: ");
			var password = Console.ReadLine();
			if (password != _password)
			{
				throw new ArgumentException("Invalid password");
			}
			return true;
		}
	}
}