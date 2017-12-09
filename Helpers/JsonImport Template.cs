var deserializedTrains = JsonConvert.DeserializeObject<TrainDto[]>(jsonString);

var sb = new StringBuilder();

var validTrains = new List<Train>();
foreach (var trainDto in deserializedTrains)
{
    if (!IsValid(trainDto))
    {
        sb.AppendLine(FailureMessage);
        continue;
    }
	
	...
}

context.Trains.AddRange(validTrains);
context.SaveChanges();

var result = sb.ToString();
return result;