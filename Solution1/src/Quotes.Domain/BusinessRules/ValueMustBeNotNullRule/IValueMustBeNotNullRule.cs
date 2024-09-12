namespace Quotes.Domain.BusinessRules.ValueMustBeNotNullRule;

public interface IValueMustBeNotNullRule
{
    void Check(object value);
}