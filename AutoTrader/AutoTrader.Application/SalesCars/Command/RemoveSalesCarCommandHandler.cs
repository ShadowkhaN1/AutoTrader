using AutoMapper;
using AutoTrader.Application.Exceptions;
using AutoTrader.Application.Interfaces;
using AutoTrader.Domain.Cars;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Application.SalesCars.Command;

internal class RemoveSalesCarCommandHandler : IRequestHandler<RemoveSalesCarCommand>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _context;

    public RemoveSalesCarCommandHandler(IMapper mapper, IApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<Unit> Handle(RemoveSalesCarCommand request, CancellationToken cancellationToken)
    {
        var removeSalesCar = await _context.SalesCars.SingleOrDefaultAsync(s => s.Id == request.SalesCardId, cancellationToken: cancellationToken);

        if (removeSalesCar == null)
        {
            throw new NotFoundException(nameof(SalesCar), request.SalesCardId);
        }

        _context.SalesCars.Remove(removeSalesCar);

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}