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
        IsValid = result.IsSuccessful;

        Assert();
    }

    protected override string Message => "Quote name must be unique";
}
