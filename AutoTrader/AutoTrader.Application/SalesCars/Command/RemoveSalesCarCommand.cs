using MediatR;

namespace AutoTrader.Application.SalesCars.Command;

public class RemoveSalesCarCommand : IRequest
{
    public RemoveSalesCarCommand(Guid salesCardId)
    {
        SalesCardId = salesCardId;
    }

    public Guid SalesCardId { get; }
}