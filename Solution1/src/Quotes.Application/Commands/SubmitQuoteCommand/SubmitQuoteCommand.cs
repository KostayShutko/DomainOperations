using MediatR;

namespace Quotes.Application.Commands.SubmitQuoteCommand;

public class SubmitQuoteCommand : IRequest<int>
{
    public int QuoteId { get; set; }
}