using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;

public interface IStatusTransitionMustBeAllowedRule : IBusinessRule
{
    void Check(QuoteStatus from, QuoteStatus to);
}
