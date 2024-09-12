using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteApproveOperation;
using Quotes.Infrastructure.Repository;

namespace Quotes.Application.Commands.ApproveQuoteCommand;

public class ApproveQuoteCommandHandler : BaseCommand<Quote>, IRequestHandler<ApproveQuoteCommand, int>
{
    private readonly IQuoteApproveOperation quoteApproveOperation;

    public ApproveQuoteCommandHandler(IRepository<Quote> repository, IQuoteApproveOperation quoteApproveOperation)
        : base(repository)
    {
        this.quoteApproveOperation = quoteApproveOperation;
    }

    public async Task<int> Handle(ApproveQuoteCommand command, CancellationToken cancellationToken)
    {
        var quote = await FindByIdAsync(command.QuoteId);

        quoteApproveOperation.Execute(quote);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}
