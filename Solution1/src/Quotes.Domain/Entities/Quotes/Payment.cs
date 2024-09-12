namespace Quotes.Domain.Entities.Quotes;

public class Payment : Entity
{
    public int QuoteId { get; set; }
    public DateTime CreatedOn { get; set; }
    public PaymentStatus Status { get; set; }
}
