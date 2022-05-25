using System.Collections.Immutable;
using AutoTrader.Application.Dtos;
using AutoTrader.Application.Models.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AutoTrader.API.Controllers
{
    public class ModelsController : ApiControllerBase
    {
        [HttpGet()]
        public async Task<ActionResult<List<ModelDto>>> Get()
        {
            var models = await Mediator.Send(new GetModelsCarsQuery());

            return Ok(models);
        }
    }
}
