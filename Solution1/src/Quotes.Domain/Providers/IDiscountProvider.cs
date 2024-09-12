namespace Quotes.Domain.Providers;

public interface IDiscountProvider
{
    Task<decimal> GetDiscount();
}
