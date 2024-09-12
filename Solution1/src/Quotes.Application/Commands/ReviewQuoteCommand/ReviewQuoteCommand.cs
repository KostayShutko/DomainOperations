using MediatR;

namespace Quotes.Application.Commands.ReviewQuoteCommand;

public class ReviewQuoteCommand : IRequest<int>
{
    public int QuoteId { get; set; }
}
