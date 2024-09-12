using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuotePayOperation;
using Quotes.Infrastructure.Repository;
using Quotes.Infrastructure.Repository.Specifications;

namespace Quotes.Application.Commands.PayQuoteCommand;

public class PayQuoteCommandHandler : BaseCommand<Quote>, IRequestHandler<PayQuoteCommand, int>
{
    private readonly IQuotePayOperation quotePayOperation;

    public PayQuoteCommandHandler(IRepository<Quote> repository, IQuotePayOperation quotePayOperation)
        : base(repository)
    {
        this.quotePayOperation = quotePayOperation;
    }

    public async Task<int> Handle(PayQuoteCommand command, CancellationToken cancellationToken)
    {
        var quote = await FindFirstBySpecification(new GetByQuoteIdWithPaymentSpecification(command.QuoteId));

        quotePayOperation.Execute(quote);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}
