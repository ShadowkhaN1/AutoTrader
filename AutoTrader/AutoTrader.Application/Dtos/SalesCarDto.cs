using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoTrader.Domain.Cars;

namespace AutoTrader.Application.Dtos;

public class SalesCarDto
{
    public Guid Id { get; set; }
    public int YearOfProduction { get; set; }
    public string VIN { get; set; }
    public FuelType FuelType { get; set; }
    public int NumberOfDoors { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public Color Color { get; set; }
    public BodyType BodyType { get; set; }

    [DataType(DataType.PhoneNumber)]
    public int PhoneNumber { get; set; }
    public int Capacity { get; set; }

    [DataType(DataType.ImageUrl)]
    public List<string> ImagesUrl { get; set; }
    public Model Model { get; set; }
}