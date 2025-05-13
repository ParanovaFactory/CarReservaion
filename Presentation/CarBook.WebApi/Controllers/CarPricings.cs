using CarBook.Application.Features.Mediator.Commands.CarPricingCommands;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricings : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarPricings(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarPricings")]
        public async Task<IActionResult> GetCarPricings()
        {
            var query = new GetCarPricingWithCarQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("GetPricingList")]
        public async Task<IActionResult> GetPricingList()
        {
            var query = new GetCarPricingQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarPricingById(int id)
        {
            var query = new GetCarPricingByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarPricing(CreateCarPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing was added");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCarPricing(UpdateCarPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing was updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarPricing(int id)
        {
            var command = new DeleteCarPricingCommand(id);
            await _mediator.Send(command);
            return Ok("Pricing was deleted");
        }

        [HttpGet("CarPricingWithPerod")]
        public async Task<IActionResult> GetCarPricingWithPeriod()
        {
            var query = new GetCarPricingWithPeriodQuery();
            var carPricing = await _mediator.Send(query);
            return Ok(carPricing);
        }
    }
}
