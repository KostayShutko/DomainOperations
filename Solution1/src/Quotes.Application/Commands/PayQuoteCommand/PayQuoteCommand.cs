using MediatR;

namespace Quotes.Application.Commands.PayQuoteCommand;

public class PayQuoteCommand : IRequest<int>
{
    public int QuoteId { get; set; }
}
