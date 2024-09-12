using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteItemAddOperation;
using Quotes.Infrastructure.Repository;
using Quotes.Infrastructure.Repository.Specifications;

namespace Quotes.Application.Commands.AddQuoteItemCommand;

public class AddQuoteItemCommandHandler : BaseCommand<Quote>, IRequestHandler<AddQuoteItemCommand, int>
{
    private readonly IQuoteItemAddOperation quoteItemAddOperation;

    public AddQuoteItemCommandHandler(IRepository<Quote> repository, IQuoteItemAddOperation quoteItemAddOperation)
        : base(repository)
    {
        this.quoteItemAddOperation = quoteItemAddOperation;
    }

    public async Task<int> Handle(AddQuoteItemCommand command, CancellationToken cancellationToken)
    {
        var quote = await FindFirstBySpecification(new GetByQuoteIdWithQuoteItemsSpecification(command.QuoteId));

        var quoteItem = new QuoteItem
        {
            QuoteId = command.QuoteId,
            Name = command.Name,
            Code = command.Code,
            Type = command.Type,
            Quantity = command.Quantity,
            Cost = command.Cost
        };

        quoteItemAddOperation.Execute(quote, quoteItem);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}
