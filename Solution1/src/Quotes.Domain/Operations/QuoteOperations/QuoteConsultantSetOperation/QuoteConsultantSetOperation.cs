using Quotes.Domain.BusinessRules.UserMustExistRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteConsultantSetOperation;

public class QuoteConsultantSetOperation : IQuoteConsultantSetOperation
{
    private readonly IUserMustExistRule userMustExistRule;

    public QuoteConsultantSetOperation(IUserMustExistRule userMustExistRule)
    {
        this.userMustExistRule = userMustExistRule;
    }

    public async Task Execute(Quote quote, int consultantId)
    {
        await userMustExistRule.Check(consultantId);

        quote.ConsultantId = consultantId;
    }
}