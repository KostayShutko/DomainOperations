using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCompleteOperation;

public class QuoteCompleteOperation : IQuoteCompleteOperation
{
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuoteCompleteOperation(IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule)
    {
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }
    public void Execute(Quote quote)
    {
        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.Completed);

        quote.Status = QuoteStatus.Completed;
    }
}
