...

var sb = new StringBuilder();

var serializer = new XmlSerializer(typeof(CardDto[]), new XmlRootAttribute("Cards"));
serializer.Serialize(new StringWriter(sb), cards, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

var result = sb.ToString();
return result;