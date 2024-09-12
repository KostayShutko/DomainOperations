using Quotes.Domain.Providers;

namespace Quotes.Infrastructure.Providers;

public class DiscountProvider : IDiscountProvider
{
    public async Task<decimal> GetDiscount()
    {
        return await Task.FromResult(0.1M);
    }
}
