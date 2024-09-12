using Quotes.Domain.BusinessRules.UserMustExistRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCustomerSetOperation;

public class QuoteCustomerSetOperation : IQuoteCustomerSetOperation
{
    private readonly IUserMustExistRule userMustExistRule;

    public QuoteCustomerSetOperation(IUserMustExistRule userMustExistRule)
    {
        this.userMustExistRule = userMustExistRule;
    }

    public async Task Execute(Quote quote, int customerId)
    {
        await userMustExistRule.Check(customerId);

        quote.CustomerId = customerId;
    }
}