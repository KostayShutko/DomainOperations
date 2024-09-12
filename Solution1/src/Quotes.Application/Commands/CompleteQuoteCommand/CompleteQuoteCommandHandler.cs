using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteCompleteOperation;
using Quotes.Infrastructure.Repository;

namespace Quotes.Application.Commands.CompleteQuoteCommand;

public class CompleteQuoteCommandHandler : BaseCommand<Quote>, IRequestHandler<CompleteQuoteCommand, int>
{
    private readonly IQuoteCompleteOperation quoteCompleteOperation;

    public CompleteQuoteCommandHandler(IRepository<Quote> repository, IQuoteCompleteOperation quoteCompleteOperation)
        : base(repository)
    {
        this.quoteCompleteOperation = quoteCompleteOperation;
    }

    public async Task<int> Handle(CompleteQuoteCommand command, CancellationToken cancellationToken)
    {
        var quote = await FindByIdAsync(command.QuoteId);

        quoteCompleteOperation.Execute(quote);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}