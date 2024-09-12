using Quotes.Domain.Entities.Quotes;

namespace Quotes.Domain.Operations.PaymentOperations.PaymentCreateOperation;

public interface IPaymentCreateOperation : IOperation
{
    Payment Execute(Quote quote);
}
