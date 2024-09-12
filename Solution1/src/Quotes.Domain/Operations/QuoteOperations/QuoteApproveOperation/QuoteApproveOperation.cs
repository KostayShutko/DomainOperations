using Quotes.Domain.BusinessRules.StatusTransitionMustBeAllowedRule;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.PaymentOperations.PaymentCreateOperation;

namespace Quotes.Domain.Operations.QuoteOperations.QuoteApproveOperation;

public class QuoteApproveOperation : IQuoteApproveOperation
{
    private readonly IPaymentCreateOperation paymentCreateOperation;
    private readonly IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule;

    public QuoteApproveOperation(IPaymentCreateOperation paymentCreateOperation, IStatusTransitionMustBeAllowedRule statusTransitionMustBeAllowedRule) 
    {
        this.paymentCreateOperation = paymentCreateOperation;
        this.statusTransitionMustBeAllowedRule = statusTransitionMustBeAllowedRule;
    }

    public void Execute(Quote quote)
    {
        statusTransitionMustBeAllowedRule.Check(quote.Status, QuoteStatus.Approved);

        var payment = paymentCreateOperation.Execute(quote);

        quote.Payment = payment;
        quote.Status = QuoteStatus.Approved;
    }
}
