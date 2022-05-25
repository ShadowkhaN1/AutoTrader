using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using AutoTrader.Common;

namespace AutoTrader.Domain.Cars;

public class SalesCar : BaseEntity
{
    private List<Image> _imageUrls = new List<Image>();

    private SalesCar()
    {
        // EF Core needs it to generate migrations
    }

    public SalesCar(
        string vin,
        decimal price,
        Color color,
        BodyType bodyType,
        string phoneNumber,
        int capacity,
        List<Image> imagesUrl,
        Model model,
        FuelType fuelType,
        int numberOfDoors,
        int yearOfProduction)
    {
        Id = new Guid();
        VIN = vin;
        Price = price;
        Color = color;
        BodyType = bodyType;
        PhoneNumber = phoneNumber;
        Capacity = capacity;
        _imageUrls = imagesUrl;
        Model = model;
        FuelType = fuelType;
        NumberOfDoors = numberOfDoors;
        YearOfProduction = yearOfProduction;
    }

    public int YearOfProduction { get; private set; }
    public string VIN { get; private set; }
    public FuelType FuelType { get; private set; }
    public int NumberOfDoors { get; private set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; private set; }
    public Color Color { get; private set; }
    public BodyType BodyType { get; private set; }

    //todo przerobic na value object
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; private set; }
    public int Capacity { get; private set; }
    public List<Image> ImagesUrl => _imageUrls;
    public Model Model { get; private set; }
}
