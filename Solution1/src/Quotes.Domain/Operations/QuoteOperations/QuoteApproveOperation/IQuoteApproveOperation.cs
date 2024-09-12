using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteApproveOperation;

public interface IQuoteApproveOperation : IOperation
{
    void Execute(Quote quote);
}
