using MediatR;

namespace AutoTrader.Application.SalesCars.Command;

internal class CreateSalesCarCommandHandler : IRequestHandler<CreateSalesCarCommand>
{
    public Task<Unit> Handle(CreateSalesCarCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}