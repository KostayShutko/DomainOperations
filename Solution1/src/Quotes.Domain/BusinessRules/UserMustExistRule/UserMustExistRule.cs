using Quotes.Domain.BusinessRules.Checks;

namespace Quotes.Domain.BusinessRules.UserMustExistRule;

public class UserMustExistRule : BaseBusinessRule, IUserMustExistRule
{
    private readonly IDoesUserExistCheck doesUserExistCheck;

    public UserMustExistRule(IDoesUserExistCheck doesUserExistCheck)
    {
        this.doesUserExistCheck = doesUserExistCheck;
    }

    public async Task Check(int id)
    {
        var result = await doesUserExistCheck.Execute(id);
        IsValid = result.IsSuccessful;

        Assert();
    }

    protected override string Message => $"The user must exist";
}
