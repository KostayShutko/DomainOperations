namespace Quotes.Domain.BusinessRules.PercentageMustBeInCorrectRangeRule;

public interface IPercentageMustBeInCorrectRangeRule : IBusinessRule
{
    void Check(decimal percentage);
}