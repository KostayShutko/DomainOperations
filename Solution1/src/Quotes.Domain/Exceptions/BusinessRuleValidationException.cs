namespace Quotes.Domain.Exceptions;

public class BusinessRuleValidationException : Exception
{
    public string Message { get; }

    public BusinessRuleValidationException(string message) 
        : base(message)
    {
        Message = message;
    }

    public override string ToString()
    {
        return Message;
    }
}
