using AutoTrader.Common;
using System.ComponentModel.DataAnnotations;

namespace AutoTrader.Domain.Cars
{
    public class Image
    {
        public Image()
        {
            // EF Core needs it to generate migrations
        }

        public Image(string imageUrl, SalesCar salesCar)
        {
            Id = new Guid();
            ImageUrl = imageUrl;
            SalesCar = salesCar;
        }

        public Guid Id { get; private set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        public SalesCar SalesCar { get; set; }
    }
}
