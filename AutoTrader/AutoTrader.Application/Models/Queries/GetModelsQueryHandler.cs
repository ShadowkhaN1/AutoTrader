using AutoMapper;
using AutoTrader.Application.Dtos;
using AutoTrader.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using AutoTrader.Domain.Cars;

namespace AutoTrader.Application.Models.Queries;

internal class GetModelsQueryHandler : IRequestHandler<GetModelsCarsQuery, List<ModelDto>>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _context;

    public GetModelsQueryHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<List<ModelDto>> Handle(GetModelsCarsQuery request,
        CancellationToken cancellationToken)
    {
        var models = await _context.Models.ToListAsync(cancellationToken: cancellationToken);

        return _mapper.Map<List<ModelDto>>(models);
    }
}
