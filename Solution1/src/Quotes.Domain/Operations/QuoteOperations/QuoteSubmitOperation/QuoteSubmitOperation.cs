using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteSubmitOperation;

public class QuoteSubmitOperation : IQuoteSubmitOperation
{
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuoteSubmitOperation(IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule)
    {
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }

    public void Execute(Quote quote)
    {
        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.Submitted);

        quote.Status = QuoteStatus.Submitted;
    }
}
