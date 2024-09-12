using Quotes.Domain.BusinessRules.CompanyMustExistRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCompanySetOperation;

public class QuoteCompanySetOperation : IQuoteCompanySetOperation
{
    private readonly ICompanyMustExistRule companyMustExistRule;

    public QuoteCompanySetOperation(ICompanyMustExistRule companyMustExistRule)
    {
        this.companyMustExistRule = companyMustExistRule;
    }

    public async Task Execute(Quote quote, int companyId)
    {
        await companyMustExistRule.Check(companyId);

        quote.CompanyId = companyId;
    }
}