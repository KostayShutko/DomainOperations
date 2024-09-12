using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteItemRemoveOperation;

public interface IQuoteItemRemoveOperation : IOperation
{
    void Execute(Quote quote, QuoteItem quoteItem);
}