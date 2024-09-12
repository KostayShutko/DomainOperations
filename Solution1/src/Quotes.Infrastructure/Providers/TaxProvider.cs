using Quotes.Domain.Providers;

namespace Quotes.Infrastructure.Providers;

public class TaxProvider : ITaxProvider
{
    public async Task<decimal> GetTax()
    {
        return await Task.FromResult(0.1M);
    }
}