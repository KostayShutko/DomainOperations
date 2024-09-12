using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteReviewOperation;

public interface IQuoteReviewOperation : IOperation
{
    void Execute(Quote quote);
}
