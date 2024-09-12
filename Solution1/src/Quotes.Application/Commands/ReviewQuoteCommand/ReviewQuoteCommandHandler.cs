using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteReviewOperation;
using Quotes.Infrastructure.Repository;

namespace Quotes.Application.Commands.ReviewQuoteCommand;

public class ReviewQuoteCommandHandler : BaseCommand<Quote>, IRequestHandler<ReviewQuoteCommand, int>
{
    private readonly IQuoteReviewOperation quoteReviewOperation;

    public ReviewQuoteCommandHandler(IRepository<Quote> repository, IQuoteReviewOperation quoteReviewOperation)
        : base(repository)
    {
        this.quoteReviewOperation = quoteReviewOperation;
    }

    public async Task<int> Handle(ReviewQuoteCommand command, CancellationToken cancellationToken)
    {
        var quote = await FindByIdAsync(command.QuoteId);

        quoteReviewOperation.Execute(quote);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}