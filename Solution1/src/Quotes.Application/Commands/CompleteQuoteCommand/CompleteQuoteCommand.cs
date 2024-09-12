using MediatR;

namespace Quotes.Application.Commands.CompleteQuoteCommand;

public class CompleteQuoteCommand : IRequest<int>
{
    public int QuoteId { get; set; }
}
