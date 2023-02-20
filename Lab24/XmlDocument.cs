using System.Xml.Linq;

namespace Lab24;

public class XmlDocument
{
	public XDocument Document { get; private set; }
	public XElement Root { get; private set; }
	public List<Phone> Phones { get; }

	public XmlDocument()
	{
		Document = new XDocument();
		Root = new XElement("phones");
		Phones = new List<Phone>();
	}

	public XmlDocument(string path)
	{
		Document = XDocument.Load(path);
		Root = Document.Root!;
		Phones = new List<Phone>();
	}
	
	public void Insert(params Phone[] phones) => Phones.AddRange(phones);
	public void Insert(IEnumerable<Phone> phones) => Phones.AddRange(phones);
	
	public void Load()
	{
		foreach (var element in Root.Elements()) 
			Phones.Add(Phone.ToObject(element));
	}
	
	public void Save()
	{
		Document = new XDocument();
		Root = new XElement("phones");
		foreach (var phone in Phones) 
			Root.Add(phone.ToXmlElement());
		Document.Add(Root);
		Document.Save("phones.xml");
	}
}