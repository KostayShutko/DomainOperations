using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteAmendOperation;

public interface IQuoteAmendOperation : IOperation
{
    void Execute(Quote quote);
}