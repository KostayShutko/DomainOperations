using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteTotalsCalculateOperation;
using Quotes.Domain.Providers;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteDiscountApplyOperation;

public class QuoteDiscountApplyOperation : IQuoteDiscountApplyOperation
{
    private readonly IDiscountProvider discountProvider;
    private readonly IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation;

    public QuoteDiscountApplyOperation(IDiscountProvider discountProvider, IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation)
    {
        this.discountProvider = discountProvider;
        this.quoteTotalsCalculateOperation = quoteTotalsCalculateOperation;
    }

    public async Task Execute(Quote quote)
    {
        var discount = await discountProvider.GetDiscount();

        quote.Discount = discount;

        quoteTotalsCalculateOperation.Execute(quote);
    }
}
