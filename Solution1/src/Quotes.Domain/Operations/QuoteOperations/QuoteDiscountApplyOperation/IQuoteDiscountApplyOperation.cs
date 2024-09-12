using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteDiscountApplyOperation;

public interface IQuoteDiscountApplyOperation : IOperation
{
    Task Execute(Quote quote);
}
