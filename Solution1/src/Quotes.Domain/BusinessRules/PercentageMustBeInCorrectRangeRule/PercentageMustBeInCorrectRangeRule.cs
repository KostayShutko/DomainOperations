namespace Quotes.Domain.BusinessRules.PercentageMustBeInCorrectRangeRule;

public class PercentageMustBeInCorrectRangeRule : BaseBusinessRule, IPercentageMustBeInCorrectRangeRule
{
    public void Check(decimal percentage)
    {
        IsValid = percentage >= 0 && percentage <= 1;

        Assert();
    }

    protected override string Message => "The percentage must be in correct range";
}
