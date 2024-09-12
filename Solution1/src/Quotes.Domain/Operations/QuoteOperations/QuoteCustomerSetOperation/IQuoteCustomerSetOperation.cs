using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCustomerSetOperation;

public interface IQuoteCustomerSetOperation : IOperation
{
    Task Execute(Quote quote, int customerId);
}
