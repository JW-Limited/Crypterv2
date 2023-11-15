namespace LILO_WebEngine.Exceptions;

public class InvalidQueryException : Exception
{
    public InvalidQueryException(string queryParameter, IEnumerable<string> possibleValues)
        : base($"The query parameter '{queryParameter}' is invalid. Possible values are: {string.Join(", ", possibleValues)}.")
    {
        QueryParameter = queryParameter;
        PossibleValues = possibleValues;
    }

    public string QueryParameter { get; }
    public IEnumerable<string> PossibleValues { get; }

    public string GenerateHumanReadableErrorMessage()
    {
        var errorMessage = $"The query parameter '{QueryParameter}' is invalid.";
        if (PossibleValues.Any())
        {
            errorMessage += $" Possible values are: {string.Join(", ", PossibleValues)}.";
        }
        return errorMessage;
    }

    public override string ToString()
    {
        return $"LILOWebEngine.ExceptionHelpers.InvalidQueryException: {GenerateHumanReadableErrorMessage()}";
    }
}

