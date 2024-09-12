namespace Quotes.Domain.BusinessRules.CompanyMustExistRule;

public interface ICompanyMustExistRule : IBusinessRule
{
    Task Check(int id);
}