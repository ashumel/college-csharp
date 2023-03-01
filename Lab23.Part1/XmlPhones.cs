using System.Xml;

namespace Lab23.Part1;

public class XmlPhones
{
	private XmlElement _root;
	private XmlDocument _document = new();
	private string _fileName;
	
	public List<Phone> Phones { get; }
	
	public XmlPhones(string fileName)
	{
		_fileName = fileName;
		_document.Load(fileName);
		_root = _document.DocumentElement!;
		Phones = GetAll();
	}

	private List<Phone> GetAll()
	{
		var list = new List<Phone>();
		foreach (XmlElement element in _root)
		{
			var serial = element.Attributes.GetNamedItem("serial")!.Value!;
			var number = element.ChildNodes[0]!.FirstChild!.Value!;
			var model = element.ChildNodes[1]!.FirstChild!.Value!;
			var price = double.Parse(element.ChildNodes[2]!.FirstChild!.Value!);
			var phone = new Phone(serial, number, model, price);
			list.Add(phone);
		}

		return list;
	}

	public void Add()
	{
		Console.WriteLine("Add new phone");
		Console.Write("Model: ");
		var model = Console.ReadLine()!;
		Console.Write("Serial: ");
		var serial = Console.ReadLine()!;
		Console.Write("Number: ");
		var number = Console.ReadLine()!;
		Console.WriteLine("Price: ");
		var price = Console.ReadLine();
		
		var phoneXml = _document.CreateElement("phone");
		var phoneSerialXml = _document.CreateAttribute("serial");
		var phoneNumberXml = _document.CreateElement("number");
		var phoneModelXml = _document.CreateElement("model");
		var phonePriceXml = _document.CreateElement("price");
		
		phoneSerialXml.AppendChild(_document.CreateTextNode(serial));
		phoneModelXml.AppendChild(_document.CreateTextNode(model));
		phoneNumberXml.AppendChild(_document.CreateTextNode(number));
		phonePriceXml.AppendChild(_document.CreateTextNode(price));
		
		phoneXml.Attributes.Append(phoneSerialXml);
		phoneXml.AppendChild(phoneNumberXml);
		phoneXml.AppendChild(phoneModelXml);
		phoneXml.AppendChild(phonePriceXml);
		
		_root.AppendChild(phoneXml);
		Save();
	}

	private void Save() => 
		_document.Save(_fileName);
}