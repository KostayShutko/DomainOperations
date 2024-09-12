using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteTaxApplyOperation;

public interface IQuoteTaxApplyOperation : IOperation
{
    Task Execute(Quote quote);
}
