namespace lab_15;

public class NumArray
{
	private readonly double[] _array;
	public Operation OperationConsole;

	public NumArray(double[] array)
	{
		_array = array;
	}

	public void ShowMax() => Console.WriteLine(_array.Max());
	public void ShowMin() => Console.WriteLine(_array.Min());
	public void ShowSum() => Console.WriteLine(_array.Sum());
	public void ShowAvg() => Console.WriteLine(_array.Average());
}