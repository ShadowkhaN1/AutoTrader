using Microsoft.AspNetCore.Mvc;

namespace AutoTrader.API.Controllers
{
    public class SalesCarsController : ApiControllerBase
    {

        [HttpGet(Name = "SalesCars")]
        public async Task<ActionResult> Get()
        {
            var vm = await Mediator.Send();

            return Ok("siemens");
        }
    }
}
