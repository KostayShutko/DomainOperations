using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteCreateOperation;

public class QuoteCreateOperation : IQuoteCreateOperation
{
    public Quote Execute()
    {
        var quote = new Quote
        {
            CreatedOn = DateTime.UtcNow,
            Status = QuoteStatus.Draft,
            QuoteItems = new List<QuoteItem>(),
            TotalCost = 0,
            TotalCostWithTaxes = 0,
            Discount = 1,
            Tax = 1
        };

        return quote;
    }
}
