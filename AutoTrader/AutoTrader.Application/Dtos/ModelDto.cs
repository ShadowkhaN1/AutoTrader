using AutoTrader.Domain.Cars;

namespace AutoTrader.Application.Dtos;

public class ModelDto
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public List<SalesCar> SalesCars { get; set; }
    public Brand Brand { get; set; }
}