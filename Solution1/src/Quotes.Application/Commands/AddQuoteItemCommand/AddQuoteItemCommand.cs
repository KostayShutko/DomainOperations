﻿using MediatR;

namespace Quotes.Application.Commands.AddQuoteItemCommand;

public class AddQuoteItemCommand : IRequest<int>
{
    public int QuoteId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Type { get; set; }
    public int Quantity { get; set; }
    public decimal Cost { get; set; }
}
