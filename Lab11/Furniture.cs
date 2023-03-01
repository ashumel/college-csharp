namespace Lab11;

public class Furniture
{
	public Furniture(string color, double width, double height)
	{
		Color = color;
		Width = width;
		Height = height;
	}

	protected readonly string Color;
	protected readonly double Width;
	protected readonly double Height;

	public virtual void Show()
	{
		Console.WriteLine("-- Furniture --\n" +
		                  $"Color: {Color}\n" +
		                  $"Width: {Width}\n" +
		                  $"Height: {Height}");
	}
}

public class Cabinet : Furniture
{
	public Cabinet(string color, double width, double height, string name, string material) : 
		base(color, width, height)
	{
		Name = name;
		Material = material;
	}

	protected readonly string Name;
	protected readonly string Material;

	public override void Show()
	{
		Console.WriteLine("-- Cabinet --\n" +
		                  $"Name: {Name}\n" +
		                  $"Material: {Material}");
	}
}

public class CabinetBook : Cabinet
{
	public CabinetBook(string color, double width, double height, string name, string material, int filling)
		: base(color, width, height, name, material)
	{
		this._filling = filling;
	}

	private readonly int _filling;

	public new void Show()
	{
		Console.WriteLine("-- Cabinet Book --\n" +
		                  $"Filling: {_filling}\n" +
		                  $"Color: {Color}," +
		                  $"Material: {Material}");
	}
}