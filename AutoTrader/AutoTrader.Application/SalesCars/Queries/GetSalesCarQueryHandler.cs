using AutoMapper;
using AutoTrader.Application.Dtos;
using MediatR;

namespace AutoTrader.Application.SalesCars.Queries;

internal class GetSalesCarQueryHandler : IRequestHandler<GetSalesCarQuery, SalesCarDto>
{
    private readonly IMapper _mapper;

    public GetSalesCarQueryHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<SalesCarDto> Handle(GetSalesCarQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}