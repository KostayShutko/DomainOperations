using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteTotalsCalculateOperation;
using Quotes.Domain.Providers;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteTaxApplyOperation;

public class QuoteTaxApplyOperation : IQuoteTaxApplyOperation
{
    private readonly ITaxProvider taxProvider;
    private readonly IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation;

    public QuoteTaxApplyOperation(ITaxProvider taxProvider, IQuoteTotalsCalculateOperation quoteTotalsCalculateOperation)
    {
        this.taxProvider = taxProvider;
        this.quoteTotalsCalculateOperation = quoteTotalsCalculateOperation;
    }

    public async Task Execute(Quote quote)  
    {
        var tax = await taxProvider.GetTax();

        quote.Tax = tax;

        quoteTotalsCalculateOperation.Execute(quote);
    }
}
