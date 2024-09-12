using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCreateOperation;

public interface IQuoteCreateOperation : IOperation
{
    Quote Execute();
}