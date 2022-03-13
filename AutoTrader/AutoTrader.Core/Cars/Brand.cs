namespace AutoTrader.Core.Cars;

public class Brand
{
    private List<Model> _models = new List<Model>();
    private List<SalesCar> _salesCars = new List<SalesCar>();

    public Brand(string name)
    {
        Id = new Guid();
        Name = name;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public IReadOnlyList<Model> Models => _models;
    public IReadOnlyList<SalesCar> SalesCars => _salesCars;

    public void AddModel(Model model)
    {
        _models.Add(model);
    }
    public void AddSalesCar(SalesCar salesCar)
    {
        _salesCars.Add(salesCar);
    }
}