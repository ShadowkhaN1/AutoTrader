using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoTrader.Application.Dtos;
using AutoTrader.Domain.Cars;
using MediatR;

namespace AutoTrader.Application.SalesCars.Queries
{
    public class GetSalesCarsQuery : IRequest<IImmutableList<SalesCarDto>>
    {
        public int YearOfProduction { get; set; }
        public FuelType FuelType { get; set; }
        public int NumberOfDoors { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public Color Color { get; set; }
        public BodyType BodyType { get; set; }
        public int Capacity { get; set; }
        public string ModelName { get; set; }
        public string BrandName { get; set; }
    }
}
