using AutoTrader.Domain.Cars;

namespace AutoTrader.Application.Dtos;

public class BrandDto
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public List<Model> Models { get; private set; }
    public List<SalesCar> SalesCars { get; private set; }
}
