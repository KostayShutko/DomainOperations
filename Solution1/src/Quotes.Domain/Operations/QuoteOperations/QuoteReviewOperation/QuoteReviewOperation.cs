using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteReviewOperation;

public class QuoteReviewOperation : IQuoteReviewOperation
{
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuoteReviewOperation(IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule)
    {
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }

    public void Execute(Quote quote)
    {
        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.UnderReview);

        quote.Status = QuoteStatus.UnderReview;
    }
}
