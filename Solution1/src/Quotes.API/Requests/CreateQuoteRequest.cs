namespace Quotes.API.Requests;

public class CreateQuoteRequest
{
    public string Name { get; set; }
    public int CompanyId { get; set; }
    public int ConsultantId { get; set; }
    public int CustomerId { get; set; }
}
