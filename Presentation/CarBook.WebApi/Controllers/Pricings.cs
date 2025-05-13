using CarBook.Application.Features.Mediator.Commands.PrcingCommands;
using CarBook.Application.Features.Mediator.Commands.PricingCommands;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pricings : ControllerBase
    {
        private readonly IMediator _mediator;

        public Pricings(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            var query = new GetPricingQuery();
            var pricings = await _mediator.Send(query);
            return Ok(pricings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> PricingById(int id)
        {
            var query = new GetPricingByIdQuery(id);
            var pricing = await _mediator.Send(query);
            return Ok(pricing);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            var command = new DeletePricingCommand(id);
            await _mediator.Send(command);
            return Ok("Pricing was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Pricing was updated");
        }
    }
}
