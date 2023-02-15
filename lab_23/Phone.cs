namespace lab_23;

public class Phone
{
	public string Model { get; }
	public string Number { get; }
	public string Serial { get; }
	public double Price { get; }

	public Phone(string serial, string number, string model, double price)
	{
		Model = model;
		Number = number;
		Serial = serial;
		Price = price;
	}
	

	public override string ToString() => 
		$"Model: {Model}, Number: {Number}, Serial: {Serial}, Price: {Price}";
}