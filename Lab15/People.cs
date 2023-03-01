namespace Lab15;

public delegate void Operation();
public class People
{
	public Operation Operation;
	private string Name { get; set; }
	private long? Number { get; set; }

	public People()
	{
		Name = null;
		Number = null;
	}

	public void Set()
	{
		Console.Write("\nWrite name: ");
		Name = Console.ReadLine();
		Console.Write("Write number: ");
		Number = int.Parse(Console.ReadLine() ?? string.Empty);
	}

	public void Show() => 
		Console.Write($"\nName: {Name}\nNumber: {Number}\n");
}