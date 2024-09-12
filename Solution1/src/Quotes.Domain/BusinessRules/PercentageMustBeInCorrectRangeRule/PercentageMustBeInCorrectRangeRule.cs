namespace Quotes.Domain.BusinessRules.PercentageMustBeInCorrectRangeRule;

public class PercentageMustBeInCorrectRangeRule : BaseBusinessRule, IPercentageMustBeInCorrectRangeRule
{
    public void Check(decimal percentage)
    {
        var isValid = percentage >= 0 && percentage <= 1;

        Assert(isValid, Message);
    }

    public string Message => "The percentage must be in correct range";
}
