namespace Quotes.Domain.BusinessRules.ValueMustBeNotNullRule;

public class ValueMustBeNotNullRule : BaseBusinessRule, IValueMustBeNotNullRule
{
    public void Check(object value)
    {
        IsValid = value is not null;

        Assert();
    }

    protected override string Message => "The value must be set";
}