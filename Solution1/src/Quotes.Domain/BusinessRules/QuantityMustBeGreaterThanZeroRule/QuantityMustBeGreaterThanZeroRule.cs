namespace Quotes.Domain.BusinessRules.QuantityMustBeGreaterThanZeroRule;

public class QuantityMustBeGreaterThanZeroRule : BaseBusinessRule, IQuantityMustBeGreaterThanZeroRule
{
    public void Check(int quantity)
    {
        var isValid = quantity >= 0;

        Assert(isValid, Message);
    }

    public string Message => "The quantity must be greater or equal to zero";
}
