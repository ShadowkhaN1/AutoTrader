using AutoTrader.Domain.Cars;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Infrastructure.DataBase
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<SalesCar> SalesCars { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
