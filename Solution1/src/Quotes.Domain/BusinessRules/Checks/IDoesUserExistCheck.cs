namespace Quotes.Domain.BusinessRules.Checks;

public interface IDoesUserExistCheck : ICheck
{
    Task<ICheckResult> Execute(int id);
}
