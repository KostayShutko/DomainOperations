using MediatR;
using Quotes.Domain.Entities.Quotes;
using Quotes.Domain.Operations.QuoteOperations.QuoteCompanySetOperation;
using Quotes.Domain.Operations.QuoteOperations.QuoteConsultantSetOperation;
using Quotes.Domain.Operations.QuoteOperations.QuoteCreateOperation;
using Quotes.Domain.Operations.QuoteOperations.QuoteCustomerSetOperation;
using Quotes.Domain.Operations.QuoteOperations.QuoteDiscountApplyOperation;
using Quotes.Domain.Operations.QuoteOperations.QuoteNameSetOperation;
using Quotes.Domain.Operations.QuoteOperations.QuoteTaxApplyOperation;
using Quotes.Infrastructure.Repository;

namespace Quotes.Application.Commands.CreateQuoteCommand;

public class CreateQuoteCommandHandler : BaseCommand<Quote>, IRequestHandler<CreateQuoteCommand, int>
{
    private readonly IQuoteCreateOperation quoteCreateOperation;
    private readonly IQuoteNameSetOperation quoteNameSetOperation;
    private readonly IQuoteCompanySetOperation quoteCompanySetOperation;
    private readonly IQuoteConsultantSetOperation quoteConsultantSetOperation;
    private readonly IQuoteCustomerSetOperation quoteCustomerSetOperation;
    private readonly IQuoteDiscountApplyOperation quoteDiscountApplyOperation;
    private readonly IQuoteTaxApplyOperation quoteTaxApplyOperation;

    public CreateQuoteCommandHandler(
        IRepository<Quote> repository,
        IQuoteCreateOperation quoteCreateOperation,
        IQuoteNameSetOperation quoteNameSetOperation,
        IQuoteCompanySetOperation quoteCompanySetOperation,
        IQuoteConsultantSetOperation quoteConsultantSetOperation,
        IQuoteCustomerSetOperation quoteCustomerSetOperation,
        IQuoteDiscountApplyOperation quoteDiscountApplyOperation,
        IQuoteTaxApplyOperation quoteTaxApplyOperation
    )
        : base(repository)
    {
        this.quoteCreateOperation = quoteCreateOperation;
        this.quoteNameSetOperation = quoteNameSetOperation;
        this.quoteCompanySetOperation = quoteCompanySetOperation;
        this.quoteConsultantSetOperation = quoteConsultantSetOperation;
        this.quoteCustomerSetOperation = quoteCustomerSetOperation;
        this.quoteDiscountApplyOperation = quoteDiscountApplyOperation;
        this.quoteTaxApplyOperation = quoteTaxApplyOperation;
    }

    public async Task<int> Handle(CreateQuoteCommand command, CancellationToken cancellationToken)
    {
        var quote = quoteCreateOperation.Execute();

        await quoteNameSetOperation.Execute(quote, command.Name);
        await quoteCompanySetOperation.Execute(quote, command.CompanyId);
        await quoteConsultantSetOperation.Execute(quote, command.ConsultantId);
        await quoteCustomerSetOperation.Execute(quote, command.CustomerId);
        await quoteDiscountApplyOperation.Execute(quote);
        await quoteTaxApplyOperation.Execute(quote);

        var savedQuote = await SaveChangesAsync(quote);
        return savedQuote.Id;
    }
}