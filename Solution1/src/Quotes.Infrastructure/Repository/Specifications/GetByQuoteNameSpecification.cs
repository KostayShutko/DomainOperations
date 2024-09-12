using Quotes.Domain.Entities.Quotes;

namespace Quotes.Infrastructure.Repository.Specifications;

public class GetByQuoteNameSpecification : BaseSpecification<Quote>
{
    public GetByQuoteNameSpecification(string name)
    {
        SetFilterCondition(quote => quote.Name == name);
    }
}