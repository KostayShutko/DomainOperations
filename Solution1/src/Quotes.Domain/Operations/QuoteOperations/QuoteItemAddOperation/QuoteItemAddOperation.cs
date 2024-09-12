using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteTotalsCalculateOperation;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteItemAddOperation;

public class QuoteItemAddOperation : IQuoteItemAddOperation
{
    private readonly IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation;

    public QuoteItemAddOperation(IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation)
    {
        this.quoteTotalsCalculateOperation = quoteTotalsCalculateOperation;
    }

    public void Execute(Quote quote, QuoteItem quoteItem)
    {
        if (quote.QuoteItems == null)
        {
            quote.QuoteItems = new List<QuoteItem>();
        }

        quote.QuoteItems.Add(quoteItem);

        quoteTotalsCalculateOperation.Execute(quote);
    }
}
