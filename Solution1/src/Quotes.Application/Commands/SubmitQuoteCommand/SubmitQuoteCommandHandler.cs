using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteSubmitOperation;
using Quotes.Infrastructure.Repository;

namespace Quotes.Application.Commands.SubmitQuoteCommand;

public class SubmitQuoteCommandHandler : BaseCommand<Quote>, IRequestHandler<SubmitQuoteCommand, int>
{
    private readonly IQuoteSubmitOperation quoteSubmitOperation;

    public SubmitQuoteCommandHandler(IRepository<Quote> repository, IQuoteSubmitOperation quoteSubmitOperation)
        : base(repository)
    {
        this.quoteSubmitOperation = quoteSubmitOperation;
    }

    public async Task<int> Handle(SubmitQuoteCommand command, CancellationToken cancellationToken)
    {
        var quote = await FindByIdAsync(command.QuoteId);

        quoteSubmitOperation.Execute(quote);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}