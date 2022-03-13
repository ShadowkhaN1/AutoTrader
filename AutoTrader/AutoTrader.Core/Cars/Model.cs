namespace AutoTrader.Core.Cars;

public class Model
{
    private List<SalesCar> _salesCars = new List<SalesCar>();

    public Model(string name)
    {
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