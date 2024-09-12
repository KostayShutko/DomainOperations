using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteConsultantSetOperation;

public interface IQuoteConsultantSetOperation : IOperation
{
    Task Execute(Quote quote, int consultantId);
}