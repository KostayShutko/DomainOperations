using Quotes.Domain.Exceptions;

namespace Quotes.Domain.BusinessRules;

public abstract class BaseBusinessRule
{
    protected abstract string Message { get; }

    protected bool? IsValid { get; set; }

    protected void Assert()
    {
        if (!IsValid.HasValue)
        {
            throw new NotImplementedException();
        }
        if (!IsValid.Value)
        {
            throw new BusinessRuleValidationException(Message);
        }
    }
}
