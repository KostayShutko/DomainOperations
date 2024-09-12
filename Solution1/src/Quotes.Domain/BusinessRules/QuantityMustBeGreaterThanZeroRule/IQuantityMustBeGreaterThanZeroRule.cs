namespace Quotes.Domain.BusinessRules.QuantityMustBeGreaterThanZeroRule;

public interface IQuantityMustBeGreaterThanZeroRule : IBusinessRule
{
    void Check(int quantity);
}
