using FluentValidation;

namespace AutoTrader.Application.SalesCars.Command;

public class CreateSalesCarCommandValidator : AbstractValidator<CreateSalesCarCommand>
{
    public CreateSalesCarCommandValidator()
    {
        RuleFor(s => s.SalesCarDto.Price)
            .NotEmpty()
            .WithMessage("Price is required");

        RuleFor(s => s.SalesCarDto.YearOfProduction)
            .NotEmpty()
            .WithMessage(x => $"{nameof(x.SalesCarDto.YearOfProduction)} is required");
    }
}