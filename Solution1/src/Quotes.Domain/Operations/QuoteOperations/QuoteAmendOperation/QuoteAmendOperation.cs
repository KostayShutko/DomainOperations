using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteAmendOperation;

public class QuoteAmendOperation : IQuoteAmendOperation
{
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuoteAmendOperation(IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule)
    {
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }

    public void Execute(Quote quote)
    {
        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.Draft);

        quote.Status = QuoteStatus.Draft;
    }
}