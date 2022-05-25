using AutoMapper;
using AutoTrader.Application.Dtos;
using AutoTrader.Application.Interfaces;
using AutoTrader.Domain.Cars;
using MediatR;

namespace AutoTrader.Application.SalesCars.Command;

internal class CreateSalesCarCommandHandler : IRequestHandler<CreateSalesCarCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _context;

    public CreateSalesCarCommandHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<Guid> Handle(CreateSalesCarCommand request, CancellationToken cancellationToken)
    {
        var salesCar = _mapper.Map<SalesCarDto, SalesCar>(request.SalesCarDto);

        _context.SalesCars.Add(salesCar);

        await _context.SaveChangesAsync(cancellationToken);

        return salesCar.Id;
    }
}