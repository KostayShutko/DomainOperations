namespace Quotes.Domain.Providers;

public interface ITaxProvider
{
    Task<decimal> GetTax();
}
