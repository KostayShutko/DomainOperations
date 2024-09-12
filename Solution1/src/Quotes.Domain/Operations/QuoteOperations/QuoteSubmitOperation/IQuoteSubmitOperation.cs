using Quotes.Domain.Entities.Quotes;
namespace Quotes.Domain.Operations.QuoteOperations.QuoteSubmitOperation;

public interface IQuoteSubmitOperation : IOperation
{
    void Execute(Quote quote);
}