using AutoTrader.Application.Dtos;
using MediatR;

namespace AutoTrader.Application.SalesCars.Queries
{
    public class GetSalesCarQuery : IRequest<SalesCarDto>
    {
        public GetSalesCarQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

    }
}
