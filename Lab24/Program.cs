namespace Lab24;

public static class Program 
{
	public static void Main(string[] args)
	{
		var phonesXml = new XmlDocument();
		var phonesList = new List<Phone>
		{
			new("Google Pixel XL", "511355248237067", "+1 202-918-2132"),
			new("OnePlus 9 Pro", "985086738750056", "+1 214-825-9650"),
			new("Nokia 3", "549356670561236", "+1 505-897-0335"),
			new("Motorola E4", "104031540761939", "+1 508-597-1683"),
			new("Galaxy S8 Active", "533210492867560", "+1 260-282-8539")
		};
		
		phonesXml.Insert(phonesList);
		phonesXml.Save();
		
		foreach (var phone in phonesXml.Phones)
			Console.WriteLine(phone.ToString());

		var phoneMy = new Phone("Xiaomi Note 8", 
			"492145244552426", "+1 202-918-2132");
		phonesXml.Insert(phoneMy);
		phonesXml.Save();

		phonesXml.Phones[0].Model = "ЛСП";
		phonesXml.Save();
	}
}