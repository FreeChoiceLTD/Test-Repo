/* Commenr Start */
Attributrs: 
[XmlType("Trip")] - over the class
[XmlAttribute("price")] - over property to match Xml Attribute

CardDto /* MUST HAVE CLASS ATTRIBUTE [[XmlType("XmlElementValue")]] e.g: */ [XmlType("Card")]
/* Attention */ new XmlRootAttribute("Cards")) - Cards is RootValue
/* Commenr End */

var serializer = new XmlSerializer(typeof(CardDto[]), new XmlRootAttribute("Cards"));
var deserializedCards = (CardDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

var sb = new StringBuilder();

var validCards = new List<CustomerCard>();

foreach (var cardDto in deserializedCards)
{
	if (!IsValid(cardDto))
	{
		sb.AppendLine(FailureMessage);
		continue;
	}
		
	...
}

context.Cards.AddRange(validCards);
context.SaveChanges();

var result = sb.ToString();
return result;