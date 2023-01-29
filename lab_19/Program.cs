using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace lab_19;

internal static class Program
{
	[Obsolete("Obsolete")]
	public static void Main()
	{
		var cinemas = new[]
		{
			new Cinema() { City = "Vitebsk", Name = "Five stars", Seats = 64},
			new Cinema() { City = "Minsk", Name = "Charlie", Seats = 62},
			new Cinema() { City = "Vilnius", Name = "Oscar", Seats = 66},
			new Cinema() { City = "Kiev", Name = "MovieTime", Seats = 48}
		};
		
		var binaryFormatter = new BinaryFormatter();
		using var streamStreamDat = new FileStream("cinemas.dat", FileMode.Create);
		binaryFormatter.Serialize(streamStreamDat, cinemas);
		streamStreamDat.Close();
		
		var xmlCinemaSerializer = new XmlSerializer(typeof(Cinema[]));
		using var writeStreamXml = new FileStream("cinemas.xml", FileMode.Create);
		xmlCinemaSerializer.Serialize(writeStreamXml, cinemas);
		writeStreamXml.Close();
		
		using var writeStreamJson = new FileStream("cinemas.json", FileMode.Create);
		JsonSerializer.Serialize(writeStreamJson, cinemas);
		
		using var readStreamDat = new FileStream("cinemas.dat", FileMode.OpenOrCreate);
		var cinemasDeserilizeDat = (Cinema[])binaryFormatter.Deserialize(readStreamDat);
		
		using var readStreamXml = new FileStream("cinemas.xml", FileMode.OpenOrCreate);
		var cinemasDeserilizeXml = xmlCinemaSerializer.Deserialize(readStreamXml) as Cinema[];
		
		Console.WriteLine("Filter by city: ");
		var city = Console.ReadLine();
		if (cinemasDeserilizeXml == null) return;
		foreach (var cinema in cinemasDeserilizeXml)
		{
			if (cinema.City == city)
				cinema.Show();
		}
	}
}