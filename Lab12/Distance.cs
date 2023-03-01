namespace Lab12;

public static class Distance
{
	public static int Length(int x1, int x2) => x2 - x1;

	public static double Length(int x1, int y1, int x2, int y2) =>
		Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}