namespace Quotes.Domain.BusinessRules.Checks;

public interface IDoesCompanyExistCheck : ICheck
{
    Task<ICheckResult> Execute(int id);
}
