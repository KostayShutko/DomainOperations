using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.PaymentOperations.PaymentCompleteOperation;

public class PaymentCompleteOperation : IPaymentCompleteOperation
{
    public void Execute(Payment payment)
    {
        payment.Status = PaymentStatus.Paid;
    }
}
