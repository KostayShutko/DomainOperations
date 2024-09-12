using Quotes.Domain.Exceptions;

namespace Quotes.Domain.BusinessRules;

public class BaseBusinessRule
{
    protected void Assert(bool isValid, string message)
    {
        if (!isValid)
        {
            throw new BusinessRuleValidationException(message);
        }
    }
}
