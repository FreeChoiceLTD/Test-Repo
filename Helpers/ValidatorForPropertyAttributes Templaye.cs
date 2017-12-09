// Validates Property Attribures
private static bool IsValid(object obj)
{
    var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
    var validationResults = new List<ValidationResult>();

    var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
    return isValid;
}