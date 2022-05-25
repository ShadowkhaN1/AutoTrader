using AutoTrader.Domain.Cars;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoTrader.Infrastructure.Persistence.Configurations;

public class SalesCarConfiguration : IEntityTypeConfiguration<SalesCar>
{
    public void Configure(EntityTypeBuilder<SalesCar> builder)
    {
        builder.Property(s => s.FuelType).HasConversion(new EnumToStringConverter<FuelType>());
        builder.Property(s => s.BodyType).HasConversion(new EnumToStringConverter<BodyType>());
        builder.Property(s => s.Color).HasConversion(new EnumToStringConverter<Color>());
    }
}
