﻿using Quotes.Domain.Entities.Quotes;

namespace Quotes.Infrastructure.Repository.Specifications;

public class GetByQuoteIdWithQuoteItemsSpecification : BaseSpecification<Quote>
{
    public GetByQuoteIdWithQuoteItemsSpecification(int id)
    {
        AddInclude(quote => quote.QuoteItems);
        SetFilterCondition(quote => quote.Id == id);
    }
}
