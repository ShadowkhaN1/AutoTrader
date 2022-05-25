using System.ComponentModel.DataAnnotations;

namespace AutoTrader.Domain.Cars;

public class Model
{
    private Model()
    {
        // EF Core needs it to generate migrations
    }

    public Model(string name, Brand brand)
    {
        Id = new Guid();
        Name = name;
        Brand = brand;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }

    [Required]
    public Brand Brand { get; private set; }
}