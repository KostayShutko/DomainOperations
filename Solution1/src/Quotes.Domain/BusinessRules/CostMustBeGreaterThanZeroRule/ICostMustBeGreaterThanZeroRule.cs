namespace Quotes.Domain.BusinessRules.CostMustBeGreaterThanZeroRule;

public interface ICostMustBeGreaterThanZeroRule : IBusinessRule
{
    void Check(decimal cost);
}
