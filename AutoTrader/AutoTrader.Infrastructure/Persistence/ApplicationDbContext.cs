using AutoTrader.Domain.Cars;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AutoTrader.Application.Interfaces;

namespace AutoTrader.Infrastructure.Persistence;

internal class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Model> Models { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<SalesCar> SalesCars { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
