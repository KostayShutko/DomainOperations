namespace Quotes.Domain.BusinessRules.ValueMustBeNotNullRule;

public class ValueMustBeNotNullRule : BaseBusinessRule, IValueMustBeNotNullRule
{
    public void Check(object value)
    {
        var isValid = value is not null;

        Assert(isValid, Message);
    }

    public string Message => "The value must be set";
}