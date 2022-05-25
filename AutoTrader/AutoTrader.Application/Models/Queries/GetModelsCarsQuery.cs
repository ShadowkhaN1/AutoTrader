using System.Collections.Immutable;
using AutoTrader.Application.Dtos;
using MediatR;

namespace AutoTrader.Application.Models.Queries
{
    public class GetModelsCarsQuery : IRequest<List<ModelDto>>
    {
    }
}
