using Quotes.Domain.BusinessRules.QuoteNameMustBeUniqueRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteNameSetOperation;

public class QuoteNameSetOperation : IQuoteNameSetOperation
{
    private readonly IQuoteNameMustBeUniqueRule quoteNameMustBeUniqueRule;

    public QuoteNameSetOperation(IQuoteNameMustBeUniqueRule quoteNameMustBeUniqueRule)
    {
        this.quoteNameMustBeUniqueRule = quoteNameMustBeUniqueRule;
    }

    public async Task Execute(Quote quote, string name)
    {
        await quoteNameMustBeUniqueRule.Check(name);

        quote.Name = name;
    }
}
