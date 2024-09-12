using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCompleteOperation;

public interface IQuoteCompleteOperation : IOperation
{
    void Execute(Quote quote);
}
