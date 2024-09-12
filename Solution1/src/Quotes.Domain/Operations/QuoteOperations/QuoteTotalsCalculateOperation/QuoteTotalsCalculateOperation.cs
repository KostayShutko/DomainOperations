using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteTotalsCalculateOperation;

public class QuoteTotalsCalculateOperation : IQuoteTotalsCalculateOperation
{
    public void Execute(Quote quote)
    {
        quote.Status = QuoteStatus.Expired;

        quote.TotalCost = quote.QuoteItems.Sum(item => item.TotalCost);

        var discountAmount = quote.TotalCost * quote.Discount;
        quote.TotalCostWithDiscount = quote.TotalCost - discountAmount;

        var taxAmount = quote.TotalCostWithDiscount * quote.Tax;
        quote.TotalCostWithTaxes = quote.TotalCostWithDiscount + taxAmount;
    }
}