using Quotes.Domain.BusinessRules.Checks;

namespace Quotes.Domain.BusinessRules.CompanyMustExistRule;

public class CompanyMustExistRule : BaseBusinessRule, ICompanyMustExistRule
{
    private readonly IDoesCompanyExistCheck check;

    public CompanyMustExistRule(IDoesCompanyExistCheck check)
    {
        this.check = check;
    }

    public async Task Check(int id)
    {
        var result = await check.Execute(id);
        var isValid = result.IsSuccessful;

        Assert(isValid, Message);
    }

    public string Message => $"Company must exist";
}