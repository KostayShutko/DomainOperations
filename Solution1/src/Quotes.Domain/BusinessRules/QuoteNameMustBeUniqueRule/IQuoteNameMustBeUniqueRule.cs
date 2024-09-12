namespace Quotes.Domain.BusinessRules.QuoteNameMustBeUniqueRule;

public interface IQuoteNameMustBeUniqueRule : IBusinessRule
{
    Task Check(string name);
}
