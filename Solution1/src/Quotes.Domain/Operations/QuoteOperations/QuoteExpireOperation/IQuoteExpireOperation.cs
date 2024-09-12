using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteExpireOperation;

public interface IQuoteExpireOperation : IOperation
{
    void Execute(Quote quote);
}
