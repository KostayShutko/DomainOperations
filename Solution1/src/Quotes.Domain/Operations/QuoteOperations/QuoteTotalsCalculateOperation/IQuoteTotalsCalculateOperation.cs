using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteTotalsCalculateOperation;

public interface IQuoteTotalsCalculateOperation : IOperation
{
    void Execute(Quote quote);
}
