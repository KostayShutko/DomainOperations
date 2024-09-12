namespace Quotes.Domain.Entities.Quotes;

public class QuoteItem : Entity
{
    public int QuoteId { get; set; }
    public virtual Quote Quote { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Type { get; set; }
    public int Quantity { get; set; }
    public decimal Cost { get; set; }
    public decimal TotalCost { get; set; }
}
