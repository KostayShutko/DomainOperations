using MediatR;

namespace Quotes.Application.Commands.ApproveQuoteCommand;

public class ApproveQuoteCommand : IRequest<int>
{
    public int QuoteId { get; set; }
}
