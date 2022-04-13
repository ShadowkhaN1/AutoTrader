using AutoMapper;
using AutoTrader.Application.Dtos;
using AutoTrader.Domain.Cars;

namespace AutoTrader.Application.Mappers;

public static class AutoMapperConfig
{
    public static IMapper Initialize() =>

        new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SalesCar, SalesCarDto>();
                cfg.CreateMap<Brand, BrandDto>();
                cfg.CreateMap<Model, ModelDto>();
            })
            .CreateMapper();
}
