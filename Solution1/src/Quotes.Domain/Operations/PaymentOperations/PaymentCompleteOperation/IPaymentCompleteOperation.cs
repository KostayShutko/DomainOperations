using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.PaymentOperations.PaymentCompleteOperation;

public interface IPaymentCompleteOperation : IOperation
{
    void Execute(Payment payment);
}
