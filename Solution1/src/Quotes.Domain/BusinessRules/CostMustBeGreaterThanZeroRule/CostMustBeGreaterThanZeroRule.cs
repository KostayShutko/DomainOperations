namespace Quotes.Domain.BusinessRules.CostMustBeGreaterThanZeroRule;

public class CostMustBeGreaterThanZeroRule : BaseBusinessRule, ICostMustBeGreaterThanZeroRule
{
    public void Check(decimal cost)
    {
        var isValid = cost >= 0;

        Assert(isValid, Message);
    }

    public string Message => "The cost must be greater or equal to zero";
}
