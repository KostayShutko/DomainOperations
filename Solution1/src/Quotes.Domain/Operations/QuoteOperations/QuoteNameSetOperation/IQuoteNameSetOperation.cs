using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteNameSetOperation;

public interface IQuoteNameSetOperation : IOperation
{
    Task Execute(Quote quote, string name);
}
