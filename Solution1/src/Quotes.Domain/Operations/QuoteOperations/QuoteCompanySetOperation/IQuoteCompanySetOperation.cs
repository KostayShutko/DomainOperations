using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCompanySetOperation;

public interface IQuoteCompanySetOperation : IOperation
{
    Task Execute(Quote quote, int companyId);
}
