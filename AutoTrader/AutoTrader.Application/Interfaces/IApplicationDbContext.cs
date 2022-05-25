using AutoTrader.Domain.Cars;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<SalesCar> SalesCars { get; }
    DbSet<Brand> Brands { get; }
    DbSet<Model> Models { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
