using System.Xml.Linq;

namespace Lab24;

public class Phone
{
	public string Model { get; set; }
	public string IMEI { get; set; }
	public string Number { get; set; }

	public Phone(string model, string imei, string number)
	{
		Model = model;
		IMEI = imei;
		Number = number;
	}

	public XElement ToXmlElement()
	{
		var imei = new XAttribute("imei", IMEI);
		var model = new XAttribute("model", Model);
		var number = new XAttribute("number", Number);
		var element = new XElement("phone");
		element.Add(model, imei, number);
		
		return element;
	}

	public static Phone ToObject(XElement element) =>
		new Phone(element.Attribute("model")!.Value,
			element.Attribute("imei")!.Value, element.Attribute("number")!.Value);

	public override string ToString() => $"{Model} | {IMEI} | {Number}";
}