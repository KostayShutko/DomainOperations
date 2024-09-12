using Quotes.Domain.BusinessRules.Checks;

namespace Quotes.Domain.BusinessRules.QuoteNameMustBeUniqueRule;

public class QuoteNameMustBeUniqueRule : BaseBusinessRule, IQuoteNameMustBeUniqueRule
{
    private readonly IIsQuoteNameUniqueCheck isQuoteNameUniqueCheck;

    public QuoteNameMustBeUniqueRule(IIsQuoteNameUniqueCheck isQuoteNameUniqueCheck)
    {
        this.isQuoteNameUniqueCheck = isQuoteNameUniqueCheck;
    }

    public async Task Check(string name)
    {
        var result = await isQuoteNameUniqueCheck.Execute(name);
        var isValid = result.IsSuccessful;

        Assert(isValid, Message);
    }

    public string Message => "Quote name must be unique";
}
