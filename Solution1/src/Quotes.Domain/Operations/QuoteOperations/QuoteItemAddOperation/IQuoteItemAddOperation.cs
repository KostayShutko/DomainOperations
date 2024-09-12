using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteItemAddOperation;

public interface IQuoteItemAddOperation : IOperation
{
    void Execute(Quote quote, QuoteItem quoteItem);
}
