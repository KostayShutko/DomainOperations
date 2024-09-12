using MediatR;

namespace Quotes.Application.Commands.CreateQuoteCommand;

public class CreateQuoteCommand : IRequest<int>
{
    public string Name { get; set; }
    public int CompanyId { get; set; }
    public int ConsultantId { get; set; }
    public int CustomerId { get; set; }
}
