namespace Quotes.Domain.BusinessRules.UserMustExistRule;

public interface IUserMustExistRule : IBusinessRule
{
    Task Check(int id);
}
