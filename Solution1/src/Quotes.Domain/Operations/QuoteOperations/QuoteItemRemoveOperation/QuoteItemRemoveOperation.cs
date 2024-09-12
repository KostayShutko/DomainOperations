using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteTotalsCalculateOperation;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteItemRemoveOperation;

public class QuoteItemRemoveOperation : IQuoteItemRemoveOperation
{
    private readonly IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation;

    public QuoteItemRemoveOperation(IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation)
    {
        this.quoteTotalsCalculateOperation = quoteTotalsCalculateOperation;
    }

    public void Execute(Quote quote, QuoteItem quoteItem)
    {
        quote.QuoteItems.Remove(quoteItem);

        quoteTotalsCalculateOperation.Execute(quote);
    }
}