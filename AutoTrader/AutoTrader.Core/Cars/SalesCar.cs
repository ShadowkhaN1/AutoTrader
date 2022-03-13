using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoTrader.Core.Cars;

public class SalesCar
{
    public SalesCar()
    {
        Id = new Guid();
    }

    public Guid Id { get; set; }
    public int YearOfProduction { get; set; }
    public string VIN { get; set; }
    public FuelType FuelType { get; set; }
    public int NumberOfDoors { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string Color { get; set; }
    public BodyType Type { get; set; }

    [DataType(DataType.PhoneNumber)]
    public int PhoneNumber { get; set; }
    public int Capacity { get; set; }

    [DataType(DataType.ImageUrl)]
    public List<string> ImagesUrl { get; set; }
    public Brand Brand { get; set; }
    public Model Model { get; set; }
}

public class SalesCarsCollection
{
    public ICollection<SalesCar> SalesCars { get; set; }

    public SalesCarsCollection()
    {
        // initialize array of objects in default constructor to generate sample data
        this.SalesCars = new List<SalesCar>
        {
            new SalesCar { Id = new Guid(), Capacity = 1700, Color = "Black", FuelType = FuelType.Diesel, PhoneNumber = 123456765, Price = 14500, VIN = "WAUZZZ8LZ1A035327",
                ImagesUrl = new List<string>(){ "https://ireland.apollo.olxcdn.com/v1/files/eyJmbiI6IjRneDRkM3Z2cGcyYzMtT1RPTU9UT1BMIiwidyI6W3siZm4iOiJ3ZzRnbnFwNnkxZi1PVE9NT1RPUEwiLCJzIjoiMTYiLCJwIjoiMTAsLTEwIiwiYSI6IjAifV19.yHOhReqHb59wk2TyYypcge4OurwZOgDpFbv1SjxY_Os/image;s=1080x720" },
                Type = BodyType.Coupe, NumberOfDoors = 3, YearOfProduction = 2000, Model = new Model("A3"), Brand = new Brand("Audi")
                },
            new SalesCar { Id = new Guid(), Capacity = 1400, Color = "Red", FuelType = FuelType.Gasoline, PhoneNumber = 123456222, Price = 10000, VIN = "WEUZZZ8QZ1V035327",
                ImagesUrl = new List<string>(){ "https://ireland.apollo.olxcdn.com/v1/files/eyJmbiI6ImIzY3E0a2xnZG9ldDItT1RPTU9UT1BMIiwidyI6W3siZm4iOiJ3ZzRnbnFwNnkxZi1PVE9NT1RPUEwiLCJzIjoiMTYiLCJwIjoiMTAsLTEwIiwiYSI6IjAifV19.G6tiD4GdtiLHcdXNY_faHbOROiGlcUHapQVkvgOf8Zo/image;s=1080x720" },
                Type = BodyType.Sedan, NumberOfDoors = 4, YearOfProduction = 2004, Model = new Model("Klasa C"), Brand = new Brand("Mercedes")
            },
        };
    }
}