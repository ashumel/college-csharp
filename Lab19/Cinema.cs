namespace Lab19;

[Serializable]
public class Cinema
{
	public string? Name { get; init; }
	public string? City { get; init; }
	public short Seats { get; init; }

	public void Show()
	{
		Console.Write(
			$"-- Cinema -- \nName: {Name}\n" +
			$"City: {City}\nSeats: {Seats}");
	}
}