using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuotePayOperation;

public interface IQuotePayOperation : IOperation
{
    void Execute(Quote quote);
}
