using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteExpireOperation;

public class QuoteExpireOperation : IQuoteExpireOperation
{
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuoteExpireOperation(IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule)
    {
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }

    public void Execute(Quote quote)
    {
        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.Expired);

        quote.Status = QuoteStatus.Expired;
    }
}
