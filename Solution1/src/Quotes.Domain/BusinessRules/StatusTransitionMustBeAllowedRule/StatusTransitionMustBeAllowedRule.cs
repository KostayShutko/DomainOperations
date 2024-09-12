using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;

public class StatusTransitionMustBeAllowedRule : BaseBusinessRule, IStatusTransitionMustBeAllowedRule
{
    private static readonly List<StatusTransition> StatusTransitions = new List<StatusTransition>
    {
        new StatusTransition(QuoteStatus.Draft, QuoteStatus.Submitted),
        new StatusTransition(QuoteStatus.Draft, QuoteStatus.Expired),
        new StatusTransition(QuoteStatus.Submitted, QuoteStatus.UnderReview),
        new StatusTransition(QuoteStatus.UnderReview, QuoteStatus.Approved),
        new StatusTransition(QuoteStatus.Approved, QuoteStatus.Draft),
        new StatusTransition(QuoteStatus.Approved, QuoteStatus.Paid),
        new StatusTransition(QuoteStatus.Paid, QuoteStatus.Completed)
    };

    public void Check(QuoteStatus from, QuoteStatus to)
    {
        var isValid = StatusTransitions.Any(transition => transition.IsAllowed(from, to));

        Assert(isValid, Message);
    }

    public string Message => "Status transition not allowed";
}
