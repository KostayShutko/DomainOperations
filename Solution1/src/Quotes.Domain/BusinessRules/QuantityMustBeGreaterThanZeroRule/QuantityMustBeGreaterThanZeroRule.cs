namespace Quotes.Domain.BusinessRules.QuantityMustBeGreaterThanZeroRule;

public class QuantityMustBeGreaterThanZeroRule : BaseBusinessRule, IQuantityMustBeGreaterThanZeroRule
{
    public void Check(int quantity)
    {
        IsValid = quantity >= 0;

        Assert();
    }

    protected override string Message => "The quantity must be greater or equal to zero";
}
