namespace Quotes.Domain.Entities.Quotes;

public class Quote : Entity
{
    public string Name { get; set; }
    public int CustomerId { get; set; }
    public int CompanyId { get; set; }
    public int ConsultantId { get; set; }
    public QuoteStatus Status { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public DateTime CreatedOn { get; set; }
    public virtual Payment Payment { get; set; }
    public decimal TotalCost { get; set; }
    public decimal TotalCostWithDiscount { get; set; }
    public decimal TotalCostWithTaxes { get; set; }
    public virtual List<QuoteItem> QuoteItems { get; set; }
}
