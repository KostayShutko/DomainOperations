namespace Quotes.Domain.BusinessRules.Checks;

public interface IIsQuoteNameUniqueCheck : ICheck
{
    Task<ICheckResult> Execute(string name);
}
