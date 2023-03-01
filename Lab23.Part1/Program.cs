namespace Lab23.Part1;

public static class Program
{
	public static void Main(string[] args)
	{
		var xmlPhones = new XmlPhones("phones.xml");
		var phones = xmlPhones.Phones;
		Console.WriteLine(string.Join('\n', phones));
		xmlPhones.Add();
	}
}