using System.Collections.Immutable;
using AutoMapper;
using AutoTrader.Application.Dtos;
using AutoTrader.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Application.SalesCars.Queries;

internal class GetSalesCarsQueryHandler : IRequestHandler<GetSalesCarsQuery, IImmutableList<SalesCarDto>>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _context;

    public GetSalesCarsQueryHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<IImmutableList<SalesCarDto>> Handle(GetSalesCarsQuery request,
        CancellationToken cancellationToken)
    {
        var searchSalesCars = await _context.SalesCars
            .Where(s => s.BodyType == request.BodyType
                        && s.Model.Name == request.ModelName
                        && s.BodyType == request.BodyType
                        && s.Color == request.Color
                        && s.FuelType == request.FuelType)
            .ToListAsync(cancellationToken: cancellationToken);

        return _mapper.Map<ImmutableList<SalesCarDto>>(searchSalesCars);
    }
}
