using AutoMapper;
using AutoTrader.Application.Dtos;
using AutoTrader.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Application.SalesCars.Queries;

internal class GetSalesCarQueryHandler : IRequestHandler<GetSalesCarQuery, SalesCarDto>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _context;

    public GetSalesCarQueryHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<SalesCarDto> Handle(GetSalesCarQuery request, CancellationToken cancellationToken)
    {
        var salesCar = await _context.SalesCars.SingleOrDefaultAsync(s => s.Id == request.Id, cancellationToken: cancellationToken);

        return _mapper.Map<SalesCarDto>(salesCar);
    }
}