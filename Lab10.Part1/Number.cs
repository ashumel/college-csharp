namespace Lab10;

public static class Number
{
	public static long Factorial(long n)
	{
		if (n == 1) return 1;
		return n * Factorial(n: n - 1);
	}

	public static int Fibonacci(int n)
	{
		if (n <= 1) return n;
		return Fibonacci(n - 1) + Fibonacci(n - 2);
	}
		
}