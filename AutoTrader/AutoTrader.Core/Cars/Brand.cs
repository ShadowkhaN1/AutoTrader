namespace AutoTrader.Domain.Cars;

public class Brand
{
    private List<Model> _models = new List<Model>();

    private Brand()
    {
        // EF Core needs it to generate migrations
    }
    public Brand(string name)
    {
        Id = new Guid();
        Name = name;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public IReadOnlyList<Model> Models => _models;

    public void AddModel(Model model)
    {
        _models.Add(model);
    }
}