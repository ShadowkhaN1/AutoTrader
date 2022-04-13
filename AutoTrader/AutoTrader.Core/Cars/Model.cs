namespace AutoTrader.Domain.Cars;

public class Model
{
    private List<SalesCar> _salesCars = new List<SalesCar>();

    private Model()
    {
        // EF Core needs it to generate migrations
    }

    public Model(string name, Brand brand)
    {
        Name = name;
        Brand = brand;
        Id = new Guid();
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public IReadOnlyCollection<SalesCar> SalesCars => _salesCars;
    public Brand Brand { get; set; }

    public void AddSalesCars(SalesCar salesCar)
    {
        _salesCars.Add(salesCar);
    }
}