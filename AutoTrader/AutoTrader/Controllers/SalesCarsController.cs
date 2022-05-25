using AutoTrader.Application.Dtos;
using AutoTrader.Application.SalesCars.Command;
using AutoTrader.Application.SalesCars.Queries;
using Microsoft.AspNetCore.Mvc;

namespace AutoTrader.API.Controllers
{
    public class SalesCarsController : ApiControllerBase
    {
        [HttpGet("{Id}")]
        public async Task<ActionResult<SalesCarDto>> Get(Guid Id)
        {
            var salesCar = await Mediator.Send(new GetSalesCarQuery(Id));

            return Ok(salesCar);
        }

        [HttpGet("search")]
        public async Task<ActionResult<Guid>> Search([FromQuery] GetSalesCarsQuery carsQuery)
        {
            var salesCars = await Mediator.Send(carsQuery);

            return Ok(salesCars);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Guid>> Create(CreateSalesCarCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(Guid Id)
        {
            await Mediator.Send(new RemoveSalesCarCommand(Id));

            return NoContent();
        }
    }
}
