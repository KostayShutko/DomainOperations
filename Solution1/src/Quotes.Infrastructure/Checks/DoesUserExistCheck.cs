using Quotes.Domain.BusinessRules.Checks;

namespace Quotes.Infrastructure.Checks;

public class DoesUserExistCheck : IDoesUserExistCheck
{
    public DoesUserExistCheck()
    {
    }

    public async Task<ICheckResult> Execute(int id)
    {
        return await Task.FromResult(CheckResult.Successful);
    }
}
