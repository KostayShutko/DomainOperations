namespace Quotes.Domain.BusinessRules.CostMustBeGreaterThanZeroRule;

public class CostMustBeGreaterThanZeroRule : BaseBusinessRule, ICostMustBeGreaterThanZeroRule
{
    public void Check(decimal cost)
    {
        IsValid = cost >= 0;

        Assert();
    }

    protected override string Message => "The cost must be greater or equal to zero";
}
