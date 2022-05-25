using AutoTrader.Domain.Cars;

namespace AutoTrader.Application.Dtos;

public class BrandDto
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public List<ModelDto> Models { get; private set; }
    //public List<SalesCarDto> SalesCars { get; private set; }
}
