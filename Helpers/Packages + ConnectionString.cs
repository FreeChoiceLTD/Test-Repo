Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Newtonsoft.Json

public const string ConnectionString = @"Server=DESKTOP-5FMQC2G\SQLEXPRESS;Database=TeamBuilder;Integrated Security=True;";

// Json Attributes:  
[JsonProperty("Picture")] // Property name
// XmlAttributes: 
[XmlType("post")] // Class Attribute matching element name
[XmlAttribute("id")]
[XmlElement("content")]

// Validates Property Attribures
private static bool IsValid(object obj)
{
    var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
    var validationResults = new List<ValidationResult>();

    var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
    return isValid;
}

// Xml Deserialisation - Import: 
	from string - Comments: 
		CardDto /* MUST HAVE CLASS ATTRIBUTE [[XmlType("XmlElementValue")]] e.g: */ [XmlType("Card")]
		/* Attention */ new XmlRootAttribute("Cards")) - Cards is RootValue
	from string - Example:
		var serializer = new XmlSerializer(typeof(CardDto[]), new XmlRootAttribute("Cards")); 
		var deserializedCards = (CardDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));
	from file: 
		var xDoc = XDocument.Load(CategoriesXmlFilePath);
// Xml Serialisation - Export:
	var sb = new StringBuilder();

	var serializer = new XmlSerializer(typeof(CardDto[]), new XmlRootAttribute("Cards"));
	serializer.Serialize(new StringWriter(sb), cards, new XmlSerializerNamespaces(new[] {XmlQualifiedName.Empty}));

	var result = sb.ToString();
	return result;
// Json Deserialisation - Import: 
	var collection = JsonConvert.DeserializeObject<TModelDto[]>(jsonString);
// Json Serialization - Export:
	var jsonString = JsonConvert.SerializeObject(trains, Formatting.Indented);

// Automapper Configuration - in the constructor e.g:
public StationsProfile()
{
    CreateMap<StationDto, Station>();
    CreateMap<SeatingClassDto, SeatingClass>();
}