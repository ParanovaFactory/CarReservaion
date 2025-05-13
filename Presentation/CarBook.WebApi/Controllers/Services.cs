using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Services : ControllerBase
    {
        private readonly IMediator _mediator;

        public Services(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var query = new GetServiceQuery();
            var services = await _mediator.Send(query);
            return Ok(services);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ServiceById(int id)
        {
            var query = new GetServiceByIdQuery(id);
            var service = await _mediator.Send(query);
            return Ok(service);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Service was added");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var command = new DeleteServiceCommand(id);
            await _mediator.Send(command);
            return Ok("Service was deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
        {
            await _mediator.Send(command);
            return Ok("Service was updated");
        }
    }
}
