using Quotes.Domain.BusinessRules.Checks;

namespace Quotes.Infrastructure.Checks;

public class DoesCompanyExistCheck : IDoesCompanyExistCheck
{
    public DoesCompanyExistCheck()
    {
    }

    public async Task<ICheckResult> Execute(int id)
    {
        return await Task.FromResult(CheckResult.Successful);
    }
}