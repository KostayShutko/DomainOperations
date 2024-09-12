using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.PaymentOperations.PaymentCompleteOperation;

namespace Quotes.Domain.Operations.QuoteOperations.QuotePayOperation;

public class QuotePayOperation : IQuotePayOperation 
{
    private readonly IPaymentCompleteOperation paymentCompleteOperation;
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuotePayOperation(IPaymentCompleteOperation paymentCompleteOperation, IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule)
    {
        this.paymentCompleteOperation = paymentCompleteOperation;
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }

    public void Execute(Quote quote)
    {

        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.Paid);

        paymentCompleteOperation.Execute(quote.Payment);

        quote.Status = QuoteStatus.Paid;
    }
}