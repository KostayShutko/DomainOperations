using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.PaymentOperations.PaymentCreateOperation;

public class PaymentCreateOperation : IPaymentCreateOperation
{
    public Payment Execute(Quote quote)
    {
        var payment = new Payment
        {
            QuoteId = quote.Id,
            Status = PaymentStatus.Pending,
            CreatedOn =  DateTime.UtcNow
        };

        return payment;
    }
}